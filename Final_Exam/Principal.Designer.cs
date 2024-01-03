namespace Final_Exam
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teléfonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteTeléfonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadoToolStripMenuItem,
            this.departamentoToolStripMenuItem,
            this.teléfonoToolStripMenuItem,
            this.reporteTeléfonoToolStripMenuItem,
            this.reporteEmpleadoToolStripMenuItem,
            this.reporteDepartamentoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            this.departamentoToolStripMenuItem.Click += new System.EventHandler(this.departamentoToolStripMenuItem_Click);
            // 
            // teléfonoToolStripMenuItem
            // 
            this.teléfonoToolStripMenuItem.Name = "teléfonoToolStripMenuItem";
            this.teléfonoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.teléfonoToolStripMenuItem.Text = "Teléfono";
            this.teléfonoToolStripMenuItem.Click += new System.EventHandler(this.teléfonoToolStripMenuItem_Click);
            // 
            // reporteTeléfonoToolStripMenuItem
            // 
            this.reporteTeléfonoToolStripMenuItem.Name = "reporteTeléfonoToolStripMenuItem";
            this.reporteTeléfonoToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.reporteTeléfonoToolStripMenuItem.Text = "Reporte Teléfono";
            this.reporteTeléfonoToolStripMenuItem.Click += new System.EventHandler(this.reporteTeléfonoToolStripMenuItem_Click);
            // 
            // reporteEmpleadoToolStripMenuItem
            // 
            this.reporteEmpleadoToolStripMenuItem.Name = "reporteEmpleadoToolStripMenuItem";
            this.reporteEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.reporteEmpleadoToolStripMenuItem.Text = "Reporte Empleado";
            this.reporteEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.reporteEmpleadoToolStripMenuItem_Click);
            // 
            // reporteDepartamentoToolStripMenuItem
            // 
            this.reporteDepartamentoToolStripMenuItem.Name = "reporteDepartamentoToolStripMenuItem";
            this.reporteDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.reporteDepartamentoToolStripMenuItem.Text = "Reporte Departamento";
            this.reporteDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.reporteDepartamentoToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 457);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teléfonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteTeléfonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

