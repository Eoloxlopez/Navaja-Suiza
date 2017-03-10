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
    /// <summary>
    /// Clase formulario
    /// </summary>
    public partial class Form1 : Form
    {

        const int Ktam = 5;
        int[] Vector1 = new int[Ktam];
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <remarks>Contiene un MessageBox que explica la funcionalidad del programa</remarks>
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Aplicacion para introducir un vector y posteriormente introducir un numero para comprobar si esta en el vector");
        }
        /// <summary>
        /// Metodo del InputBox
        /// </summary>
        /// <param name="TextoIntroducido">Texto que se introduce en el InputBox</param>
        /// <returns></returns
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
        /// Metodo para leer un vector
        /// </summary>
        /// <param name="VectorParam">Vector que se quiere leer</param>
        void LeerVector(int[] VectorParam)
        {
            for (int i = 0; i < VectorParam.Length; i++)
            {
                VectorParam[i] = int.Parse(InputBox("Introduzca una numero en el espacio " + i));
            }
        }

        /// <summary>
        /// Metodo para saber si un numero esta en el vector
        /// </summary>
        /// <param name="VectorParam">Vector en el que buscar</param>
        /// <param name="EstaElNum">Numero que se quiere buscar en el vector</param>
        /// <returns>Un booleano true si esta el numero y false si no esta</returns>
        bool EstaVector(int[] VectorParam, int EstaElNum)
        {
            bool ComprobarNum;
            ComprobarNum = false;


            for (int i = 0; i < VectorParam.Length && !ComprobarNum; i++)
            {
                if (EstaElNum == VectorParam[i])
                {
                    ComprobarNum = true;
                }
            }


            return ComprobarNum;
        }

        /// <summary>
        /// Boton para leer un vector
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>Llama al metodo LeerVector</remarks>
        private void button1_Click(object sender, EventArgs e)
        {
            LeerVector(Vector1);
        }
        /// <summary>
        /// Boton para mostrar en un MessageBox si el numero estaba en el vector
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>Se declara un int con el numero introducido por TextBox y luego un booleano llamando al metodo EstaVector y discriminando si es true o false con un if muestra un MessageBox con el resultado</remarks>
        private void button2_Click(object sender, EventArgs e)
        {
            int Resultado;
            bool NumeroEsta, EsNumero;
            EsNumero = false;
            EsNumero = int.TryParse(textBox1.Text, out Resultado);
                                    
            if (EsNumero)
            {
                NumeroEsta = EstaVector(Vector1, Resultado);


                if (NumeroEsta)
                {
                    MessageBox.Show("El numero introducido estaba en el vector");
                }
                else
                {
                    MessageBox.Show("El numero introducido no estaba en el vector");
                }
            }
            else
            {
                MessageBox.Show("El caracter introducido no es un numero valido");
            }
            
        }
    }
}
