namespace Navaja_de_Alejandro.Aplicacion_1
{
    partial class FormAplicacion1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LeerLista = new System.Windows.Forms.Button();
            this.MostrarListas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeerLista
            // 
            this.LeerLista.Location = new System.Drawing.Point(74, 53);
            this.LeerLista.Name = "LeerLista";
            this.LeerLista.Size = new System.Drawing.Size(205, 60);
            this.LeerLista.TabIndex = 0;
            this.LeerLista.Text = "Leer Lista";
            this.LeerLista.UseVisualStyleBackColor = true;
            this.LeerLista.Click += new System.EventHandler(this.LeerLista_Click);
            // 
            // MostrarListas
            // 
            this.MostrarListas.Location = new System.Drawing.Point(74, 152);
            this.MostrarListas.Name = "MostrarListas";
            this.MostrarListas.Size = new System.Drawing.Size(205, 60);
            this.MostrarListas.TabIndex = 1;
            this.MostrarListas.Text = "Mostrar Lista de Primos y No primos";
            this.MostrarListas.UseVisualStyleBackColor = true;
            this.MostrarListas.Click += new System.EventHandler(this.MostrarListas_Click);
            // 
            // FormAplicacion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 283);
            this.Controls.Add(this.MostrarListas);
            this.Controls.Add(this.LeerLista);
            this.Name = "FormAplicacion1";
            this.Text = "FormAplicacion1";
            this.ResumeLayout(false);

        }

        #endregion
        /// <summary>
        /// Boton Leer Lista
        /// </summary>
        private System.Windows.Forms.Button LeerLista;
        /// <summary>
        /// Boton Mostrar Lista
        /// </summary>
        private System.Windows.Forms.Button MostrarListas;
    }
}