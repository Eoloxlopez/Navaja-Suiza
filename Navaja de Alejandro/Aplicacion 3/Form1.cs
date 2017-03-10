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
    public partial class Form1 : Form
    {

        const int Kfilas = 3;
        const int Kcols = 3;
        int[,] MatrizDiagonal = new int[Kfilas, Kcols];

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Aplicacion para introducir una matriz para que se sume su diagonal y posteriormente mostrar la suma de la diagonal");
        }

        private static string InputBox(string texto)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = texto;
            ib.DefaultValue = "";
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }

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

        int SumarDiagonal(int[,] MatrizParam)
        {
            int SumaDiagonal = 0;


            for (int i = 0; i < MatrizParam.GetLength(0); i++)
            {
                SumaDiagonal = SumaDiagonal + MatrizParam[i, i];
            }


            return SumaDiagonal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LeerMatriz(MatrizDiagonal);
        }

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
