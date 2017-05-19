namespace Navaja_de_Alejandro
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotonApp1 = new System.Windows.Forms.Button();
            this.BotonApp2 = new System.Windows.Forms.Button();
            this.BotonApp4 = new System.Windows.Forms.Button();
            this.BotonApp3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonApp1
            // 
            this.BotonApp1.Location = new System.Drawing.Point(104, 74);
            this.BotonApp1.Name = "BotonApp1";
            this.BotonApp1.Size = new System.Drawing.Size(220, 79);
            this.BotonApp1.TabIndex = 0;
            this.BotonApp1.Text = "Aplicacion 1";
            this.BotonApp1.UseVisualStyleBackColor = true;
            this.BotonApp1.Click += new System.EventHandler(this.Bapp1_Click);
            // 
            // BotonApp2
            // 
            this.BotonApp2.Location = new System.Drawing.Point(509, 74);
            this.BotonApp2.Name = "BotonApp2";
            this.BotonApp2.Size = new System.Drawing.Size(217, 79);
            this.BotonApp2.TabIndex = 1;
            this.BotonApp2.Text = "Aplicacion 2";
            this.BotonApp2.UseVisualStyleBackColor = true;
            this.BotonApp2.Click += new System.EventHandler(this.Bapp2_Click);
            // 
            // BotonApp4
            // 
            this.BotonApp4.Location = new System.Drawing.Point(509, 257);
            this.BotonApp4.Name = "BotonApp4";
            this.BotonApp4.Size = new System.Drawing.Size(217, 85);
            this.BotonApp4.TabIndex = 2;
            this.BotonApp4.Text = "Aplicacion 4";
            this.BotonApp4.UseVisualStyleBackColor = true;
            this.BotonApp4.Click += new System.EventHandler(this.Bapp4_Click);
            // 
            // BotonApp3
            // 
            this.BotonApp3.Location = new System.Drawing.Point(104, 257);
            this.BotonApp3.Name = "BotonApp3";
            this.BotonApp3.Size = new System.Drawing.Size(220, 85);
            this.BotonApp3.TabIndex = 2;
            this.BotonApp3.Text = "Aplicacion 3";
            this.BotonApp3.UseVisualStyleBackColor = true;
            this.BotonApp3.Click += new System.EventHandler(this.Bapp3_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 416);
            this.Controls.Add(this.BotonApp3);
            this.Controls.Add(this.BotonApp4);
            this.Controls.Add(this.BotonApp2);
            this.Controls.Add(this.BotonApp1);
            this.Name = "FormPrincipal";
            this.Text = "Aplicacion 2";
            this.ResumeLayout(false);

        }

        #endregion
        /// <summary>
        /// Boton de la Aplicacion 1
        /// </summary>
        private System.Windows.Forms.Button BotonApp1;

        /// <summary>
        /// Boton de la Aplicacion 2
        /// </summary>
        private System.Windows.Forms.Button BotonApp2;

        /// <summary>
        /// Boton de la Aplicacion 4
        /// </summary>
        private System.Windows.Forms.Button BotonApp4;

        /// <summary>
        /// Boton de la Aplicacion 3
        /// </summary>
        private System.Windows.Forms.Button BotonApp3;
    }
}

