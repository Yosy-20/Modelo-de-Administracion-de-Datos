namespace WindowsFormsApp3
{
    partial class nuvcontra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuvcontra));
            this.label1 = new System.Windows.Forms.Label();
            this.nuevcontra = new System.Windows.Forms.TextBox();
            this.provnuev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.acnueva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la nueva contraseña";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nuevcontra
            // 
            this.nuevcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevcontra.Location = new System.Drawing.Point(61, 197);
            this.nuevcontra.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nuevcontra.Name = "nuevcontra";
            this.nuevcontra.Size = new System.Drawing.Size(305, 34);
            this.nuevcontra.TabIndex = 1;
            // 
            // provnuev
            // 
            this.provnuev.Location = new System.Drawing.Point(61, 75);
            this.provnuev.Name = "provnuev";
            this.provnuev.Size = new System.Drawing.Size(305, 34);
            this.provnuev.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirmar contraseña";
            // 
            // acnueva
            // 
            this.acnueva.Location = new System.Drawing.Point(162, 263);
            this.acnueva.Name = "acnueva";
            this.acnueva.Size = new System.Drawing.Size(105, 40);
            this.acnueva.TabIndex = 4;
            this.acnueva.Text = "Aceptar";
            this.acnueva.UseVisualStyleBackColor = true;
            this.acnueva.Click += new System.EventHandler(this.acnueva_Click);
            // 
            // nuvcontra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(432, 334);
            this.Controls.Add(this.acnueva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.provnuev);
            this.Controls.Add(this.nuevcontra);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "nuvcontra";
            this.Text = "Nueva contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nuevcontra;
        private System.Windows.Forms.TextBox provnuev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button acnueva;
    }
}