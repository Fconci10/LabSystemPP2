namespace LabSystem
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
            tbClienteNom = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbClienteApe = new TextBox();
            label4 = new Label();
            tbClienteCalle = new TextBox();
            label5 = new Label();
            tbClienteNumCalle = new TextBox();
            label6 = new Label();
            label7 = new Label();
            tbClienteCondFisc = new TextBox();
            label8 = new Label();
            tbClienteRazSoc = new TextBox();
            btnAgregar = new Button();
            label1 = new Label();
            btnActualizar = new Button();
            btnBorrar = new Button();
            dvg = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            idPer = new DataGridViewTextBoxColumn();
            label9 = new Label();
            cbTipo = new ComboBox();
            label10 = new Label();
            tbClienteDNI = new TextBox();
            tbClienteCuit = new TextBox();
            btnLimpiar = new Button();
            btnVolver = new Button();
            btnVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dvg).BeginInit();
            SuspendLayout();
            // 
            // tbClienteNom
            // 
            tbClienteNom.Location = new Point(175, 97);
            tbClienteNom.Name = "tbClienteNom";
            tbClienteNom.Size = new Size(100, 23);
            tbClienteNom.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 105);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 134);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // tbClienteApe
            // 
            tbClienteApe.Location = new Point(175, 126);
            tbClienteApe.Name = "tbClienteApe";
            tbClienteApe.Size = new Size(100, 23);
            tbClienteApe.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 163);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 6;
            label4.Text = "Calle";
            // 
            // tbClienteCalle
            // 
            tbClienteCalle.Location = new Point(175, 155);
            tbClienteCalle.Name = "tbClienteCalle";
            tbClienteCalle.Size = new Size(100, 23);
            tbClienteCalle.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 192);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 8;
            label5.Text = "Num. Calle";
            // 
            // tbClienteNumCalle
            // 
            tbClienteNumCalle.Location = new Point(175, 184);
            tbClienteNumCalle.Name = "tbClienteNumCalle";
            tbClienteNumCalle.Size = new Size(100, 23);
            tbClienteNumCalle.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 76);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 10;
            label6.Text = "Cuit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(73, 225);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 12;
            label7.Text = "Condicion Fiscal";
            // 
            // tbClienteCondFisc
            // 
            tbClienteCondFisc.Location = new Point(175, 217);
            tbClienteCondFisc.Name = "tbClienteCondFisc";
            tbClienteCondFisc.Size = new Size(100, 23);
            tbClienteCondFisc.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(73, 254);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 14;
            label8.Text = "Razon Social";
            // 
            // tbClienteRazSoc
            // 
            tbClienteRazSoc.Location = new Point(175, 246);
            tbClienteRazSoc.Name = "tbClienteRazSoc";
            tbClienteRazSoc.Size = new Size(100, 23);
            tbClienteRazSoc.TabIndex = 13;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(175, 275);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 23);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 16;
            label1.Text = "Agregar Cliente";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(149, 330);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 25;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(49, 330);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 26;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // dvg
            // 
            dvg.AllowUserToAddRows = false;
            dvg.AllowUserToDeleteRows = false;
            dvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg.Columns.AddRange(new DataGridViewColumn[] { Column1, Column10, Column9, Column4, Column2, Column3, Column7, Column8, Column5, Column6, idPer });
            dvg.Location = new Point(297, 105);
            dvg.Name = "dvg";
            dvg.ReadOnly = true;
            dvg.RowTemplate.Height = 25;
            dvg.Size = new Size(1042, 193);
            dvg.TabIndex = 27;
            dvg.CellDoubleClick += dvg_CellDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID Cliente";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "Tipo";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "DNI";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Cuit";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Apellido";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Calle";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Altura";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Condicion fiscal";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Razon social";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // idPer
            // 
            idPer.HeaderText = "ID Persona";
            idPer.Name = "idPer";
            idPer.ReadOnly = true;
            idPer.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(353, 36);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 28;
            label9.Text = "Tipo Cliente";
            // 
            // cbTipo
            // 
            cbTipo.DisplayMember = "1 2";
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Persona", "Empresa" });
            cbTipo.Location = new Point(446, 33);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(87, 23);
            cbTipo.TabIndex = 29;
            cbTipo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(73, 47);
            label10.Name = "label10";
            label10.Size = new Size(27, 15);
            label10.TabIndex = 31;
            label10.Text = "DNI";
            // 
            // tbClienteDNI
            // 
            tbClienteDNI.Location = new Point(175, 39);
            tbClienteDNI.Name = "tbClienteDNI";
            tbClienteDNI.Size = new Size(100, 23);
            tbClienteDNI.TabIndex = 30;
            // 
            // tbClienteCuit
            // 
            tbClienteCuit.Location = new Point(175, 68);
            tbClienteCuit.Name = "tbClienteCuit";
            tbClienteCuit.Size = new Size(100, 23);
            tbClienteCuit.TabIndex = 32;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(268, 332);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 33;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(1264, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 34;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(471, 304);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(111, 23);
            btnVenta.TabIndex = 35;
            btnVenta.Text = "Realizar venta";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 450);
            Controls.Add(btnVenta);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(tbClienteCuit);
            Controls.Add(label10);
            Controls.Add(tbClienteDNI);
            Controls.Add(cbTipo);
            Controls.Add(label9);
            Controls.Add(dvg);
            Controls.Add(btnBorrar);
            Controls.Add(btnActualizar);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(label8);
            Controls.Add(tbClienteRazSoc);
            Controls.Add(label7);
            Controls.Add(tbClienteCondFisc);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbClienteNumCalle);
            Controls.Add(label4);
            Controls.Add(tbClienteCalle);
            Controls.Add(label3);
            Controls.Add(tbClienteApe);
            Controls.Add(label2);
            Controls.Add(tbClienteNom);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dvg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbClienteDNI;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Button btnActualizar;
        private TextBox tbClienteNom;
        private TextBox tbClienteApe;
        private TextBox tbClienteCalle;
        private TextBox tbClienteNumCalle;
        private TextBox tbClienteCondFisc;
        private TextBox tbClienteRazSoc;
        private Button btnAgregar;
        private Label label1;
        private Button btnBorrar;
        private DataGridView dvg;
        private Label label9;
        private ComboBox cbTipo;
        private Label label10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn idPer;
        private TextBox tbClienteCuit;
        private Button btnLimpiar;
        private Button btnVolver;
        private Button btnVenta;
    }
}
