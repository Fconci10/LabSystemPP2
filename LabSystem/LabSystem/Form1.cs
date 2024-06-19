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
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            FormVenta fv = new FormVenta();
            fv.CargarProd();
            if (cbTipo.SelectedIndex==0) {
                fv.DatosCliente(tbClienteNom.Text+" "+tbClienteApe.Text, 
                    tbClienteCalle.Text + " " + tbClienteNumCalle.Text,tbClienteDNI.Text,
                    tbClienteCondFisc.Text
                    );
            }
            else {
                fv.DatosCliente(tbClienteNom.Text,
                    tbClienteCalle.Text + " " + tbClienteNumCalle.Text, tbClienteCuit.Text,
                    tbClienteRazSoc.Text
                    );
            }
            fv.Show();
            this.Close();
        }

        //Metodos

        public void Guardar() //metodo para agregar cliente
        {
            int cargar = 0;//la variable cargar aumenta cada vez que un campo no este vacio
            long cuit = 0;
            int numCalle = 0;
            int dni = 0;
            long resultadoP = 0;
            int resultadoC = 0;
            Cliente cliente = new Cliente();//objeto de la clase cliente que se va a cargar en la bd

            //Si el tipo de cliente es persona, index=0 agrego el DNI
            if (cbTipo.SelectedIndex == 0)
            {
                //agrego el contenido del tbDNI al atributo DNI del cliente
                if (!tbClienteDNI.Text.Equals("") && tbClienteDNI.Text.Length == 8)
                {
                    dni = int.Parse(tbClienteDNI.Text);
                    cliente.setDni(dni);
                    cargar++;
                }
                else { MessageBox.Show("El campo DNI esta vacio, o el DNI no tiene 8 numeros"); }
            }

            //Si el tipo de cliente es empresa, index=1 agrego el cuit
            if (cbTipo.SelectedIndex == 1)
            {
                //agrego el contenido del tbCuit al atributo cuit del cliente
                if (!tbClienteCuit.Text.Equals("") && tbClienteCuit.Text.Length == 11)
                {
                    cuit = (long)Convert.ToDouble(tbClienteCuit.Text);
                    cliente.setCuit(cuit);
                    cargar++;
                }
                else { MessageBox.Show("El campo Cuit esta vacio, o el cuit no tiene 11 numero"); }
            }
            //agrego el contenido del tbNombre al atributo nombre del cliente
            if (!tbClienteNom.Text.Equals("")) { cliente.setNombre(tbClienteNom.Text); cargar++; }
            else
            {
                MessageBox.Show("EL campo Nombre calle esta vacio");
            }
            //Si el tipo de cliente es persona, index=0 agrego el apellido
            if (cbTipo.SelectedIndex == 0)
            {
                //agrego el contenido del tbApe al atributo apellido del cliente
                if (!tbClienteApe.Text.Equals("")) { cliente.setApellido(tbClienteApe.Text); cargar++; }
                else
                {
                    MessageBox.Show("EL campo Apellido calle esta vacio");
                }
            }
            //agrego el contenido del tbCalle al atributo nombre calle del cliente
            if (!tbClienteCalle.Text.Equals("")) { cliente.setNombreCalle(tbClienteCalle.Text); cargar++; }
            else
            {
                MessageBox.Show("EL campo Nombre calle calle esta vacio");
            }

            //agrego el contenido del tbNumCalle al atributo numero calle del cliente
            if (!tbClienteNumCalle.Text.Equals("") && !tbClienteNumCalle.Text.Equals("0"))
            {
                numCalle = int.Parse(tbClienteNumCalle.Text);
                cliente.setNumCalle(numCalle);
                cargar++;
            }
            else { MessageBox.Show("EL campo Numero calle esta vacio"); }

            //Si el tipo de cliente es persona, index=0 agrego la condicio fiscal
            if (cbTipo.SelectedIndex == 0)
            {
                //agrego el contenido del tbCondicionFiscal al atributo condicion fiscal del cliente
                if (!tbClienteCondFisc.Text.Equals("")) { cliente.setCondicionFiscal(tbClienteCondFisc.Text); cargar++; }
                else { MessageBox.Show("EL campo Condicion fiscal calle esta vacio"); }
            }

            //Si el tipo de cliente es empresa, index=1 agrego la razon social
            if (cbTipo.SelectedIndex == 1)
            {
                //agrego el contenido del tbRazonsoc al atributo razon social del cliente
                if (!tbClienteRazSoc.Text.Equals("")) { cliente.setRazonSocial(tbClienteRazSoc.Text); cargar++; }
                else { MessageBox.Show("EL campo Razon social calle esta vacio"); }
            }
            if (cargar == 6 && cbTipo.SelectedIndex == 0 || cargar == 5 && cbTipo.SelectedIndex == 1)//si cargar es igual a 6 significa que no hay ningun campo vacio
            {
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
                    MessageBox.Show("Se ah registrado un nuevo cliente");
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
            if (idCliente != 0)
            {
                long cuit = 0;
                int dni = 0;
                int numCalle = 0;
                Cliente cliente = new Cliente();//objeto de la clase cliente que se va a cargar en la bd

                if (cbTipo.SelectedIndex == 0)
                {
                    //agrego el contenido del tbDNI al atributo DNI del cliente
                    if (!tbClienteDNI.Text.Equals("") && tbClienteDNI.Text.Length == 8)
                    {
                        dni = int.Parse(tbClienteDNI.Text);
                        cliente.setDni(dni);
                    }
                    else { MessageBox.Show("El campo DNI esta vacio, o el DNI no tiene 8 numeros"); }
                }

                if (cbTipo.SelectedIndex == 1)
                {
                    //agrego el contenido del tbCuit al atributo cuit del cliente
                    if (!tbClienteCuit.Text.Equals("") && tbClienteCuit.Text.Length == 11)
                    {
                        cuit = (long)Convert.ToDouble(tbClienteCuit.Text);
                        cliente.setCuit(cuit);
                    }
                    else { MessageBox.Show("El campo Cuit esta vacio, o el cuit no tiene 11 numeros"); }
                }
                //agrego el contenido del tbNombre al atributo nombre del cliente
                if (!tbClienteNom.Text.Equals("")) { cliente.setNombre(tbClienteNom.Text); }
                else
                {
                    MessageBox.Show("EL campo Nombre esta vacio");
                }

                //Si el tipo de cliente es persona, index=0 agrego el apellido
                if (cbTipo.SelectedIndex == 0)
                {
                    //agrego el contenido del tbApe al atributo apellido del cliente
                    if (!tbClienteApe.Text.Equals("")) { cliente.setApellido(tbClienteApe.Text); }
                    else
                    {
                        MessageBox.Show("EL campo Apellido calle esta vacio");
                    }
                }

                //agrego el contenido del tbCalle al atributo nombre calle del cliente
                if (!tbClienteCalle.Text.Equals("")) { cliente.setNombreCalle(tbClienteCalle.Text); }
                else
                {
                    MessageBox.Show("EL campo Calle esta vacio");
                }

                //agrego el contenido del tbNumCalle al atributo numero calle del cliente
                if (!tbClienteNumCalle.Text.Equals("") && !tbClienteNumCalle.Text.Equals("0"))
                {
                    numCalle = int.Parse(tbClienteNumCalle.Text);
                    cliente.setNumCalle(numCalle);
                }
                else { MessageBox.Show("EL campo Numero calle esta vacio"); }

                if (cbTipo.Text.Equals("Persona"))
                {
                    //agrego el contenido del tbCondicionFiscal al atributo condicion fiscal del cliente
                    if (!tbClienteCondFisc.Text.Equals("")) { cliente.setCondicionFiscal(tbClienteCondFisc.Text); }
                    else { MessageBox.Show("EL campo Condicion fiscal esta vacio"); }
                }

                if (cbTipo.Text.Equals("Empresa"))
                {
                    //agrego el contenido del tbRazonsoc al atributo razon social del cliente
                    if (!tbClienteRazSoc.Text.Equals("")) { cliente.setRazonSocial(tbClienteRazSoc.Text); }
                    else { MessageBox.Show("EL campo Razon social esta vacio"); }
                }
                if (!tbClienteNom.Text.Equals("") && !tbClienteCalle.Text.Equals("") && !tbClienteNumCalle.Text.Equals(""))
                {
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
                    MessageBox.Show("se ah borrado al cliente " + tbClienteNom.Text);
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
            dvg.Rows.Clear();
            cbTipo.SelectedIndex = -1;
            CargarTodo();
        }
    }
}
