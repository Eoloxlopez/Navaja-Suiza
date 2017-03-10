using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Aplicacion1
{
    /// <summary>
    /// Clase formulario
    /// </summary>
    public partial class Form1 : Form
    {

        ArrayList ListaPrimos = new ArrayList();
        ArrayList ListaNoPrimos = new ArrayList();
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <remarks>Contiene un MessageBox que explica la funcionalidad del programa</remarks>
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Aplicacion para introducir una lista que te va preguntando si quieres continuar introduciendo mas numeros y posteriormente muestra los numeros primos y los que no son primos");
        }

        /// <summary>
        /// Metodo del InputBox
        /// </summary>
        /// <param name="TextoIntroducido">Texto que se introduce en el InputBox</param>
        /// <returns></returns>
        private static string InputBox(string TextoIntroducido)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = TextoIntroducido;
            ib.DefaultValue = "";
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }

        /// <summary>
        /// Metodo para leer un ArrayList
        /// </summary>
        /// <param name="ListaParam">Lista que se quiere leer</param>
        /// <remarks>Al introducir el numero se pregunta con un MessageBox si se quiere continuar</remarks>
        void LeerArray(ArrayList ListaParam)
        {
            int Resultado;
            bool EsNumero;
            EsNumero = false;            
            DialogResult QuiereContinuar = DialogResult.Yes;


            while (QuiereContinuar == DialogResult.Yes)
            {
                EsNumero = int.TryParse(InputBox("Introduzca el número "), out Resultado);
                if (EsNumero)
                {
                    ListaParam.Add(Resultado);
                    QuiereContinuar = MessageBox.Show("¿Quiere introducir otro numero?", "¿Continuar?", MessageBoxButtons.YesNo); 
                }
                else
                {
                    MessageBox.Show("El caracter introducido no es un numero valido");
                }
            }


        }
        /// <summary>
        /// Metodo para mostrar un ArrayList
        /// </summary>
        /// <param name="ListaParam">Lista que se quiere mostrar</param>
        /// <remarks>Un string vacio al que se le van sumando los elementos de la lista</remarks>
        /// <returns>Un string con todos los elementos de la lista</returns>
        string MostrarArray(ArrayList ListaParam)
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
        bool ComprobarPrimos (int NumeroPrimo)
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
        void SepararPrimos(ArrayList NoPrimos, ArrayList PrimosLista)
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
        /// <summary>
        /// Boton que llama al metodo LeerArray
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            LeerArray(ListaNoPrimos);
        }
        /// <summary>
        /// Boton para mostrar por MessageBox las listas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>Llama al metodo SepararPrimos y luego declara dos strings llamando al metodo MostrarArray con dos ArrayList</remarks>
        private void button2_Click(object sender, EventArgs e)
        {
            string TextoPrimos, TextoNoPrimos;
            SepararPrimos(ListaNoPrimos, ListaPrimos);
            TextoPrimos = "Los numeros que son primos son: \n" + MostrarArray(ListaPrimos);
            TextoNoPrimos = "Los numeros que no son primos son: \n" + MostrarArray(ListaNoPrimos);


            MessageBox.Show(TextoPrimos);
            MessageBox.Show(TextoNoPrimos);
        }
    }
}
