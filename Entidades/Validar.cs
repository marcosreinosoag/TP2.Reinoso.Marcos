using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validar
    {
        /// <summary>
        /// Analiza si un string esta compuesto solamente por letras
        /// </summary>
        /// <param name="cadenaParaAnalizar"></param>
        /// <returns>Retorna la cadena si se verifica que el string fue ingresado correctamente, caso contrario null</returns>
        public static string? ValidarStringSoloLetras(string cadenaParaAnalizar)
        {
            string? retorno = null;
            if (string.IsNullOrWhiteSpace(cadenaParaAnalizar) == true)
            {
                return retorno;
            }
            foreach (char item in cadenaParaAnalizar)
            {

                if (item < 65 || item > 90)
                {
                    if (item < 97 || item > 122)
                    {
                        return retorno;
                    }
                }
            }
            retorno = cadenaParaAnalizar;
            return retorno;
        }
        public static int ConvertirStringAEntero(string aConvertir)
        {
            int retorno = int.MinValue;
            if (aConvertir != null)
            {
                while (int.TryParse(aConvertir, out retorno))
                {
                    return retorno;
                }
            }
            return retorno;
        }
    }
}
