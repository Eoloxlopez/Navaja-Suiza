using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Navaja_de_Alejandro
{
    
    /// <summary>
    /// Clase formulario
    /// </summary>
    public partial class FormPrincipal : Form
    {
        /// <summary>
        /// Constructor del formulario principal
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boton que llama a la aplicacion 1
        /// </summary>
        /// <param name="sender">Parametro del boton que abre la aplicacion 1</param>
        /// <param name="e">Parametro del boton que abre la aplicacion 1</param>
        private void Bapp1_Click(object sender, EventArgs e)
        {
            Navaja_de_Alejandro.Aplicacion_1.FormAplicacion1 NuevoFormulario = new Navaja_de_Alejandro.Aplicacion_1.FormAplicacion1();
            NuevoFormulario.ShowDialog();
        }
        /// <summary>
        ///  Boton que llama a la aplicacion 2
        /// </summary>
        /// <param name="sender">Parametro del boton que abre la aplicacion 2</param>
        /// <param name="e">Parametro del boton que abre la aplicacion 2</param>
        private void Bapp2_Click(object sender, EventArgs e)
        {
            Navaja_de_Alejandro.Aplicacion_2.FormAplicacion2 NuevoFormulario = new Navaja_de_Alejandro.Aplicacion_2.FormAplicacion2();
            NuevoFormulario.ShowDialog();
        }
        /// <summary>
        ///  Boton que llama a la aplicacion 3
        /// </summary>
        /// <param name="sender">Parametro del boton que abre la aplicacion 3</param>
        /// <param name="e">Parametro del boton que abre la aplicacion 3</param>
        private void Bapp3_Click(object sender, EventArgs e)
        {
            Navaja_de_Alejandro.Aplicacion_3.FormAplicacion3 NuevoFormulario = new Navaja_de_Alejandro.Aplicacion_3.FormAplicacion3();
            NuevoFormulario.ShowDialog();
        }
        /// <summary>
        ///  Boton que llama a la aplicacion 4
        /// </summary>
        /// <param name="sender">Parametro del boton que abre la aplicacion 4</param>
        /// <param name="e">Parametro del boton que abre la aplicacion 4</param>
        private void Bapp4_Click(object sender, EventArgs e)
        {
            Navaja_de_Alejandro.Aplicacion_4.FormAplicacion4 NuevoFormulario = new Navaja_de_Alejandro.Aplicacion_4.FormAplicacion4();
            NuevoFormulario.ShowDialog();
        }
    }
}
