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
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bapp1_Click(object sender, EventArgs e)
        {
            Aplicacion1.Form1 NuevoFormulario = new Aplicacion1.Form1();
            NuevoFormulario.ShowDialog();
        }

        private void Bapp2_Click(object sender, EventArgs e)
        {
            Aplicacion2.Form1 NuevoFormulario = new Aplicacion2.Form1();
            NuevoFormulario.ShowDialog();
        }

        private void Bapp3_Click(object sender, EventArgs e)
        {
            Aplicacion3.Form1 NuevoFormulario = new Aplicacion3.Form1();
            NuevoFormulario.ShowDialog();
        }

        private void Bapp4_Click(object sender, EventArgs e)
        {
            Aplicacion4.Form1 NuevoFormulario = new Aplicacion4.Form1();
            NuevoFormulario.ShowDialog();
        }
    }
}
