using Data_Base_firts.Controladores;
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
    }
}
