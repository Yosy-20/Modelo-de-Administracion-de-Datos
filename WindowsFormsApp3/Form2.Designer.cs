namespace WindowsFormsApp3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Usu = new System.Windows.Forms.TextBox();
            this.Contra = new System.Windows.Forms.TextBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.Resgistro = new System.Windows.Forms.LinkLabel();
            this.manini = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "INICIO DE SESION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Correo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Usu
            // 
            this.Usu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usu.Location = new System.Drawing.Point(208, 123);
            this.Usu.Name = "Usu";
            this.Usu.Size = new System.Drawing.Size(255, 34);
            this.Usu.TabIndex = 4;
            this.Usu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Contra
            // 
            this.Contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contra.Location = new System.Drawing.Point(208, 221);
            this.Contra.Name = "Contra";
            this.Contra.Size = new System.Drawing.Size(255, 34);
            this.Contra.TabIndex = 5;
            // 
            // Ingresar
            // 
            this.Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.Location = new System.Drawing.Point(461, 373);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(125, 40);
            this.Ingresar.TabIndex = 6;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // Resgistro
            // 
            this.Resgistro.AutoSize = true;
            this.Resgistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resgistro.LinkColor = System.Drawing.Color.Navy;
            this.Resgistro.Location = new System.Drawing.Point(26, 384);
            this.Resgistro.Name = "Resgistro";
            this.Resgistro.Size = new System.Drawing.Size(137, 29);
            this.Resgistro.TabIndex = 7;
            this.Resgistro.TabStop = true;
            this.Resgistro.Text = "Registrarse";
            this.Resgistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Resgistro_LinkClicked);
            // 
            // manini
            // 
            this.manini.AutoSize = true;
            this.manini.Location = new System.Drawing.Point(208, 274);
            this.manini.Name = "manini";
            this.manini.Size = new System.Drawing.Size(92, 20);
            this.manini.TabIndex = 9;
            this.manini.Text = "Recordar  ";
            this.manini.UseVisualStyleBackColor = true;
            this.manini.CheckedChanged += new System.EventHandler(this.manini_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 445);
            this.Controls.Add(this.manini);
            this.Controls.Add(this.Resgistro);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.Contra);
            this.Controls.Add(this.Usu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Divine Verse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Usu;
        private System.Windows.Forms.TextBox Contra;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.LinkLabel Resgistro;
        private System.Windows.Forms.CheckBox manini;
    }
}