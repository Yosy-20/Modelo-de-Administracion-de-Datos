namespace WindowsFormsApp3
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barra = new System.Windows.Forms.MenuStrip();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testcons = new System.Windows.Forms.ComboBox();
            this.libcons = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.capcons = new System.Windows.Forms.ComboBox();
            this.Acepconst = new System.Windows.Forms.Button();
            this.barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccione un Testamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Seleccione un Libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Seleccione un Capitulo";
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
            this.barra.Size = new System.Drawing.Size(538, 30);
            this.barra.TabIndex = 21;
            this.barra.Text = "menuStrip1";
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favoritosToolStripMenuItem1,
            this.historialToolStripMenuItem1,
            this.perfilToolStripMenuItem});
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.historialToolStripMenuItem.Text = "Usuario";
            // 
            // favoritosToolStripMenuItem1
            // 
            this.favoritosToolStripMenuItem1.Name = "favoritosToolStripMenuItem1";
            this.favoritosToolStripMenuItem1.Size = new System.Drawing.Size(151, 26);
            this.favoritosToolStripMenuItem1.Text = "Favoritos";
            this.favoritosToolStripMenuItem1.Click += new System.EventHandler(this.favoritosToolStripMenuItem1_Click);
            // 
            // historialToolStripMenuItem1
            // 
            this.historialToolStripMenuItem1.Name = "historialToolStripMenuItem1";
            this.historialToolStripMenuItem1.Size = new System.Drawing.Size(151, 26);
            this.historialToolStripMenuItem1.Text = "Historial";
            this.historialToolStripMenuItem1.Click += new System.EventHandler(this.historialToolStripMenuItem1_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.perfilToolStripMenuItem.Text = "Perfil";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // favoritosToolStripMenuItem
            // 
            this.favoritosToolStripMenuItem.Name = "favoritosToolStripMenuItem";
            this.favoritosToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.favoritosToolStripMenuItem.Text = "Consultas";
            this.favoritosToolStripMenuItem.Click += new System.EventHandler(this.favoritosToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // testcons
            // 
            this.testcons.FormattingEnabled = true;
            this.testcons.Location = new System.Drawing.Point(149, 166);
            this.testcons.Name = "testcons";
            this.testcons.Size = new System.Drawing.Size(239, 37);
            this.testcons.TabIndex = 22;
            // 
            // libcons
            // 
            this.libcons.FormattingEnabled = true;
            this.libcons.Location = new System.Drawing.Point(149, 296);
            this.libcons.Name = "libcons";
            this.libcons.Size = new System.Drawing.Size(239, 37);
            this.libcons.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 46);
            this.label4.TabIndex = 24;
            this.label4.Text = "Consulta";
            // 
            // capcons
            // 
            this.capcons.FormattingEnabled = true;
            this.capcons.Location = new System.Drawing.Point(149, 445);
            this.capcons.Name = "capcons";
            this.capcons.Size = new System.Drawing.Size(239, 37);
            this.capcons.TabIndex = 25;
            // 
            // Acepconst
            // 
            this.Acepconst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acepconst.Location = new System.Drawing.Point(295, 507);
            this.Acepconst.Name = "Acepconst";
            this.Acepconst.Size = new System.Drawing.Size(110, 31);
            this.Acepconst.TabIndex = 26;
            this.Acepconst.Text = "Aceptar";
            this.Acepconst.UseVisualStyleBackColor = true;
            this.Acepconst.Click += new System.EventHandler(this.Acepconst_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 581);
            this.Controls.Add(this.Acepconst);
            this.Controls.Add(this.capcons);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.libcons);
            this.Controls.Add(this.testcons);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Divine Verse";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip barra;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ComboBox testcons;
        private System.Windows.Forms.ComboBox libcons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox capcons;
        private System.Windows.Forms.Button Acepconst;
    }
}