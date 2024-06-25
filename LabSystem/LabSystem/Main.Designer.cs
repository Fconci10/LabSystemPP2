namespace LabSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            btnClientes = new Button();
            btnProveedor = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Transparent;
            btnClientes.FlatAppearance.BorderColor = Color.Black;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 108, 204);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.Location = new Point(296, 213);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(150, 35);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += button1_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.BackColor = Color.Transparent;
            btnProveedor.FlatAppearance.BorderColor = Color.Black;
            btnProveedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnProveedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 108, 204);
            btnProveedor.FlatStyle = FlatStyle.Flat;
            btnProveedor.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedor.Location = new Point(510, 213);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(150, 35);
            btnProveedor.TabIndex = 4;
            btnProveedor.Text = "Proveedores";
            btnProveedor.UseVisualStyleBackColor = false;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fda2b84b_8989_4777_93d5_9f801216611a;
            pictureBox1.Location = new Point(366, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 382);
            panel1.TabIndex = 6;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.procesos_biomedicos_contenido;
            pictureBox5.Location = new Point(-3, 202);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(200, 186);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.reparacion_de_equipos_medicos;
            pictureBox4.Location = new Point(0, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(197, 169);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(680, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseDown += pictureBox2_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(739, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(816, 382);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnProveedor);
            Controls.Add(btnClientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            Opacity = 0.9D;
            Text = "Main";
            Load += Main_Load;
            MouseDown += pictureBox2_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnClientes;
        private Button btnProveedor;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
    }
}