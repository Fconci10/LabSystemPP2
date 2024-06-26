using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSystem
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
            desHabilitar();
            CargarTodo();
        }
        int idProveedor = 0;
        int idPersona = 0;
        Empleado empleado;
        Usuario usuario;

        //Botones
        private void btnAgregar_Click(object sender, EventArgs e) //boton para agregar Proveedor
        {
            Guardar();//metodo para agregar Proveedor
        }

        //al darle doble clic a un Proveedor en la tabla
        private void dvg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecProveedor();//metodo que toma los datos del Proveedor al que se le dio doble clic
        }
        private void btnActualizar_Click_1(object sender, EventArgs e)//boton para actualizar Proveedo
        {
            Actualizar();// metodo para actualizar Proveedor
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)//boton para borrar Proveedor
        {
            Borrar();//metodo para borrar Proveedor
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecTipoPro();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)//boton para limpiar todos los campos
        {
            LimpiarDatos();//metodo para limpiar todos los campos
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.main.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)//boton para buscar al proveedor
        {
            ValidarBusqueda();
        }

        private void btnEmplDatos_Click(object sender, EventArgs e)
        {
            VerDatosEmpleado();
        }

        //Metodos

        public void Guardar() //metodo para agregar Proveedor
        {
            if (!camposVacios())
            {
                //int cargar = 0;//la variable cargar aumenta cada vez que un campo no este vacio
                long cuit = 0;
                int numCalle = 0;
                int dni = 0;
                int resultadoP = 0;
                int resultadoPr = 0;
                Proveedor Proveedor = new Proveedor();//objeto de la clase Proveedor que se va a cargar en la bd

                if (tbProveedorCuit.Enabled)
                {
                    cuit = (long)Convert.ToDouble(tbProveedorCuit.Text);
                    Proveedor.setCuit(cuit);
                }
                else
                {
                    dni = int.Parse(tbProveedorDNI.Text);
                    Proveedor.setDni(dni);
                }

                //agrego el contenido del tbNombre al atributo nombre del Proveedor
                Proveedor.setNombre(tbProveedorNom.Text);

                if (tbProveedorApe.Enabled) { Proveedor.setApellido(tbProveedorApe.Text); }

                //agrego el contenido del tbCalle al atributo nombre calle del Proveedor
                Proveedor.setNombreCalle(tbProveedorCalle.Text);

                numCalle = int.Parse(tbProveedorNumCalle.Text);
                Proveedor.setNumCalle(numCalle);

                if (tbProveedorCondFisc.Enabled) { Proveedor.setCondicionFiscal(tbProveedorCondFisc.Text); }
                else { Proveedor.SetRazonSocial(tbProveedorRazSoc.Text); }


                //agrego el contenido del tbDesc al atributo descripcion del Proveedor
                Proveedor.SetDescripcion(tbProveedorDesc.Text);

                PersonaNegocio personaNegocio = new PersonaNegocio();
                long resultado = personaNegocio.unicaP(Proveedor);

                if (personaNegocio.unicaP(Proveedor) == 1)
                {
                    Proveedor.setTipo(cbTipo.SelectedIndex);

                    //Se insertan los datos del proveedor que corresponden a la tabla persona
                    //osea se insertan datos en la tabla pesona
                    //ya que la clase proveedor hereda atributos de la clase persona
                    //y esto retorna el codigo de la persona de la base de datos
                    resultadoP = personaNegocio.Insertar(Proveedor);

                    //para relacionar las tablas Proveedor y persona, le agrego clase Proveedor
                    //el codigo de persona llamando al metodo setCodPersona heredado de Persona
                    Proveedor.setCodPersona(resultadoP);

                    //hago el insert en la tabla proveedor con los datos completos del proveedor,
                    //incluyendo su codigo persona de esta manera relacionando las tablas proveedor y persona
                    ProveedorNegocio prn = new ProveedorNegocio();
                    resultadoPr = prn.Insertar(Proveedor);

                }
                if (resultadoP > 0 && resultadoPr > 0)
                {
                    LimpiarDatos();
                    MessageBox.Show("Se ha registrado un nuevo Proveedor");
                }
                else
                {
                    MessageBox.Show("ERROR al registrar un nuevo Proveedor");
                }
            }
        }

        public void CargarTodo()//metodo para cargar los cProveedor en la tabla
        {
            ProveedorNegocio prn = new ProveedorNegocio();
            List<Proveedor> lista = new List<Proveedor>();
            lista = prn.RecibirTodos();
            string tipo, dni, cuit;

            foreach (Proveedor Proveedor in lista)
            {
                if (Proveedor.getTipo() == 0)
                {
                    tipo = "Persona";
                }
                else
                {
                    tipo = "Empresa";
                }

                if (Proveedor.getDni() == 0) { dni = ""; } else { dni = Proveedor.getDni().ToString(); }
                if (Proveedor.getCuit() == 0) { cuit = ""; } else { cuit = Proveedor.getCuit().ToString(); }
                dvg.Rows.Add(
                Proveedor.GetCodProveedor(),
                tipo,
                dni,
                cuit,
                Proveedor.getNombre(),
                Proveedor.getApellido(),
                Proveedor.getNombreCalle(),
                Proveedor.getNumCalle(),
                Proveedor.getCondicionFiscal(),
                Proveedor.GetRazonSocial(),
                Proveedor.getCodPersona(),
                Proveedor.GetDescripcion()
                );
            }
        }

        public void SelecProveedor()//metodo para seleccionar un Proveedor de la tabla
        {
            idProveedor = int.Parse(dvg.CurrentRow.Cells[0].Value.ToString());
            if (dvg.CurrentRow.Cells[1].Value.ToString().Equals("Persona")) { cbTipo.SelectedIndex = 0; } else { cbTipo.SelectedIndex = 1; }
            tbProveedorDNI.Text = dvg.CurrentRow.Cells[2].Value.ToString();
            tbProveedorCuit.Text = dvg.CurrentRow.Cells[3].Value.ToString();
            tbProveedorNom.Text = dvg.CurrentRow.Cells[4].Value.ToString();
            tbProveedorApe.Text = dvg.CurrentRow.Cells[5].Value.ToString();
            tbProveedorCalle.Text = dvg.CurrentRow.Cells[6].Value.ToString();
            tbProveedorNumCalle.Text = dvg.CurrentRow.Cells[7].Value.ToString();
            tbProveedorCondFisc.Text = dvg.CurrentRow.Cells[8].Value.ToString();
            tbProveedorRazSoc.Text = dvg.CurrentRow.Cells[9].Value.ToString();
            idPersona = int.Parse(dvg.CurrentRow.Cells[10].Value.ToString());
            tbProveedorDesc.Text = dvg.CurrentRow.Cells[11].Value.ToString();
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            btnVerProd.Enabled = true;
        }

        public void SelecTipoPro()//metodo para seleccionar el tipo de Proveedor
        {
            desHabilitarRojo();
            habilitar();
            int seleccion = cbTipo.SelectedIndex;
            if (seleccion == 0)//segun el tipo de Proveedor se habilitan algunos campos, 0 es persona 1 es empresa
            {
                tbProveedorCuit.Enabled = false;
                tbProveedorRazSoc.Enabled = false;
                tbProveedorCuit.Text = "";
                tbProveedorRazSoc.Text = "";
                tbProveedorDNI.Enabled = true;
                tbProveedorApe.Enabled = true;
            }
            else
            {
                tbProveedorCuit.Enabled = true;
                tbProveedorRazSoc.Enabled = true;
                tbProveedorDNI.Enabled = false;
                tbProveedorCondFisc.Enabled = false;
                tbProveedorApe.Enabled = false;
                tbProveedorDNI.Text = "";
                tbProveedorCondFisc.Text = "";
                tbProveedorApe.Text = "";
            }
        }

        public void Actualizar()//metodo para actualizar cProveedor
        {
            if (idProveedor != 0 && !camposVacios())
            {
                long cuit = 0;
                int dni = 0;
                int numCalle = 0;
                Proveedor Proveedor = new Proveedor();//objeto de la clase cliente que se va a cargar en la bd

                if (cbTipo.SelectedIndex == 0)
                {
                    if (tbProveedorCuit.Enabled)
                    {
                        cuit = (long)Convert.ToDouble(tbProveedorCuit.Text);
                        Proveedor.setCuit(cuit);
                    }
                    else
                    {
                        dni = int.Parse(tbProveedorDNI.Text);
                        Proveedor.setDni(dni);
                    }

                    //agrego el contenido del tbNombre al atributo nombre del Proveedor
                    Proveedor.setNombre(tbProveedorNom.Text);

                    if (tbProveedorApe.Enabled) { Proveedor.setApellido(tbProveedorApe.Text); }

                    //agrego el contenido del tbCalle al atributo nombre calle del Proveedor
                    Proveedor.setNombreCalle(tbProveedorCalle.Text);

                    numCalle = int.Parse(tbProveedorNumCalle.Text);
                    Proveedor.setNumCalle(numCalle);

                    if (tbProveedorCondFisc.Enabled) { Proveedor.setCondicionFiscal(tbProveedorCondFisc.Text); }
                    else { Proveedor.SetRazonSocial(tbProveedorRazSoc.Text); }


                    //agrego el contenido del tbDesc al atributo descripcion del Proveedor
                    Proveedor.SetDescripcion(tbProveedorDesc.Text);

                    //agrego el contenido del tbRazonsoc al atributo razon social del cliente
                    Proveedor.setTipo(cbTipo.SelectedIndex);

                    Proveedor.setCodPersona(idPersona);

                    //envio el objeto cliente a la capa negocioPersona
                    PersonaNegocio personaNegocio = new PersonaNegocio();
                    personaNegocio.Update(Proveedor, Proveedor.getCodPersona());

                    //envio el objeto cliente a la capa negocioCliente
                    ProveedorNegocio pr = new ProveedorNegocio();
                    pr.UpdatePRV(Proveedor);
                    LimpiarDatos();
                    btnActualizar.Enabled = false;
                    btnBorrar.Enabled = false;
                    MessageBox.Show(Proveedor.getNombre() + " " + Proveedor.getNombreCalle() + " " + Proveedor.getNumCalle() + " " + Proveedor.GetDescripcion());
                }
            }
        }

        public void Borrar()//metodo para borrar el cliente
        {
            if (idProveedor != 0)
            {
                ProveedorNegocio pr = new ProveedorNegocio();
                int resultadoPr = pr.BorrarPRV(idProveedor);
                PersonaNegocio per = new PersonaNegocio();
                int resultadoP = per.BorrarP(idPersona);

                if (resultadoPr == -1 && resultadoP == -1)
                {
                    MessageBox.Show("se ha borrado al Proveedor " + tbProveedorNom.Text);
                    LimpiarDatos();
                    btnActualizar.Enabled = false;
                    btnBorrar.Enabled = false;
                }
                else { MessageBox.Show("ERROR al borrar el Proveedor " + tbProveedorNom.Text); }
            }
        }


        public void desHabilitar()//metodo para deshabilitar los campos
        {
            tbProveedorDNI.Enabled = false;
            tbProveedorCuit.Enabled = false;
            tbProveedorNom.Enabled = false;
            tbProveedorApe.Enabled = false;
            tbProveedorCalle.Enabled = false;
            tbProveedorNumCalle.Enabled = false;
            tbProveedorCondFisc.Enabled = false;
            tbProveedorRazSoc.Enabled = false;
            tbProveedorDesc.Enabled = false;
            tbProveedorDNIp.BackColor = Color.Transparent;
            tbProveedorCuitp.BackColor = Color.Transparent;
            tbProveedorNomp.BackColor = Color.Transparent;
            tbProveedorApep.BackColor = Color.Transparent;
            tbProveedorCallep.BackColor = Color.Transparent;
            tbProveedorNumCallep.BackColor = Color.Transparent;
            tbProveedorCondFiscp.BackColor = Color.Transparent;
            tbProveedorRazSocp.BackColor = Color.Transparent;
            tbProveedorDescp.BackColor = Color.Transparent;
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
            btnVerProd.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        public void habilitar()//metodo para habilitar los campos
        {
            tbProveedorDNI.Enabled = true;
            tbProveedorCuit.Enabled = true;
            tbProveedorNom.Enabled = true;
            tbProveedorApe.Enabled = true;
            tbProveedorCalle.Enabled = true;
            tbProveedorNumCalle.Enabled = true;
            tbProveedorCondFisc.Enabled = true;
            tbProveedorRazSoc.Enabled = true;
            tbProveedorDesc.Enabled = true;
            btnAgregar.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        public void desHabilitarRojo()
        {
            tbProveedorDNIp.BackColor = Color.Transparent;
            tbProveedorCuitp.BackColor = Color.Transparent;
            tbProveedorNomp.BackColor = Color.Transparent;
            tbProveedorApep.BackColor = Color.Transparent;
            tbProveedorCallep.BackColor = Color.Transparent;
            tbProveedorNumCallep.BackColor = Color.Transparent;
            tbProveedorCondFiscp.BackColor = Color.Transparent;
            tbProveedorRazSocp.BackColor = Color.Transparent;
            tbProveedorDescp.BackColor = Color.Transparent;
        }

        public void LimpiarDatos()
        {
            idProveedor = 0;
            idPersona = 0;
            tbProveedorDNI.Text = "";
            tbProveedorNom.Text = "";
            tbProveedorApe.Text = "";
            tbProveedorCuit.Text = "";
            tbProveedorCondFisc.Text = "";
            tbProveedorRazSoc.Text = "";
            tbProveedorCalle.Text = "";
            tbProveedorNumCalle.Text = "";
            dvg.Columns[2].Visible = true;
            dvg.Columns[5].Visible = true;
            dvg.Columns[8].Visible = true;
            dvg.Columns[3].Visible = true;
            dvg.Columns[9].Visible = true;
            tbBuscar.Text = "";
            dvg.Rows.Clear();
            cbTipo.SelectedIndex = -1;
            tbProveedorDesc.Text = "";
            btnVerProd.Enabled = false;
            desHabilitar();
            CargarTodo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProductos frmprod = new FormProductos();
            frmprod.codProv = idProveedor;
            frmprod.codPer = idPersona;
            frmprod.CargarGrilla();
            this.Close();
            frmprod.Show();
        }

        private void tbProveedorDNI_Leave(object sender, EventArgs e)
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
                if (textBoxActual.Name.Equals("tbProveedorDNI") && textBoxActual.Text.Length != 8)
                {
                    MessageBox.Show("El campo " + textBoxActual.Tag + " tiene que tener 8 numeros");
                    foreach (Control ctrl in PanelControl.Controls)
                    {
                        if (ctrl is Panel && ctrl.Name == textBoxActual.Name + "p") { ctrl.BackColor = Color.Red; }
                    }
                }
                else if (textBoxActual.Name.Equals("tbProveedorCuit") && textBoxActual.Text.Length != 11)
                {
                    MessageBox.Show("El campo " + textBoxActual.Tag + " tiene que tener 11 numeros");
                    foreach (Control ctrl in PanelControl.Controls)
                    {
                        if (ctrl is Panel && ctrl.Name == textBoxActual.Name + "p") { ctrl.BackColor = Color.Red; }
                    }
                }
                else if (textBoxActual.Name.Equals("tbProveedorNumCalle") && textBoxActual.Text.Equals("0"))
                {
                    MessageBox.Show("El campo " + textBoxActual.Tag + " no pede tener el valor 0");
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
        }

        public bool camposVacios()
        {
            bool vacio = false;

            foreach (Control ctrl in PanelControl.Controls)
            {
                if (ctrl is Panel && ctrl.HasChildren)
                {
                    Point p = new Point(2, 2);
                    if (ctrl.GetChildAtPoint(p).Text.Equals("") && ctrl.GetChildAtPoint(p).Enabled)
                    {
                        MessageBox.Show("El campo " + ctrl.GetChildAtPoint(p).Tag + " se encuentra vacio");
                        foreach (Control ctrl2 in PanelControl.Controls)
                        {
                            if (ctrl2 is Panel && ctrl2.Name == ctrl.GetChildAtPoint(p).Name + "p") { ctrl2.BackColor = Color.Red; }
                        }
                        vacio = true;
                    }
                    else if (tbProveedorCuit.Enabled && tbProveedorCuit.Text.Length != 11 || tbProveedorDNI.Enabled && tbProveedorDNI.Text.Length != 8 || tbProveedorNumCalle.Text.Equals("0"))
                    {
                        vacio = true;
                    }
                }
            }
            return vacio;
        }

        private void tbProveedorDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbProveedorApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidarBusqueda()
        {
            if (tbBuscar.Text.Length == 8 || tbBuscar.Text.Length == 11)
            {
                ProveedorNegocio provN = new ProveedorNegocio();
                long valor = long.Parse(tbBuscar.Text);
                Proveedor proveedor = provN.BuscarProveedor(valor);
                if (proveedor.getNombre() != null)
                {
                    btnLimpiar.Enabled = true;
                    dvg.Rows.Clear();
                    if (proveedor.getTipo() == 0)
                    {
                        dvg.Columns[3].Visible = false;
                        dvg.Columns[9].Visible = false;
                        dvg.Rows.Add(
                        proveedor.GetCodProveedor(),
                        "Persona",
                        proveedor.getDni(),
                        "",
                        proveedor.getNombre(),
                        proveedor.getApellido(),
                        proveedor.getNombreCalle(),
                        proveedor.getNumCalle(),
                        proveedor.getCondicionFiscal(),
                        "",
                        proveedor.getCodPersona(),
                        proveedor.GetDescripcion()
                        );
                    }
                    else
                    {
                        dvg.Columns[2].Visible = false;
                        dvg.Columns[5].Visible = false;
                        dvg.Columns[8].Visible = false;
                        dvg.Rows.Add(
                        proveedor.GetCodProveedor(),
                        "Empresa",
                        "",
                        proveedor.getCuit(),
                        proveedor.getNombre(),
                        "",
                        proveedor.getNombreCalle(),
                        proveedor.getNumCalle(),
                        "",
                        proveedor.GetRazonSocial(),
                        proveedor.getCodPersona(),
                        proveedor.GetDescripcion()
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro al Proveedor");
                }
            }
            else
            {
                MessageBox.Show("Para realizar la busqueda, el DNI debe contar con un maximo de 8 numeros" +
                " y el Cuit debe tener 11 numeros");
            }
        }

        public void SetEmpleado(Empleado emp, Usuario usu) { this.empleado = emp; this.usuario = usu; }

        private void VerDatosEmpleado()
        {
            FormEmpleado fe = new FormEmpleado();
            fe.SetEmpleado(empleado, usuario);
            fe.CargarDatos();
            fe.Show();
        }
    }
}
