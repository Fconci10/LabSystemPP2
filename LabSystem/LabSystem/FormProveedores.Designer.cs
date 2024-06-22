namespace LabSystem
{
    partial class FormProveedores
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
            btnLimpiar = new Button();
            tbProveedorCuit = new TextBox();
            label10 = new Label();
            tbProveedorDNI = new TextBox();
            cbTipo = new ComboBox();
            label9 = new Label();
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
            Column11 = new DataGridViewTextBoxColumn();
            btnBorrar = new Button();
            btnActualizar = new Button();
            label1 = new Label();
            btnAgregar = new Button();
            label8 = new Label();
            tbProveedorRazSoc = new TextBox();
            label7 = new Label();
            tbProveedorCondFisc = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tbProveedorNumCalle = new TextBox();
            label4 = new Label();
            tbProveedorCalle = new TextBox();
            label3 = new Label();
            tbProveedorApe = new TextBox();
            label2 = new Label();
            tbProveedorNom = new TextBox();
            label11 = new Label();
            tbProveedorDesc = new TextBox();
            btnVolver = new Button();
            btnVerProd = new Button();
            tbProveedorDNIp = new Panel();
            tbProveedorRazSocp = new Panel();
            tbProveedorNumCallep = new Panel();
            tbProveedorCallep = new Panel();
            tbProveedorApep = new Panel();
            tbProveedorDescp = new Panel();
            tbProveedorNomp = new Panel();
            tbProveedorCuitp = new Panel();
            tbProveedorCondFiscp = new Panel();
            PanelControl = new Panel();
            domainUpDown1 = new DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)dvg).BeginInit();
            tbProveedorDNIp.SuspendLayout();
            tbProveedorRazSocp.SuspendLayout();
            tbProveedorNumCallep.SuspendLayout();
            tbProveedorCallep.SuspendLayout();
            tbProveedorApep.SuspendLayout();
            tbProveedorDescp.SuspendLayout();
            tbProveedorNomp.SuspendLayout();
            tbProveedorCuitp.SuspendLayout();
            tbProveedorCondFiscp.SuspendLayout();
            PanelControl.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(289, 373);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 57;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // tbProveedorCuit
            // 
            tbProveedorCuit.Location = new Point(2, 2);
            tbProveedorCuit.Name = "tbProveedorCuit";
            tbProveedorCuit.Size = new Size(100, 23);
            tbProveedorCuit.TabIndex = 56;
            tbProveedorCuit.Tag = "Cuit";
            tbProveedorCuit.KeyPress += tbProveedorDNI_KeyPress;
            tbProveedorCuit.Leave += tbProveedorDNI_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 65);
            label10.Name = "label10";
            label10.Size = new Size(27, 15);
            label10.TabIndex = 55;
            label10.Text = "DNI";
            // 
            // tbProveedorDNI
            // 
            tbProveedorDNI.Location = new Point(2, 2);
            tbProveedorDNI.Name = "tbProveedorDNI";
            tbProveedorDNI.Size = new Size(100, 23);
            tbProveedorDNI.TabIndex = 54;
            tbProveedorDNI.Tag = "DNI";
            tbProveedorDNI.KeyPress += tbProveedorDNI_KeyPress;
            tbProveedorDNI.Leave += tbProveedorDNI_Leave;
            // 
            // cbTipo
            // 
            cbTipo.DisplayMember = "1 2";
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Persona", "Empresa" });
            cbTipo.Location = new Point(382, 25);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(87, 23);
            cbTipo.TabIndex = 53;
            cbTipo.SelectedIndexChanged += cbTipo_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(289, 28);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 52;
            label9.Text = "Tipo Cliente";
            // 
            // dvg
            // 
            dvg.AllowUserToAddRows = false;
            dvg.AllowUserToDeleteRows = false;
            dvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg.Columns.AddRange(new DataGridViewColumn[] { Column1, Column10, Column9, Column4, Column2, Column3, Column7, Column8, Column5, Column6, idPer, Column11 });
            dvg.Location = new Point(260, 94);
            dvg.Name = "dvg";
            dvg.ReadOnly = true;
            dvg.RowTemplate.Height = 25;
            dvg.Size = new Size(1042, 150);
            dvg.TabIndex = 51;
            dvg.CellDoubleClick += dvg_CellDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID Proveedor";
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
            // Column11
            // 
            Column11.HeaderText = "desc";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(284, 258);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 50;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(384, 258);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 49;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 33);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 48;
            label1.Text = "Agregar Cliente";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(142, 373);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 23);
            btnAgregar.TabIndex = 47;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 272);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 46;
            label8.Text = "Razon Social";
            // 
            // tbProveedorRazSoc
            // 
            tbProveedorRazSoc.Location = new Point(2, 2);
            tbProveedorRazSoc.Name = "tbProveedorRazSoc";
            tbProveedorRazSoc.Size = new Size(100, 23);
            tbProveedorRazSoc.TabIndex = 45;
            tbProveedorRazSoc.Tag = "Razón social";
            tbProveedorRazSoc.Leave += tbProveedorDNI_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 244);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 44;
            label7.Text = "Condicion Fiscal";
            // 
            // tbProveedorCondFisc
            // 
            tbProveedorCondFisc.Location = new Point(2, 2);
            tbProveedorCondFisc.Name = "tbProveedorCondFisc";
            tbProveedorCondFisc.Size = new Size(100, 23);
            tbProveedorCondFisc.TabIndex = 43;
            tbProveedorCondFisc.Tag = "Condición Fiscal";
            tbProveedorCondFisc.KeyPress += tbProveedorApe_KeyPress;
            tbProveedorCondFisc.Leave += tbProveedorDNI_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 97);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 42;
            label6.Text = "Cuit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 213);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 41;
            label5.Text = "Num. Calle";
            // 
            // tbProveedorNumCalle
            // 
            tbProveedorNumCalle.Location = new Point(2, 2);
            tbProveedorNumCalle.Name = "tbProveedorNumCalle";
            tbProveedorNumCalle.Size = new Size(100, 23);
            tbProveedorNumCalle.TabIndex = 40;
            tbProveedorNumCalle.Tag = "Numero Calle";
            tbProveedorNumCalle.KeyPress += tbProveedorDNI_KeyPress;
            tbProveedorNumCalle.Leave += tbProveedorDNI_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 184);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 39;
            label4.Text = "Calle";
            // 
            // tbProveedorCalle
            // 
            tbProveedorCalle.Location = new Point(2, 2);
            tbProveedorCalle.Name = "tbProveedorCalle";
            tbProveedorCalle.Size = new Size(100, 23);
            tbProveedorCalle.TabIndex = 38;
            tbProveedorCalle.Tag = "Calle";
            tbProveedorCalle.Leave += tbProveedorDNI_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 155);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 37;
            label3.Text = "Apellido";
            // 
            // tbProveedorApe
            // 
            tbProveedorApe.Location = new Point(2, 2);
            tbProveedorApe.Name = "tbProveedorApe";
            tbProveedorApe.Size = new Size(100, 23);
            tbProveedorApe.TabIndex = 36;
            tbProveedorApe.Tag = "Apellido";
            tbProveedorApe.KeyPress += tbProveedorApe_KeyPress;
            tbProveedorApe.Leave += tbProveedorDNI_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 126);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 35;
            label2.Text = "Nombre";
            // 
            // tbProveedorNom
            // 
            tbProveedorNom.Location = new Point(2, 2);
            tbProveedorNom.Name = "tbProveedorNom";
            tbProveedorNom.Size = new Size(100, 23);
            tbProveedorNom.TabIndex = 34;
            tbProveedorNom.Tag = "Nombre";
            tbProveedorNom.Leave += tbProveedorDNI_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(40, 322);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 58;
            label11.Text = "Descripcion";
            // 
            // tbProveedorDesc
            // 
            tbProveedorDesc.Location = new Point(2, 2);
            tbProveedorDesc.Multiline = true;
            tbProveedorDesc.Name = "tbProveedorDesc";
            tbProveedorDesc.Size = new Size(217, 50);
            tbProveedorDesc.TabIndex = 59;
            tbProveedorDesc.Tag = "Descripción";
            tbProveedorDesc.Leave += tbProveedorDNI_Leave;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(1201, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 60;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnVerProd
            // 
            btnVerProd.Location = new Point(557, 268);
            btnVerProd.Name = "btnVerProd";
            btnVerProd.Size = new Size(197, 23);
            btnVerProd.TabIndex = 61;
            btnVerProd.Text = "Ver productos del proveedor";
            btnVerProd.UseVisualStyleBackColor = true;
            btnVerProd.Click += button1_Click;
            // 
            // tbProveedorDNIp
            // 
            tbProveedorDNIp.BackColor = Color.Transparent;
            tbProveedorDNIp.Controls.Add(tbProveedorDNI);
            tbProveedorDNIp.Location = new Point(9, 10);
            tbProveedorDNIp.Name = "tbProveedorDNIp";
            tbProveedorDNIp.Size = new Size(104, 28);
            tbProveedorDNIp.TabIndex = 62;
            // 
            // tbProveedorRazSocp
            // 
            tbProveedorRazSocp.BackColor = Color.Transparent;
            tbProveedorRazSocp.Controls.Add(tbProveedorRazSoc);
            tbProveedorRazSocp.Location = new Point(9, 220);
            tbProveedorRazSocp.Name = "tbProveedorRazSocp";
            tbProveedorRazSocp.Size = new Size(104, 28);
            tbProveedorRazSocp.TabIndex = 63;
            // 
            // tbProveedorNumCallep
            // 
            tbProveedorNumCallep.BackColor = Color.Transparent;
            tbProveedorNumCallep.Controls.Add(tbProveedorNumCalle);
            tbProveedorNumCallep.Location = new Point(9, 158);
            tbProveedorNumCallep.Name = "tbProveedorNumCallep";
            tbProveedorNumCallep.Size = new Size(104, 28);
            tbProveedorNumCallep.TabIndex = 65;
            // 
            // tbProveedorCallep
            // 
            tbProveedorCallep.BackColor = Color.Transparent;
            tbProveedorCallep.Controls.Add(tbProveedorCalle);
            tbProveedorCallep.Location = new Point(9, 129);
            tbProveedorCallep.Name = "tbProveedorCallep";
            tbProveedorCallep.Size = new Size(104, 28);
            tbProveedorCallep.TabIndex = 65;
            // 
            // tbProveedorApep
            // 
            tbProveedorApep.BackColor = Color.Transparent;
            tbProveedorApep.Controls.Add(tbProveedorApe);
            tbProveedorApep.Location = new Point(9, 100);
            tbProveedorApep.Name = "tbProveedorApep";
            tbProveedorApep.Size = new Size(104, 28);
            tbProveedorApep.TabIndex = 65;
            // 
            // tbProveedorDescp
            // 
            tbProveedorDescp.BackColor = Color.Transparent;
            tbProveedorDescp.Controls.Add(tbProveedorDesc);
            tbProveedorDescp.Location = new Point(9, 254);
            tbProveedorDescp.Name = "tbProveedorDescp";
            tbProveedorDescp.Size = new Size(221, 54);
            tbProveedorDescp.TabIndex = 66;
            // 
            // tbProveedorNomp
            // 
            tbProveedorNomp.BackColor = Color.Transparent;
            tbProveedorNomp.Controls.Add(tbProveedorNom);
            tbProveedorNomp.Location = new Point(9, 71);
            tbProveedorNomp.Name = "tbProveedorNomp";
            tbProveedorNomp.Size = new Size(104, 28);
            tbProveedorNomp.TabIndex = 67;
            // 
            // tbProveedorCuitp
            // 
            tbProveedorCuitp.BackColor = Color.Transparent;
            tbProveedorCuitp.Controls.Add(tbProveedorCuit);
            tbProveedorCuitp.Location = new Point(9, 42);
            tbProveedorCuitp.Name = "tbProveedorCuitp";
            tbProveedorCuitp.Size = new Size(104, 28);
            tbProveedorCuitp.TabIndex = 65;
            // 
            // tbProveedorCondFiscp
            // 
            tbProveedorCondFiscp.BackColor = Color.Transparent;
            tbProveedorCondFiscp.Controls.Add(tbProveedorCondFisc);
            tbProveedorCondFiscp.Location = new Point(9, 189);
            tbProveedorCondFiscp.Name = "tbProveedorCondFiscp";
            tbProveedorCondFiscp.Size = new Size(104, 28);
            tbProveedorCondFiscp.TabIndex = 68;
            // 
            // PanelControl
            // 
            PanelControl.Controls.Add(tbProveedorDescp);
            PanelControl.Controls.Add(tbProveedorDNIp);
            PanelControl.Controls.Add(tbProveedorRazSocp);
            PanelControl.Controls.Add(tbProveedorCondFiscp);
            PanelControl.Controls.Add(tbProveedorNumCallep);
            PanelControl.Controls.Add(tbProveedorCallep);
            PanelControl.Controls.Add(tbProveedorApep);
            PanelControl.Controls.Add(tbProveedorNomp);
            PanelControl.Controls.Add(tbProveedorCuitp);
            PanelControl.Location = new Point(138, 50);
            PanelControl.Name = "PanelControl";
            PanelControl.Size = new Size(240, 317);
            PanelControl.TabIndex = 69;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 450);
            Controls.Add(domainUpDown1);
            Controls.Add(btnVerProd);
            Controls.Add(btnVolver);
            Controls.Add(label11);
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
            Name = "FormProveedores";
            Text = "FormProveedores";
            ((System.ComponentModel.ISupportInitialize)dvg).EndInit();
            tbProveedorDNIp.ResumeLayout(false);
            tbProveedorDNIp.PerformLayout();
            tbProveedorRazSocp.ResumeLayout(false);
            tbProveedorRazSocp.PerformLayout();
            tbProveedorNumCallep.ResumeLayout(false);
            tbProveedorNumCallep.PerformLayout();
            tbProveedorCallep.ResumeLayout(false);
            tbProveedorCallep.PerformLayout();
            tbProveedorApep.ResumeLayout(false);
            tbProveedorApep.PerformLayout();
            tbProveedorDescp.ResumeLayout(false);
            tbProveedorDescp.PerformLayout();
            tbProveedorNomp.ResumeLayout(false);
            tbProveedorNomp.PerformLayout();
            tbProveedorCuitp.ResumeLayout(false);
            tbProveedorCuitp.PerformLayout();
            tbProveedorCondFiscp.ResumeLayout(false);
            tbProveedorCondFiscp.PerformLayout();
            PanelControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private TextBox tbProveedorCuit;
        private Label label10;
        private TextBox tbProveedorDNI;
        private ComboBox cbTipo;
        private Label label9;
        private DataGridView dvg;
        private Button btnBorrar;
        private Button btnActualizar;
        private Label label1;
        private Button btnAgregar;
        private Label label8;
        private TextBox tbProveedorRazSoc;
        private Label label7;
        private TextBox tbProveedorCondFisc;
        private Label label6;
        private Label label5;
        private TextBox tbProveedorNumCalle;
        private Label label4;
        private TextBox tbProveedorCalle;
        private Label label3;
        private TextBox tbProveedorApe;
        private Label label2;
        private TextBox tbProveedorNom;
        private Label label11;
        private TextBox tbProveedorDesc;
        private Button btnVolver;
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
        private DataGridViewTextBoxColumn Column11;
        private Button btnVerProd;
        private Panel tbProveedorDNIp;
        private Panel tbProveedorRazSocp;
        private Panel tbProveedorNumCallep;
        private Panel tbProveedorCallep;
        private Panel tbProveedorApep;
        private Panel tbProveedorDescp;
        private Panel tbProveedorNomp;
        private Panel tbProveedorCuitp;
        private Panel tbProveedorCondFiscp;
        private Panel PanelControl;
        private DomainUpDown domainUpDown1;
    }
}