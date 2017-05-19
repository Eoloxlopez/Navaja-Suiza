using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navaja_de_Alejandro.Aplicacion_4
{
    /// <summary>
    /// Clase formulario
    /// </summary>
    public partial class FormAplicacion4 : Form
    {
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <remarks>Contiene un MessageBox que explica la funcionalidad del programa</remarks>
        public FormAplicacion4()
        {
            InitializeComponent();
            MessageBox.Show("Aplicacion para introducir un vector y posteriormente introducir un numero para comprobar si esta en el vector");
        }

        Logica_Aplicacion_4 Logica = new Logica_Aplicacion_4();

        /// <summary>
        /// Boton para Leer el vector
        /// </summary>
        /// <param name="sender">Parametro del Boton Leer el vector</param>
        /// <param name="e">Parametro del Boton Leer el vector</param>
        /// <remarks>Se declara un int con el numero introducido por TextBox y luego un booleano llamando al metodo EstaVector y discriminando si es true o false con un if muestra un MessageBox con el resultado</remarks>
        private void BotonLeerVector_Click(object sender, EventArgs e)
        {

            int Resultado, TamVector;
            bool EsNumero;
            EsNumero = false;
            TamVector = 0;
            EsNumero = int.TryParse(TextBoxLeerVector.Text, out Resultado);

            if (TamVector == Logica.Constante)
            {
                BotonLeerVector.Enabled = false;
            }
            if (EsNumero)
            {
                Logica.Vector1[TamVector] = Resultado;
                TamVector++;
                
            }
            else
            {
                MessageBox.Show("El caracter introducido no es un numero valido");
            }
            TextBoxLeerVector.Clear();
        }
        /// <summary>
        /// Boton introducir numero
        /// </summary>
        /// <param name="sender">Parametro del Boton Introducir numero</param>
        /// <param name="e">Parametro del Boton Introducir numero</param>
        /// <remarks>Comprueba con int.TryParse si es un caracter valido. En caso de ser valido llama a AñadirNumero sino muestra un mensaje de error</remarks>
        private void BotonIntrodNum_Click(object sender, EventArgs e)
        {
            int Resultado;
            bool NumeroEsta, EsNumero;
            EsNumero = false;

            EsNumero = int.TryParse(TextBoxLeerVector.Text, out Resultado);
            if (EsNumero)
            {
                NumeroEsta = Logica.EstaVector(Logica.Vector1, Resultado);


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

            TextBoxIntroducirNum.Clear();
        }
    }
}
