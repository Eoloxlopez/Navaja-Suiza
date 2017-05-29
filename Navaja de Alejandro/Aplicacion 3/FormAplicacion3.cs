using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navaja_de_Alejandro.Aplicacion_3
{
    /// <summary>
    ///  Clase Formulario Form 3
    /// </summary>
    public partial class FormAplicacion3 : Form
    {

        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <remarks>Contiene un MessageBox que explica la funcionalidad del programa</remarks>
        public FormAplicacion3()
        {
            InitializeComponent();
            MessageBox.Show("Aplicacion para introducir una matriz para que se sume su diagonal y posteriormente mostrar la suma de la diagonal");
        }
        /// <summary>
        /// Boton para añadir numeros a la matriz
        /// </summary>
        /// <param name="sender">Parametro del Boton Añadir a la matriz</param>
        /// <param name="e">Parametro del Boton Añadir a la matriz</param>
        /// <remarks>Comprueba con Double.TryParse si es un caracter valido. En caso de ser valido llama a AñadirNumero sino muestra un mensaje de error</remarks>  
        private void BotonAñadirMatriz_Click(object sender, EventArgs e)
        {
            if (Logica_Aplicacion_3.FilasLLenas == 3)
            {
                BotonAñadirMatriz.Enabled = false;
            }
            else
            {                
                double NumTextBox;
                bool ValorAceptado = Double.TryParse(TextBoxAñadirMatriz1.Text, out NumTextBox);

                if (ValorAceptado)
                {
                    Logica_Aplicacion_3.AñadirNumero(Logica_Aplicacion_3.MatrizDiagonal, NumTextBox);
                }
                else
                {
                    MessageBox.Show("El caracter introducido no es valido");
                }
            }

            TextBoxAñadirMatriz1.Clear();
        }
        /// <summary>
        /// Boton para mostrar por MessageBox la suma de la diagonal
        /// </summary>
        /// <param name="sender">Parametro del Boton Suma Diagonal</param>
        /// <param name="e">Parametro del Boton Suma Diagonal</param>
        /// <remarks>Le asigna un valor a un double llamando al metodo SumaDiagonal para mostrarlo por MessageBox</remarks>
        private void BotonSumDiago_Click(object sender, EventArgs e)
        {
            string MostrarTexto;
            double ResultadoDiagonal;
            ResultadoDiagonal = Logica_Aplicacion_3.SumarDiagonal(Logica_Aplicacion_3.MatrizDiagonal);
            MostrarTexto = "La suma de la diagonal es = " + ResultadoDiagonal;

            MessageBox.Show(MostrarTexto);
        }
    }
}
