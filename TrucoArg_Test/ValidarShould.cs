using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoArg_Test
{
    [TestClass]
    public class ValidarShould
    {
        [TestMethod]
        public void ValidarStringSoloLetrasCorrectamente()
        {
            string? retorno;

            retorno = Validar.ValidarStringSoloLetras("UTNFRA");

            Assert.AreEqual(retorno, "UTNFRA");
        }
        [TestMethod]
        public void DevolverNullCuandoElStringEsErroneo()
        {
            string? retorno;

            retorno = Validar.ValidarStringSoloLetras("111123");

            Assert.IsNull(retorno);
        }
        [TestMethod]
        public void ConvertirStringAEnteroCorrectamente()
        {
            int retorno;

            retorno = Validar.ConvertirStringAEntero("1234");

            Assert.AreEqual(retorno, 1234);
        }
        [TestMethod]
        public void DevolverCeroCuandoElStringNoSePudoCovertirAEntero()
        {
            int retorno;
            retorno = Validar.ConvertirStringAEntero("aaaaaa");
            Assert.AreEqual(retorno,0);
        }

    }
}
