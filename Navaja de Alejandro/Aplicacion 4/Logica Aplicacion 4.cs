using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navaja_de_Alejandro.Aplicacion_4
{
    /// <summary>
    /// Clase Logica de la aplicacion 4
    /// </summary>
    public class Logica_Aplicacion_4
    {
        /// <summary>
        /// Constante que le da tamaño al vector
        /// </summary>
        const int Ktam = 5;
        /// <summary>
        /// Vector de numeros
        /// </summary>
        public int[] Vector1 = new int[Ktam];

        /// <summary>
        /// Metodo para saber si un numero esta en el vector
        /// </summary>
        /// <param name="VectorParam">Vector en el que buscar</param>
        /// <param name="EstaElNum">Numero que se quiere buscar en el vector</param>
        /// <returns>Un booleano true si esta el numero y false si no esta</returns>
        public bool EstaVector(int[] VectorParam, int EstaElNum)
        {
            bool ComprobarNum;
            ComprobarNum = false;


            for (int i = 0; i < VectorParam.Length && !ComprobarNum; i++)
            {
                if (EstaElNum == VectorParam[i])
                {
                    ComprobarNum = true;
                }
            }


            return ComprobarNum;
        }
        /// <summary>
        /// Propiedad para saber el valor de la constante de tamaño del vector
        /// </summary>
        /// <reurns>tamaño del vector</reurns>
        public int Constante
        {
            get
            {
                return Ktam;
            }
            
        }
    }
}
