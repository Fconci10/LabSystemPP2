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
            button1 = new Button();
            btnProveedor = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 108, 204);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Alef", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(294, 262);
            button1.Name = "button1";
            button1.Size = new Size(150, 35);
            button1.TabIndex = 3;
            button1.Text = "Clientes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.BackColor = Color.Transparent;
            btnProveedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnProveedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 108, 204);
            btnProveedor.FlatStyle = FlatStyle.Flat;
            btnProveedor.Font = new Font("Alef", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedor.Location = new Point(526, 262);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(150, 35);
            btnProveedor.TabIndex = 4;
            btnProveedor.Text = "Proveedores";
            btnProveedor.UseVisualStyleBackColor = false;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(396, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 118);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 500);
            panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(896, 12);
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
            pictureBox3.Location = new Point(940, 12);
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
            ClientSize = new Size(1000, 500);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnProveedor);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            Opacity = 0.9D;
            Text = "Main";
            Load += Main_Load;
            MouseDown += pictureBox2_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button btnProveedor;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}