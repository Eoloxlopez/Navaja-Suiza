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
    public partial class Form1 : Form
    {

        ArrayList ListaPrimos = new ArrayList();
        ArrayList ListaNoPrimos = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Aplicacion para introducir una lista que te va preguntando si quieres introducir mas numeros y posteriormente mostrar los numeros primos y los que no son primos");
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


        void LeerArray(ArrayList ListaParam)
        {
            DialogResult QuiereContinuar = DialogResult.Yes;

            while (QuiereContinuar == DialogResult.Yes)
            {
                ListaParam.Add(int.Parse(InputBox("Introduzca el número ")));
                QuiereContinuar = MessageBox.Show("¿Quiere introducir otro numero?", "¿Continuar?", MessageBoxButtons.YesNo);
            }


        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            LeerArray(ListaPrimos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string TextoPrimos, TextoNoPrimos;
            SepararPrimos(ListaPrimos, ListaNoPrimos);
            TextoPrimos = "Los numeros que son primos son: \n" + MostrarArray(ListaPrimos);
            TextoNoPrimos = "Los numeros que no son primos son: \n" + MostrarArray(ListaNoPrimos);


            MessageBox.Show(TextoPrimos);
            MessageBox.Show(TextoNoPrimos);
        }
    }
}
