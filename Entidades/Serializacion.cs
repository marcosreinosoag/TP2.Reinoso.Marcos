using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Serializacion<T>
    {
        static string ruta;
        static Serializacion()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory;
        }
        public static void Escribir(T datos, string archivo)
        {
            string rutaCompleta = ruta  + archivo + ".json";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                JsonSerializerOptions options = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }, };
                string objetoJson = JsonSerializer.Serialize(datos, options);
                File.WriteAllText(rutaCompleta, objetoJson);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al escribir en el archivo {rutaCompleta}", ex);
            }
        }
        public static T? Leer(string nombreArchivo)
        {
            string rutaCompleta = ruta + nombreArchivo + ".json";
            T? datos = default;
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                JsonSerializerOptions options = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }, };
                string archivoJson = File.ReadAllText(rutaCompleta);
                datos = JsonSerializer.Deserialize<T>(archivoJson, options);

                return datos;
            }
            catch (Exception)
            {
                throw new Exception($"Error al leer en el archivo{rutaCompleta}");
            }
        }
    }
}
