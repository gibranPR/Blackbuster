namespace BlackBuster
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hacerVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalDeRentaPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porMembresiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalDeVentasDiariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porTipoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porMembresíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRentas = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hacerVentaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // hacerVentaToolStripMenuItem
            // 
            this.hacerVentaToolStripMenuItem.Name = "hacerVentaToolStripMenuItem";
            this.hacerVentaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.hacerVentaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.hacerVentaToolStripMenuItem.Text = "Rentar pelicula";
            this.hacerVentaToolStripMenuItem.Click += new System.EventHandler(this.hacerVentaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalDeRentaPorClienteToolStripMenuItem,
            this.totalDeVentasDiariaToolStripMenuItem});
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // totalDeRentaPorClienteToolStripMenuItem
            // 
            this.totalDeRentaPorClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porClienteToolStripMenuItem,
            this.porTipoToolStripMenuItem,
            this.porMembresiaToolStripMenuItem});
            this.totalDeRentaPorClienteToolStripMenuItem.Name = "totalDeRentaPorClienteToolStripMenuItem";
            this.totalDeRentaPorClienteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.totalDeRentaPorClienteToolStripMenuItem.Text = "Total de renta";
            // 
            // porClienteToolStripMenuItem
            // 
            this.porClienteToolStripMenuItem.Name = "porClienteToolStripMenuItem";
            this.porClienteToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.porClienteToolStripMenuItem.Text = "Por cliente";
            this.porClienteToolStripMenuItem.Click += new System.EventHandler(this.porClienteToolStripMenuItem_Click);
            // 
            // porTipoToolStripMenuItem
            // 
            this.porTipoToolStripMenuItem.Name = "porTipoToolStripMenuItem";
            this.porTipoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.porTipoToolStripMenuItem.Text = "Por tipo";
            this.porTipoToolStripMenuItem.Click += new System.EventHandler(this.porTipoToolStripMenuItem_Click);
            // 
            // porMembresiaToolStripMenuItem
            // 
            this.porMembresiaToolStripMenuItem.Name = "porMembresiaToolStripMenuItem";
            this.porMembresiaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.porMembresiaToolStripMenuItem.Text = "Por membresía";
            this.porMembresiaToolStripMenuItem.Click += new System.EventHandler(this.porMembresiaToolStripMenuItem_Click);
            // 
            // totalDeVentasDiariaToolStripMenuItem
            // 
            this.totalDeVentasDiariaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porClienteToolStripMenuItem1,
            this.porTipoToolStripMenuItem1,
            this.porMembresíaToolStripMenuItem});
            this.totalDeVentasDiariaToolStripMenuItem.Name = "totalDeVentasDiariaToolStripMenuItem";
            this.totalDeVentasDiariaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.totalDeVentasDiariaToolStripMenuItem.Text = "Total de renta diarias";
            this.totalDeVentasDiariaToolStripMenuItem.Click += new System.EventHandler(this.totalDeVentasDiariaToolStripMenuItem_Click);
            // 
            // porClienteToolStripMenuItem1
            // 
            this.porClienteToolStripMenuItem1.Name = "porClienteToolStripMenuItem1";
            this.porClienteToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.porClienteToolStripMenuItem1.Text = "Por Cliente";
            // 
            // porTipoToolStripMenuItem1
            // 
            this.porTipoToolStripMenuItem1.Name = "porTipoToolStripMenuItem1";
            this.porTipoToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.porTipoToolStripMenuItem1.Text = "Por tipo";
            // 
            // porMembresíaToolStripMenuItem
            // 
            this.porMembresíaToolStripMenuItem.Name = "porMembresíaToolStripMenuItem";
            this.porMembresíaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.porMembresíaToolStripMenuItem.Text = "Por membresía";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(159, 195);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(150, 193);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(471, 195);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(150, 193);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnReportes, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClientes, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRentas, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.10486F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.89514F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 562);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnRentas
            // 
            this.btnRentas.Location = new System.Drawing.Point(315, 195);
            this.btnRentas.Name = "btnRentas";
            this.btnRentas.Size = new System.Drawing.Size(150, 193);
            this.btnRentas.TabIndex = 2;
            this.btnRentas.Text = "Rentas";
            this.btnRentas.UseVisualStyleBackColor = true;
            this.btnRentas.Click += new System.EventHandler(this.btnRentas_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackbuster V1.0";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalDeRentaPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalDeVentasDiariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porMembresiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porTipoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porMembresíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hacerVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRentas;
    }
}

