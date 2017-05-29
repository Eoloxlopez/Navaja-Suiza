using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navaja_de_Alejandro.Aplicacion_2;
namespace Navaja_de_Alejandro.Aplicacion_2
{
    /// <summary>
    ///  Clase Formulario Form 2
    /// </summary>
    public partial class FormAplicacion2 : Form
    {
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <remarks>Contiene un MessageBox que explica la funcionalidad del programa</remarks>
        public FormAplicacion2()
        {
            InitializeComponent();
            MessageBox.Show("Aplicacion para introducir dos matrices iguales que se suman elemento a elemento en una tercera matriz y posteriormente mostrarla matriz sumada");
        }

        /// <summary>
        /// Boton para añadir numeros a la primera matriz
        /// </summary>
        /// <param name="sender">Parametro del Boton Añadir a la primera matriz</param>
        /// <param name="e">Parametro del Boton Añadir a la primera matriz</param>
        /// <remarks>Comprueba con Double.TryParse si es un caracter valido. En caso de ser valido llama a AñadirNumero sino muestra un mensaje de error</remarks>  
        private void BotonAñadirMatriz1_Click(object sender, EventArgs e)
        {
            if (Logica_Aplicacion_2.FilasLLenas == 3)
            {
                BotonAñadirMatriz1.Enabled = false;
            }
            else
            {
                bool Matriz = true;
                double NumTextBox;
                bool ValorAceptado = Double.TryParse(TextBoxAñadirMatriz1.Text, out NumTextBox);

                if (ValorAceptado)
                {
                    Logica_Aplicacion_2.AñadirNumero(Logica_Aplicacion_2.PrimeraMatriz, NumTextBox, Matriz);
                }
                else
                {
                    MessageBox.Show("El caracter introducido no es valido");
                }
            }

            TextBoxAñadirMatriz1.Clear();

        }
        /// <summary>
        /// Boton para añadir numeros a la segunda matriz
        /// </summary>
        /// <param name="sender">Parametro del Boton Añadir a la segunda matriz</param>
        /// <param name="e">Parametro del Boton Añadir a la segunda matriz</param>
        /// <remarks>Comprueba con Double.TryParse si es un caracter valido. En caso de ser valido llama a AñadirNumero sino muestra un mensaje de error</remarks>        
        private void BotonAñadirMatriz2_Click(object sender, EventArgs e)
        {
            if (Logica_Aplicacion_2.FilasLLenas2 == 3)
            {
                BotonAñadirMatriz2.Enabled = false;
            }
            else
            {
                bool Matriz = false;
                double NumTextBox;
                bool ValorAceptado = Double.TryParse(TextBoxAñadirMatriz2.Text, out NumTextBox);

                if (ValorAceptado)
                {
                    Logica_Aplicacion_2.AñadirNumero(Logica_Aplicacion_2.SegundaMatriz, NumTextBox, Matriz);
                }
                else
                {
                    MessageBox.Show("El caracter introducido no es valido");
                }
            }

            TextBoxAñadirMatriz2.Clear();
        }
        /// <summary>
        /// Boton para mostrar por MessageBox la matriz sumada
        /// </summary>
        /// <param name="sender">Parametro del Boton Sumar matrices</param>
        /// <param name="e">Parametro del Boton Sumar matrices</param>
        /// <remarks>Llama al metodo SumaMatriz y luego declara un string llamando al metodo MostrarMatriz</remarks>
        private void BotonSumMatriz_Click(object sender, EventArgs e)
        {
            string MostrarTexto;
            Logica_Aplicacion_2.SumaMatriz(Logica_Aplicacion_2.PrimeraMatriz, Logica_Aplicacion_2.SegundaMatriz, Logica_Aplicacion_2.MatrizSumada);
            MostrarTexto = Logica_Aplicacion_2.MostrarMatriz(Logica_Aplicacion_2.MatrizSumada);

            MessageBox.Show(MostrarTexto);            
        }

        private void TextBoxAñadirMatriz1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxAñadirMatriz2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
