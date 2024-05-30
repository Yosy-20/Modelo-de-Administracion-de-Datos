namespace WindowsFormsApp3
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.CitaFav = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Elimfav = new System.Windows.Forms.Button();
            this.verFav = new System.Windows.Forms.Button();
            this.barra = new System.Windows.Forms.MenuStrip();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Versiculo = new System.Windows.Forms.ListBox();
            this.barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // CitaFav
            // 
            this.CitaFav.FormattingEnabled = true;
            this.CitaFav.ItemHeight = 29;
            this.CitaFav.Location = new System.Drawing.Point(28, 116);
            this.CitaFav.Name = "CitaFav";
            this.CitaFav.Size = new System.Drawing.Size(161, 497);
            this.CitaFav.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "Favoritos";
            // 
            // Elimfav
            // 
            this.Elimfav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Elimfav.Location = new System.Drawing.Point(611, 124);
            this.Elimfav.Name = "Elimfav";
            this.Elimfav.Size = new System.Drawing.Size(110, 41);
            this.Elimfav.TabIndex = 12;
            this.Elimfav.Text = "Eliminar";
            this.Elimfav.UseVisualStyleBackColor = true;
            // 
            // verFav
            // 
            this.verFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verFav.Location = new System.Drawing.Point(611, 188);
            this.verFav.Name = "verFav";
            this.verFav.Size = new System.Drawing.Size(110, 41);
            this.verFav.TabIndex = 13;
            this.verFav.Text = "ver";
            this.verFav.UseVisualStyleBackColor = true;
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
            this.barra.Size = new System.Drawing.Size(779, 28);
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
            this.favoritosToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.favoritosToolStripMenuItem1.Text = "Favoritos";
            this.favoritosToolStripMenuItem1.Click += new System.EventHandler(this.favoritosToolStripMenuItem1_Click);
            // 
            // historialToolStripMenuItem1
            // 
            this.historialToolStripMenuItem1.Name = "historialToolStripMenuItem1";
            this.historialToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.historialToolStripMenuItem1.Text = "Historial";
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
            // Versiculo
            // 
            this.Versiculo.FormattingEnabled = true;
            this.Versiculo.ItemHeight = 29;
            this.Versiculo.Location = new System.Drawing.Point(207, 116);
            this.Versiculo.Name = "Versiculo";
            this.Versiculo.Size = new System.Drawing.Size(374, 497);
            this.Versiculo.TabIndex = 21;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(779, 636);
            this.Controls.Add(this.Versiculo);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.verFav);
            this.Controls.Add(this.Elimfav);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CitaFav);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Divine Verse";
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CitaFav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Elimfav;
        private System.Windows.Forms.Button verFav;
        private System.Windows.Forms.MenuStrip barra;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ListBox Versiculo;
    }
}