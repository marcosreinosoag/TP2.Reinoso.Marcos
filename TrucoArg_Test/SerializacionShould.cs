using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoArg_Test
{
    [TestClass]
    public class SerializacionShould
    {
        [TestMethod]
        public void EscribirArchivoJson()
        {
            string nombreArchivo = "Serializar Prueba";
            string ruta = AppDomain.CurrentDomain.BaseDirectory;

            Carta auxCarta = new Carta(1, Palo.Espada, 1);

            Serializacion<Carta>.Escribir(auxCarta, "Serializar Prueba");

            Assert.IsTrue(BuscarArchivo(ruta, nombreArchivo));
        }
        private bool BuscarArchivo(string ruta, string nombreArchivo)
        {
            return File.Exists(ruta + @"/" + nombreArchivo + ".json");
        }
        [TestMethod]
        public void LeerArchivoJson()
        {
            string nombreArchivo = "Serializar Prueba";

            Carta? auxCarta = Serializacion<Carta>.Leer(nombreArchivo);

            Assert.IsNotNull(auxCarta);
            Assert.AreEqual(auxCarta.Numero,1);
            Assert.AreEqual(auxCarta.Tipo,Palo.Espada);
            Assert.AreEqual(auxCarta.Puntaje,1);
        }
    }
}
