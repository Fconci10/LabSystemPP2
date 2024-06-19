namespace LabSystem
{
    partial class FormProductos
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
            lblNomProv = new Label();
            label2 = new Label();
            tbCodigo = new TextBox();
            tbNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tbDesc = new TextBox();
            label5 = new Label();
            tbPrecVenta = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dgv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            tbPreCom = new TextBox();
            label8 = new Label();
            button1 = new Button();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnBorrar = new Button();
            cbTipo = new ComboBox();
            label9 = new Label();
            tbCantidad = new TextBox();
            label10 = new Label();
            btnLimp = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 17);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Proveedor";
            // 
            // lblNomProv
            // 
            lblNomProv.AutoSize = true;
            lblNomProv.Location = new Point(213, 17);
            lblNomProv.Name = "lblNomProv";
            lblNomProv.Size = new Size(10, 15);
            lblNomProv.TabIndex = 1;
            lblNomProv.Text = ".";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 56);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 2;
            label2.Text = "Codigo del Producto";
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(180, 53);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(100, 23);
            tbCodigo.TabIndex = 3;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(180, 82);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 85);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre del Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 114);
            label4.Name = "label4";
            label4.Size = new Size(123, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha de vencimiento";
            // 
            // tbDesc
            // 
            tbDesc.Location = new Point(180, 140);
            tbDesc.Multiline = true;
            tbDesc.Name = "tbDesc";
            tbDesc.Size = new Size(300, 47);
            tbDesc.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 144);
            label5.Name = "label5";
            label5.Size = new Size(140, 15);
            label5.TabIndex = 8;
            label5.Text = "Descripcion del Producto";
            // 
            // tbPrecVenta
            // 
            tbPrecVenta.Location = new Point(180, 193);
            tbPrecVenta.Name = "tbPrecVenta";
            tbPrecVenta.Size = new Size(100, 23);
            tbPrecVenta.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 196);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 10;
            label6.Text = "Precio de Venta";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.ImeMode = ImeMode.Alpha;
            dateTimePicker1.Location = new Point(180, 111);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(222, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column7, Column6, Column5, Column8 });
            dgv.Location = new Point(12, 382);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(943, 150);
            dgv.TabIndex = 18;
            dgv.CellDoubleClick += dgv_CellDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Codigo";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Vencimiento";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Descripcion";
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column7
            // 
            Column7.HeaderText = "Tipo";
            Column7.Name = "Column7";
            // 
            // Column6
            // 
            Column6.HeaderText = "Precio de venta";
            Column6.Name = "Column6";
            // 
            // Column5
            // 
            Column5.HeaderText = "Precio de compra";
            Column5.Name = "Column5";
            // 
            // Column8
            // 
            Column8.HeaderText = "Cantidad";
            Column8.Name = "Column8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 351);
            label7.Name = "label7";
            label7.Size = new Size(158, 15);
            label7.TabIndex = 19;
            label7.Text = "Productos de este Proveedor";
            // 
            // tbPreCom
            // 
            tbPreCom.Location = new Point(180, 222);
            tbPreCom.Name = "tbPreCom";
            tbPreCom.Size = new Size(100, 23);
            tbPreCom.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(72, 225);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 20;
            label8.Text = "Precio de Compra";
            // 
            // button1
            // 
            button1.Location = new Point(878, 17);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(296, 253);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(393, 252);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 24;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(493, 252);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 25;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Insumo", "Equipamiento" });
            cbTipo.Location = new Point(359, 53);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(121, 23);
            cbTipo.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(296, 55);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 27;
            label9.Text = "Tipo";
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(180, 251);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.Size = new Size(100, 23);
            tbCantidad.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(119, 254);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 28;
            label10.Text = "Cantidad";
            // 
            // btnLimp
            // 
            btnLimp.Location = new Point(296, 302);
            btnLimp.Name = "btnLimp";
            btnLimp.Size = new Size(106, 23);
            btnLimp.TabIndex = 30;
            btnLimp.Text = "Vaciar campos";
            btnLimp.UseVisualStyleBackColor = true;
            btnLimp.Click += btnLimp_Click;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 554);
            Controls.Add(btnLimp);
            Controls.Add(tbCantidad);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(cbTipo);
            Controls.Add(btnBorrar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(button1);
            Controls.Add(tbPreCom);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dgv);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbPrecVenta);
            Controls.Add(label6);
            Controls.Add(tbDesc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbNombre);
            Controls.Add(label3);
            Controls.Add(tbCodigo);
            Controls.Add(label2);
            Controls.Add(lblNomProv);
            Controls.Add(label1);
            Name = "FormProductos";
            Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNomProv;
        private Label label2;
        private TextBox tbCodigo;
        private TextBox tbNombre;
        private Label label3;
        private Label label4;
        private TextBox tbDesc;
        private Label label5;
        private TextBox tbPrecVenta;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgv;
        private Label label7;
        private TextBox tbPreCom;
        private Label label8;
        private Button button1;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnBorrar;
        private ComboBox cbTipo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private Label label9;
        private TextBox tbCantidad;
        private Label label10;
        private DataGridViewTextBoxColumn Column8;
        private Button btnLimp;
    }
}