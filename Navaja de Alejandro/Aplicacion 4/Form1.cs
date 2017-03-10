using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_25
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
        int[] vectorfil = new int[Kfilas];
        int[] vectorcol = new int[Kcols];
        int[,] matriz = new int[Kfilas, Kcols];

        void leermatriz(int[,] matriz1)
        {
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    matriz[i, j] = int.Parse(InputBox("Elemento[" + i + ", " + j + "]"));
                }
            }
        }
        string Qmes(int n1)
        {
            string texto = "";


            switch (n1)
            {
                case 1:
                    texto = "Enero";
                    break;

                case 2:
                    texto = "Febrero";
                    break;
                case 3:
                    texto = "Marzo";
                    break;
                case 4:
                    texto = "Abril";
                    break;
                case 5:
                    texto = "Mayo";
                    break;
                case 6:
                    texto = "Junio";
                    break;
                case 7:
                    texto = "Julio";
                    break;
                case 8:
                    texto = "Agosto";
                    break;
                case 9:
                    texto = "Septiembre";
                    break;
                case 10:
                    texto = "Octubre";
                    break;
                case 11:
                    texto = "Noviembre";
                    break;
                case 12:
                    texto = "Diciembre";
                    break;
            }

            return texto;
        }
        string mesMventas(int[,] matriz1)
        {

            int col, fil, i, mayor;
            string texto, mes;
            texto = "";
            mes = "";
            col = 0;
            i = 0;


            for (fil = 0; fil < matriz1.GetLength(1); fil++)
            {
                mayor = 0;
                for (col = 0; col < matriz1.GetLength(0); col++)
                {
                    if (matriz1[col, fil] > mayor)
                    {
                        mayor = matriz1[col, fil];
                        i = fil;
                    }
                }

                mes = Qmes(i);
                texto = texto + "El mayor mes de ventas de la " + (fil + 1) + "º empresa es " + mes + " donde a ganado" + mayor + "\n";
            }

            return texto;
        }

        string ventasTmes(int[,] matriz1)
        {
            string texto, mes;
            int suma, col;
            mes = "";
            texto = "";
            suma = 0;


            for (int fil = 0; fil < matriz1.GetLength(1); fil++)
            {


                for (col = 0; col < matriz1.GetLength(0); col++)
                {
                    suma = suma + matriz1[col, fil];
                }
                mes = Qmes(col);
                texto = texto + "Las ventas totales de " + mes + "son " + suma + "\n";
                suma = 0;
            }
            return texto;
        }

        string ventasTempresa(int[,] matriz1)
        {
            string texto, mes;
            texto = "";
            int suma, fil, col;
            suma = 0;
            fil = 0;
            col = 0;


            for (col = 0; col < matriz1.GetLength(0); col++)
            {
                for (fil = 0; fil < matriz1.GetLength(1); fil++)
                {
                    suma = suma + matriz1[col, fil];
                }
                mes = Qmes(col);
                texto = texto + "Las ventas totales de la " + (fil + 1) + "º empresa es " + suma + "\n";
                suma = 0;
            }
            return texto;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            leermatriz(matriz);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto = ventasTempresa(matriz);
            MessageBox.Show(texto);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string texto = ventasTmes(matriz);
            MessageBox.Show(texto);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string texto = mesMventas(matriz);
            MessageBox.Show(texto);
        }
    }
}
