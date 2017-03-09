namespace Navaja_de_Alejandro
{
    partial class Form1
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
            this.Bapp1 = new System.Windows.Forms.Button();
            this.Bapp2 = new System.Windows.Forms.Button();
            this.Bapp4 = new System.Windows.Forms.Button();
            this.Bapp3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bapp1
            // 
            this.Bapp1.Location = new System.Drawing.Point(104, 74);
            this.Bapp1.Name = "Bapp1";
            this.Bapp1.Size = new System.Drawing.Size(220, 79);
            this.Bapp1.TabIndex = 0;
            this.Bapp1.Text = "button1";
            this.Bapp1.UseVisualStyleBackColor = true;
            this.Bapp1.Click += new System.EventHandler(this.Bapp1_Click);
            // 
            // Bapp2
            // 
            this.Bapp2.Location = new System.Drawing.Point(509, 74);
            this.Bapp2.Name = "Bapp2";
            this.Bapp2.Size = new System.Drawing.Size(217, 79);
            this.Bapp2.TabIndex = 1;
            this.Bapp2.Text = "button2";
            this.Bapp2.UseVisualStyleBackColor = true;
            this.Bapp2.Click += new System.EventHandler(this.Bapp2_Click);
            // 
            // Bapp4
            // 
            this.Bapp4.Location = new System.Drawing.Point(509, 257);
            this.Bapp4.Name = "Bapp4";
            this.Bapp4.Size = new System.Drawing.Size(217, 85);
            this.Bapp4.TabIndex = 2;
            this.Bapp4.Text = "button3";
            this.Bapp4.UseVisualStyleBackColor = true;
            this.Bapp4.Click += new System.EventHandler(this.Bapp4_Click);
            // 
            // Bapp3
            // 
            this.Bapp3.Location = new System.Drawing.Point(104, 257);
            this.Bapp3.Name = "Bapp3";
            this.Bapp3.Size = new System.Drawing.Size(220, 85);
            this.Bapp3.TabIndex = 2;
            this.Bapp3.Text = "button3";
            this.Bapp3.UseVisualStyleBackColor = true;
            this.Bapp3.Click += new System.EventHandler(this.Bapp3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 416);
            this.Controls.Add(this.Bapp3);
            this.Controls.Add(this.Bapp4);
            this.Controls.Add(this.Bapp2);
            this.Controls.Add(this.Bapp1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bapp1;
        private System.Windows.Forms.Button Bapp2;
        private System.Windows.Forms.Button Bapp4;
        private System.Windows.Forms.Button Bapp3;
    }
}

