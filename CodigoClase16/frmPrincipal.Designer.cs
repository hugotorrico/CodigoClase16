namespace CodigoClase16
{
    partial class frmPrincipal
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
            primerFormularioToolStripMenuItem = new ToolStripMenuItem();
            segundoFormularioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { primerFormularioToolStripMenuItem, segundoFormularioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // primerFormularioToolStripMenuItem
            // 
            primerFormularioToolStripMenuItem.Name = "primerFormularioToolStripMenuItem";
            primerFormularioToolStripMenuItem.Size = new Size(142, 24);
            primerFormularioToolStripMenuItem.Text = "Primer Formulario";
            primerFormularioToolStripMenuItem.Click += primerFormularioToolStripMenuItem_Click;
            // 
            // segundoFormularioToolStripMenuItem
            // 
            segundoFormularioToolStripMenuItem.Name = "segundoFormularioToolStripMenuItem";
            segundoFormularioToolStripMenuItem.Size = new Size(158, 24);
            segundoFormularioToolStripMenuItem.Text = "Segundo Formulario";
            segundoFormularioToolStripMenuItem.Click += segundoFormularioToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem primerFormularioToolStripMenuItem;
        private ToolStripMenuItem segundoFormularioToolStripMenuItem;
    }
}