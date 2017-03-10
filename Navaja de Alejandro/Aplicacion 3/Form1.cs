using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_23
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
        const int Kcols = 3;
        int[,] matriz1 = new int[Kfilas, Kcols];
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
        int sumaDIAGO(int[,] matriz)
        {
            int suma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                suma = suma + matriz[i, i];
            }
            return suma;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            leermatriz(matriz1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto;
            int suma = sumaDIAGO(matriz1);
            texto = "La suma de la diagonal es = " + suma;

            MessageBox.Show(texto);
        }
    }
}
