namespace WindowsFormsApp3
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.label1 = new System.Windows.Forms.Label();
            this.barra = new System.Windows.Forms.MenuStrip();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Acepbusq = new System.Windows.Forms.Button();
            this.busqueda = new System.Windows.Forms.TextBox();
            this.allBusq = new System.Windows.Forms.CheckBox();
            this.TestBusq = new System.Windows.Forms.ComboBox();
            this.libBusq = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.ListBox();
            this.barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Buscar";
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
            this.barra.Size = new System.Drawing.Size(830, 28);
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
            // Acepbusq
            // 
            this.Acepbusq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acepbusq.Location = new System.Drawing.Point(535, 98);
            this.Acepbusq.Name = "Acepbusq";
            this.Acepbusq.Size = new System.Drawing.Size(107, 34);
            this.Acepbusq.TabIndex = 21;
            this.Acepbusq.Text = "Aceptar";
            this.Acepbusq.UseVisualStyleBackColor = true;
            this.Acepbusq.Click += new System.EventHandler(this.Acepbusq_Click);
            // 
            // busqueda
            // 
            this.busqueda.Location = new System.Drawing.Point(78, 98);
            this.busqueda.Name = "busqueda";
            this.busqueda.Size = new System.Drawing.Size(388, 34);
            this.busqueda.TabIndex = 22;
            // 
            // allBusq
            // 
            this.allBusq.AutoSize = true;
            this.allBusq.Location = new System.Drawing.Point(484, 173);
            this.allBusq.Name = "allBusq";
            this.allBusq.Size = new System.Drawing.Size(182, 33);
            this.allBusq.TabIndex = 23;
            this.allBusq.Text = "Toda la biblia";
            this.allBusq.UseVisualStyleBackColor = true;
            this.allBusq.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TestBusq
            // 
            this.TestBusq.FormattingEnabled = true;
            this.TestBusq.Location = new System.Drawing.Point(252, 184);
            this.TestBusq.Name = "TestBusq";
            this.TestBusq.Size = new System.Drawing.Size(188, 37);
            this.TestBusq.TabIndex = 24;
            this.TestBusq.SelectedIndexChanged += new System.EventHandler(this.TestBusq_SelectedIndexChanged);
            // 
            // libBusq
            // 
            this.libBusq.FormattingEnabled = true;
            this.libBusq.Location = new System.Drawing.Point(38, 184);
            this.libBusq.Name = "libBusq";
            this.libBusq.Size = new System.Drawing.Size(171, 37);
            this.libBusq.TabIndex = 25;
            this.libBusq.SelectedIndexChanged += new System.EventHandler(this.libBusq_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Testamento";
            // 
            // Resultado
            // 
            this.Resultado.FormattingEnabled = true;
            this.Resultado.ItemHeight = 29;
            this.Resultado.Location = new System.Drawing.Point(212, 240);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(362, 410);
            this.Resultado.TabIndex = 28;
            this.Resultado.SelectedIndexChanged += new System.EventHandler(this.Resultado_SelectedIndexChanged);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 660);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.libBusq);
            this.Controls.Add(this.TestBusq);
            this.Controls.Add(this.allBusq);
            this.Controls.Add(this.busqueda);
            this.Controls.Add(this.Acepbusq);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Divine Verse";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip barra;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.Button Acepbusq;
        private System.Windows.Forms.TextBox busqueda;
        private System.Windows.Forms.CheckBox allBusq;
        private System.Windows.Forms.ComboBox TestBusq;
        private System.Windows.Forms.ComboBox libBusq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Resultado;
    }
}