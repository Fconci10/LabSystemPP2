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
using System.Runtime.InteropServices;

namespace LabSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "USUARIO")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "USUARIO";
                textBox1.ForeColor = Color.Red;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "CONTRASEÑA")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "CONTRASEÑA";
                textBox2.ForeColor = Color.Red;
                textBox2.UseSystemPasswordChar = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado;
            Usuario usuario = new Usuario();
            usuario.SetNombreUsuario(textBox1.Text);
            usuario.SetCalve(textBox2.Text);
            UsuarioNegocio Un = new UsuarioNegocio();
            resultado = Un.IngresoUsuario(usuario);
            if (resultado != 0)
            {
                MessageBox.Show("felicidades se encontro el usuario");
                EmpleadoNegocio Neg = new EmpleadoNegocio();
                Empleado empleado = Neg.GetUsuarioLogin(resultado);
                Neg.CargarTipo(empleado);
                Program.main.Hide();
                usuario.SetCodigo(resultado);
                if (empleado.GetTipoEmpleado()[0].Equals("encargado de ventas"))
                {
                    Form1 clientes = new Form1();
                    clientes.SetEmpleado(empleado, usuario);
                    clientes.Show();
                    LimpiarCampos();
                }
                else if (empleado.GetTipoEmpleado()[0].Equals("encargado de stock"))
                {
                    FormProveedores proveedores = new FormProveedores();
                    proveedores.SetEmpleado(empleado, usuario);
                    proveedores.Show();
                    LimpiarCampos();
                }
                LimpiarCampos();
            }
            else { MessageBox.Show("NO se encontro el usuario"); }
        }

        public void LimpiarCampos()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
