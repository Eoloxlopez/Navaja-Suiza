using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        const int Kfilas = 3;
        const int Kcols = 4;
        int[,] matriz2 = new int[Kfilas, Kcols];
        int[,] matriz = new int[Kfilas, Kcols];
        int[,] matrizS = new int[Kfilas, Kcols];

        void leermatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = int.Parse(InputBox("Elemento[" + i + ", " + j + "]"));
                }
            }
        }
        void suma(int[,] matrix, int[,] matrix2, int[,] matrix3)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int fil = 0; fil < matrix.GetLength(0); fil++)
                {
                    matrix3[fil, col] = matrix[fil, col] + matrix2[fil, col];
                }
               
            }
            
        }
        string mostrarmatriz(int[,] matriz1)
        {
            string texto = "Los valores de la matriz son:\n";
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    texto = texto + matriz1[i, j] + ",";
                }
                texto = texto + "\n";
            }
            return texto;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            leermatriz(matriz);
            leermatriz(matriz2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            suma(matriz, matriz2, matrizS);

            string texto = mostrarmatriz(matrizS);

            MessageBox.Show(texto);

        }
    }
}
