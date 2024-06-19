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

        //Metodos

        public void Guardar() //metodo para agregar Proveedor
        {
            int cargar = 0;//la variable cargar aumenta cada vez que un campo no este vacio
            long cuit = 0;
            int numCalle = 0;
            int dni = 0;
            int resultadoP = 0;
            int resultadoPr = 0;
            Proveedor Proveedor = new Proveedor();//objeto de la clase Proveedor que se va a cargar en la bd

            //Si el tipo de Proveedor es persona, index=0 agrego el DNI
            if (cbTipo.SelectedIndex == 0)
            {
                //agrego el contenido del tbDNI al atributo DNI del Proveedor
                if (!tbProveedorDNI.Text.Equals("") && tbProveedorDNI.Text.Length == 8)
                {
                    dni = int.Parse(tbProveedorDNI.Text);
                    Proveedor.setDni(dni);
                    cargar++;
                }
                else { MessageBox.Show("El campo DNI esta vacio, o el DNI no tiene 8 numeros"); }
            }

            //Si el tipo de Proveedor es empresa, index=1 agrego el cuit
            if (cbTipo.SelectedIndex == 1)
            {
                //agrego el contenido del tbCuit al atributo cuit del Proveedor
                if (!tbProveedorCuit.Text.Equals("") && tbProveedorCuit.Text.Length == 11)
                {
                    cuit = (long)Convert.ToDouble(tbProveedorCuit.Text);
                    Proveedor.setCuit(cuit);
                    cargar++;
                }
                else { MessageBox.Show("El campo Cuit esta vacio, o el cuit no tiene 11 numero"); }
            }
            //agrego el contenido del tbNombre al atributo nombre del Proveedor
            if (!tbProveedorNom.Text.Equals("")) { Proveedor.setNombre(tbProveedorNom.Text); cargar++; }
            else
            {
                MessageBox.Show("EL campo Nombre esta vacio");
            }
            //Si el tipo de Proveedor es persona, index=0 agrego el apellido
            if (cbTipo.SelectedIndex == 0)
            {
                //agrego el contenido del tbApe al atributo apellido del Proveedor
                if (!tbProveedorApe.Text.Equals("")) { Proveedor.setApellido(tbProveedorApe.Text); cargar++; }
                else
                {
                    MessageBox.Show("EL campo Apellido esta vacio");
                }
            }
            //agrego el contenido del tbCalle al atributo nombre calle del Proveedor
            if (!tbProveedorCalle.Text.Equals("")) { Proveedor.setNombreCalle(tbProveedorCalle.Text); cargar++; }
            else
            {
                MessageBox.Show("EL campo Nombre calle calle esta vacio");
            }

            //agrego el contenido del tbNumCalle al atributo numero calle del Proveedor
            if (!tbProveedorNumCalle.Text.Equals("") && !tbProveedorNumCalle.Text.Equals("0"))
            {
                numCalle = int.Parse(tbProveedorNumCalle.Text);
                Proveedor.setNumCalle(numCalle);
                cargar++;
            }
            else { MessageBox.Show("EL campo Numero calle esta vacio"); }

            //Si el tipo deProveedor es persona, index=0 agrego la condicio fiscal
            if (cbTipo.SelectedIndex == 0)
            {
                //agrego el contenido del tbCondicionFiscal al atributo condicion fiscal del Proveedor
                if (!tbProveedorCondFisc.Text.Equals("")) { Proveedor.setCondicionFiscal(tbProveedorCondFisc.Text); cargar++; }
                else { MessageBox.Show("EL campo Condicion fiscal esta vacio"); }
            }

            //Si el tipo de Proveedor es empresa, index=1 agrego la razon social
            if (cbTipo.SelectedIndex == 1)
            {
                //agrego el contenido del tbRazonsoc al atributo razon social del Proveedor
                if (!tbProveedorRazSoc.Text.Equals("")) { Proveedor.SetRazonSocial(tbProveedorRazSoc.Text); cargar++; }
                else { MessageBox.Show("EL campo Razon social esta vacio"); }
            }

            //agrego el contenido del tbDesc al atributo nombre calle del Proveedor
            if (!tbProveedorDesc.Text.Equals("")) { Proveedor.SetDescripcion(tbProveedorDesc.Text); cargar++; }
            else
            {
                MessageBox.Show("EL campo Descripcion esta vacio");
            }

            if (cargar == 7 && cbTipo.SelectedIndex == 0 || cargar == 6 && cbTipo.SelectedIndex == 1)//si cargar es igual a 6 significa que no hay ningun campo vacio
            {
                //envio el objeto Proveedor a la capa negocioPersona
                PersonaNegocio personaNegocio = new PersonaNegocio();
                long resultado = personaNegocio.unicaP(Proveedor);

                if (personaNegocio.unicaP(Proveedor) == 1)
                {
                    Proveedor.setTipo(cbTipo.SelectedIndex);

                    resultadoP = personaNegocio.Insertar(Proveedor);

                    //para relacionar las tablas Proveedor y persona, le agrego a la tabla Proveedor
                    //el codigo de persona llamando al metodo getCodPer de la capa de Proveedornegocios
                    Proveedor.setCodPersona(resultadoP);

                    //personaNegocio.getCodPer(cliente)
                    //envio el objeto Proveedor a la capa negocioProveedor
                    ProveedorNegocio prn = new ProveedorNegocio();
                    resultadoPr = prn.Insertar(Proveedor);

                }
                if (resultadoP > 0 && resultadoPr > 0)
                {
                    LimpiarDatos();
                    MessageBox.Show("Se ah registrado un nuevo Proveedor");
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
            //LimpiarDatos();
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
            if (idProveedor != 0)
            {
                long cuit = 0;
                int dni = 0;
                int numCalle = 0;
                Proveedor Proveedor = new Proveedor();//objeto de la clase cliente que se va a cargar en la bd

                if (cbTipo.SelectedIndex == 0)
                {
                    //agrego el contenido del tbDNI al atributo DNI del cliente
                    if (!tbProveedorDNI.Text.Equals("") && tbProveedorDNI.Text.Length == 8)
                    {
                        dni = int.Parse(tbProveedorDNI.Text);
                        Proveedor.setDni(dni);
                    }
                    else { MessageBox.Show("El campo DNI esta vacio, o el DNI no tiene 8 numeros"); }
                }

                if (cbTipo.SelectedIndex == 1)
                {
                    //agrego el contenido del tbCuit al atributo cuit del cliente
                    if (!tbProveedorCuit.Text.Equals("") && tbProveedorCuit.Text.Length == 11)
                    {
                        cuit = (long)Convert.ToDouble(tbProveedorCuit.Text);
                        Proveedor.setCuit(cuit);
                    }
                    else { MessageBox.Show("El campo Cuit esta vacio, o el cuit no tiene 11 numeros"); }
                }
                //agrego el contenido del tbNombre al atributo nombre del cliente
                if (!tbProveedorNom.Text.Equals("")) { Proveedor.setNombre(tbProveedorNom.Text); }
                else
                {
                    MessageBox.Show("EL campo Nombre esta vacio");
                }

                //Si el tipo de cliente es persona, index=0 agrego el apellido
                if (cbTipo.SelectedIndex == 0)
                {
                    //agrego el contenido del tbApe al atributo apellido del cliente
                    if (!tbProveedorApe.Text.Equals("")) { Proveedor.setApellido(tbProveedorApe.Text); }
                    else
                    {
                        MessageBox.Show("EL campo Apellido calle esta vacio");
                    }
                }

                //agrego el contenido del tbCalle al atributo nombre calle del cliente
                if (!tbProveedorCalle.Text.Equals("")) { Proveedor.setNombreCalle(tbProveedorCalle.Text); }
                else
                {
                    MessageBox.Show("EL campo Calle esta vacio");
                }

                //agrego el contenido del tbNumCalle al atributo numero calle del cliente
                if (!tbProveedorNumCalle.Text.Equals("") && !tbProveedorNumCalle.Text.Equals("0"))
                {
                    numCalle = int.Parse(tbProveedorNumCalle.Text);
                    Proveedor.setNumCalle(numCalle);
                }
                else { MessageBox.Show("EL campo Numero calle esta vacio"); }

                if (cbTipo.Text.Equals("Persona"))
                {
                    //agrego el contenido del tbCondicionFiscal al atributo condicion fiscal del cliente
                    if (!tbProveedorCondFisc.Text.Equals("")) { Proveedor.setCondicionFiscal(tbProveedorCondFisc.Text); }
                    else { MessageBox.Show("EL campo Condicion fiscal esta vacio"); }
                }

                if (cbTipo.Text.Equals("Empresa"))
                {
                    //agrego el contenido del tbRazonsoc al atributo razon social del cliente
                    if (!tbProveedorRazSoc.Text.Equals("")) { Proveedor.SetRazonSocial(tbProveedorRazSoc.Text); }
                    else { MessageBox.Show("EL campo Razon social esta vacio"); }
                }

                //agrego el contenido del tbDesc al atributo nombre calle del Proveedor
                if (!tbProveedorDesc.Text.Equals("")) { Proveedor.SetDescripcion(tbProveedorDesc.Text); }
                else
                {
                    MessageBox.Show("EL campo Descripcion esta vacio");
                }
                if (!tbProveedorNom.Text.Equals("") && !tbProveedorCalle.Text.Equals("") && !tbProveedorNumCalle.Text.Equals("") && !tbProveedorDesc.Text.Equals(""))
                {
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
                    MessageBox.Show("se ah borrado al Proveedor " + tbProveedorNom.Text);
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
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
            btnVerProd.Enabled = false;
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
            btnAgregar.Enabled = true;
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
            dvg.Rows.Clear();
            cbTipo.SelectedIndex = -1;
            tbProveedorDesc.Text = "";
            btnVerProd.Enabled = false;
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
    }
}
