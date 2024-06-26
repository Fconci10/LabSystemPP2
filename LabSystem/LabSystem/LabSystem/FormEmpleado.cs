using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;

namespace LabSystem
{
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
        {
            InitializeComponent();
        }
        Empleado empleado;
        Usuario usuario;
        string nomUsu = "";
        string clave = "";


        public void SetEmpleado(Empleado emp, Usuario usu) { this.empleado = emp; this.usuario = usu; }
        public void CargarDatos()
        {
            lblNombre.Text = empleado.getNombre();
            lblApellido.Text = empleado.getApellido();
            lblDni.Text = empleado.getDni().ToString();
            lblNom.Text = empleado.getNombre();
            lblApe.Text = empleado.getApellido();
            lblDireccion.Text = empleado.getNombreCalle() + " " + empleado.getNumCalle().ToString();
            lblCf.Text = empleado.getCondicionFiscal();
            lblNE.Text = empleado.GetEmpleadoID().ToString();
            lblHI.Text = empleado.GetHorariroIngreso();
            lblHE.Text = empleado.GetEmpleadoEgreso();
            List<string> lista = empleado.GetTipoEmpleado();
            foreach (string item in lista)
            {
                dgvPuestos.Rows.Add(item);
            }
            CargarUsuario(usuario);
        }
        private void CargarUsuario(Usuario usuario)
        {
            lblNumUsu.Text = usuario.GetCodigo().ToString();
            nomUsu = usuario.GetNombreUsuario().ToString();
            clave = usuario.GetClave().ToString();
            tbUsuario.Text = nomUsu;
            tbClave.Text = clave;
        }
        private void rbPersonal_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Name.Equals("rbPersonal"))
            {
                panelPersonal.Enabled = true;
                panelPersonal.Visible = true;
                panelEmpleado.Enabled = false;
                panelEmpleado.Visible = false;
                panelUsuario.Enabled = false;
                panelUsuario.Visible = false;
            }
            if (rb.Name.Equals("rbEmpleado"))
            {
                panelPersonal.Enabled = false;
                panelPersonal.Visible = false;
                panelEmpleado.Enabled = true;
                panelEmpleado.Visible = true;
                panelUsuario.Enabled = false;
                panelUsuario.Visible = false;
            }
            if (rb.Name.Equals("rbUsuario"))
            {
                panelPersonal.Enabled = false;
                panelPersonal.Visible = false;
                panelEmpleado.Enabled = false;
                panelEmpleado.Visible = false;
                panelUsuario.Enabled = true;
                panelUsuario.Visible = true;
                checkBox1.Checked = false;
                CargarUsuario(usuario);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbClave.Enabled = true;
                tbUsuario.Enabled = true;
                btnActualizar.Enabled = true;
            }
            else
            {
                tbClave.Enabled = false;
                tbUsuario.Enabled = false;
                btnActualizar.Enabled = false;
            }
        }

        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            TextBox textBoxActual = (TextBox)sender;
            if (textBoxActual.Text.Equals(""))
            {
                MessageBox.Show("El campo " + textBoxActual.Tag + " se encuentra vacio");

                foreach (Control ctrl in pCampoUsuario.Controls)
                {
                    if (ctrl is Panel && ctrl.Name == textBoxActual.Name + "P") { ctrl.BackColor = Color.Red; }
                }
            }
            else
            {
                foreach (Control ctrl in pCampoUsuario.Controls)
                {
                    if (ctrl is Panel && ctrl.Name == textBoxActual.Name + "P") { ctrl.BackColor = Color.Transparent; }
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!tbUsuario.Text.Equals("") && !tbClave.Text.Equals(""))
            {
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                usuario = usuarioNegocio.UsuarioUpdate(usuario.GetCodigo(), tbUsuario.Text, tbClave.Text);
                CargarUsuario(usuario);
            }
        }
    }
}
