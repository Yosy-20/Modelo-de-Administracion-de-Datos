namespace WindowsFormsApp3
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ingles = new System.Windows.Forms.Button();
            this.español = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Divine Verse";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idioma/Language";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ingles
            // 
            this.ingles.Location = new System.Drawing.Point(215, 280);
            this.ingles.Name = "ingles";
            this.ingles.Size = new System.Drawing.Size(103, 41);
            this.ingles.TabIndex = 3;
            this.ingles.Text = "English";
            this.ingles.UseVisualStyleBackColor = true;
            // 
            // español
            // 
            this.español.Location = new System.Drawing.Point(476, 280);
            this.español.Name = "español";
            this.español.Size = new System.Drawing.Size(122, 41);
            this.español.TabIndex = 4;
            this.español.Text = "Español";
            this.español.UseVisualStyleBackColor = true;
            this.español.Click += new System.EventHandler(this.español_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bienvenido/Welcome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.español);
            this.Controls.Add(this.ingles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Divine Verse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ingles;
        private System.Windows.Forms.Button español;
        private System.Windows.Forms.Label label2;
    }
}