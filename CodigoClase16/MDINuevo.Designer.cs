namespace CodigoClase16
{
    partial class MDINuevo
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
            menuStrip1 = new MenuStrip();
            personasToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem1 = new ToolStripMenuItem();
            editarToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarToolStripMenuItem1 = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            repComprasToolStripMenuItem = new ToolStripMenuItem();
            repVentasToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { personasToolStripMenuItem, productosToolStripMenuItem, reportesToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // personasToolStripMenuItem
            // 
            personasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, editarToolStripMenuItem, eliminarToolStripMenuItem, proveedoresToolStripMenuItem, clientesToolStripMenuItem });
            personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            personasToolStripMenuItem.Size = new Size(124, 24);
            personasToolStripMenuItem.Text = "Mantenimiento";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(174, 26);
            nuevoToolStripMenuItem.Text = "Usuarios";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(174, 26);
            editarToolStripMenuItem.Text = "Productos";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(174, 26);
            eliminarToolStripMenuItem.Text = "Categorias";
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(174, 26);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(174, 26);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem1, editarToolStripMenuItem1, eliminarToolStripMenuItem1 });
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(81, 24);
            productosToolStripMenuItem.Text = "Procesos";
            // 
            // nuevoToolStripMenuItem1
            // 
            nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            nuevoToolStripMenuItem1.Size = new Size(224, 26);
            nuevoToolStripMenuItem1.Text = "Registrar Venta";
            nuevoToolStripMenuItem1.Click += nuevoToolStripMenuItem1_Click;
            // 
            // editarToolStripMenuItem1
            // 
            editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            editarToolStripMenuItem1.Size = new Size(224, 26);
            editarToolStripMenuItem1.Text = "Registrar Compra";
            // 
            // eliminarToolStripMenuItem1
            // 
            eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            eliminarToolStripMenuItem1.Size = new Size(224, 26);
            eliminarToolStripMenuItem1.Text = "Eliminar";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { repComprasToolStripMenuItem, repVentasToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // repComprasToolStripMenuItem
            // 
            repComprasToolStripMenuItem.Name = "repComprasToolStripMenuItem";
            repComprasToolStripMenuItem.Size = new Size(181, 26);
            repComprasToolStripMenuItem.Text = "Rep Compras";
            // 
            // repVentasToolStripMenuItem
            // 
            repVentasToolStripMenuItem.Name = "repVentasToolStripMenuItem";
            repVentasToolStripMenuItem.Size = new Size(181, 26);
            repVentasToolStripMenuItem.Text = "Rep Ventas";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // MDINuevo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MDINuevo";
            Text = "MDINuevo";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem personasToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem1;
        private ToolStripMenuItem editarToolStripMenuItem1;
        private ToolStripMenuItem eliminarToolStripMenuItem1;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem repComprasToolStripMenuItem;
        private ToolStripMenuItem repVentasToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}