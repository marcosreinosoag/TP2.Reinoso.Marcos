using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoArg_Test
{
    [TestClass]
    public class TrucoArgShould
    {
        [TestMethod]
        public void VerificarUsuarioYClaveCorrectamente()
        {
            string nombreUsuario = "MarcosReinoso2022";
            string clave = "1234";
            bool retorno;

            retorno = TrucoArg.VerificarUsuarioYClave(nombreUsuario, clave);

            Assert.AreEqual(retorno, true);
        }

        [TestMethod]
        public void VerificarQueElUsuarioYClaveSonErroneos()
        {
            string nombreUsuario = "pepe";
            string clave = "111";
            bool retorno;

            retorno = TrucoArg.VerificarUsuarioYClave(nombreUsuario, clave);

            Assert.AreEqual(retorno, false);
        }
    }
}
