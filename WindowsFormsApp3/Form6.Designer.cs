namespace WindowsFormsApp3
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.cita = new System.Windows.Forms.ListBox();
            this.Versiculo = new System.Windows.Forms.ListBox();
            this.regresarcon = new System.Windows.Forms.Button();
            this.Favcon = new System.Windows.Forms.Button();
            this.limcons = new System.Windows.Forms.Button();
            this.barra = new System.Windows.Forms.MenuStrip();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // cita
            // 
            this.cita.FormattingEnabled = true;
            this.cita.ItemHeight = 29;
            this.cita.Location = new System.Drawing.Point(47, 108);
            this.cita.Name = "cita";
            this.cita.Size = new System.Drawing.Size(187, 497);
            this.cita.TabIndex = 9;
            this.cita.SelectedIndexChanged += new System.EventHandler(this.Cita_SelectedIndexChanged);
            // 
            // Versiculo
            // 
            this.Versiculo.FormattingEnabled = true;
            this.Versiculo.ItemHeight = 29;
            this.Versiculo.Location = new System.Drawing.Point(282, 108);
            this.Versiculo.Name = "Versiculo";
            this.Versiculo.Size = new System.Drawing.Size(374, 497);
            this.Versiculo.TabIndex = 10;
            // 
            // regresarcon
            // 
            this.regresarcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarcon.Location = new System.Drawing.Point(689, 176);
            this.regresarcon.Name = "regresarcon";
            this.regresarcon.Size = new System.Drawing.Size(111, 39);
            this.regresarcon.TabIndex = 11;
            this.regresarcon.Text = "Regresar";
            this.regresarcon.UseVisualStyleBackColor = true;
            this.regresarcon.Click += new System.EventHandler(this.regresarcon_Click);
            // 
            // Favcon
            // 
            this.Favcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Favcon.Location = new System.Drawing.Point(687, 108);
            this.Favcon.Name = "Favcon";
            this.Favcon.Size = new System.Drawing.Size(113, 37);
            this.Favcon.TabIndex = 12;
            this.Favcon.Text = "Favorito";
            this.Favcon.UseVisualStyleBackColor = true;
            // 
            // limcons
            // 
            this.limcons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limcons.Location = new System.Drawing.Point(687, 243);
            this.limcons.Name = "limcons";
            this.limcons.Size = new System.Drawing.Size(111, 39);
            this.limcons.TabIndex = 13;
            this.limcons.Text = "Limpiar";
            this.limcons.UseVisualStyleBackColor = true;
            this.limcons.Click += new System.EventHandler(this.limcons_Click);
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
            this.barra.Size = new System.Drawing.Size(825, 28);
            this.barra.TabIndex = 20;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 46);
            this.label4.TabIndex = 25;
            this.label4.Text = "Consulta";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(825, 635);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.limcons);
            this.Controls.Add(this.Favcon);
            this.Controls.Add(this.regresarcon);
            this.Controls.Add(this.Versiculo);
            this.Controls.Add(this.cita);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Divine Verse";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cita;
        private System.Windows.Forms.ListBox Versiculo;
        private System.Windows.Forms.Button regresarcon;
        private System.Windows.Forms.Button Favcon;
        private System.Windows.Forms.Button limcons;
        private System.Windows.Forms.MenuStrip barra;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}