using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoArg_Test
{
    [TestClass]
    public class AccesoBaseDeDatosShould
    {
        [TestMethod]
        public void ObtenerJugadoresCorrectamente()
        {
            List<Jugador> auxJugadores;
            AccesoBaseDeDatos auxAccesoBaseDeDatos = new AccesoBaseDeDatos();
            auxJugadores = auxAccesoBaseDeDatos.ObtenerJugadores();
            Assert.IsNotNull(auxJugadores);
        }
        [ExpectedException(typeof(DBConcurrencyException))]
        [TestMethod]
        public void DevolverUnaExcepcionCuandoAgregoUnJugadorQueEsNull()
        {
            AccesoBaseDeDatos auxAccesoBaseDeDatos = new AccesoBaseDeDatos();
            auxAccesoBaseDeDatos.AgregarJugador(null);
        }

        [ExpectedException(typeof(DBConcurrencyException))]
        [TestMethod]
        public void DevolverUnaExcepcionCuandoModificoUnJugadorQueEsNull()
        {
            AccesoBaseDeDatos auxAccesoBaseDeDatos = new AccesoBaseDeDatos();
            auxAccesoBaseDeDatos.ModificarJugador(null);
        }

        [TestMethod]
        [ExpectedException(typeof(DBConcurrencyException))]
        public void DevolverUnaExcepcionCuandoAgregoUnaSalaQueEsNull()
        {
            AccesoBaseDeDatos auxAccesoBaseDeDatos = new AccesoBaseDeDatos();
            auxAccesoBaseDeDatos.AgregarSala(null);
        }

        [TestMethod]
        [ExpectedException(typeof(DBConcurrencyException))]
        public void DevolverUnaExcepcionCuandoAgregoUnaPartidaQueEsNull()
        {
            AccesoBaseDeDatos auxAccesoBaseDeDatos = new AccesoBaseDeDatos();
            auxAccesoBaseDeDatos.AgregarPartida(null);
        }
        [TestMethod]
        public void ObtenerPartidasCorrectamente()
        {
            List<string> auxPartidas;
            AccesoBaseDeDatos auxAccesoBaseDeDatos = new AccesoBaseDeDatos();
            auxPartidas = auxAccesoBaseDeDatos.ObtenerPartidas();
            Assert.IsNotNull(auxPartidas);
        }
    }
}
