using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Navaja_de_Alejandro.Aplicacion_3;
namespace Pruebas_Unitarias
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void SumaDiagonal_PruebaValoresEntero()
        {
            
            int TamañoMatriz = 3;
             
            for (int i = 0; i < TamañoMatriz; i++)
            {
                for (int j = 0; j < TamañoMatriz; j++)
                {
                    Logica_Aplicacion_3.MatrizDiagonal[i, j] = 3;
                }
            }

            double Resultado = Logica_Aplicacion_3.SumarDiagonal(Logica_Aplicacion_3.MatrizDiagonal);

            Assert.AreEqual(Resultado, 9);
        }

        [TestMethod]
        public void SumaDiagonal_PruebaValoresDecimales()
        {

            int TamañoMatriz = 3;

            for (int i = 0; i < TamañoMatriz; i++)
            {
                for (int j = 0; j < TamañoMatriz; j++)
                {
                    Logica_Aplicacion_3.MatrizDiagonal[i, j] = 1.5;
                }
            }

            double Resultado = Logica_Aplicacion_3.SumarDiagonal(Logica_Aplicacion_3.MatrizDiagonal);

            Assert.AreEqual(Resultado, 4.5);
        }

        [TestMethod]
        public void SumaDiagonal_PruebaValoresNegativos()
        {

            int TamañoMatriz = 3;

            for (int i = 0; i < TamañoMatriz; i++)
            {
                for (int j = 0; j < TamañoMatriz; j++)
                {
                    Logica_Aplicacion_3.MatrizDiagonal[i, j] = -3;
                }
            }

            double Resultado = Logica_Aplicacion_3.SumarDiagonal(Logica_Aplicacion_3.MatrizDiagonal);

            Assert.AreEqual(Resultado, -9);
        }

        [TestMethod]
        public void SumaDiagonal_PruebaValoresVacios()
        {

            int TamañoMatriz = 3;

            for (int i = 0; i < TamañoMatriz; i++)
            {
                for (int j = 0; j < TamañoMatriz; j++)
                {
                    Logica_Aplicacion_3.MatrizDiagonal[i, j] = 0;
                }
            }

            double Resultado = Logica_Aplicacion_3.SumarDiagonal(Logica_Aplicacion_3.MatrizDiagonal);

            Assert.AreEqual(Resultado, 0);
        }

        [TestMethod]
        public void SumaDiagonal_PruebaValoresMaximos()
        {

            int TamañoMatriz = 3;

            for (int i = 0; i < TamañoMatriz; i++)
            {
                for (int j = 0; j < TamañoMatriz; j++)
                {
                    Logica_Aplicacion_3.MatrizDiagonal[i, j] = double.MaxValue;
                }
            }

            double Resultado = Logica_Aplicacion_3.SumarDiagonal(Logica_Aplicacion_3.MatrizDiagonal);

            Assert.AreEqual(Resultado, double.MaxValue * 3);
        }


        [TestMethod]
        public void SumaDiagonal_PruebaValoresMinimos()
        {

            int TamañoMatriz = 3;

            for (int i = 0; i < TamañoMatriz; i++)
            {
                for (int j = 0; j < TamañoMatriz; j++)
                {
                    Logica_Aplicacion_3.MatrizDiagonal[i, j] = double.MinValue;
                }
            }

            double Resultado = Logica_Aplicacion_3.SumarDiagonal(Logica_Aplicacion_3.MatrizDiagonal);

            Assert.AreEqual(Resultado, double.MinValue * 3);
        }
    }
}
