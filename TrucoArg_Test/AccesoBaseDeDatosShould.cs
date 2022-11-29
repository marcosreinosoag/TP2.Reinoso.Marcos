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
    }
}
