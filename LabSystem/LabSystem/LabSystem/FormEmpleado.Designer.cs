namespace LabSystem
{
    partial class FormEmpleado
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
            lblNombre = new Label();
            lblApellido = new Label();
            rbPersonal = new RadioButton();
            rbUsuario = new RadioButton();
            rbEmpleado = new RadioButton();
            panelPersonal = new Panel();
            lblCf = new Label();
            label4 = new Label();
            lblDireccion = new Label();
            label7 = new Label();
            lblApe = new Label();
            label5 = new Label();
            lblNom = new Label();
            label3 = new Label();
            lblDni = new Label();
            label2 = new Label();
            panelEmpleado = new Panel();
            label13 = new Label();
            dgvPuestos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            lblNE = new Label();
            label11 = new Label();
            lblHE = new Label();
            label9 = new Label();
            lblHI = new Label();
            label6 = new Label();
            panelUsuario = new Panel();
            pCampoUsuario = new Panel();
            tbUsuarioP = new Panel();
            tbUsuario = new TextBox();
            tbClaveP = new Panel();
            tbClave = new TextBox();
            checkBox1 = new CheckBox();
            btnActualizar = new Button();
            label12 = new Label();
            label10 = new Label();
            lblNumUsu = new Label();
            label8 = new Label();
            gbDatos = new GroupBox();
            panelPersonal.SuspendLayout();
            panelEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
            panelUsuario.SuspendLayout();
            pCampoUsuario.SuspendLayout();
            tbUsuarioP.SuspendLayout();
            tbClaveP.SuspendLayout();
            gbDatos.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(95, 21);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(45, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "label2";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(150, 21);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(45, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "label3";
            // 
            // rbPersonal
            // 
            rbPersonal.AutoSize = true;
            rbPersonal.Location = new Point(6, 17);
            rbPersonal.Name = "rbPersonal";
            rbPersonal.Size = new Size(81, 19);
            rbPersonal.TabIndex = 3;
            rbPersonal.TabStop = true;
            rbPersonal.Text = "Personales";
            rbPersonal.UseVisualStyleBackColor = true;
            rbPersonal.CheckedChanged += rbPersonal_CheckedChanged;
            // 
            // rbUsuario
            // 
            rbUsuario.AutoSize = true;
            rbUsuario.Location = new Point(170, 17);
            rbUsuario.Name = "rbUsuario";
            rbUsuario.Size = new Size(65, 19);
            rbUsuario.TabIndex = 5;
            rbUsuario.TabStop = true;
            rbUsuario.Text = "Usuario";
            rbUsuario.UseVisualStyleBackColor = true;
            rbUsuario.CheckedChanged += rbPersonal_CheckedChanged;
            // 
            // rbEmpleado
            // 
            rbEmpleado.AutoSize = true;
            rbEmpleado.Location = new Point(90, 17);
            rbEmpleado.Name = "rbEmpleado";
            rbEmpleado.Size = new Size(78, 19);
            rbEmpleado.TabIndex = 5;
            rbEmpleado.TabStop = true;
            rbEmpleado.Text = "Empleado";
            rbEmpleado.UseVisualStyleBackColor = true;
            rbEmpleado.CheckedChanged += rbPersonal_CheckedChanged;
            // 
            // panelPersonal
            // 
            panelPersonal.Controls.Add(lblCf);
            panelPersonal.Controls.Add(label4);
            panelPersonal.Controls.Add(lblDireccion);
            panelPersonal.Controls.Add(label7);
            panelPersonal.Controls.Add(lblApe);
            panelPersonal.Controls.Add(label5);
            panelPersonal.Controls.Add(lblNom);
            panelPersonal.Controls.Add(label3);
            panelPersonal.Controls.Add(lblDni);
            panelPersonal.Controls.Add(label2);
            panelPersonal.Location = new Point(21, 91);
            panelPersonal.Name = "panelPersonal";
            panelPersonal.Size = new Size(249, 196);
            panelPersonal.TabIndex = 5;
            // 
            // lblCf
            // 
            lblCf.AutoSize = true;
            lblCf.Location = new Point(130, 157);
            lblCf.Name = "lblCf";
            lblCf.Size = new Size(38, 15);
            lblCf.TabIndex = 9;
            lblCf.Text = "label6";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 157);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 8;
            label4.Text = "Condición Fiscal";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(130, 118);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(38, 15);
            lblDireccion.TabIndex = 7;
            lblDireccion.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 118);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 6;
            label7.Text = "Direccion";
            // 
            // lblApe
            // 
            lblApe.AutoSize = true;
            lblApe.Location = new Point(130, 84);
            lblApe.Name = "lblApe";
            lblApe.Size = new Size(38, 15);
            lblApe.TabIndex = 5;
            lblApe.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 84);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Apellido";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(130, 48);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(38, 15);
            lblNom.TabIndex = 3;
            lblNom.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 48);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(130, 15);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(38, 15);
            lblDni.TabIndex = 1;
            lblDni.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 15);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 0;
            label2.Text = "DNI";
            // 
            // panelEmpleado
            // 
            panelEmpleado.Controls.Add(label13);
            panelEmpleado.Controls.Add(dgvPuestos);
            panelEmpleado.Controls.Add(lblNE);
            panelEmpleado.Controls.Add(label11);
            panelEmpleado.Controls.Add(lblHE);
            panelEmpleado.Controls.Add(label9);
            panelEmpleado.Controls.Add(lblHI);
            panelEmpleado.Controls.Add(label6);
            panelEmpleado.Enabled = false;
            panelEmpleado.Location = new Point(21, 91);
            panelEmpleado.Name = "panelEmpleado";
            panelEmpleado.Size = new Size(249, 240);
            panelEmpleado.TabIndex = 6;
            panelEmpleado.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 105);
            label13.Name = "label13";
            label13.Size = new Size(70, 15);
            label13.TabIndex = 7;
            label13.Text = "Mis puestos";
            // 
            // dgvPuestos
            // 
            dgvPuestos.AllowUserToAddRows = false;
            dgvPuestos.AllowUserToDeleteRows = false;
            dgvPuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuestos.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dgvPuestos.Location = new Point(18, 123);
            dgvPuestos.Name = "dgvPuestos";
            dgvPuestos.RowTemplate.Height = 25;
            dgvPuestos.Size = new Size(202, 94);
            dgvPuestos.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Nombre del puesto";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 90;
            // 
            // lblNE
            // 
            lblNE.AutoSize = true;
            lblNE.Location = new Point(142, 17);
            lblNE.Name = "lblNE";
            lblNE.Size = new Size(44, 15);
            lblNE.TabIndex = 5;
            lblNE.Text = "label12";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 17);
            label11.Name = "label11";
            label11.Size = new Size(107, 15);
            label11.TabIndex = 4;
            label11.Text = "Numero empleado";
            // 
            // lblHE
            // 
            lblHE.AutoSize = true;
            lblHE.Location = new Point(142, 75);
            lblHE.Name = "lblHE";
            lblHE.Size = new Size(44, 15);
            lblHE.TabIndex = 3;
            lblHE.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 75);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 2;
            label9.Text = "Horario egreso";
            // 
            // lblHI
            // 
            lblHI.AutoSize = true;
            lblHI.Location = new Point(142, 44);
            lblHI.Name = "lblHI";
            lblHI.Size = new Size(38, 15);
            lblHI.TabIndex = 1;
            lblHI.Text = "label8";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 44);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 0;
            label6.Text = "Horario ingreso";
            // 
            // panelUsuario
            // 
            panelUsuario.Controls.Add(pCampoUsuario);
            panelUsuario.Controls.Add(checkBox1);
            panelUsuario.Controls.Add(btnActualizar);
            panelUsuario.Controls.Add(label12);
            panelUsuario.Controls.Add(label10);
            panelUsuario.Controls.Add(lblNumUsu);
            panelUsuario.Controls.Add(label8);
            panelUsuario.Enabled = false;
            panelUsuario.Location = new Point(21, 95);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(249, 162);
            panelUsuario.TabIndex = 7;
            panelUsuario.Visible = false;
            // 
            // pCampoUsuario
            // 
            pCampoUsuario.Controls.Add(tbUsuarioP);
            pCampoUsuario.Controls.Add(tbClaveP);
            pCampoUsuario.Location = new Point(82, 40);
            pCampoUsuario.Name = "pCampoUsuario";
            pCampoUsuario.Size = new Size(120, 72);
            pCampoUsuario.TabIndex = 11;
            // 
            // tbUsuarioP
            // 
            tbUsuarioP.Controls.Add(tbUsuario);
            tbUsuarioP.Location = new Point(3, 5);
            tbUsuarioP.Name = "tbUsuarioP";
            tbUsuarioP.Size = new Size(106, 29);
            tbUsuarioP.TabIndex = 9;
            // 
            // tbUsuario
            // 
            tbUsuario.Enabled = false;
            tbUsuario.Location = new Point(3, 3);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(100, 23);
            tbUsuario.TabIndex = 4;
            tbUsuario.Tag = "Usuario";
            tbUsuario.Leave += tbUsuario_Leave;
            // 
            // tbClaveP
            // 
            tbClaveP.Controls.Add(tbClave);
            tbClaveP.Location = new Point(3, 37);
            tbClaveP.Name = "tbClaveP";
            tbClaveP.Size = new Size(106, 29);
            tbClaveP.TabIndex = 10;
            // 
            // tbClave
            // 
            tbClave.Enabled = false;
            tbClave.Location = new Point(3, 3);
            tbClave.Name = "tbClave";
            tbClave.Size = new Size(100, 23);
            tbClave.TabIndex = 5;
            tbClave.Tag = "Contraseña";
            tbClave.Leave += tbUsuario_Leave;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(172, 14);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(56, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Editar";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnActualizar
            // 
            btnActualizar.Enabled = false;
            btnActualizar.Location = new Point(87, 119);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Aceptar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 86);
            label12.Name = "label12";
            label12.Size = new Size(67, 15);
            label12.TabIndex = 3;
            label12.Text = "Contraseña";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 49);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 2;
            label10.Text = "Usuario";
            // 
            // lblNumUsu
            // 
            lblNumUsu.AutoSize = true;
            lblNumUsu.Location = new Point(108, 16);
            lblNumUsu.Name = "lblNumUsu";
            lblNumUsu.Size = new Size(44, 15);
            lblNumUsu.TabIndex = 1;
            lblNumUsu.Text = "label10";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 16);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 0;
            label8.Text = "Numero usuario";
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(rbPersonal);
            gbDatos.Controls.Add(rbUsuario);
            gbDatos.Controls.Add(rbEmpleado);
            gbDatos.Location = new Point(21, 44);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(249, 45);
            gbDatos.TabIndex = 8;
            gbDatos.TabStop = false;
            gbDatos.Text = "Datos";
            // 
            // FormEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 346);
            Controls.Add(gbDatos);
            Controls.Add(panelUsuario);
            Controls.Add(panelEmpleado);
            Controls.Add(panelPersonal);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Name = "FormEmpleado";
            Text = "FormEmpleado";
            panelPersonal.ResumeLayout(false);
            panelPersonal.PerformLayout();
            panelEmpleado.ResumeLayout(false);
            panelEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).EndInit();
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            pCampoUsuario.ResumeLayout(false);
            tbUsuarioP.ResumeLayout(false);
            tbUsuarioP.PerformLayout();
            tbClaveP.ResumeLayout(false);
            tbClaveP.PerformLayout();
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNombre;
        private Label lblApellido;
        private RadioButton rbPersonal;
        private RadioButton rbUsuario;
        private RadioButton rbEmpleado;
        private Panel panelPersonal;
        private Label lblDni;
        private Label label2;
        private Label label7;
        private Label lblApe;
        private Label label5;
        private Label lblNom;
        private Label label3;
        private Label lblDireccion;
        private Label lblCf;
        private Label label4;
        private Panel panelEmpleado;
        private Label label9;
        private Label lblHI;
        private Label label6;
        private DataGridView dgvPuestos;
        private Label lblNE;
        private Label label11;
        private Label lblHE;
        private DataGridViewTextBoxColumn Column1;
        private Label label13;
        private Panel panelUsuario;
        private TextBox tbClave;
        private TextBox tbUsuario;
        private Label label12;
        private Label label10;
        private Label lblNumUsu;
        private Label label8;
        private CheckBox checkBox1;
        private Button btnActualizar;
        private GroupBox gbDatos;
        private Panel pCampoUsuario;
        private Panel tbUsuarioP;
        private Panel tbClaveP;
    }
}