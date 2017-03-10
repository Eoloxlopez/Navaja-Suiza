using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion2
{
    /// <summary>
    /// Clase formulario
    /// </summary>
    public partial class Form1 : Form
    {

        const int Kfilas = 3;
        const int Kcols = 4;
        int[,] PrimeraMatriz = new int[Kfilas, Kcols];
        int[,] SegundaMatriz = new int[Kfilas, Kcols];
        int[,] MatrizSumada = new int[Kfilas, Kcols];
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <remarks>Contiene un MessageBox que explica la funcionalidad del programa</remarks>
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Aplicacion para introducir dos matrices iguales que se van tienen que sumar elemento a elemento en una tercera matriz y posteriormente mostrarla matriz sumada");
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
        /// Metodo para leer una matriz
        /// </summary>
        /// <param name="MatrizParam">Matriz que se quiere leer</param>
        void LeerMatriz(int[,] MatrizParam)
        {
            int Resultado;
            bool EsNumero;
            EsNumero = false;


            for (int i = 0; i < MatrizParam.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizParam.GetLength(1); j++)
                {                    
                    do
                    {
                        EsNumero = int.TryParse(InputBox("Elemento[" + i + ", " + j + "]"), out Resultado);
                        if (EsNumero)
                        {
                            MatrizParam[i, j] = Resultado;
                        }
                        else
                        {
                            MessageBox.Show("El caracter introducido no es un numero valido");
                        } 
                    } while (!EsNumero);
                }
            }
        }
        /// <summary>
        /// Metodo para sumar dos matrices elemento a elemnto en una tercera matriz
        /// </summary>
        /// <param name="MatrizParam1">La primera de las dos matrices a sumar</param>
        /// <param name="MatrizParam2">La segunda de las dos matrices a sumar</param>
        /// <param name="MatrizParam3">La matriz sumada</param>
        void SumaMatriz(int[,] MatrizParam1, int[,] MatrizParam2, int[,] MatrizParam3)
        {
            for (int col = 0; col < MatrizParam1.GetLength(1); col++)
            {
                for (int fil = 0; fil < MatrizParam1.GetLength(0); fil++)
                {
                    MatrizParam3[fil, col] = MatrizParam1[fil, col] + MatrizParam2[fil, col];
                }
               
            }                        
        }
        /// <summary>
        /// Metodo para mostrar una matriz
        /// </summary>
        /// <param name="MatrizParam">Matriz que se quiere mostrar</param>
        /// <returns>Un string con los elementos de la matriz</returns>
        string MostrarMatriz(int[,] MatrizParam)
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
        /// <summary>
        /// Boton que llama al metodo LeerArray dos veces
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>Se leen dos matrices llamando dos veces seguidas a LeerMatriz</remarks>
        private void button1_Click(object sender, EventArgs e)
        {
            LeerMatriz(PrimeraMatriz);
            LeerMatriz(SegundaMatriz);
        }
        /// <summary>
        /// Boton para mostrar por MessageBox la matriz sumada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>Llama al metodo SumaMatriz y luego declara un string llamando al metodo MostrarMatriz</remarks>
        private void button2_Click(object sender, EventArgs e)
        {
            string MostrarTexto;
            SumaMatriz(PrimeraMatriz, SegundaMatriz, MatrizSumada);            
            MostrarTexto = MostrarMatriz(MatrizSumada);


            MessageBox.Show(MostrarTexto);

        }
    }
}
