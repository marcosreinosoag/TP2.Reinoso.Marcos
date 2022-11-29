using Entidades;

namespace TrucoArg_Test
{
    [TestClass]
    public class SalaShould
    {
        [TestMethod]
        public void DevolverJugadorUnoEnJugadorGanadorDePartida()
        {
            Jugador jugadorUno = new Jugador("Gerardo", "lopez", new DateTime(2000, 02, 22), 23, 2);
            Jugador jugadorDos = new Jugador("Martin", "Diaz", new DateTime(1997, 02, 22), 10, 2);
            Sala auxSala = new Sala(jugadorUno, jugadorDos, 2);
            string jugadorEsperado;

            jugadorEsperado = auxSala.DevolverGanadorDePartida(jugadorUno, jugadorDos);

            Assert.AreEqual(jugadorEsperado, "Jugador 1 gana la partida");
        }
        [TestMethod]
        public void DevolverJugadorDosEnJugadorGanadorDePartida()
        {

            Jugador jugadorUno = new Jugador("Gerardo", "lopez", new DateTime(2000, 02, 22), 9, 2);
            Jugador jugadorDos = new Jugador("Martin", "Diaz", new DateTime(1997, 02, 22), 16, 2);
            Sala auxSala = new Sala(jugadorUno, jugadorDos, 2);
            string jugadorEsperado;

            jugadorEsperado = auxSala.DevolverGanadorDePartida(jugadorUno, jugadorDos);

            Assert.AreEqual(jugadorEsperado, "Jugador 2 gana la partida");
        }
        [TestMethod]
        public void DevolverJugadorDosEnCasoDeEmpateGanadorDePartida()
        {
            Jugador jugadorUno = new Jugador("Gerardo", "lopez", new DateTime(2000, 02, 22), 15, 2);
            Jugador jugadorDos = new Jugador("Martin", "Diaz", new DateTime(1997, 02, 22), 15, 2);
            Sala auxSala = new Sala(jugadorUno, jugadorDos, 2);
            string jugadorEsperado;

            jugadorEsperado = auxSala.DevolverGanadorDePartida(jugadorUno, jugadorDos);

            Assert.AreEqual(jugadorEsperado, "Jugador 2 gana la partida");
        }

        [TestMethod]
        public void DevolverUnoCuandoLaCartarDelJugadorUnoSeaLaGanadora()
        {

            Carta cartaJugadorUno = new Carta(1, Palo.Espada, 1);
            Carta cartaJugadorDos = new Carta(4, Palo.Basto, 14);
            Jugador jugadorUno = new Jugador("Gerardo", "lopez", new DateTime(2000, 02, 22), 15, 2);
            Jugador jugadorDos = new Jugador("Martin", "Diaz", new DateTime(1997, 02, 22), 15, 2);
            Sala auxSala = new Sala(jugadorUno, jugadorDos, 2);
            int EnteroEsperado;

            EnteroEsperado = auxSala.CalcularCartaGanadora(cartaJugadorUno, cartaJugadorDos);

            Assert.AreEqual(EnteroEsperado, 1);
        }
        [TestMethod]
        public void DevolverDosCuandoLaCartarDelJugadorDosSeaLaGanadora()
        {
            Carta cartaJugadorDos = new Carta(1, Palo.Espada, 1); 
            Carta cartaJugadorUno = new Carta(4, Palo.Basto, 14);
            Jugador jugadorUno = new Jugador("Gerardo", "lopez", new DateTime(2000, 02, 22), 15, 2);
            Jugador jugadorDos = new Jugador("Martin", "Diaz", new DateTime(1997, 02, 22), 15, 2);
            Sala auxSala = new Sala(jugadorUno, jugadorDos, 2);
            int EnteroEsperado;

            EnteroEsperado = auxSala.CalcularCartaGanadora(cartaJugadorUno, cartaJugadorDos);

            Assert.AreEqual(EnteroEsperado, 2);
        }
        [TestMethod]
        public void Devolver0CuandoLasCartasDelosJugadoresSeanPardas()
        {

            Carta cartaJugadorDos = new Carta(6, Palo.Oro, 12);
            Carta cartaJugadorUno = new Carta(6, Palo.Basto, 12);
            Jugador jugadorUno = new Jugador("Gerardo", "lopez", new DateTime(2000, 02, 22), 15, 2);
            Jugador jugadorDos = new Jugador("Martin", "Diaz", new DateTime(1997, 02, 22), 15, 2);
            Sala auxSala = new Sala(jugadorUno, jugadorDos, 2);
            int EnteroEsperado;

            EnteroEsperado = auxSala.CalcularCartaGanadora(cartaJugadorUno, cartaJugadorDos);

            Assert.AreEqual(EnteroEsperado, 0);
        }
    }
}