using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navaja_de_Alejandro.Aplicacion_3
{
    /// <summary>
    /// Clase Logica de la aplicacion 3
    /// </summary>
    class Logica_Aplicacion_3
    {
        /// <summary>
        /// Constante que determina el numero de filas de la matriz
        /// </summary>
        const int Kfilas = 3;
        /// <summary>
        /// Constante que determina el numero de columnas de la matriz
        /// </summary>
        const int Kcols = 3;
        /// <summary>
        /// Matriz de la que sumaremos su diagonal
        /// </summary>
        public static double[,] MatrizDiagonal = new double[Kfilas, Kcols];
        public static int FilasLLenas = 0;
        public static int ColumnasLLenas = 0;

        /// <summary>
        /// Metodo para leer una matriz
        /// </summary>
        /// <param name="MatrizParam">Matriz que se quiere leer</param>
        public static void AñadirNumero(double[,] MatrizParam, double NumAñadido)
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
        /// <summary>
        /// Metodo para sumar los elementos de la diagonal de una matriz
        /// </summary>
        /// <param name="MatrizParam">Matriz que se quiere sumar su diagonal</param>
        /// <returns>Un int con la suma de los elementos de la diagonal</returns>
        public static double SumarDiagonal(double[,] MatrizParam)
        {
            double SumaDiagonal = 0;


            for (int i = 0; i < MatrizParam.GetLength(0); i++)
            {
                SumaDiagonal = SumaDiagonal + MatrizParam[i, i];
            }


            return SumaDiagonal;
        }
    }
}
