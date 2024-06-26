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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadImage();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void LoadImage()
        {
            // Ruta de la imagen en tu sistema
            string imagePath = @"C:\Users\franc\OneDrive\Escritorio\imagen111.png";
            // Cargar la imagen en el PictureBox
            pictureBox1.Image = Image.FromFile(imagePath);
            // Opcional: ajustar el tamaño de la imagen
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.main.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            Program.main.Hide();
            FormProveedores formProveedores = new FormProveedores();
            formProveedores.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }
    }
}
