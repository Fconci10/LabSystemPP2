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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
            desHabilitar();
            CargarGrilla();
        }
        public int codProv = 0;
        public int codPer = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            FormProveedores fromprov = new FormProveedores();
            this.Close();
            fromprov.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccion();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void GuardarProducto()
        {

            int dia = dateTimePicker1.Value.Day;
            int mes = dateTimePicker1.Value.Month;
            int anio = dateTimePicker1.Value.Year;
            if (!camposVacios())
            {
                ProductoNegocio prdN = new ProductoNegocio();
                if (prdN.Unico(int.Parse(tbCodigo.Text)) == 1)
                {
                    Producto producto = new Producto();
                    decimal decimalCompra = 0;
                    decimalCompra = System.Convert.ToDecimal(tbPreCom.Text);
                    decimal decimalVenta = 0;
                    decimalVenta = System.Convert.ToDecimal(tbPrecVenta.Text);
                    producto.SetCodProducto(int.Parse(tbCodigo.Text));
                    producto.SetNombre(tbNombre.Text);
                    producto.SetDia(dia);
                    producto.SetMes(mes);
                    producto.SetAnio(anio);
                    producto.SetDescripcion(tbDesc.Text);
                    producto.SetPrecioCompra(decimalCompra);
                    producto.SetPrecioVenta(decimalVenta);
                    producto.SetCantidad(int.Parse(tbCantidad.Text));
                    producto.SetTipo(cbTipo.SelectedIndex);

                    int resultado = prdN.Insertar(producto, codProv, codPer);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ah cargado el Producto");
                        CargarGrilla();
                        Limpiar();
                    }
                    else { MessageBox.Show("Error al cargar el producto"); }
                }
                else { MessageBox.Show("El codigo del producto que esta intentando ingresar, ya existe en la base de datos"); }
            }
            else { MessageBox.Show("Hay campos vacios"); }
        }

        public void CargarGrilla()
        {
            this.dgv.Rows.Clear();
            ProductoNegocio prd = new ProductoNegocio();
            List<Producto> lista = new List<Producto>();
            lista = prd.ObtenerProductosProv(codProv);
            string tipo;

            foreach (Producto Producto in lista)
            {
                if (Producto.GetTipo() == 0)
                {
                    tipo = "Insumo";
                }
                else
                {
                    tipo = "Equipamiento";
                }
                string vencimiento = Producto.GetDia() + "/" + Producto.GetMes() + "/" + Producto.GetAnio();
                dgv.Rows.Add(
                Producto.GetCodProducto(),
                Producto.GetNombre(),
                vencimiento,
                Producto.GetDescripcion(),
                tipo,
                Producto.GetPrecioVenta(),
                Producto.GetPrecioCompra(),
                Producto.GetCantidad()
                );

            }
        }

        public void Seleccion()
        {
            tbCodigo.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            tbNombre.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            tbDesc.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            if (dgv.CurrentRow.Cells[4].Value.ToString().Equals("Insumo"))
            {
                cbTipo.SelectedIndex = 0;
            }
            else { cbTipo.SelectedIndex = 1; }
            tbPrecVenta.Text = dgv.CurrentRow.Cells[5].Value.ToString();
            tbPreCom.Text = dgv.CurrentRow.Cells[6].Value.ToString();
            tbCantidad.Text = dgv.CurrentRow.Cells[7].Value.ToString();

            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
        }

        public void Actualizar()
        {
            if (int.Parse(tbCodigo.Text) != int.Parse(dgv.CurrentRow.Cells[0].Value.ToString()))
            {
                string mensaje = "El codigo del campo producto no coinside con el codigo en la tabla, al aceptar no se actualizara el producr, sino que se creara una nuevo ¿desea crear un nuevo producto?";
                DialogResult res = MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    GuardarProducto();
                }
            }
            else if(!camposVacios())
            {
                int dia = dateTimePicker1.Value.Day;
                int mes = dateTimePicker1.Value.Month;
                int anio = dateTimePicker1.Value.Year;
                if (!camposVacios())
                {
                    Producto producto = new Producto();
                    producto.SetCodProducto(int.Parse(dgv.CurrentRow.Cells[0].Value.ToString()));
                    producto.SetNombre(tbNombre.Text);
                    producto.SetDia(dia);
                    producto.SetMes(mes);
                    producto.SetAnio(anio);
                    producto.SetDescripcion(tbDesc.Text);
                    producto.SetPrecioCompra(Decimal.Parse(tbPreCom.Text));
                    producto.SetPrecioVenta(Decimal.Parse(tbPrecVenta.Text));
                    producto.SetCantidad(int.Parse(tbCantidad.Text));
                    producto.SetTipo(cbTipo.SelectedIndex);

                    ProductoNegocio prdn = new ProductoNegocio();
                    prdn.Update(producto);
                    Limpiar();
                }
                CargarGrilla();
                desHabilitar();
            }
        }

        public void Borrar()
        {
            if (!tbCodigo.Text.Equals(""))
            {
                string mensaje = "Esta apunto de Borrar un producto, el producto ya no aparecera en las tablas, sin embargo el producto permanecera almacenado en la base de datos";
                DialogResult res = MessageBox.Show(mensaje, "Continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    ProductoNegocio prd = new ProductoNegocio();
                    int resultado = prd.BorrarProd(int.Parse(tbCodigo.Text));
                    if (resultado == -1)
                    {
                        MessageBox.Show("Se ah borrado el producto");
                        CargarGrilla();
                        Limpiar();
                        desHabilitar();
                    }
                    else { MessageBox.Show("Error al borrar el producto"); }
                }
            }
            else { MessageBox.Show("Agregue el codigo del producto a borrar"); }

        }

        public void desHabilitar()
        {
            tbCodigo.Enabled = false;
            tbNombre.Enabled = false;
            dateTimePicker1.Enabled = false;
            tbDesc.Enabled = false;
            tbPrecVenta.Enabled = false;
            tbPreCom.Enabled = false;
            tbCantidad.Enabled = false;
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
            btnLimp.Enabled = false;
        }

        public void habilitar()
        {
            tbCodigo.Enabled = true;
            tbNombre.Enabled = true;
            dateTimePicker1.Enabled = true;
            tbDesc.Enabled = true;
            tbPrecVenta.Enabled = true;
            tbPreCom.Enabled = true;
            tbCantidad.Enabled = true;
            btnAgregar.Enabled = true;
            btnLimp.Enabled = true;
        }

        public void Limpiar()
        {
            tbCodigo.Text = "";
            tbNombre.Text = "";
            tbDesc.Text = "";
            tbPreCom.Text = "";
            tbPrecVenta.Text = "";
            tbCantidad.Text = "";
            cbTipo.SelectedIndex = -1;
            desHabilitar();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitar();
        }

        private void tbCodigo_Leave(object sender, EventArgs e)
        {
            TextBox textBoxActual = (TextBox)sender;
            if (textBoxActual.Text.Equals(""))
            {
                MessageBox.Show("El campo " + textBoxActual.Tag + " se encuentra vacio");

                foreach (Control ctrl in PanelControl.Controls)
                {
                    if (ctrl is Panel && ctrl.Name == textBoxActual.Name + "p") { ctrl.BackColor = Color.Red; }
                }
            }
            else
            {
                foreach (Control ctrl in PanelControl.Controls)
                {
                    if (ctrl is Panel && ctrl.Name == textBoxActual.Name + "p") { ctrl.BackColor = Color.Transparent; }
                }
            }
        }

        public bool camposVacios()
        {
            bool vacio = false;

            foreach (Control ctrl in PanelControl.Controls)
            {
                if (ctrl is Panel && ctrl.HasChildren)
                {
                    Point p = new Point(3, 3);
                    if (ctrl.GetChildAtPoint(p).Text.Equals(""))
                    {
                        MessageBox.Show("El campo " + ctrl.GetChildAtPoint(p).Tag + " se encuentra vacio");
                        foreach (Control ctrl2 in PanelControl.Controls)
                        {
                            if (ctrl2 is Panel && ctrl2.Name == ctrl.GetChildAtPoint(p).Name + "p") { ctrl2.BackColor = Color.Red; }
                        }
                        vacio = true;
                    }

                }
            }
            return vacio;
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPrecVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
