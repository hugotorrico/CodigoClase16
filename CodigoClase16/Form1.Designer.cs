namespace CodigoClase16
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            dgvDemo = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDemo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Dock = DockStyle.Top;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(898, 46);
            label1.TabIndex = 0;
            label1.Text = "Mantenimiento de Usuarios";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(95, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 270);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(51, 171);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(18, 214);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(141, 184);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 40);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(109, 137);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(109, 104);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(496, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(294, 265);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información Adicional";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._528863c9_1192_40d5_a7d3_86e1dd28ce4b;
            pictureBox1.Location = new Point(70, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 128, 255);
            button3.ForeColor = Color.White;
            button3.Location = new Point(696, 355);
            button3.Name = "button3";
            button3.Size = new Size(94, 41);
            button3.TabIndex = 5;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dgvDemo
            // 
            dgvDemo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDemo.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellidos });
            dgvDemo.Location = new Point(95, 402);
            dgvDemo.Name = "dgvDemo";
            dgvDemo.RowHeadersWidth = 51;
            dgvDemo.RowTemplate.Height = 29;
            dgvDemo.Size = new Size(695, 161);
            dgvDemo.TabIndex = 6;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "TituloNombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Apellidos
            // 
            Apellidos.DataPropertyName = "Apellido";
            Apellidos.HeaderText = "Apellidos";
            Apellidos.MinimumWidth = 6;
            Apellidos.Name = "Apellidos";
            Apellidos.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.ForeColor = Color.White;
            button1.Location = new Point(596, 355);
            button1.Name = "button1";
            button1.Size = new Size(94, 41);
            button1.TabIndex = 7;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 128, 255);
            button2.ForeColor = Color.White;
            button2.Location = new Point(496, 355);
            button2.Name = "button2";
            button2.Size = new Size(94, 41);
            button2.TabIndex = 8;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(898, 628);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvDemo);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDemo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private DataGridView dgvDemo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellidos;
        private LinkLabel linkLabel1;
        private Button button1;
        private Button button2;
    }
}
