using Data_Base_firts.Controladores;
using Data_Base_firts.Vistas.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Base_firts.Vistas.Clientes
{
    public partial class frm_clientes : Form
    {
        private readonly clientesControlles _clientesController = new clientesControlles();
        int clienteId_editar = 0;
        public frm_clientes()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            acctivacajas();
        }
        public void acctivacajas()
        {
            btn_nuevo.Enabled = false;
            lst_lista_clientes.Enabled = false;
            btn_editar.Enabled = false;
            btn_Guardar.Enabled = true;
            btn_cancelar.Enabled = true;
            txt_apellido.Enabled = true;
            txt_nombre.Enabled = true;
            txt_email.Enabled = true;
            txt_direccion.Enabled = true;
            txt_telefono.Enabled = true;
        }
        public bool verificarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_apellido.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_direccion.Text) ||
                string.IsNullOrWhiteSpace(txt_telefono.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Gestion de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void limpiar_campos()
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_email.Text = "";
            txt_telefono.Text = "";
            txt_direccion.Text = "";


            btn_nuevo.Enabled = true;
            lst_lista_clientes.Enabled = true;
            btn_editar.Enabled = true;

            btn_Guardar.Enabled = false;
            btn_cancelar.Enabled = false;

            txt_apellido.Enabled = false;
            txt_nombre.Enabled = false;
            txt_email.Enabled = false;
            txt_direccion.Enabled = false;
            txt_telefono.Enabled = false;


        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (verificarCampos() == false) return;
            var resultado = false;
            var cliente = new Data_Base_firts.Models.Cliente
            {
                Nombre = txt_nombre.Text.Trim(),
                Apellido = txt_apellido.Text.Trim(),
                Email = txt_email.Text.Trim(),
                Telefono = txt_telefono.Text.Trim(),
                Direccion = txt_direccion.Text.Trim()

            };
            if (clienteId_editar != 0)
            {
                //editar
                cliente.ClienteId = clienteId_editar;
                resultado = _clientesController.Updatecliente(cliente);
            }
            else
            {
                resultado = _clientesController.AddCliente(cliente);
            }
            if (resultado)
            {
                MessageBox.Show("Usuario agregado con éxito.", "Gestion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_campos();
                carga_lista();
                clienteId_editar = 0;
            }
            else
            {
                MessageBox.Show("Error al agregar el usuario. Por favor, intente nuevamente.", "Gestion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void carga_lista()
        {
            var lista_clientes = _clientesController.GetAllClientes();
            lst_lista_clientes.DataSource = lista_clientes;
            lst_lista_clientes.DisplayMember = "NombreCompleto";
            lst_lista_clientes.ValueMember = "ClienteId";
        }

        private void frm_clientes_Load(object sender, EventArgs e)
        {
            carga_lista();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            if (lst_lista_clientes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un usuario para editar.", "Gestion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                uno(1);
            }
        }

        public void uno(int opcion)
        {
            var cliente = _clientesController.GetUsuarioById((int)lst_lista_clientes.SelectedValue);
            if (cliente == null)
            {
                MessageBox.Show("No se encontro al usuario", "Gestion de Usuarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_apellido.Text = cliente.Apellido;
                txt_nombre.Text = cliente.Nombre;
                txt_email.Text = cliente.Email;
                txt_direccion.Text = cliente.Direccion;
                txt_telefono.Text = cliente.Telefono;

                if (opcion == 1)
                {
                    clienteId_editar = cliente.ClienteId;
                    acctivacajas();
                }
            }
        }

        private void lst_lista_clientes_DoubleClick(object sender, EventArgs e)
        {
            uno(0);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (lst_lista_clientes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.", "Gestion de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var resultado = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?"
                    , "Gestion de Usuarios",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    var clienteId = (int)lst_lista_clientes.SelectedValue;
                    var eliminar = _clientesController.DeleteCliente(clienteId);
                    if (eliminar)
                    {
                        MessageBox.Show("Cliente eliminado con éxito.", "Gestion de Usuarios",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar_campos();
                        carga_lista();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario. Por favor, intente nuevamente."
                            , "Gestion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Reporte_Clientes reporte_Clientes = new Reporte_Clientes();
            reporte_Clientes.Show();
        }
    }
}
