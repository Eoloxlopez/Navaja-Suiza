using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Navaja_de_Alejandro.Aplicacion_1
{
    /// <summary>
    /// Clase Logica de la aplicacion 1
    /// </summary>
    class Logica_Aplicacion_1
    {
        /// <summary>
        /// ArrayList que contine los numeros primos despues de separalos de ListaNoPrimos
        /// </summary>
        public ArrayList ListaPrimos = new ArrayList();
        /// <summary>
        /// ArrayList que al principio contine todos los numeros y despues separamos a ListaPrimos los que son primos
        /// </summary>
        public ArrayList ListaNoPrimos = new ArrayList();
        /// <summary>
        /// Metodo para mostrar un ArrayList
        /// </summary>
        /// <param name="ListaParam">Lista que se quiere mostrar</param>
        /// <remarks>Un string vacio al que se le van sumando los elementos de la lista</remarks>
        /// <returns>Un string con todos los elementos de la lista</returns>
        public string MostrarArray(ArrayList ListaParam)
        {
            int i;
            string TextoMostrar;
            TextoMostrar = "";


            for (i = 0; i < ListaParam.Count; i++)
            {
                TextoMostrar = TextoMostrar + ListaParam[i] + ", ";
            }


            return TextoMostrar;
        }
        /// <summary>
        /// Metodo para saber si un numero es primo
        /// </summary>
        /// <param name="NumeroPrimo">El numero que se quiere comprobar si es primo</param>
        /// <returns>Un booleano true si es primo o false si no lo es</returns>
        public bool ComprobarPrimos(int NumeroPrimo)
        {
            bool EsPrimo = true;
            int i = 2;


            while (i <= NumeroPrimo / 2 && EsPrimo)
            {
                if (NumeroPrimo % i == 0)
                {
                    EsPrimo = false;
                }
                else
                {
                    i++;
                }
            }


            return EsPrimo;
        }
        /// <summary>
        /// Metodo que separa los primos y no primos en dos listas
        /// </summary>
        /// <param name="NoPrimos">Lista original de la que se eliminan los primos</param>
        /// <param name="PrimosLista">Lista a la que se añaden los primos</param>
        /// <remarks>Se añade a una lista todos los numeros primos y los elimina de la lista original, dejando una lista de primos y una de no primos</remarks>
        public void SepararPrimos(ArrayList NoPrimos, ArrayList PrimosLista)
        {
            int i = 0;
            bool ComprobarPrimo;


            while (i < NoPrimos.Count)
            {
                ComprobarPrimo = ComprobarPrimos((int)NoPrimos[i]);
                if (!ComprobarPrimo)
                {
                    i++;
                }
                else
                {
                    PrimosLista.Add(NoPrimos[i]);
                    NoPrimos.RemoveAt(i);
                }
            }
        }
    }
}
