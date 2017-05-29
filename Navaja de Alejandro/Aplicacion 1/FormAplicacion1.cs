using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navaja_de_Alejandro.Aplicacion_1
{
    /// <summary>
    ///  Clase Formulario Form 1
    /// </summary>
    public partial class FormAplicacion1 : Form
    {
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <remarks>Contiene un MessageBox que explica la funcionalidad del programa</remarks>
        public FormAplicacion1()
        {
            InitializeComponent();
            MessageBox.Show("Aplicacion para introducir una lista que te va preguntando si quieres continuar introduciendo mas numeros y posteriormente muestra los numeros primos y los que no son primos");
        }
        Logica_Aplicacion_1 Logica = new Logica_Aplicacion_1();
        /// <summary>
        /// Metodo del InputBox
        /// </summary>
        /// <param name="TextoIntroducido">Texto que se introduce en el InputBox</param>
        /// <returns>Devuelve un string</returns>
        private static string InputBox(string TextoIntroducido)
        {
            InputBoxDialog InputBox = new InputBoxDialog();
            InputBox.FormPrompt = TextoIntroducido;
            InputBox.DefaultValue = "";
            InputBox.ShowDialog();
            string ReturnInput = InputBox.InputResponse;
            InputBox.Close();
            return ReturnInput;
        }
        /// <summary>
        /// Boton Leer Lista
        /// </summary>
        /// <param name="sender">Parametro del boton Leer Lista</param>
        /// <param name="e">Parametro del boton Leer Lista</param>
        private void LeerLista_Click(object sender, EventArgs e)
        {
            int Resultado;
            bool EsNumero;
            EsNumero = false;
            DialogResult QuiereContinuar = DialogResult.Yes;
            
            
            do
            {
                EsNumero = int.TryParse(InputBox("Introduzca el número "), out Resultado);
                if (EsNumero)
                {
                    Logica.ListaNoPrimos.Add(Resultado);
                    QuiereContinuar = MessageBox.Show("¿Quiere introducir otro numero?", "¿Continuar?", MessageBoxButtons.YesNo);
                }
                else
                {
                    MessageBox.Show("El caracter introducido no es un numero valido");
                }

            } while (QuiereContinuar == DialogResult.Yes);

        }
        /// <summary>
        /// Boton Mostrar Listas de primos y no primos
        /// </summary>
        /// <param name="sender">Parametro del boton Mostrar Listas de primos y no primos</param>
        /// <param name="e">Parametro del boton Mostrar Listas de primos y no primos</param>
        /// <remarks>LLama al metodo Separar primos y muestra en dos MessageBox la lista de primos y no primos</remarks>
        private void MostrarListas_Click(object sender, EventArgs e)
        {
            string TextoPrimos, TextoNoPrimos;
            Logica.SepararPrimos(Logica.ListaNoPrimos, Logica.ListaPrimos);
            TextoPrimos = "Los numeros que son primos son: \n" + Logica.MostrarArray(Logica.ListaPrimos);
            TextoNoPrimos = "Los numeros que no son primos son: \n" + Logica.MostrarArray(Logica.ListaNoPrimos);


            MessageBox.Show(TextoPrimos);
            MessageBox.Show(TextoNoPrimos);
        }
    }
}
