using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sala
    {
        bool finalizarRonda;
        int mano;
        bool truco;
        bool envido;
        bool ventanaActiva;
        int numeroDeSala;
        string? descripcion;
        bool partidaFinalizada;
        bool partidaCancelada;
        List<Carta> mazo;
        Jugador jugadorUno;
        Jugador jugadorDos;
        Jugador? jugadorGanador;
        List<string> historial;
        CancellationToken token;

        public event PartidaTerminada? PartidaTerminada;

        public Sala(Jugador jugadorUno, Jugador jugadorDos, int numeroDeSala)
        {
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
            mano = 2;
            mazo = new List<Carta>();
            historial = new List<string>();
            this.ventanaActiva = false;
            this.numeroDeSala = numeroDeSala + 1;
            partidaCancelada = false;
            partidaFinalizada = false;
        }

        public int IdJugadorUno { get => jugadorUno.Id; }
        public int IdJugadorDos { get => jugadorDos.Id; }
        public Jugador? JugadorGanador { get => jugadorGanador; }
        public bool FinalizarRonda { get => finalizarRonda; set => finalizarRonda = value; }
        public bool Truco { get => truco; }
        public bool Envido { get => envido; }
        public List<Carta> Mazo { get => mazo; set => mazo = value; }
        public List<string> Historial { get => historial; }
        public int Mano { get => mano; }
        public bool VentanaActiva { get => ventanaActiva; set => ventanaActiva = value; }
        public CancellationToken Token { get => token; }
        public bool PartidaFinalizada { get => partidaFinalizada; set => partidaFinalizada = value; }
        public bool PartidaCancelada { get => partidaCancelada; set => partidaCancelada = value; }
        public int NumeroDeSala { get => numeroDeSala; set => numeroDeSala = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }

        public void CrearSala(CancellationToken token)
        {
            AccesoBaseDeDatos bdSala = new AccesoBaseDeDatos();
            this.token = token;
            Random cartaJugada = new Random();
            CargarInformacionAlHistorial("Comienza La Partida");
            do
            {
                CargarInformacionAlHistorial($" TOTAL PUNTAJES: Jugador 1: {jugadorUno.PuntajePartida} Jugador 2: {jugadorDos.PuntajePartida}");
                Thread.Sleep(5000);
                if (Token.IsCancellationRequested)
                {
                    partidaFinalizada = true;
                    partidaCancelada = true;
                    CargarInformacionAlHistorial("La Partida fue Cancelada");
                    descripcion = "La Partida fue Cancelada";
                    PartidaTerminada?.Invoke($"La Partida de la sala {NumeroDeSala} fue Cancelada");
                    bdSala.AgregarSala(this);
                    return;
                }
                EmpezarUnaNuevaRonda();
                List<int> jugadorGanadorDeLaMano = new List<int>();
                CargarInformacionAlHistorial("Jugador 1");
                jugadorUno.CartasJugador.ForEach((c) => CargarInformacionAlHistorial(c.MostrarInformacion()));
                //Thread.Sleep(5000);
                CargarInformacionAlHistorial("Jugador 2");
                jugadorDos.CartasJugador.ForEach((c) => CargarInformacionAlHistorial(c.MostrarInformacion()));
                // Thread.Sleep(5000);
                CantarEnvido(jugadorUno, jugadorDos);
                if (CantarJuego(jugadorUno, jugadorDos))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        ElegirMano();
                        //Thread.Sleep(5000);
                        CargarInformacionAlHistorial($"\tMANO: {i + 1}");
                        Carta auxCartaElegidaJ1 = jugadorUno.CartaJugada();
                        //Thread.Sleep(5000);
                        CargarInformacionAlHistorial($"J1: Juega {auxCartaElegidaJ1.MostrarInformacion()}");
                        Carta auxCartaElegidaJ2 = jugadorDos.CartaJugada();
                        // Thread.Sleep(5000);
                        CargarInformacionAlHistorial($"J2: Juega {auxCartaElegidaJ2.MostrarInformacion()}");
                        int ganador = CalcularCartaGanadora(auxCartaElegidaJ1, auxCartaElegidaJ2);
                        switch (ganador)
                        {
                            case 0:
                                // Thread.Sleep(5000);
                                CargarInformacionAlHistorial("Pardas");
                                jugadorGanadorDeLaMano.Add(0);
                                break;
                            case 1:
                                // Thread.Sleep(5000);
                                CargarInformacionAlHistorial("Gana carta J1");
                                jugadorGanadorDeLaMano.Add(1);
                                break;
                            case 2:
                                // Thread.Sleep(5000);
                                CargarInformacionAlHistorial("Gana carta J2");
                                jugadorGanadorDeLaMano.Add(2);
                                break;
                        }
                        if (i > 0)
                        {
                            string resultadoGanador = SumarPuntajeJugador(jugadorGanadorDeLaMano);
                            CargarInformacionAlHistorial(resultadoGanador);
                        }
                        if (FinalizarRonda == true)
                        {
                            jugadorGanadorDeLaMano.Clear();
                            break;
                        }
                    }
                }
            } while (jugadorUno.PuntajePartida < 15 && jugadorDos.PuntajePartida < 15);
            partidaFinalizada = true;
            //Thread.Sleep(5000);
            CargarInformacionAlHistorial($" TOTAL PUNTAJES: Jugador 1: {jugadorUno.PuntajePartida} Jugador 2: {jugadorDos.PuntajePartida}");
            //Thread.Sleep(5000);
            descripcion = historial.Last();
            CargarInformacionAlHistorial(DevolverGanadorDePartida(jugadorUno, jugadorDos));
            Thread.Sleep(500);
            bdSala.AgregarPartida(this);
            CargarInformacionAlHistorial("Partida Finalizada");
        }
        private bool CantarJuego(Jugador jugadorUno, Jugador jugadorDos)
        {
            bool retorno = true;
            if (Mano == 1)
            {
                if (jugadorUno.Truco)
                {
                    // Thread.Sleep(5000);
                    CargarInformacionAlHistorial("J1 Dice: Truco");
                    if (jugadorDos.Truco)
                    {
                        // Thread.Sleep(5000);
                        CargarInformacionAlHistorial("J2 Dice: Quiero");
                    }
                    else
                    {
                        // Thread.Sleep(5000);
                        CargarInformacionAlHistorial("J2 Dice: NO Quiero");
                        // Thread.Sleep(5000);
                        CargarInformacionAlHistorial("Termina la Mano Gana J1");
                        jugadorUno.PuntajePartida += 1;
                        retorno = false;
                    }
                }
            }
            else if (jugadorDos.Truco)
            {
                // Thread.Sleep(5000);
                CargarInformacionAlHistorial("J2 Dice: Truco");
                if (jugadorUno.Truco)
                {
                    // Thread.Sleep(5000);
                    CargarInformacionAlHistorial("J1 Dice: Quiero");
                }
                else
                {
                    //Thread.Sleep(5000);
                    CargarInformacionAlHistorial("J1 Dice: NO Quiero");
                    // Thread.Sleep(5000);
                    CargarInformacionAlHistorial("Termina la Mano Gana J2");
                    jugadorDos.PuntajePartida += 1;
                    retorno = false;
                }
            }
            return retorno;
        }

        private void CantarEnvido(Jugador jugadorUno, Jugador jugadorDos)
        {
            int ganador;
            if (jugadorUno.Envido)
            {
                //Thread.Sleep(5000);
                CargarInformacionAlHistorial("J1 Dice: Envido");
                if (jugadorDos.Envido)
                {
                    // Thread.Sleep(5000);
                    CargarInformacionAlHistorial("J2 Dice: Quiero");
                    //  Thread.Sleep(5000);
                    CargarInformacionAlHistorial($"J1: {jugadorUno.Tantos} Tantos - J2: {jugadorDos.Tantos} Tantos");
                    ganador = CalcularGanadorEnvido(jugadorUno.Tantos, jugadorDos.Tantos);
                    if (ganador == 2)
                    {
                        //  Thread.Sleep(5000);
                        CargarInformacionAlHistorial("Gana J2 El envido");
                        jugadorDos.PuntajePartida += 2;
                    }
                    else
                    {
                        // Thread.Sleep(5000);
                        CargarInformacionAlHistorial("Gana J1 El envido");
                        jugadorUno.PuntajePartida += 2;
                    }
                }
                else
                {
                    //   Thread.Sleep(5000);
                    CargarInformacionAlHistorial("J2 Dice: NO Quiero");
                    jugadorUno.PuntajePartida += 1;
                }
            }
            else if (jugadorDos.Envido)
            {
                // Thread.Sleep(5000);
                CargarInformacionAlHistorial("J2 Dice: Envido");
                //Thread.Sleep(5000);
                CargarInformacionAlHistorial("J1 Dice: NO Quiero");
                jugadorDos.PuntajePartida += 1;
            }
        }

        public void ElegirMano()
        {
            if (Mano == 2)
            {
                mano = 1;
            }
            else
            {
                mano = 2;
            }
        }

        private void RepartirCartasAJugador(Jugador jugador)
        {
            List<Carta> cartas = new List<Carta>();
            do
            {
                Random carta = new Random();
                int indice = carta.Next(0, Mazo.Count);
                Carta cartaAleatoria = Mazo[indice];
                if (VerificarCartasRepetidas(cartaAleatoria) == false)
                {
                    jugador.CartasJugador.Add(cartaAleatoria);
                }
            } while (jugador.CartasJugador.Count != 3);
            jugador.VerificarTrucoYEnvido();
        }
        private bool VerificarCartasRepetidas(Carta carta)
        {
            foreach (Carta item in jugadorUno.CartasJugador)
            {
                if (item == carta)
                {
                    return true;
                }
            }
            foreach (Carta item in jugadorDos.CartasJugador)
            {
                if (item == carta)
                {
                    return true;
                }
            }
            return false;
        }
        public void EmpezarUnaNuevaRonda()
        {
            truco = false;
            envido = false;
            finalizarRonda = false;
            jugadorUno.Truco = false;
            jugadorDos.Truco = false;
            jugadorDos.Envido = false;
            jugadorUno.Envido = false;
            mazo = TrucoArg.mazoDeCartas;
            this.jugadorUno.LimpiarlistaCartasJugador();
            this.jugadorDos.LimpiarlistaCartasJugador();
            RepartirCartasAJugador(this.jugadorUno);
            RepartirCartasAJugador(this.jugadorDos);
        }

        public int CalcularCartaGanadora(Carta cartaJugador1, Carta cartaJugador2)
        {
            if (cartaJugador1.Puntaje < cartaJugador2.Puntaje)
            {
                return 1;
            }
            else if (cartaJugador1.Puntaje > cartaJugador2.Puntaje)
            {
                return 2;
            }
            return 0;
        }

        private string SumarPuntajeJugador(List<int> jugadorGanadorDeLaMano)
        {
            int jugadorUnoManosGanadas = 0;
            int jugadorDosManosGanadas = 0;
            int parda = 0;

            foreach (int item in jugadorGanadorDeLaMano)
            {
                if (item == 1)
                {
                    jugadorUnoManosGanadas++;
                }
                else if (item == 2)
                {
                    jugadorDosManosGanadas++;
                }
                else
                {
                    parda++;
                }
            }
            if (parda == 1 || parda == 2)
            {
                if (jugadorUnoManosGanadas == 1)
                {
                    return DevolverMensajeGanador(this.jugadorUno, "Jugador 1 gana la mano");
                }
                else
                {
                    return DevolverMensajeGanador(this.jugadorDos, "Jugador 2 gana la mano");
                }
            }
            if (parda == 3)
            {
                return DevolverMensajeGanador(this.jugadorUno, "Jugador 1 gana la mano");
            }
            if (jugadorUnoManosGanadas == 2)
            {
                return DevolverMensajeGanador(this.jugadorUno, "Jugador 1 gana la mano");
            }
            if (jugadorDosManosGanadas == 2)
            {
                return DevolverMensajeGanador(this.jugadorDos, "Jugador 2 gana la mano");
            }
            return "Se define en la tercer ronda";
        }
        private string DevolverMensajeGanador(Jugador jugador, string mensaje)
        {
            jugador.PuntajePartida = jugador.PuntajePartida + 2;
            this.finalizarRonda = true;
            return mensaje;
        }
        public string DevolverGanadorDePartida(Jugador jugadorUno, Jugador jugadorDos)
        {
            if (jugadorUno.PuntajePartida >= 15 && jugadorUno.PuntajePartida > jugadorDos.PuntajePartida)
            {
                jugadorUno.PuntajePartida = 0;
                jugadorDos.PuntajePartida = 0;
                jugadorUno.PartidasGanadas = 1;
                finalizarRonda = true;
                jugadorGanador = jugadorUno;
                return "Jugador 1 gana la partida";
            }
            else
            {
                jugadorDos.PuntajePartida = 0;
                jugadorUno.PuntajePartida = 0;
                jugadorDos.PartidasGanadas = 1;
                finalizarRonda = true;
                jugadorGanador = jugadorDos;
                return "Jugador 2 gana la partida";
            }
        }
        private void CargarInformacionAlHistorial(string datosPartida)
        {
            if (datosPartida != null)
            {
                historial.Add(datosPartida);
            }
        }


        private int CalcularGanadorEnvido(int tantosJ1, int tantosJ2)
        {
            if (tantosJ1 > tantosJ2)
            {
                return 1;
            }
            if (tantosJ2 > tantosJ1)
            {
                return 2;
            }
            return 0;
        }
    }
}
