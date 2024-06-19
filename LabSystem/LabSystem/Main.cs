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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
    }
}
