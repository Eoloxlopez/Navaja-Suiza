using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Navaja_de_Alejandro.Aplicacion_4;

namespace Pruebas_Unitarias
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void EstaVector_PruebaValorEnteroQueEsta()
        {
            Logica_Aplicacion_4 Logica = new Logica_Aplicacion_4();
            int Busqueda = 3;
            Logica.Vector1[0] = 3;

            Assert.IsTrue(Logica.EstaVector(Logica.Vector1, Busqueda));
        }

        [TestMethod]
        public void EstaVector_PruebaValorEnteroQueNoEsta()
        {
            Logica_Aplicacion_4 Logica = new Logica_Aplicacion_4();
            int Busqueda = 2;
            Logica.Vector1[0] = 3;

            Assert.IsFalse(Logica.EstaVector(Logica.Vector1, Busqueda));
        }

        [TestMethod]
        public void EstaVector_PruebaValorNegativo()
        {
            Logica_Aplicacion_4 Logica = new Logica_Aplicacion_4();
            int Busqueda = -6;
            Logica.Vector1[0] = -6;

            Assert.IsTrue(Logica.EstaVector(Logica.Vector1, Busqueda));
        }

        [TestMethod]
        public void EstaVector_PruebaValorMaximo()
        {
            Logica_Aplicacion_4 Logica = new Logica_Aplicacion_4();
            int Busqueda = int.MaxValue;
            Logica.Vector1[0] = int.MaxValue;

            Assert.IsTrue(Logica.EstaVector(Logica.Vector1, Busqueda));
        }

        [TestMethod]
        public void EstaVector_PruebaValorMinimo()
        {
            Logica_Aplicacion_4 Logica = new Logica_Aplicacion_4();
            int Busqueda = int.MinValue;
            Logica.Vector1[0] = int.MinValue;

            Assert.IsTrue(Logica.EstaVector(Logica.Vector1, Busqueda));
        }
    }
}
