using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Archivos
    {
        static string ruta;
        static Archivos()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory;
        }
        public static void Escribir(string mensaje, string nombreArchivo)
        {
            string rutaCompleta = ruta + nombreArchivo + ".txt";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamWriter sw = new StreamWriter(rutaCompleta,true))
                {
                    sw.WriteLine(mensaje);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al escribir en el archivo {rutaCompleta}", ex);
            }
        }
    }
}
