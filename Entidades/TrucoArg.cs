using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class TrucoArg
    {
        public static List<Carta> mazoDeCartas;
        public static List<Jugador> listaDeJugadores;
        public static List<Usuario> listaDeUsuarios;
        public static Sala[] salas;
        public static CancellationTokenSource[] tokenTareas;

        static TrucoArg()
        {
            tokenTareas = new CancellationTokenSource[6];
            salas = new Sala[6];
            mazoDeCartas = new List<Carta>();
            listaDeJugadores = new List<Jugador>();
            listaDeUsuarios = new List<Usuario>();
            LeerUsuarios();
            LeerCartas();
        }
        public static bool VerificarJugadorEnPartida(int id)
        {
            foreach (var item in salas)
            {
                if (item != null)
                {
                    if (id == item.IdJugadorUno || id == item.IdJugadorDos)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static void LeerUsuarios()
        {
            try
            {
                List<Usuario>? auxListaDeUsuarios = Serializacion<List<Usuario>>.Leer("Usuarios");
                if (auxListaDeUsuarios != null)
                {
                    listaDeUsuarios = auxListaDeUsuarios;
                }
            }
            catch
            {
                HardcodearUsuarios();
            }
        }

        public static void LeerCartas()
        {
            try
            {
                List<Carta>? auxMaxo = Serializacion<List<Carta>>.Leer("Mazo");
                if (auxMaxo != null)
                {
                    mazoDeCartas = auxMaxo;
                }
            }
            catch
            {
                HardcodearCartas();
            }
        }

        public static int BuscarSalaDisponible()
        {
            for (int i = 0; i < salas.Length; i++)
            {
                if (salas[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }
        private static int DevolverIndiceListaJugadoresPorId(int id)
        {
            foreach (Jugador jugador in listaDeJugadores)
            {
                if (jugador.Id == id)
                {
                    return listaDeJugadores.IndexOf(jugador);
                }
            }
            return -1;
        }
        public static int BuscarPartidasJugadorPorId(int id)
        {
            int indice = DevolverIndiceListaJugadoresPorId(id);
            return listaDeJugadores[indice].PartidasGanadas;
        }
        public static string BuscarApellidoJugadorPorId(int id)
        {
            int indice = DevolverIndiceListaJugadoresPorId(id);
            return listaDeJugadores[indice].Apellido;
        }
        public static string BuscarNombreJugadorPorId(int id)
        {
            int indice = DevolverIndiceListaJugadoresPorId(id);
            return listaDeJugadores[indice].Nombre;
        }
        public static bool CargarListaDeJugadores()
        {
            try
            {
                AccesoBaseDeDatos bDJugadores = new AccesoBaseDeDatos();
                listaDeJugadores = bDJugadores.ObtenerJugadores();
            }
            catch
            {
                return true;
            }
            return false;
        }
        public static void ModificarJugadorPorId(int id)
        {
            foreach (Jugador item in listaDeJugadores)
            {
                if (item.Id == id)
                {
                    AccesoBaseDeDatos bDJugadores = new AccesoBaseDeDatos();
                    bDJugadores.ModificarJugador(item);
                }
            }
        }
        public static void HardcodearUsuarios()
        {
            Usuario usuarioUno = new Usuario("MarcosReinoso2022", "1234", "Marcos", "Reinoso");
            Usuario usuarioDos = new Usuario("Ruben123", "222", "Ruben", "Castro");
            Usuario usuarioTres = new Usuario("Juan432", "664", "Juan", "Rivera");
            Usuario usuarioCuatro = new Usuario("Esteban", "qwerty", "Esteban", "Scalissi");
            Usuario usuarioCinco = new Usuario("Lorenzo22", "Argentina00", "Lorenzo", "Trejo");
            Usuario usuarioSeis = new Usuario("JosePerezz", "1100", "Jose", "Perez");
            Usuario usuarioSiete = new Usuario("NNahuel", "2023q", "Nuhuel", "Vera");
            Usuario usuarioOcho = new Usuario("Nicolas12223", "23332", "Nicolas", "Trejo");
            Usuario usuarioNueve = new Usuario("Hugoght", "ght123", "Hugo", "Utnfra");
            Usuario usuarioDiez = new Usuario("Roberto", "1233", "Roberto", "Kier");

            listaDeUsuarios.Add(usuarioUno);
            listaDeUsuarios.Add(usuarioDos);
            listaDeUsuarios.Add(usuarioTres);
            listaDeUsuarios.Add(usuarioCuatro);
            listaDeUsuarios.Add(usuarioCinco);
            listaDeUsuarios.Add(usuarioSeis);
            listaDeUsuarios.Add(usuarioSiete);
            listaDeUsuarios.Add(usuarioOcho);
            listaDeUsuarios.Add(usuarioNueve);
            listaDeUsuarios.Add(usuarioDos);
            listaDeUsuarios.Add(usuarioDiez);
        }

        public static bool BuscarIdJugador(int id)
        {
            foreach (Jugador jugador in listaDeJugadores)
            {
                if (jugador.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
        public static int DevolverIndiceJugador(int id)
        {
            if (id > -1)
            {
                foreach (Jugador item in listaDeJugadores)
                {
                    if (item.Id == id)
                    {
                        return listaDeJugadores.IndexOf(item);
                    }
                }
            }
            return -1;
        }
        public static void HardcodearCartas()
        {
            Carta unoDeEspada = new Carta(1, Palo.Espada, 1);
            Carta unoDeBasto = new Carta(1, Palo.Basto, 2);
            Carta sieteDeEspada = new Carta(7, Palo.Espada, 3);
            Carta sieteDeOro = new Carta(7, Palo.Oro, 4);
            Carta tresDeOro = new Carta(3, Palo.Oro, 5);
            Carta tresDeCopa = new Carta(3, Palo.Copa, 5);
            Carta tresDeEspada = new Carta(3, Palo.Espada, 5);
            Carta tresDeBasto = new Carta(3, Palo.Basto, 5);
            Carta dosDeOro = new Carta(2, Palo.Oro, 6);
            Carta dosDeCopa = new Carta(2, Palo.Copa, 6);
            Carta dosDeEspada = new Carta(2, Palo.Espada, 6);
            Carta dosDeBasto = new Carta(2, Palo.Basto, 6);
            Carta unoDeOro = new Carta(1, Palo.Oro, 7);
            Carta unoDeCopa = new Carta(1, Palo.Copa, 7);
            Carta doceDeEspada = new Carta(12, Palo.Espada, 8);
            Carta doceDeCopa = new Carta(12, Palo.Copa, 8);
            Carta doceDeOro = new Carta(12, Palo.Oro, 8);
            Carta doceDeBasto = new Carta(12, Palo.Basto, 8);

            Carta onceDeEspada = new Carta(11, Palo.Espada, 9);
            Carta onceDeCopa = new Carta(11, Palo.Copa, 9);
            Carta onceDeOro = new Carta(11, Palo.Oro, 9);
            Carta onceDeBasto = new Carta(11, Palo.Basto, 9);

            Carta diezDeEspada = new Carta(10, Palo.Espada, 10);
            Carta diezDeCopa = new Carta(10, Palo.Copa, 10);
            Carta diezDeOro = new Carta(10, Palo.Oro, 10);
            Carta diezDeBasto = new Carta(10, Palo.Basto, 10);

            Carta sieteDeCopa = new Carta(7, Palo.Copa, 11);
            Carta UnoDeBasto = new Carta(7, Palo.Basto, 11);

            Carta seisDeEspada = new Carta(6, Palo.Espada, 12);
            Carta seisDeCopa = new Carta(6, Palo.Copa, 12);
            Carta seisDeOro = new Carta(6, Palo.Oro, 12);
            Carta seisDeBasto = new Carta(6, Palo.Basto, 12);

            Carta cincoDeEspada = new Carta(5, Palo.Espada, 13);
            Carta cincoDeCopa = new Carta(5, Palo.Copa, 13);
            Carta cincoDeOro = new Carta(5, Palo.Oro, 13);
            Carta cincoDeBasto = new Carta(5, Palo.Basto, 13);

            Carta cuatroDeEspada = new Carta(4, Palo.Espada, 14);
            Carta cuatroDeCopa = new Carta(4, Palo.Copa, 14);
            Carta cuatroDeOro = new Carta(4, Palo.Oro, 14);
            Carta cuatroDeBasto = new Carta(4, Palo.Basto, 14);

            mazoDeCartas.Add(unoDeEspada);
            mazoDeCartas.Add(unoDeBasto);
            mazoDeCartas.Add(sieteDeEspada);
            mazoDeCartas.Add(sieteDeOro);
            mazoDeCartas.Add(tresDeOro);
            mazoDeCartas.Add(tresDeCopa);
            mazoDeCartas.Add(tresDeEspada);
            mazoDeCartas.Add(tresDeBasto);
            mazoDeCartas.Add(dosDeOro);
            mazoDeCartas.Add(dosDeCopa);
            mazoDeCartas.Add(dosDeEspada);
            mazoDeCartas.Add(dosDeBasto);
            mazoDeCartas.Add(unoDeOro);
            mazoDeCartas.Add(unoDeCopa);
            mazoDeCartas.Add(doceDeEspada);
            mazoDeCartas.Add(doceDeCopa);
            mazoDeCartas.Add(doceDeOro);
            mazoDeCartas.Add(doceDeBasto);
            mazoDeCartas.Add(onceDeEspada);
            mazoDeCartas.Add(onceDeCopa);
            mazoDeCartas.Add(onceDeOro);
            mazoDeCartas.Add(onceDeBasto);
            mazoDeCartas.Add(diezDeEspada);
            mazoDeCartas.Add(diezDeCopa);
            mazoDeCartas.Add(diezDeOro);
            mazoDeCartas.Add(diezDeBasto);
            mazoDeCartas.Add(sieteDeCopa);
            mazoDeCartas.Add(UnoDeBasto);
            mazoDeCartas.Add(seisDeEspada);
            mazoDeCartas.Add(seisDeCopa);
            mazoDeCartas.Add(seisDeOro);
            mazoDeCartas.Add(seisDeBasto);
            mazoDeCartas.Add(cincoDeEspada);
            mazoDeCartas.Add(cincoDeCopa);
            mazoDeCartas.Add(cincoDeOro);
            mazoDeCartas.Add(cincoDeBasto);
            mazoDeCartas.Add(cuatroDeEspada);
            mazoDeCartas.Add(cuatroDeCopa);
            mazoDeCartas.Add(cuatroDeOro);
            mazoDeCartas.Add(cuatroDeBasto);
        }
        public static bool VerificarUsuarioYClave(string usuarioIngresado, string claveIngresada)
        {
            foreach (Usuario item in listaDeUsuarios)
            {
                if (item.Cuenta == usuarioIngresado && item.Clave == claveIngresada)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
