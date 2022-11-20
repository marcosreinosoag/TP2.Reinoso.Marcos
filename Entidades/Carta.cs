using System.Net;

namespace Entidades
{
    public enum Palo
    {
        Espada,
        Oro,
        Basto,
        Copa,
    }
    public class Carta : IInformacion
    {
        int numero;
        Palo tipo;
        int puntaje;

        public Carta(int numero, Palo tipo, int puntaje)
        {
            this.numero = numero;
            this.tipo = tipo;
            this.puntaje = puntaje;
        }
        public int Numero { get => numero; }
        public Palo Tipo { get => tipo; }
        public int Puntaje { get => puntaje; }
        public string MostrarInformacion()
        {
            return $"Carta: {numero} de {Tipo}";
        }
    }
}