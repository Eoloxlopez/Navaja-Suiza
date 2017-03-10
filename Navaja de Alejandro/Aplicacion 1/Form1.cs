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
namespace Ejercicio_04
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

        ArrayList list = new ArrayList();
        ArrayList list2 = new ArrayList();
        void leerarray(ArrayList lista)
        {
            DialogResult continuar = DialogResult.Yes;

            while (continuar == DialogResult.Yes)
            {
                lista.Add(int.Parse(InputBox("Introduzca el número ")));
                continuar = MessageBox.Show("¿Quiere introducir otro numero?", "¿Continuar?", MessageBoxButtons.YesNo);
            }


        }

        string mostrar(ArrayList lista)
        {
            int i;
            string texto;
            texto = "Los elementos de la lista son: ";
            for (i = 0; i < lista.Count; i++)
            {
                texto = texto + lista[i] + ", ";
            }
            return texto;
        }

        bool primos (int primo)
        {
            bool comp = true;
            int num = 2;
            while (num <= primo / 2 && comp)
            {
                if (primo % num == 0)
                {
                    comp = false;
                }
                else
                {
                    num++;
                }
            }
            return comp;
        }
        void SEPARARprim(ArrayList Nprimos, ArrayList Lprimos)
        {
            int i = 0;
            bool primo;
            while (i < Nprimos.Count)
            {
                primo = primos((int)Nprimos[i]);
                if (!primo)
                {
                    i++;
                }
                else
                {
                    Lprimos.Add(Nprimos[i]);
                    Nprimos.RemoveAt(i);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            leerarray(list);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto, texto2;
            SEPARARprim(list, list2);
            texto = mostrar(list);
            texto2 = mostrar(list2);


            MessageBox.Show(texto);
            MessageBox.Show(texto2);
        }
    }
}
