using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        string cuenta;
        string clave;
        string nombre;
        string apellido;

        public Usuario(string cuenta, string clave, string nombre, string apellido)
        {
            this.cuenta = cuenta;
            this.clave = clave;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public string Cuenta { get => cuenta; }
        public string Clave { get => clave; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
    }
}
