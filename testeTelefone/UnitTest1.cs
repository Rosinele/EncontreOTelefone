using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testeTelefone
{
    [TestClass]
    public class Teste
    {
        [TestMethod]
        public void testandoNumero1()
        {
            var letra = new Numero();

            var retorno = Numero.gerar("1");

            Assert.AreEqual("1", retorno);

        }

        [TestMethod]
        public void testandoNumero2()
        {
            var letra = new Numero();

            var retorno = Numero.gerar("b");

            Assert.AreEqual("2", retorno);

        }


        [TestMethod]
        public void testandoNumero3()
        {
            var letra = new Numero();

            var retorno = Numero.gerar("f");

            Assert.AreEqual("3", retorno);

        }

        [TestMethod]
        public void testandoNumero4()
        {
            var letra = new Numero();

            var retorno = Numero.gerar("i");

            Assert.AreEqual("4", retorno);

        }

        [TestMethod]
        public void testandoNumero5()
        {
            var letra = new Numero();

            var retorno = Numero.gerar("l");

            Assert.AreEqual("5", retorno);

        }

        [TestMethod]
        public void testandoNumero6()
        {
            var letra = new Numero();

            var retorno = Numero.gerar("m");

            Assert.AreEqual("6", retorno);

        }

        [TestMethod]
        public void testandoNumero7()
        {
            var letra = new Numero();

            var retorno = Numero.gerar("r");

            Assert.AreEqual("7", retorno);

        }

        [TestMethod]
        public void testandoNumero8()
        {
            var letra = new Numero();

            var retorno = Numero.gerar("u");

            Assert.AreEqual("8", retorno);

        }

        [TestMethod]
        public void testandoNumero9()
        {
            var letra = new Numero();

            var retorno = Numero.gerar("z");

            Assert.AreEqual("9", retorno);

        }

        [TestMethod]
        public void testandoNumeroVarios()
        {
            var letra = new Numero();

            var retorno = Numero.gerar("z");

            Assert.AreEqual("9", retorno);

        }
    }
}
