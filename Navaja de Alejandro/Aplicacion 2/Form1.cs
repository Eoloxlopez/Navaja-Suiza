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
    public partial class Form1 : Form
    {

        const int Kfilas = 3;
        const int Kcols = 4;
        int[,] PrimeraMatriz = new int[Kfilas, Kcols];
        int[,] SegundaMatriz = new int[Kfilas, Kcols];
        int[,] MatrizSumada = new int[Kfilas, Kcols];

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Aplicacion para introducir dos matrices iguales que se van tienen que sumar elemento a elemento en una tercera matriz y posteriormente mostrarla matriz sumada");
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

        string MostrarMatriz(int[,] MatrizParam)
        {
            string MostrarTexto = "Los valores de la matriz son:\n";


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

        private void button1_Click(object sender, EventArgs e)
        {
            LeerMatriz(PrimeraMatriz);
            LeerMatriz(SegundaMatriz);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SumaMatriz(PrimeraMatriz, SegundaMatriz, MatrizSumada);
            string MostrarTexto = MostrarMatriz(MatrizSumada);


            MessageBox.Show(MostrarTexto);

        }
    }
}
