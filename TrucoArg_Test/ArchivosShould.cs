using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoArg_Test
{
    [TestClass]
    public class ArchivosShould
    {
        [TestMethod]

        public void EscribirArchivoTxtCorrectamente()
        { 
            Archivos.Escribir("Prueba TXT", "Archivo Prueba");
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
            Assert.IsTrue(BuscarArchivo(ruta, "Archivo Prueba"));
        }
        private bool BuscarArchivo(string ruta, string nombreArchivo)
        {
            return File.Exists(ruta + @"/" + nombreArchivo + ".txt");
        }
    }
}
