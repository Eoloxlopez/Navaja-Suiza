using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion3
{
    /// <summary>
    /// Clase formulario
    /// </summary>
    public partial class Form1 : Form
    {

        const int Kfilas = 3;
        const int Kcols = 3;
        int[,] MatrizDiagonal = new int[Kfilas, Kcols];
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <remarks>Contiene un MessageBox que explica la funcionalidad del programa</remarks>
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Aplicacion para introducir una matriz para que se sume su diagonal y posteriormente mostrar la suma de la diagonal");
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
            for (int i = 0; i < MatrizParam.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizParam.GetLength(1); j++)
                {
                    MatrizParam[i, j] = int.Parse(InputBox("Elemento[" + i + ", " + j + "]"));
                }
            }
        }
        /// <summary>
        /// Metodo para sumar los elementos de la diagonal de una matriz
        /// </summary>
        /// <param name="MatrizParam">Matriz que se quiere sumar su diagonal</param>
        /// <returns>Un int con la suma de los elementos de la diagonal</returns>
        int SumarDiagonal(int[,] MatrizParam)
        {
            int SumaDiagonal = 0;


            for (int i = 0; i < MatrizParam.GetLength(0); i++)
            {
                SumaDiagonal = SumaDiagonal + MatrizParam[i, i];
            }


            return SumaDiagonal;
        }
        /// <summary>
        /// Boton para leer la matriz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>Llama al metodo LeerMatriz</remarks>
        private void button1_Click(object sender, EventArgs e)
        {
            LeerMatriz(MatrizDiagonal);
        }
        /// <summary>
        /// Boton para mostrar por MessageBox la suma de la diagonal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>Declara un int llamando al metodo SumaDiagonal y luego un string con el el int para mostrarlo por MessageBox</remarks>
        private void button2_Click(object sender, EventArgs e)
        {
            string TextoMostrar;
            int ResultadoDiagonal;
            ResultadoDiagonal = SumarDiagonal(MatrizDiagonal);
            TextoMostrar = "La suma de la diagonal es = " + ResultadoDiagonal;

            MessageBox.Show(TextoMostrar);
        }
    }
}
