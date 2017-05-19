using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navaja_de_Alejandro.Aplicacion_2
{
    /// <summary>
    /// Clase Logica de la aplicacion 2
    /// </summary>
    static class Logica_Aplicacion_2
    {
        /// <summary>
        /// Constante que determina el numero de filas de la matriz
        /// </summary>
        const int Kfilas = 3;
        /// <summary>
        /// Constante que determina el numero de columnas de la matriz
        /// </summary>
        const int Kcols = 4;
        /// <summary>
        /// Matriz numero 1
        /// </summary>
        public static double[,] PrimeraMatriz = new double[Kfilas, Kcols];
        /// <summary>
        /// Matriz numero 2
        /// </summary>
        public static double[,] SegundaMatriz = new double[Kfilas, Kcols];
        /// <summary>
        /// Matriz donde sumaremos las matrices 1 y 2
        /// </summary>
        public static double[,] MatrizSumada = new double[Kfilas, Kcols];
        public static int FilasLLenas = 0;
        public static int ColumnasLLenas = 0;
        public static int FilasLLenas2 = 0;
        public static int ColumnasLLenas2 = 0;

        /// <summary>
        /// Metodo para añadir numeros a una matriz
        /// </summary>
        /// <param name="MatrizParam">Matriz a la que se añadiran los numeros</param>
        /// <param name="NumAñadido">Numero que se quiere añadir</param>
        /// <param name="QueMatriz">Booleano parar discriminar si se añaden a la primera o a la segunda matriz</param>
        public static void AñadirNumero(double[,] MatrizParam, double NumAñadido, bool QueMatriz)
        {

            if (QueMatriz)
            {
                MatrizParam[FilasLLenas, ColumnasLLenas] = NumAñadido;
                if (ColumnasLLenas < Kcols)
                {
                    ColumnasLLenas++;
                }
                if (ColumnasLLenas == Kcols)
                {
                    if (FilasLLenas < Kfilas)
                    {
                        FilasLLenas++;
                        ColumnasLLenas = 0;
                    }
                }
            }
            else
            {
                MatrizParam[FilasLLenas2, ColumnasLLenas2] = NumAñadido;
                if (ColumnasLLenas2 < Kcols)
                {
                    ColumnasLLenas2++;
                }
                if (ColumnasLLenas2 == Kcols)
                {
                    ColumnasLLenas2 = 0;
                    if (FilasLLenas2 < Kfilas)
                    {
                        FilasLLenas2++;
                    }
                }
            }

        }
        /// <summary>
        /// Metodo para sumar dos matrices elemento a elemnto en una tercera matriz
        /// </summary>
        /// <param name="MatrizParam1">La primera de las dos matrices a sumar</param>
        /// <param name="MatrizParam2">La segunda de las dos matrices a sumar</param>
        /// <param name="MatrizParam3">La matriz sumada</param>
        public static void SumaMatriz(double[,] MatrizParam1, double[,] MatrizParam2, double[,] MatrizParam3)
        {
            for (int col = 0; col < MatrizParam1.GetLength(1); col++)
            {
                for (int fil = 0; fil < MatrizParam1.GetLength(0); fil++)
                {
                    MatrizParam3[fil, col] = MatrizParam1[fil, col] + MatrizParam2[fil, col];
                }
            }
            ColumnasLLenas = 0;
            ColumnasLLenas2 = 0;
            FilasLLenas2 = 0;
            FilasLLenas = 0;
        }
        /// <summary>
        /// Metodo para mostrar una matriz
        /// </summary>
        /// <param name="MatrizParam">Matriz que se quiere mostrar</param>
        /// <returns>Un string con los elementos de la matriz</returns>
        public static string MostrarMatriz(double[,] MatrizParam)
        {
            string MostrarTexto;
            MostrarTexto = "Los valores de la matriz son:\n";


            for (int i = 0; i < MatrizParam.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizParam.GetLength(1); j++)
                {
                    MostrarTexto = MostrarTexto + MatrizParam[i, j] + ",";
                }
                MostrarTexto = MostrarTexto + "\n";
            }


            return MostrarTexto;
        }
    }
}
