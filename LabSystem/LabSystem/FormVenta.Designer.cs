namespace LabSystem
{
    partial class FormVenta
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
            lblDireccion = new Label();
            lblDniCuit = new Label();
            lblCf = new Label();
            selecCantNum = new NumericUpDown();
            btnAgregar = new Button();
            dgvDetalle = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Importe = new DataGridViewTextBoxColumn();
            label2 = new Label();
            lblImporte = new Label();
            btnVender = new Button();
            dgvProductos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)selecCantNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(155, 22);
            label1.TabIndex = 0;
            label1.Text = "Datos del Cliente";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(12, 82);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(60, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.Location = new Point(12, 112);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(70, 17);
            lblDireccion.TabIndex = 2;
            lblDireccion.Text = "Direccion";
            // 
            // lblDniCuit
            // 
            lblDniCuit.AutoSize = true;
            lblDniCuit.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDniCuit.Location = new Point(12, 140);
            lblDniCuit.Name = "lblDniCuit";
            lblDniCuit.Size = new Size(32, 17);
            lblDniCuit.TabIndex = 3;
            lblDniCuit.Text = "DNI";
            // 
            // lblCf
            // 
            lblCf.AutoSize = true;
            lblCf.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCf.Location = new Point(12, 168);
            lblCf.Name = "lblCf";
            lblCf.Size = new Size(116, 17);
            lblCf.TabIndex = 4;
            lblCf.Text = "Condicion Fiscal";
            // 
            // selecCantNum
            // 
            selecCantNum.Location = new Point(634, 96);
            selecCantNum.Name = "selecCantNum";
            selecCantNum.Size = new Size(68, 23);
            selecCantNum.TabIndex = 6;
            selecCantNum.ValueChanged += selecCantNum_ValueChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(553, 191);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4, Column5, Column6, Importe });
            dgvDetalle.Location = new Point(12, 276);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.Size = new Size(616, 150);
            dgvDetalle.TabIndex = 8;
            // 
            // Column3
            // 
            Column3.HeaderText = "Nombre";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 120;
            // 
            // Column4
            // 
            Column4.HeaderText = "Descripcion";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 120;
            // 
            // Column5
            // 
            Column5.HeaderText = "Cantidad";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 120;
            // 
            // Column6
            // 
            Column6.HeaderText = "Precio Unitario";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 120;
            // 
            // Importe
            // 
            Importe.HeaderText = "Importe";
            Importe.Name = "Importe";
            Importe.ReadOnly = true;
            Importe.Width = 120;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(445, 452);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 9;
            label2.Text = "Total";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblImporte.Location = new Point(530, 452);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(81, 29);
            lblImporte.TabIndex = 10;
            lblImporte.Text = "label3";
            lblImporte.Visible = false;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(12, 522);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(125, 23);
            btnVender.TabIndex = 11;
            btnVender.Text = "Realizar venta";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Column1, Column2 });
            dgvProductos.Location = new Point(224, 76);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(404, 109);
            dgvProductos.TabIndex = 12;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Precio Unitario";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 120;
            // 
            // Column1
            // 
            Column1.HeaderText = "cantMin";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "idStock";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(645, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 579);
            Controls.Add(btnVolver);
            Controls.Add(dgvProductos);
            Controls.Add(btnVender);
            Controls.Add(lblImporte);
            Controls.Add(label2);
            Controls.Add(dgvDetalle);
            Controls.Add(btnAgregar);
            Controls.Add(selecCantNum);
            Controls.Add(lblCf);
            Controls.Add(lblDniCuit);
            Controls.Add(lblDireccion);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Name = "FormVenta";
            Text = "FormVenta";
            ((System.ComponentModel.ISupportInitialize)selecCantNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNombre;
        private Label lblDireccion;
        private Label lblDniCuit;
        private Label lblCf;
        private NumericUpDown selecCantNum;
        private Button btnAgregar;
        private DataGridView dgvDetalle;
        private Label label2;
        private Label lblImporte;
        private Button btnVender;
        private DataGridView dgvProductos;
        private Button btnVolver;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Importe;
    }
}