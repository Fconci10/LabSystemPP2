using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSystem
{
    public partial class FormVenta : Form
    {
        public FormVenta()
        {
            InitializeComponent();
            btnAgregar.Enabled = false;
            selecCantNum.Enabled = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        int cantidadMin = 0;
        int cantMinProd = 0;


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CargarDetalle();
        }
        public void CargarDetalle()
        {
            Decimal importe = (Decimal)dgvProductos.CurrentRow.Cells[3].Value * selecCantNum.Value;
            dgvDetalle.Rows.Add(
                dgvProductos.CurrentRow.Cells[0].Value.ToString(),
                dgvProductos.CurrentRow.Cells[1].Value.ToString(),
                selecCantNum.Value,//
                dgvProductos.CurrentRow.Cells[3].Value.ToString(),
                importe
            );
            SumarTotal();
            btnAgregar.Enabled = false;
            int idStock = int.Parse(dgvProductos.CurrentRow.Cells[5].Value.ToString());
            ActualizarStock(idStock);

            
            if ((int)dgvProductos.CurrentRow.Cells[2].Value==0) { 
                VentaNegocio vn =new VentaNegocio();
                vn.ProducAgotado(idStock);
            }
            CargarProd();


        }
        public void CargarProd()
        {
            this.dgvProductos.Rows.Clear();
            VentaNegocio vn = new VentaNegocio();
            List<Producto> productos = new List<Producto>();
            productos = vn.GetListado();

            foreach (Producto producto in productos)
            {
                Stock stock = vn.GetStock(producto.GetCodProducto());

                dgvProductos.Rows.Add(
                    producto.GetNombre(),
                    producto.GetDescripcion(),
                    stock.GetCantidad(),
                    producto.GetPrecioVenta(),
                    stock.GetCantidadMin(),
                    stock.GetIdStock()
                );
            }

        }

        public void ActualizarStock(int idStock)
        {
            VentaNegocio vn = new VentaNegocio();
            vn.ActuStock(idStock, (int)selecCantNum.Value);
            selecCantNum.Enabled = false;
            selecCantNum.Value = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 formCli = new Form1();
            this.Close();
            formCli.Show();
        }

        public void cantidadesStok()
        {
            btnAgregar.Enabled = true;
            selecCantNum.Enabled = true;
            cantidadMin = int.Parse(dgvProductos.CurrentRow.Cells[4].Value.ToString());
            selecCantNum.Maximum = int.Parse(dgvProductos.CurrentRow.Cells[2].Value.ToString());
            cantMinProd = int.Parse(selecCantNum.Maximum.ToString()) - cantidadMin;
        }

        private void selecCantNum_ValueChanged(object sender, EventArgs e)
        {
            CantiMin();
        }
        public void CantiMin()
        {
            if (selecCantNum.Value == cantMinProd)
            {
                MessageBox.Show("Se ah alcanzado es stock minimo");
            }
            else if (selecCantNum.Value == selecCantNum.Maximum) { MessageBox.Show("No se cuenta con mas cantidad de productos en stock"); }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            this.dgvDetalle.Rows.Clear();
            lblImporte.Visible = false;
            MessageBox.Show("Se han vendido los productos a "+lblNombre.Text);
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cantidadesStok();
        }

        public void SumarTotal() {
            Double total = 0;
            foreach (DataGridViewRow columnaImporte in dgvDetalle.Rows) {
                total += Convert.ToDouble(columnaImporte.Cells["Importe"].Value);
            }
            lblImporte.Text ="$"+total.ToString();
            lblImporte.Visible = true;
        }

        public void DatosCliente(string nombre,string direccion,string dniecuit,string cfrs) { 
            lblNombre.Text = nombre;
            lblDireccion.Text = direccion;
            lblDniCuit.Text = dniecuit;
            lblCf.Text = cfrs;
        }
    }
}
