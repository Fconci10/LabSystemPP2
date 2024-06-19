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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            btnProveedor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 27F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 69);
            label1.Name = "label1";
            label1.Size = new Size(734, 50);
            label1.TabIndex = 0;
            label1.Text = "Dirijase a una de las siguentes pantallas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Stout", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 188);
            label2.Name = "label2";
            label2.Size = new Size(341, 32);
            label2.TabIndex = 1;
            label2.Text = "Ir a Clientes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ravie", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(490, 188);
            label3.Name = "label3";
            label3.Size = new Size(279, 34);
            label3.TabIndex = 2;
            label3.Text = "Ir a proveedores";
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.Font = new Font("Edwardian Script ITC", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 229);
            button1.Name = "button1";
            button1.Size = new Size(170, 63);
            button1.TabIndex = 3;
            button1.Text = "Clientes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.BackColor = Color.MediumBlue;
            btnProveedor.Font = new Font("Viner Hand ITC", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnProveedor.Location = new Point(599, 229);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(170, 63);
            btnProveedor.TabIndex = 4;
            btnProveedor.Text = "Proveedores";
            btnProveedor.UseVisualStyleBackColor = false;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepPink;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProveedor);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button btnProveedor;
    }
}