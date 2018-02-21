using System;
using System.Runtime.Remoting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CadeMeuMedico.Testes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = 1;
            var b = 2;
            var soma = a + b;
            
            Assert.AreEqual(3, soma);
        }

        [TestMethod]
        public void MeuTesteQuebrado()
        {
            var a = 4;
            var b = 4;
            var soma = a + b;

            Assert.AreEqual(8, soma);
        }



        [TestMethod]
        public void MeuTesteFuncionando()
        {
            var a = 1;
            var b = 2;
            var soma = a + b;

            Assert.AreEqual(3, soma);
        }
    }
}
