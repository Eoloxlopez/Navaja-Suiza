namespace Navaja_de_Alejandro.Aplicacion_2
{
    partial class FormAplicacion2
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
            this.TextBoxAñadirMatriz2 = new System.Windows.Forms.TextBox();
            this.TextBoxAñadirMatriz1 = new System.Windows.Forms.TextBox();
            this.BotonAñadirMatriz2 = new System.Windows.Forms.Button();
            this.BotonSumMatriz = new System.Windows.Forms.Button();
            this.BotonAñadirMatriz1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxAñadirMatriz2
            // 
            this.TextBoxAñadirMatriz2.Location = new System.Drawing.Point(88, 215);
            this.TextBoxAñadirMatriz2.MaxLength = 6;
            this.TextBoxAñadirMatriz2.Name = "TextBoxAñadirMatriz2";
            this.TextBoxAñadirMatriz2.Size = new System.Drawing.Size(245, 20);
            this.TextBoxAñadirMatriz2.TabIndex = 9;
            this.TextBoxAñadirMatriz2.TextChanged += new System.EventHandler(this.TextBoxAñadirMatriz2_TextChanged);
            // 
            // TextBoxAñadirMatriz1
            // 
            this.TextBoxAñadirMatriz1.Location = new System.Drawing.Point(88, 101);
            this.TextBoxAñadirMatriz1.MaxLength = 6;
            this.TextBoxAñadirMatriz1.Name = "TextBoxAñadirMatriz1";
            this.TextBoxAñadirMatriz1.Size = new System.Drawing.Size(245, 20);
            this.TextBoxAñadirMatriz1.TabIndex = 8;
            this.TextBoxAñadirMatriz1.TextChanged += new System.EventHandler(this.TextBoxAñadirMatriz1_TextChanged);
            // 
            // BotonAñadirMatriz2
            // 
            this.BotonAñadirMatriz2.Location = new System.Drawing.Point(374, 204);
            this.BotonAñadirMatriz2.Name = "BotonAñadirMatriz2";
            this.BotonAñadirMatriz2.Size = new System.Drawing.Size(113, 41);
            this.BotonAñadirMatriz2.TabIndex = 7;
            this.BotonAñadirMatriz2.Text = "Añadir a la Matriz 2";
            this.BotonAñadirMatriz2.UseVisualStyleBackColor = true;
            this.BotonAñadirMatriz2.Click += new System.EventHandler(this.BotonAñadirMatriz2_Click);
            // 
            // BotonSumMatriz
            // 
            this.BotonSumMatriz.Location = new System.Drawing.Point(135, 298);
            this.BotonSumMatriz.Name = "BotonSumMatriz";
            this.BotonSumMatriz.Size = new System.Drawing.Size(186, 62);
            this.BotonSumMatriz.TabIndex = 6;
            this.BotonSumMatriz.Text = "Sumar Matrices";
            this.BotonSumMatriz.UseVisualStyleBackColor = true;
            this.BotonSumMatriz.Click += new System.EventHandler(this.BotonSumMatriz_Click);
            // 
            // BotonAñadirMatriz1
            // 
            this.BotonAñadirMatriz1.Location = new System.Drawing.Point(374, 90);
            this.BotonAñadirMatriz1.Name = "BotonAñadirMatriz1";
            this.BotonAñadirMatriz1.Size = new System.Drawing.Size(113, 41);
            this.BotonAñadirMatriz1.TabIndex = 5;
            this.BotonAñadirMatriz1.Text = "Añadir a la Matriz 1";
            this.BotonAñadirMatriz1.UseVisualStyleBackColor = true;
            this.BotonAñadirMatriz1.Click += new System.EventHandler(this.BotonAñadirMatriz1_Click);
            // 
            // FormAplicacion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 451);
            this.Controls.Add(this.TextBoxAñadirMatriz2);
            this.Controls.Add(this.TextBoxAñadirMatriz1);
            this.Controls.Add(this.BotonAñadirMatriz2);
            this.Controls.Add(this.BotonSumMatriz);
            this.Controls.Add(this.BotonAñadirMatriz1);
            this.Name = "FormAplicacion2";
            this.Text = "FormAplicacion2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// TextBox Añadir Matriz 2
        /// </summary>
        private System.Windows.Forms.TextBox TextBoxAñadirMatriz2;
        /// <summary>
        /// TextBox Añadir Matriz 1
        /// </summary>
        private System.Windows.Forms.TextBox TextBoxAñadirMatriz1;
        /// <summary>
        /// Boton Añadir Matriz 2
        /// </summary>
        private System.Windows.Forms.Button BotonAñadirMatriz2;
        /// <summary>
        ///  Boton Suma Matriz
        /// </summary>
        private System.Windows.Forms.Button BotonSumMatriz;
        /// <summary>
        /// Boton Añadir Matriz 1
        /// </summary>
        private System.Windows.Forms.Button BotonAñadirMatriz1;
    }
}