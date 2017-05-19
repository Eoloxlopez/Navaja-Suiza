namespace Navaja_de_Alejandro.Aplicacion_3
{
    partial class FormAplicacion3
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
            this.TextBoxAñadirMatriz1 = new System.Windows.Forms.TextBox();
            this.BotonSumDiago = new System.Windows.Forms.Button();
            this.BotonAñadirMatriz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxAñadirMatriz1
            // 
            this.TextBoxAñadirMatriz1.Location = new System.Drawing.Point(36, 84);
            this.TextBoxAñadirMatriz1.MaxLength = 6;
            this.TextBoxAñadirMatriz1.Name = "TextBoxAñadirMatriz1";
            this.TextBoxAñadirMatriz1.Size = new System.Drawing.Size(245, 20);
            this.TextBoxAñadirMatriz1.TabIndex = 13;
            // 
            // BotonSumDiago
            // 
            this.BotonSumDiago.Location = new System.Drawing.Point(121, 165);
            this.BotonSumDiago.Name = "BotonSumDiago";
            this.BotonSumDiago.Size = new System.Drawing.Size(186, 62);
            this.BotonSumDiago.TabIndex = 11;
            this.BotonSumDiago.Text = "Sumar Diagonal";
            this.BotonSumDiago.UseVisualStyleBackColor = true;
            this.BotonSumDiago.Click += new System.EventHandler(this.BotonSumDiago_Click);
            // 
            // BotonAñadirMatriz
            // 
            this.BotonAñadirMatriz.Location = new System.Drawing.Point(311, 73);
            this.BotonAñadirMatriz.Name = "BotonAñadirMatriz";
            this.BotonAñadirMatriz.Size = new System.Drawing.Size(113, 41);
            this.BotonAñadirMatriz.TabIndex = 10;
            this.BotonAñadirMatriz.Text = "Añadir a la Matriz";
            this.BotonAñadirMatriz.UseVisualStyleBackColor = true;
            this.BotonAñadirMatriz.Click += new System.EventHandler(this.BotonAñadirMatriz_Click);
            // 
            // FormAplicacion3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 288);
            this.Controls.Add(this.TextBoxAñadirMatriz1);
            this.Controls.Add(this.BotonSumDiago);
            this.Controls.Add(this.BotonAñadirMatriz);
            this.Name = "FormAplicacion3";
            this.Text = "FormAplicacion3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxAñadirMatriz1;
        private System.Windows.Forms.Button BotonSumDiago;
        private System.Windows.Forms.Button BotonAñadirMatriz;
    }
}