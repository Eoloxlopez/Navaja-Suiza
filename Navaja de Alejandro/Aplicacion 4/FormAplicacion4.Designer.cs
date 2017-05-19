namespace Navaja_de_Alejandro.Aplicacion_4
{
    partial class FormAplicacion4
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
            this.TextBoxIntroducirNum = new System.Windows.Forms.TextBox();
            this.BotonIntrodNum = new System.Windows.Forms.Button();
            this.TextBoxLeerVector = new System.Windows.Forms.TextBox();
            this.BotonLeerVector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxIntroducirNum
            // 
            this.TextBoxIntroducirNum.Location = new System.Drawing.Point(34, 172);
            this.TextBoxIntroducirNum.MaxLength = 6;
            this.TextBoxIntroducirNum.Name = "TextBoxIntroducirNum";
            this.TextBoxIntroducirNum.Size = new System.Drawing.Size(220, 20);
            this.TextBoxIntroducirNum.TabIndex = 7;
            // 
            // BotonIntrodNum
            // 
            this.BotonIntrodNum.Location = new System.Drawing.Point(286, 161);
            this.BotonIntrodNum.Name = "BotonIntrodNum";
            this.BotonIntrodNum.Size = new System.Drawing.Size(181, 41);
            this.BotonIntrodNum.TabIndex = 6;
            this.BotonIntrodNum.Text = "Introducir numero";
            this.BotonIntrodNum.UseVisualStyleBackColor = true;
            this.BotonIntrodNum.Click += new System.EventHandler(this.BotonIntrodNum_Click);
            // 
            // TextBoxLeerVector
            // 
            this.TextBoxLeerVector.Location = new System.Drawing.Point(34, 46);
            this.TextBoxLeerVector.MaxLength = 6;
            this.TextBoxLeerVector.Name = "TextBoxLeerVector";
            this.TextBoxLeerVector.Size = new System.Drawing.Size(220, 20);
            this.TextBoxLeerVector.TabIndex = 5;
            // 
            // BotonLeerVector
            // 
            this.BotonLeerVector.Location = new System.Drawing.Point(286, 35);
            this.BotonLeerVector.Name = "BotonLeerVector";
            this.BotonLeerVector.Size = new System.Drawing.Size(181, 41);
            this.BotonLeerVector.TabIndex = 4;
            this.BotonLeerVector.Text = "Leer Vector";
            this.BotonLeerVector.UseVisualStyleBackColor = true;
            this.BotonLeerVector.Click += new System.EventHandler(this.BotonLeerVector_Click);
            // 
            // FormAplicacion4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 238);
            this.Controls.Add(this.TextBoxIntroducirNum);
            this.Controls.Add(this.BotonIntrodNum);
            this.Controls.Add(this.TextBoxLeerVector);
            this.Controls.Add(this.BotonLeerVector);
            this.Name = "FormAplicacion4";
            this.Text = "FormAplicacion4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// TextBox Introducir Numero
        /// </summary>
        private System.Windows.Forms.TextBox TextBoxIntroducirNum;
        /// <summary>
        /// Boton Introducir Numero
        /// </summary>
        private System.Windows.Forms.Button BotonIntrodNum;
        /// <summary>
        /// TextBox Leer vector
        /// </summary>
        private System.Windows.Forms.TextBox TextBoxLeerVector;
        /// <summary>
        /// Boton Leer vector
        /// </summary>
        private System.Windows.Forms.Button BotonLeerVector;
    }
}