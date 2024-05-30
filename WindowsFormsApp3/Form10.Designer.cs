namespace WindowsFormsApp3
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ContraP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Ingex = new System.Windows.Forms.Button();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña Provisional";
            // 
            // ContraP
            // 
            this.ContraP.Location = new System.Drawing.Point(406, 228);
            this.ContraP.Name = "ContraP";
            this.ContraP.Size = new System.Drawing.Size(205, 34);
            this.ContraP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(136, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "Exedío el limite de intentos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(588, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ingrese nuevamente con la contraseña proporcionada";
            // 
            // Ingex
            // 
            this.Ingex.Location = new System.Drawing.Point(584, 287);
            this.Ingex.Name = "Ingex";
            this.Ingex.Size = new System.Drawing.Size(122, 39);
            this.Ingex.TabIndex = 5;
            this.Ingex.Text = "Ingresar";
            this.Ingex.UseVisualStyleBackColor = true;
            this.Ingex.Click += new System.EventHandler(this.Ingex_Click);
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(406, 133);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(205, 34);
            this.Usuario.TabIndex = 6;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(736, 362);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Ingex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ContraP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peligro";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContraP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Ingex;
        private System.Windows.Forms.TextBox Usuario;
    }
}