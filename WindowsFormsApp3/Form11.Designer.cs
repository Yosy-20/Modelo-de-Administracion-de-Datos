namespace WindowsFormsApp3
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.genusu = new System.Windows.Forms.ComboBox();
            this.dateusu = new System.Windows.Forms.DateTimePicker();
            this.Aceusu = new System.Windows.Forms.Button();
            this.nomusu = new System.Windows.Forms.TextBox();
            this.apeusu = new System.Windows.Forms.TextBox();
            this.corusu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.elimusu = new System.Windows.Forms.Button();
            this.barra = new System.Windows.Forms.MenuStrip();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.usu = new System.Windows.Forms.TextBox();
            this.barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // genusu
            // 
            this.genusu.FormattingEnabled = true;
            this.genusu.Location = new System.Drawing.Point(273, 312);
            this.genusu.Name = "genusu";
            this.genusu.Size = new System.Drawing.Size(149, 37);
            this.genusu.TabIndex = 31;
            // 
            // dateusu
            // 
            this.dateusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateusu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateusu.Location = new System.Drawing.Point(273, 380);
            this.dateusu.Name = "dateusu";
            this.dateusu.Size = new System.Drawing.Size(149, 28);
            this.dateusu.TabIndex = 30;
            // 
            // Aceusu
            // 
            this.Aceusu.Location = new System.Drawing.Point(585, 127);
            this.Aceusu.Name = "Aceusu";
            this.Aceusu.Size = new System.Drawing.Size(111, 37);
            this.Aceusu.TabIndex = 29;
            this.Aceusu.Text = "Editar";
            this.Aceusu.UseVisualStyleBackColor = true;
            this.Aceusu.Click += new System.EventHandler(this.Aceusu_Click);
            // 
            // nomusu
            // 
            this.nomusu.Location = new System.Drawing.Point(273, 127);
            this.nomusu.Name = "nomusu";
            this.nomusu.Size = new System.Drawing.Size(231, 34);
            this.nomusu.TabIndex = 26;
            // 
            // apeusu
            // 
            this.apeusu.Location = new System.Drawing.Point(273, 211);
            this.apeusu.Name = "apeusu";
            this.apeusu.Size = new System.Drawing.Size(231, 34);
            this.apeusu.TabIndex = 25;
            // 
            // corusu
            // 
            this.corusu.Location = new System.Drawing.Point(273, 451);
            this.corusu.Name = "corusu";
            this.corusu.Size = new System.Drawing.Size(231, 34);
            this.corusu.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Género";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "Usuario";
            // 
            // elimusu
            // 
            this.elimusu.Location = new System.Drawing.Point(585, 196);
            this.elimusu.Name = "elimusu";
            this.elimusu.Size = new System.Drawing.Size(111, 42);
            this.elimusu.TabIndex = 32;
            this.elimusu.Text = "Eliminar";
            this.elimusu.UseVisualStyleBackColor = true;
            this.elimusu.Click += new System.EventHandler(this.elimusu_Click);
            // 
            // barra
            // 
            this.barra.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialToolStripMenuItem,
            this.favoritosToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(766, 28);
            this.barra.TabIndex = 33;
            this.barra.Text = "menuStrip1";
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favoritosToolStripMenuItem1,
            this.historialToolStripMenuItem1,
            this.perfilToolStripMenuItem});
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.historialToolStripMenuItem.Text = "Usuario";
            // 
            // favoritosToolStripMenuItem1
            // 
            this.favoritosToolStripMenuItem1.Name = "favoritosToolStripMenuItem1";
            this.favoritosToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.favoritosToolStripMenuItem1.Text = "Favoritos";
            this.favoritosToolStripMenuItem1.Click += new System.EventHandler(this.favoritosToolStripMenuItem1_Click);
            // 
            // historialToolStripMenuItem1
            // 
            this.historialToolStripMenuItem1.Name = "historialToolStripMenuItem1";
            this.historialToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.historialToolStripMenuItem1.Text = "Historial";
            this.historialToolStripMenuItem1.Click += new System.EventHandler(this.historialToolStripMenuItem1_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.perfilToolStripMenuItem.Text = "Perfil";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // favoritosToolStripMenuItem
            // 
            this.favoritosToolStripMenuItem.Name = "favoritosToolStripMenuItem";
            this.favoritosToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.favoritosToolStripMenuItem.Text = "Consultas";
            this.favoritosToolStripMenuItem.Click += new System.EventHandler(this.favoritosToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "Usuario";
            // 
            // usu
            // 
            this.usu.Location = new System.Drawing.Point(273, 505);
            this.usu.Name = "usu";
            this.usu.Size = new System.Drawing.Size(231, 34);
            this.usu.TabIndex = 35;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(766, 562);
            this.Controls.Add(this.usu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.elimusu);
            this.Controls.Add(this.genusu);
            this.Controls.Add(this.dateusu);
            this.Controls.Add(this.Aceusu);
            this.Controls.Add(this.nomusu);
            this.Controls.Add(this.apeusu);
            this.Controls.Add(this.corusu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form11";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox genusu;
        private System.Windows.Forms.DateTimePicker dateusu;
        private System.Windows.Forms.Button Aceusu;
        private System.Windows.Forms.TextBox nomusu;
        private System.Windows.Forms.TextBox apeusu;
        private System.Windows.Forms.TextBox corusu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button elimusu;
        private System.Windows.Forms.MenuStrip barra;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usu;
    }
}