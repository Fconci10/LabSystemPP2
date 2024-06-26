using CapaEntidades;
using CapaNegocios;
namespace LabSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarTodo();//metodo para cargar los clientes en la tabla 
            desHabilitar();//deshabilita los todos los campos para evitar que se ingresen datos inconpletos
        }
        int idCliente = 0;
        int idPersona = 0;
        Empleado empleado;
        Usuario usuario;

        //Botones
        private void btnAgregar_Click(object sender, EventArgs e) //boton para agregar cliente
        {
            Guardar();//metodo para agregar cliente
        }

        //al darle doble clic a un cliente en la tabla
        private void dvg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecCliente();//metodo que toma los datos del cliente al que se le dio doble clic
        }

        private void btnActualizar_Click(object sender, EventArgs e)//boton para actualizar cliente
        {
            Actualizar();// metodo para actualizar cliente
        }

        private void btnBorrar_Click(object sender, EventArgs e)//boton para borrar cliente
        {
            Borrar();//metodo para borrar cliente
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//controla la eleccion del combobox
        {
            SelecTipoCli();//metodo para habilitar los campos segun el tipo de cliente
        }

        private void btnLimpiar_Click(object sender, EventArgs e)//boton para limpiar todos los campos
        {
            LimpiarDatos();//metodo para limpiar todos los campos
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.main.Show();
            //Program.main.LimpiarCampos();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            FormVenta fv = new FormVenta();
            fv.CargarProd();
            if (cbTipo.SelectedIndex == 0)
            {
                fv.DatosCliente(tbClienteNom.Text + " " + tbClienteApe.Text,
                    tbClienteCalle.Text + " " + tbClienteNumCalle.Text, tbClienteDNI.Text,
                    tbClienteCondFisc.Text
                    );
            }
            else
            {
                fv.DatosCliente(tbClienteNom.Text,
                    tbClienteCalle.Text + " " + tbClienteNumCalle.Text, tbClienteCuit.Text,
                    tbClienteRazSoc.Text
                    );
            }
            fv.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ValidarBusqueda();
        }

        private void btnEmplDatos_Click(object sender, EventArgs e)
        {
            VerDatosEmpleado();
        }

        //Metodos

        public void Guardar() //metodo para agregar cliente
        {
            long cuit = 0;
            int numCalle = 0;
            int dni = 0;
            long resultadoP = 0;
            int resultadoC = 0;
            Cliente cliente = new Cliente();//objeto de la clase cliente que se va a cargar en la bd

            if (!camposVacios())
            {

                if (tbClienteDNI.Enabled)
                {
                    dni = int.Parse(tbClienteDNI.Text);
                    cliente.setDni(dni);
                }
                else
                {
                    cuit = (long)Convert.ToDouble(tbClienteCuit.Text);
                    cliente.setCuit(cuit);
                }

                cliente.setNombre(tbClienteNom.Text);

                if (tbClienteApe.Enabled) { cliente.setApellido(tbClienteApe.Text); }

                cliente.setNombreCalle(tbClienteCalle.Text);
                numCalle = int.Parse(tbClienteNumCalle.Text);
                cliente.setNumCalle(numCalle);

                if (tbClienteCondFisc.Enabled) { cliente.setCondicionFiscal(tbClienteCondFisc.Text); }
                else { cliente.setRazonSocial(tbClienteRazSoc.Text); }

                //envio el objeto cliente a la capa negocioPersona
                PersonaNegocio personaNegocio = new PersonaNegocio();
                long resultado = personaNegocio.unicaP(cliente);

                if (personaNegocio.unicaP(cliente) == 1)
                {
                    cliente.setTipo(cbTipo.SelectedIndex);

                    resultadoP = personaNegocio.Insertar(cliente);

                    //para relacionar las tablas cliente y persona, le agrego a la tabla cliente
                    //el codigo de persona llamando al metodo getCodPer de la capa de Clientenegocios
                    cliente.setCodPersona(resultadoP);

                    //personaNegocio.getCodPer(cliente)
                    //envio el objeto cliente a la capa negocioCliente
                    ClienteNegocio cn = new ClienteNegocio();
                    resultadoC = cn.Insertar(cliente);

                }
                if (resultadoP > 0 && resultadoC > 0)
                {
                    LimpiarDatos();
                    MessageBox.Show("Se ha registrado un nuevo cliente");
                }
                else
                {
                    MessageBox.Show("ERROR al registrar un nuevo cliente");
                }
            }
        }

        public void CargarTodo()//metodo para cargar los clientes en la tabla
        {
            ClienteNegocio cn = new ClienteNegocio();
            List<Cliente> lista = new List<Cliente>();
            lista = cn.RecibirTodos();
            string tipo, dni, cuit;

            foreach (Cliente cliente in lista)
            {
                if (cliente.getTipo() == 0)
                {
                    tipo = "Persona";
                }
                else
                {
                    tipo = "Empresa";
                }

                if (cliente.getDni() == 0) { dni = ""; } else { dni = cliente.getDni().ToString(); }
                if (cliente.getCuit() == 0) { cuit = ""; } else { cuit = cliente.getCuit().ToString(); }
                dvg.Rows.Add(
                cliente.getIdCliente(),
                tipo,
                dni,
                cuit,
                cliente.getNombre(),
                cliente.getApellido(),
                cliente.getNombreCalle(),
                cliente.getNumCalle(),
                cliente.getCondicionFiscal(),
                cliente.getRazoSocial(),
                cliente.getCodPersona()
                );
            }
        }

        public void SelecCliente()//metodo para seleccionar un cliente de la tabla
        {
            idCliente = int.Parse(dvg.CurrentRow.Cells[0].Value.ToString());
            if (dvg.CurrentRow.Cells[1].Value.ToString().Equals("Persona")) { cbTipo.SelectedIndex = 0; } else { cbTipo.SelectedIndex = 1; }
            tbClienteDNI.Text = dvg.CurrentRow.Cells[2].Value.ToString();
            tbClienteCuit.Text = dvg.CurrentRow.Cells[3].Value.ToString();
            tbClienteNom.Text = dvg.CurrentRow.Cells[4].Value.ToString();
            tbClienteApe.Text = dvg.CurrentRow.Cells[5].Value.ToString();
            tbClienteCalle.Text = dvg.CurrentRow.Cells[6].Value.ToString();
            tbClienteNumCalle.Text = dvg.CurrentRow.Cells[7].Value.ToString();
            tbClienteCondFisc.Text = dvg.CurrentRow.Cells[8].Value.ToString();
            tbClienteRazSoc.Text = dvg.CurrentRow.Cells[9].Value.ToString();
            idPersona = int.Parse(dvg.CurrentRow.Cells[10].Value.ToString());
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            btnVenta.Enabled = true;
        }

        public void SelecTipoCli()//metodo para seleccionar el tipo de cliente
        {
            desHabilitarRojo();
            habilitar();
            int seleccion = cbTipo.SelectedIndex;
            if (seleccion == 0)//segun el tipo de cliente se habilitan algunos campos, 0 es persona 1 es empresa
            {
                tbClienteCuit.Enabled = false;
                tbClienteRazSoc.Enabled = false;
                tbClienteCuit.Text = "";
                tbClienteRazSoc.Text = "";
                tbClienteDNI.Enabled = true;
                tbClienteApe.Enabled = true;
            }
            else
            {
                tbClienteCuit.Enabled = true;
                tbClienteRazSoc.Enabled = true;
                tbClienteDNI.Enabled = false;
                tbClienteCondFisc.Enabled = false;
                tbClienteApe.Enabled = false;
                tbClienteDNI.Text = "";
                tbClienteCondFisc.Text = "";
                tbClienteApe.Text = "";
            }
        }

        public void Actualizar()//metodo para actualizar clientes
        {
            if (idCliente != 0 && !camposVacios())
            {
                long cuit = 0;
                int dni = 0;
                int numCalle = 0;
                Cliente cliente = new Cliente();//objeto de la clase cliente que se va a cargar en la bd

                if (tbClienteDNI.Enabled)
                {
                    dni = int.Parse(tbClienteDNI.Text);
                    cliente.setDni(dni);
                }
                else
                {
                    cuit = (long)Convert.ToDouble(tbClienteCuit.Text);
                    cliente.setCuit(cuit);
                }

                cliente.setNombre(tbClienteNom.Text);

                if (tbClienteApe.Enabled) { cliente.setApellido(tbClienteApe.Text); }

                cliente.setNombreCalle(tbClienteCalle.Text);
                numCalle = int.Parse(tbClienteNumCalle.Text);
                cliente.setNumCalle(numCalle);

                if (tbClienteCondFisc.Enabled) { cliente.setCondicionFiscal(tbClienteCondFisc.Text); }
                else { cliente.setRazonSocial(tbClienteRazSoc.Text); }

                //agrego el contenido del tbRazonsoc al atributo razon social del cliente
                cliente.setTipo(cbTipo.SelectedIndex);

                cliente.setCodPersona(idPersona);

                //envio el objeto cliente a la capa negocioPersona
                PersonaNegocio personaNegocio = new PersonaNegocio();
                personaNegocio.Update(cliente, idPersona);

                //envio el objeto cliente a la capa negocioCliente
                ClienteNegocio cn = new ClienteNegocio();
                cn.updateC(cliente);
                LimpiarDatos();
                btnActualizar.Enabled = false;
                btnBorrar.Enabled = false;
            }
        }

        public void Borrar()//metodo para borrar el cliente
        {
            if (idCliente != 0)
            {
                ClienteNegocio cn = new ClienteNegocio();
                int resultadoC = cn.BorrarC(idCliente);
                PersonaNegocio per = new PersonaNegocio();
                int resultadoP = per.BorrarP(idPersona);

                if (resultadoC == -1 && resultadoP == -1)
                {
                    MessageBox.Show("se ha borrado al cliente " + tbClienteNom.Text);
                    LimpiarDatos();
                    btnActualizar.Enabled = false;
                    btnBorrar.Enabled = false;
                }
                else { MessageBox.Show("ERROR al borrar el cliente " + tbClienteNom.Text); }
            }
        }


        public void desHabilitar()//metodo para deshabilitar los campos
        {
            tbClienteDNI.Enabled = false;
            tbClienteCuit.Enabled = false;
            tbClienteNom.Enabled = false;
            tbClienteApe.Enabled = false;
            tbClienteCalle.Enabled = false;
            tbClienteNumCalle.Enabled = false;
            tbClienteCondFisc.Enabled = false;
            tbClienteRazSoc.Enabled = false;

            tbClienteDNIp.BackColor = Color.Transparent;
            tbClienteCuitp.BackColor = Color.Transparent;
            tbClienteNomp.BackColor = Color.Transparent;
            tbClienteApep.BackColor = Color.Transparent;
            tbClienteCallep.BackColor = Color.Transparent;
            tbClienteNumCallep.BackColor = Color.Transparent;
            tbClienteCondFiscp.BackColor = Color.Transparent;
            tbClienteRazSocp.BackColor = Color.Transparent;

            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
            btnVenta.Enabled = false;
        }

        public void habilitar()//metodo para habilitar los campos
        {
            tbClienteDNI.Enabled = true;
            tbClienteCuit.Enabled = true;
            tbClienteNom.Enabled = true;
            tbClienteApe.Enabled = true;
            tbClienteCalle.Enabled = true;
            tbClienteNumCalle.Enabled = true;
            tbClienteCondFisc.Enabled = true;
            tbClienteRazSoc.Enabled = true;
            btnAgregar.Enabled = true;
        }

        public void desHabilitarRojo()
        {
            tbClienteDNIp.BackColor = Color.Transparent;
            tbClienteCuitp.BackColor = Color.Transparent;
            tbClienteNomp.BackColor = Color.Transparent;
            tbClienteApep.BackColor = Color.Transparent;
            tbClienteCallep.BackColor = Color.Transparent;
            tbClienteNumCallep.BackColor = Color.Transparent;
            tbClienteCondFiscp.BackColor = Color.Transparent;
            tbClienteRazSocp.BackColor = Color.Transparent;
        }

        public void LimpiarDatos()
        {
            idCliente = 0;
            idPersona = 0;
            tbClienteDNI.Text = "";
            tbClienteNom.Text = "";
            tbClienteApe.Text = "";
            tbClienteCuit.Text = "";
            tbClienteCondFisc.Text = "";
            tbClienteRazSoc.Text = "";
            tbClienteCalle.Text = "";
            tbClienteNumCalle.Text = "";
            dvg.Columns[2].Visible = true;
            dvg.Columns[5].Visible = true;
            dvg.Columns[8].Visible = true;
            dvg.Columns[3].Visible = true;
            dvg.Columns[9].Visible = true;
            tbBuscar.Text = "";
            dvg.Rows.Clear();
            cbTipo.SelectedIndex = -1;
            CargarTodo();
            desHabilitar();
        }

        private void tbClienteDNI_Leave(object sender, EventArgs e)
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
                if (textBoxActual.Name.Equals("tbClienteDNI") && textBoxActual.Text.Length != 8)
                {
                    MessageBox.Show("El campo " + textBoxActual.Tag + " tiene que tener 8 numeros");
                    foreach (Control ctrl in PanelControl.Controls)
                    {
                        if (ctrl is Panel && ctrl.Name == textBoxActual.Name + "p") { ctrl.BackColor = Color.Red; }
                    }
                }
                else if (textBoxActual.Name.Equals("tbClienteCuit") && textBoxActual.Text.Length != 11)
                {
                    MessageBox.Show("El campo " + textBoxActual.Tag + " tiene que tener 11 numeros");
                    foreach (Control ctrl in PanelControl.Controls)
                    {
                        if (ctrl is Panel && ctrl.Name == textBoxActual.Name + "p") { ctrl.BackColor = Color.Red; }
                    }
                }
                else if (textBoxActual.Name.Equals("tbClienteNumCalle") && textBoxActual.Text.Equals("0"))
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
                    Point p = new Point(3, 3);
                    if (ctrl.GetChildAtPoint(p).Text.Equals("") && ctrl.GetChildAtPoint(p).Enabled)
                    {
                        MessageBox.Show("El campo " + ctrl.GetChildAtPoint(p).Tag + " se encuentra vacio");
                        foreach (Control ctrl2 in PanelControl.Controls)
                        {
                            if (ctrl2 is Panel && ctrl2.Name == ctrl.GetChildAtPoint(p).Name + "p") { ctrl2.BackColor = Color.Red; }
                        }
                        vacio = true;
                    }
                    else if (tbClienteCuit.Enabled && tbClienteCuit.Text.Length != 11 || tbClienteDNI.Enabled && tbClienteDNI.Text.Length != 8 || tbClienteNumCalle.Text.Equals("0"))
                    {
                        vacio = true;
                    }
                }
            }
            return vacio;
        }

        private void tbClienteDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbClienteApe_KeyPress(object sender, KeyPressEventArgs e)
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
                ClienteNegocio cliN = new ClienteNegocio();
                long valor = long.Parse(tbBuscar.Text);
                Cliente cliente = cliN.BuscarCliente(valor);
                if (cliente.getNombre() != null)
                {
                    btnLimpiar.Enabled = true;
                    dvg.Rows.Clear();
                    if (cliente.getTipo() == 0)
                    {
                        dvg.Columns[3].Visible = false;
                        dvg.Columns[9].Visible = false;
                        dvg.Rows.Add(
                        cliente.getIdCliente(),
                        "Persona",
                        cliente.getDni(),
                        "",
                        cliente.getNombre(),
                        cliente.getApellido(),
                        cliente.getNombreCalle(),
                        cliente.getNumCalle(),
                        cliente.getCondicionFiscal(),
                        "",
                        cliente.getCodPersona()
                        );
                    }
                    else
                    {
                        dvg.Columns[2].Visible = false;
                        dvg.Columns[5].Visible = false;
                        dvg.Columns[8].Visible = false;
                        dvg.Rows.Add(
                        cliente.getIdCliente(),
                        "Empresa",
                        "",
                        cliente.getCuit(),
                        cliente.getNombre(),
                        "",
                        cliente.getNombreCalle(),
                        cliente.getNumCalle(),
                        "",
                        cliente.getRazoSocial(),
                        cliente.getCodPersona()
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
            fe.SetEmpleado(empleado,usuario);
            fe.CargarDatos();
            fe.Show();
        }
    }
}
