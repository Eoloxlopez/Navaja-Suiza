using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion4
{
    public partial class Form1 : Form
    {

        const int Ktam = 5;
        int[] Vector1 = new int[Ktam];

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Aplicacion para introducir un vector y posteriormente introducir un numero para comprobar si esta en el vector");
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

        void LeerVector(int[] VectorParam)
        {
            for (int i = 0; i < VectorParam.Length; i++)
            {
                VectorParam[i] = int.Parse(InputBox("Introduzca una temperatura en el espacio " + i));
            }
        }

        bool EstaVector(int[] VectorParam, int EstaElNum)
        {
            bool ComprobarNum = false;


            for (int i = 0; i < VectorParam.Length && !ComprobarNum; i++)
            {
                if (EstaElNum == VectorParam[i])
                {
                    ComprobarNum = true;
                }
            }


            return ComprobarNum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LeerVector(Vector1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int NumIntroducido;            
            bool NumeroEsta;
            NumIntroducido = int.Parse(textBox1.Text);
            NumeroEsta = EstaVector(Vector1, NumIntroducido);

            if (NumeroEsta)
            {
                MessageBox.Show("El numero introduzido estaba en el vector"); 
            }
            else
            {
                MessageBox.Show("El numero introduzido no estaba en el vector");
            }
        }
    }
}
