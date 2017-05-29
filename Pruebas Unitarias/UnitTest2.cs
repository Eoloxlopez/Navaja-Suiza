using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Navaja_de_Alejandro.Aplicacion_2;

namespace Pruebas_Unitarias
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void SumarMatriz_PruebaValoresEnteros()
        {
            Logica_Aplicacion_2.PrimeraMatriz[0, 0] = 15;
            Logica_Aplicacion_2.SegundaMatriz[0, 0] = 15;

            Logica_Aplicacion_2.SumaMatriz(Logica_Aplicacion_2.PrimeraMatriz, Logica_Aplicacion_2.SegundaMatriz, Logica_Aplicacion_2.MatrizSumada);

            Assert.AreEqual(Logica_Aplicacion_2.MatrizSumada[0, 0], 30); 
        }

        [TestMethod]
        public void SumarMatriz_PruebaValoresDecimales()
        {
            Logica_Aplicacion_2.PrimeraMatriz[0, 0] = 1.5;
            Logica_Aplicacion_2.SegundaMatriz[0, 0] = 3.8;

            Logica_Aplicacion_2.SumaMatriz(Logica_Aplicacion_2.PrimeraMatriz, Logica_Aplicacion_2.SegundaMatriz, Logica_Aplicacion_2.MatrizSumada);

            Assert.AreEqual(Logica_Aplicacion_2.MatrizSumada[0, 0], 5.3);
        }

        [TestMethod]
        public void SumarMatriz_PruebaValoresNegativos()
        {
            Logica_Aplicacion_2.PrimeraMatriz[0, 0] = -6;
            Logica_Aplicacion_2.SegundaMatriz[0, 0] = -8;

            Logica_Aplicacion_2.SumaMatriz(Logica_Aplicacion_2.PrimeraMatriz, Logica_Aplicacion_2.SegundaMatriz, Logica_Aplicacion_2.MatrizSumada);

            Assert.AreEqual(Logica_Aplicacion_2.MatrizSumada[0, 0], -14);
        }

        [TestMethod]
        public void SumarMatriz_PruebaValoresMaximo()
        {
            Logica_Aplicacion_2.PrimeraMatriz[0, 0] = double.MaxValue;
            Logica_Aplicacion_2.SegundaMatriz[0, 0] = double.MaxValue;

            Logica_Aplicacion_2.SumaMatriz(Logica_Aplicacion_2.PrimeraMatriz, Logica_Aplicacion_2.SegundaMatriz, Logica_Aplicacion_2.MatrizSumada);

            Assert.AreEqual(Logica_Aplicacion_2.MatrizSumada[0, 0], double.MaxValue * 2);
        }


        [TestMethod]
        public void SumarMatriz_PruebaValoresMinimo()
        {
            Logica_Aplicacion_2.PrimeraMatriz[0, 0] = double.MinValue;
            Logica_Aplicacion_2.SegundaMatriz[0, 0] = double.MinValue;

            Logica_Aplicacion_2.SumaMatriz(Logica_Aplicacion_2.PrimeraMatriz, Logica_Aplicacion_2.SegundaMatriz, Logica_Aplicacion_2.MatrizSumada);

            Assert.AreEqual(Logica_Aplicacion_2.MatrizSumada[0, 0], double.MinValue * 2);
        }

        [TestMethod]
        public void SumarMatriz_PruebaValoresVacios()
        {
            Logica_Aplicacion_2.PrimeraMatriz[0, 0] = 0;
            Logica_Aplicacion_2.SegundaMatriz[0, 0] = 0;

            Logica_Aplicacion_2.SumaMatriz(Logica_Aplicacion_2.PrimeraMatriz, Logica_Aplicacion_2.SegundaMatriz, Logica_Aplicacion_2.MatrizSumada);

            Assert.AreEqual(Logica_Aplicacion_2.MatrizSumada[0, 0], 0);
        }
    }
}
