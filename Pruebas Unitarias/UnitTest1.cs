using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using Navaja_de_Alejandro.Aplicacion_1;

namespace Pruebas_Unitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SepararPrimos_PruebaValorNoPrimo()
        {
            Logica_Aplicacion_1 Logica = new Logica_Aplicacion_1();
            ArrayList ListaPrimos = new ArrayList();
            ArrayList ListaNoPrimos = new ArrayList();

            ListaNoPrimos.Add(12);
            Logica.SepararPrimos(ListaNoPrimos, ListaPrimos);

            Assert.AreEqual(ListaPrimos.Count, 0);
            Assert.AreEqual(ListaNoPrimos.Count, 1);
        }

        [TestMethod]
        public void SepararPrimos_PruebaValorPrimo()
        {
            Logica_Aplicacion_1 Logica = new Logica_Aplicacion_1();
            ArrayList ListaPrimos = new ArrayList();
            ArrayList ListaNoPrimos = new ArrayList();

            ListaNoPrimos.Add(7);
            Logica.SepararPrimos(ListaNoPrimos, ListaPrimos);

            Assert.AreEqual(ListaPrimos.Count, 1);
            Assert.AreEqual(ListaNoPrimos.Count, 0);
        }

        [TestMethod]
        public void SepararPrimos_PruebaValorNegativo()
        {
            //Los negativos se añadiran a la lista de primos
            Logica_Aplicacion_1 Logica = new Logica_Aplicacion_1();
            ArrayList ListaPrimos = new ArrayList();
            ArrayList ListaNoPrimos = new ArrayList();

            ListaNoPrimos.Add(-7);
            Logica.SepararPrimos(ListaNoPrimos, ListaPrimos);

            Assert.AreEqual(ListaPrimos.Count, 1);
            Assert.AreEqual(ListaNoPrimos.Count, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void SepararPrimos_PruebaValorDecimal()
        {
            Logica_Aplicacion_1 Logica = new Logica_Aplicacion_1();
            ArrayList ListaPrimos = new ArrayList();
            ArrayList ListaNoPrimos = new ArrayList();

            ListaNoPrimos.Add(1.3);
            Logica.SepararPrimos(ListaNoPrimos, ListaPrimos);
        }


        [TestMethod]        
        public void SepararPrimos_PruebaSinValor()
        {
            //No se añadira nada a ninguna lista
            Logica_Aplicacion_1 Logica = new Logica_Aplicacion_1();
            ArrayList ListaPrimos = new ArrayList();
            ArrayList ListaNoPrimos = new ArrayList();

            Logica.SepararPrimos(ListaNoPrimos, ListaPrimos);


            Assert.AreEqual(ListaPrimos.Count, 0);
            Assert.AreEqual(ListaNoPrimos.Count, 0);
        }

        [TestMethod]
        public void SepararPrimos_PruebaValorMaximo()
        {
            //Se añadira a la lista de primos
            Logica_Aplicacion_1 Logica = new Logica_Aplicacion_1();
            ArrayList ListaPrimos = new ArrayList();
            ArrayList ListaNoPrimos = new ArrayList();

            ListaNoPrimos.Add(int.MaxValue);
            Logica.SepararPrimos(ListaNoPrimos, ListaPrimos);


            Assert.AreEqual(ListaPrimos.Count, 1);
            Assert.AreEqual(ListaNoPrimos.Count, 0);
        }

        [TestMethod]
        public void SepararPrimos_PruebaValorMinimo()
        {
            //Se añadira a la lista de primos
            Logica_Aplicacion_1 Logica = new Logica_Aplicacion_1();
            ArrayList ListaPrimos = new ArrayList();
            ArrayList ListaNoPrimos = new ArrayList();

            ListaNoPrimos.Add(int.MinValue);
            Logica.SepararPrimos(ListaNoPrimos, ListaPrimos);


            Assert.AreEqual(ListaPrimos.Count, 1);
            Assert.AreEqual(ListaNoPrimos.Count, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void SepararPrimos_PruebaValorLetra()
        {
            Logica_Aplicacion_1 Logica = new Logica_Aplicacion_1();
            ArrayList ListaPrimos = new ArrayList();
            ArrayList ListaNoPrimos = new ArrayList();

            ListaNoPrimos.Add("A");
            Logica.SepararPrimos(ListaNoPrimos, ListaPrimos);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void SepararPrimos_PruebaValorNoAlfanumerico()
        {
            Logica_Aplicacion_1 Logica = new Logica_Aplicacion_1();
            ArrayList ListaPrimos = new ArrayList();
            ArrayList ListaNoPrimos = new ArrayList();

            ListaNoPrimos.Add("*");
            Logica.SepararPrimos(ListaNoPrimos, ListaPrimos);
        }
    }
}
