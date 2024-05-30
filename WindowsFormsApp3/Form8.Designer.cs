namespace WindowsFormsApp3
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.label1 = new System.Windows.Forms.Label();
            this.Historial = new System.Windows.Forms.ListBox();
            this.Meshist = new System.Windows.Forms.CheckBox();
            this.Anhist = new System.Windows.Forms.CheckBox();
            this.Allhist = new System.Windows.Forms.CheckBox();
            this.Elimhist = new System.Windows.Forms.Button();
            this.barra = new System.Windows.Forms.MenuStrip();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FechaR = new System.Windows.Forms.CheckBox();
            this.barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Historial";
            // 
            // Historial
            // 
            this.Historial.FormattingEnabled = true;
            this.Historial.ItemHeight = 29;
            this.Historial.Location = new System.Drawing.Point(51, 111);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(430, 497);
            this.Historial.TabIndex = 13;
            this.Historial.SelectedIndexChanged += new System.EventHandler(this.Historial_SelectedIndexChanged);
            // 
            // Meshist
            // 
            this.Meshist.AutoSize = true;
            this.Meshist.Location = new System.Drawing.Point(531, 124);
            this.Meshist.Name = "Meshist";
            this.Meshist.Size = new System.Drawing.Size(81, 33);
            this.Meshist.TabIndex = 15;
            this.Meshist.Text = "Mes";
            this.Meshist.UseVisualStyleBackColor = true;
            this.Meshist.CheckedChanged += new System.EventHandler(this.Meshist_CheckedChanged);
            // 
            // Anhist
            // 
            this.Anhist.AutoSize = true;
            this.Anhist.Location = new System.Drawing.Point(531, 182);
            this.Anhist.Name = "Anhist";
            this.Anhist.Size = new System.Drawing.Size(77, 33);
            this.Anhist.TabIndex = 16;
            this.Anhist.Text = "Año";
            this.Anhist.UseVisualStyleBackColor = true;
            this.Anhist.CheckedChanged += new System.EventHandler(this.Anhist_CheckedChanged);
            // 
            // Allhist
            // 
            this.Allhist.AutoSize = true;
            this.Allhist.Location = new System.Drawing.Point(531, 242);
            this.Allhist.Name = "Allhist";
            this.Allhist.Size = new System.Drawing.Size(99, 33);
            this.Allhist.TabIndex = 17;
            this.Allhist.Text = "Todo ";
            this.Allhist.UseVisualStyleBackColor = true;
            this.Allhist.CheckedChanged += new System.EventHandler(this.Allhist_CheckedChanged);
            // 
            // Elimhist
            // 
            this.Elimhist.Location = new System.Drawing.Point(518, 528);
            this.Elimhist.Name = "Elimhist";
            this.Elimhist.Size = new System.Drawing.Size(230, 37);
            this.Elimhist.TabIndex = 18;
            this.Elimhist.Text = "Eliminar historial";
            this.Elimhist.UseVisualStyleBackColor = true;
            this.Elimhist.Click += new System.EventHandler(this.Elimhist_Click);
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
            this.barra.Size = new System.Drawing.Size(790, 28);
            this.barra.TabIndex = 19;
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
            // FechaR
            // 
            this.FechaR.AutoSize = true;
            this.FechaR.Location = new System.Drawing.Point(531, 296);
            this.FechaR.Name = "FechaR";
            this.FechaR.Size = new System.Drawing.Size(204, 33);
            this.FechaR.TabIndex = 20;
            this.FechaR.Text = "Fecha Reciente";
            this.FechaR.UseVisualStyleBackColor = true;
            this.FechaR.CheckedChanged += new System.EventHandler(this.FechaR_CheckedChanged);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 630);
            this.Controls.Add(this.FechaR);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.Elimhist);
            this.Controls.Add(this.Allhist);
            this.Controls.Add(this.Anhist);
            this.Controls.Add(this.Meshist);
            this.Controls.Add(this.Historial);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Divine Verse";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Historial;
        private System.Windows.Forms.CheckBox Meshist;
        private System.Windows.Forms.CheckBox Anhist;
        private System.Windows.Forms.CheckBox Allhist;
        private System.Windows.Forms.Button Elimhist;
        private System.Windows.Forms.MenuStrip barra;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.CheckBox FechaR;
    }
}