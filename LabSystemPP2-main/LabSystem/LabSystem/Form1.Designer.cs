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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            label9 = new Label();
            cbTipo = new ComboBox();
            label10 = new Label();
            tbClienteDNI = new TextBox();
            tbClienteCuit = new TextBox();
            btnLimpiar = new Button();
            btnVolver = new Button();
            btnVenta = new Button();
            tbClienteDNIp = new Panel();
            tbClienteNumCallep = new Panel();
            tbClienteApep = new Panel();
            tbClienteRazSocp = new Panel();
            tbClienteCondFiscp = new Panel();
            tbClienteCuitp = new Panel();
            tbClienteNomp = new Panel();
            tbClienteCallep = new Panel();
            PanelControl = new Panel();
            label12 = new Label();
            btnBuscar = new Button();
            tbBuscar = new TextBox();
            btnEmplDatos = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dvg).BeginInit();
            tbClienteDNIp.SuspendLayout();
            tbClienteNumCallep.SuspendLayout();
            tbClienteApep.SuspendLayout();
            tbClienteRazSocp.SuspendLayout();
            tbClienteCondFiscp.SuspendLayout();
            tbClienteCuitp.SuspendLayout();
            tbClienteNomp.SuspendLayout();
            tbClienteCallep.SuspendLayout();
            PanelControl.SuspendLayout();
            SuspendLayout();
            // 
            // tbClienteNom
            // 
            tbClienteNom.Location = new Point(3, 3);
            tbClienteNom.Name = "tbClienteNom";
            tbClienteNom.Size = new Size(100, 23);
            tbClienteNom.TabIndex = 0;
            tbClienteNom.Tag = "Nombre";
            tbClienteNom.Leave += tbClienteDNI_Leave;
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
            label3.Location = new Point(73, 137);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // tbClienteApe
            // 
            tbClienteApe.Location = new Point(3, 3);
            tbClienteApe.Name = "tbClienteApe";
            tbClienteApe.Size = new Size(100, 23);
            tbClienteApe.TabIndex = 3;
            tbClienteApe.Tag = "Apellido";
            tbClienteApe.KeyPress += tbClienteApe_KeyPress;
            tbClienteApe.Leave += tbClienteDNI_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 168);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 6;
            label4.Text = "Calle";
            // 
            // tbClienteCalle
            // 
            tbClienteCalle.Location = new Point(3, 3);
            tbClienteCalle.Name = "tbClienteCalle";
            tbClienteCalle.Size = new Size(100, 23);
            tbClienteCalle.TabIndex = 5;
            tbClienteCalle.Tag = "Calle";
            tbClienteCalle.Leave += tbClienteDNI_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 200);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 8;
            label5.Text = "Num. Calle";
            // 
            // tbClienteNumCalle
            // 
            tbClienteNumCalle.Location = new Point(3, 3);
            tbClienteNumCalle.Name = "tbClienteNumCalle";
            tbClienteNumCalle.Size = new Size(100, 23);
            tbClienteNumCalle.TabIndex = 7;
            tbClienteNumCalle.Tag = "Numero Calle";
            tbClienteNumCalle.KeyPress += tbClienteDNI_KeyPress;
            tbClienteNumCalle.Leave += tbClienteDNI_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 73);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 10;
            label6.Text = "Cuit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 232);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 12;
            label7.Text = "Condición Fiscal";
            // 
            // tbClienteCondFisc
            // 
            tbClienteCondFisc.Location = new Point(3, 3);
            tbClienteCondFisc.Name = "tbClienteCondFisc";
            tbClienteCondFisc.Size = new Size(100, 23);
            tbClienteCondFisc.TabIndex = 11;
            tbClienteCondFisc.Tag = "Condición Fiscal";
            tbClienteCondFisc.KeyPress += tbClienteApe_KeyPress;
            tbClienteCondFisc.Leave += tbClienteDNI_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(72, 264);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 14;
            label8.Text = "Razón social";
            // 
            // tbClienteRazSoc
            // 
            tbClienteRazSoc.Location = new Point(3, 3);
            tbClienteRazSoc.Name = "tbClienteRazSoc";
            tbClienteRazSoc.Size = new Size(100, 23);
            tbClienteRazSoc.TabIndex = 13;
            tbClienteRazSoc.Tag = "Razón Social";
            tbClienteRazSoc.Leave += tbClienteDNI_Leave;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(178, 293);
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
            label1.Location = new Point(172, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 16;
            label1.Text = "Agregar Cliente";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(186, 347);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 25;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(73, 347);
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
            dvg.Location = new Point(297, 124);
            dvg.Name = "dvg";
            dvg.ReadOnly = true;
            dvg.RowTemplate.Height = 25;
            dvg.Size = new Size(1042, 193);
            dvg.TabIndex = 27;
            dvg.CellDoubleClick += dvg_CellDoubleClick;
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
            label10.Location = new Point(73, 41);
            label10.Name = "label10";
            label10.Size = new Size(27, 15);
            label10.TabIndex = 31;
            label10.Text = "DNI";
            // 
            // tbClienteDNI
            // 
            tbClienteDNI.Location = new Point(3, 3);
            tbClienteDNI.Name = "tbClienteDNI";
            tbClienteDNI.Size = new Size(100, 23);
            tbClienteDNI.TabIndex = 30;
            tbClienteDNI.Tag = "DNI";
            tbClienteDNI.KeyPress += tbClienteDNI_KeyPress;
            tbClienteDNI.Leave += tbClienteDNI_Leave;
            // 
            // tbClienteCuit
            // 
            tbClienteCuit.Location = new Point(3, 3);
            tbClienteCuit.Name = "tbClienteCuit";
            tbClienteCuit.Size = new Size(100, 23);
            tbClienteCuit.TabIndex = 32;
            tbClienteCuit.Tag = "Cuit";
            tbClienteCuit.KeyPress += tbClienteDNI_KeyPress;
            tbClienteCuit.Leave += tbClienteDNI_Leave;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(297, 347);
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
            btnVenta.Location = new Point(472, 323);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(111, 23);
            btnVenta.TabIndex = 35;
            btnVenta.Text = "Realizar venta";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // tbClienteDNIp
            // 
            tbClienteDNIp.Controls.Add(tbClienteDNI);
            tbClienteDNIp.Location = new Point(3, 3);
            tbClienteDNIp.Name = "tbClienteDNIp";
            tbClienteDNIp.Size = new Size(106, 29);
            tbClienteDNIp.TabIndex = 36;
            // 
            // tbClienteNumCallep
            // 
            tbClienteNumCallep.Controls.Add(tbClienteNumCalle);
            tbClienteNumCallep.Location = new Point(3, 162);
            tbClienteNumCallep.Name = "tbClienteNumCallep";
            tbClienteNumCallep.Size = new Size(106, 29);
            tbClienteNumCallep.TabIndex = 37;
            // 
            // tbClienteApep
            // 
            tbClienteApep.Controls.Add(tbClienteApe);
            tbClienteApep.Location = new Point(3, 99);
            tbClienteApep.Name = "tbClienteApep";
            tbClienteApep.Size = new Size(106, 29);
            tbClienteApep.TabIndex = 37;
            // 
            // tbClienteRazSocp
            // 
            tbClienteRazSocp.Controls.Add(tbClienteRazSoc);
            tbClienteRazSocp.Location = new Point(3, 226);
            tbClienteRazSocp.Name = "tbClienteRazSocp";
            tbClienteRazSocp.Size = new Size(106, 29);
            tbClienteRazSocp.TabIndex = 37;
            // 
            // tbClienteCondFiscp
            // 
            tbClienteCondFiscp.Controls.Add(tbClienteCondFisc);
            tbClienteCondFiscp.Location = new Point(3, 194);
            tbClienteCondFiscp.Name = "tbClienteCondFiscp";
            tbClienteCondFiscp.Size = new Size(106, 29);
            tbClienteCondFiscp.TabIndex = 38;
            // 
            // tbClienteCuitp
            // 
            tbClienteCuitp.Controls.Add(tbClienteCuit);
            tbClienteCuitp.Location = new Point(3, 35);
            tbClienteCuitp.Name = "tbClienteCuitp";
            tbClienteCuitp.Size = new Size(106, 29);
            tbClienteCuitp.TabIndex = 37;
            // 
            // tbClienteNomp
            // 
            tbClienteNomp.Controls.Add(tbClienteNom);
            tbClienteNomp.Location = new Point(3, 67);
            tbClienteNomp.Name = "tbClienteNomp";
            tbClienteNomp.Size = new Size(106, 29);
            tbClienteNomp.TabIndex = 37;
            // 
            // tbClienteCallep
            // 
            tbClienteCallep.Controls.Add(tbClienteCalle);
            tbClienteCallep.Location = new Point(3, 130);
            tbClienteCallep.Name = "tbClienteCallep";
            tbClienteCallep.Size = new Size(106, 29);
            tbClienteCallep.TabIndex = 37;
            // 
            // PanelControl
            // 
            PanelControl.Controls.Add(tbClienteDNIp);
            PanelControl.Controls.Add(tbClienteCallep);
            PanelControl.Controls.Add(tbClienteNumCallep);
            PanelControl.Controls.Add(tbClienteNomp);
            PanelControl.Controls.Add(tbClienteRazSocp);
            PanelControl.Controls.Add(tbClienteCuitp);
            PanelControl.Controls.Add(tbClienteApep);
            PanelControl.Controls.Add(tbClienteCondFiscp);
            PanelControl.Location = new Point(172, 32);
            PanelControl.Name = "PanelControl";
            PanelControl.Size = new Size(118, 256);
            PanelControl.TabIndex = 39;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(610, 70);
            label12.Name = "label12";
            label12.Size = new Size(123, 15);
            label12.TabIndex = 75;
            label12.Text = "Buscar con Cuit o DNI";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(789, 88);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 74;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(610, 88);
            tbBuscar.MaxLength = 11;
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(173, 23);
            tbBuscar.TabIndex = 73;
            tbBuscar.KeyPress += tbClienteDNI_KeyPress;
            // 
            // btnEmplDatos
            // 
            btnEmplDatos.BackColor = Color.Transparent;
            btnEmplDatos.BackgroundImage = (Image)resources.GetObject("btnEmplDatos.BackgroundImage");
            btnEmplDatos.Location = new Point(1181, 3);
            btnEmplDatos.Name = "btnEmplDatos";
            btnEmplDatos.Size = new Size(47, 53);
            btnEmplDatos.TabIndex = 76;
            btnEmplDatos.UseVisualStyleBackColor = false;
            btnEmplDatos.Click += btnEmplDatos_Click;
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
            Column5.HeaderText = "Condición fiscal";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Razón social";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 450);
            Controls.Add(btnEmplDatos);
            Controls.Add(label12);
            Controls.Add(btnBuscar);
            Controls.Add(tbBuscar);
            Controls.Add(btnVenta);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(label10);
            Controls.Add(cbTipo);
            Controls.Add(label9);
            Controls.Add(dvg);
            Controls.Add(btnBorrar);
            Controls.Add(btnActualizar);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PanelControl);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dvg).EndInit();
            tbClienteDNIp.ResumeLayout(false);
            tbClienteDNIp.PerformLayout();
            tbClienteNumCallep.ResumeLayout(false);
            tbClienteNumCallep.PerformLayout();
            tbClienteApep.ResumeLayout(false);
            tbClienteApep.PerformLayout();
            tbClienteRazSocp.ResumeLayout(false);
            tbClienteRazSocp.PerformLayout();
            tbClienteCondFiscp.ResumeLayout(false);
            tbClienteCondFiscp.PerformLayout();
            tbClienteCuitp.ResumeLayout(false);
            tbClienteCuitp.PerformLayout();
            tbClienteNomp.ResumeLayout(false);
            tbClienteNomp.PerformLayout();
            tbClienteCallep.ResumeLayout(false);
            tbClienteCallep.PerformLayout();
            PanelControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbClienteDNI;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
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
        private TextBox tbClienteCuit;
        private Button btnLimpiar;
        private Button btnVolver;
        private Button btnVenta;
        private Panel tbClienteDNIp;
        private Panel tbClienteNumCallep;
        private Panel tbClienteApep;
        private Panel tbClienteRazSocp;
        private Panel tbClienteCondFiscp;
        private Panel tbClienteCuitp;
        private Panel tbClienteNomp;
        private Panel tbClienteCallep;
        private Panel PanelControl;
        private Label label12;
        private Button btnBuscar;
        private TextBox tbBuscar;
        private Button btnEmplDatos;
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
    }
}
