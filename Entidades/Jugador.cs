using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : IInformacion
    {
        int id;
        string nombre;
        string apellido;
        DateTime fechaDeNacimiento;
        int puntajePartida;
        int partidasGanadas;
        List<Carta> cartasJugador;
        bool truco;
        bool envido;
        int tantos;
        public Jugador(string nombre, string apellido, DateTime fechaDeNacimiento, int puntajePartida, int partidasGanadas)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.puntajePartida = puntajePartida;
            this.partidasGanadas = partidasGanadas;
            truco = false;
            envido = false;
            tantos = 0;
            cartasJugador = new List<Carta>();
        }
        public Jugador(int id, string nombre, string apellido, DateTime fechaDeNacimiento, int puntajePartida, int partidasGanadas) : this(nombre, apellido, fechaDeNacimiento, puntajePartida, partidasGanadas)
        {
            this.id = id;
        }
        public int Id
        {
            get { return this.id; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public string Apellido
        {
            get { return this.apellido; }
        }
        public DateTime FechaNacimiento
        {
            get { return this.fechaDeNacimiento; }
        }
        public int PartidasGanadas
        {
            get { return this.partidasGanadas; }
            set { partidasGanadas += value; }
        }
        public int PuntajePartida
        {
            get { return this.puntajePartida; }
            set { puntajePartida = value; }
        }
        public List<Carta> CartasJugador
        {
            get { return this.cartasJugador; }
            set { this.cartasJugador = value; }
        }

        public bool Truco { get => truco; set => truco = value; }
        public bool Envido { get => envido; set => envido = value; }
        public int Tantos { get => tantos; set => tantos = value; }
        public string DevolverNombreYApellido()
        {
            return $"{this.nombre} {this.apellido}";
        }
        public Carta CartaJugada()
        {
            int auxIndiceCartaJugada;
            Random indiceCartaJugada = new Random();
            Carta auxCartaElegida;
            if (cartasJugador.Count > 0)
            {
                auxIndiceCartaJugada = indiceCartaJugada.Next(0, cartasJugador.Count - 1);
            }
            else
            {
                auxIndiceCartaJugada = 0;
            }
            auxCartaElegida = CartasJugador[auxIndiceCartaJugada];
            CartasJugador.Remove(auxCartaElegida);
            return auxCartaElegida;
        }
        public void LimpiarlistaCartasJugador()
        {
            cartasJugador.Clear();
        }
        public void VerificarTrucoYEnvido()
        {
            int puntajeCartas = CalcularPuntajeCartas();
            truco = false;
            if (puntajeCartas < 25)
            {
                truco = true;
            }
            CalcularTantos();
            if (tantos > 0)
            {
                envido = true;
            }
        }
        private void CalcularTantos()
        {
            int totalTantos = 0;
            tantos = 0;
            foreach (Carta item in cartasJugador)
            {

                foreach (Carta cartaABustar in cartasJugador)
                {
                    if (item != cartaABustar && item.Tipo == cartaABustar.Tipo)
                    {
                        totalTantos += 20;
                        if (item.Numero > 9 && cartaABustar.Numero < 9)
                        {
                            totalTantos += cartaABustar.Numero;
                            break;
                        }
                        if (cartaABustar.Numero > 9 && item.Numero < 9)
                        {
                            totalTantos += item.Numero;
                            break;
                        }
                        if (cartaABustar.Numero < 9 && item.Numero < 9)
                        {
                            totalTantos += item.Numero + cartaABustar.Numero;
                            break;
                        }
                        break;
                    }
                }
                if (totalTantos > 0)
                {
                    tantos = totalTantos;
                    break;
                }
            }
        }
        public int CalcularPuntajeCartas()
        {
            int puntajeTotal = 0;
            foreach (Carta item in cartasJugador)
            {
                puntajeTotal += item.Puntaje;
            }
            return puntajeTotal;
        }
        public string MostrarInformacion()
        {
            return $"Nombre:{nombre} Apellido{apellido}";
        }
    }
}
