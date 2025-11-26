using _02_CRUD.Controladores;
using _02_CRUD.Modelos;
using _02_CRUD.Vistas.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_CRUD.Vistas.Clientes
{
    public partial class frm_editar_cliente : Form
    {
        int _id;
        private readonly Cliente_Controller _cliente_controller = new Cliente_Controller();
        public frm_editar_cliente(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frm_editar_cliente_Load(object sender, EventArgs e)
        {
            var cliente = _cliente_controller.uno(_id);

            txt_Apellidos.Text = cliente.Apellidos  ;
            txt_Cedula.Text = cliente.RUC ;
            txt_Direccion.Text = cliente.Direcion;
            txt_Correos.Text=cliente.Correo  ;
            chb_Estado.Checked =cliente.Estado ;
            txt_Nombres.Text = cliente.Nombres ;
            txt_telefono.Text= cliente.Telefono;

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!validaciones())
            {
                MessageBox.Show("Complete los campos para guadar e usuario");
                return;
            }

            var cliente = new ClienteModel
            {
                Apellidos = txt_Apellidos.Text.Trim(),
                RUC = txt_Cedula.Text.Trim(),
                Direcion = txt_Direccion.Text.Trim(),
                Correo = txt_Correos.Text.Trim(),
                Estado = chb_Estado.Checked == true,
                Nombres = txt_Nombres.Text.Trim(),
                Telefono = txt_telefono.Text.Trim(),
                id = _id
            };

            var nuevo_cliente = _cliente_controller.editar(cliente);
            if (nuevo_cliente != "ok")
            {
                MessageBox.Show(nuevo_cliente);
            }
            else
            {
                MessageBox.Show("Se guardo con éxito");
                limpiarcajas();
                var frm_lista = new frm_lista_clientes();
                frm_lista.Show();
                this.Close();
            }

        }
        public void limpiarcajas()
        {
            txt_Apellidos.Text = "";
            txt_Cedula.Text = string.Empty;
            txt_Direccion.Text = "";
            txt_telefono.Text = "";
            txt_Correos.Text = "";
            txt_Nombres.Text = "";
            chb_Estado.Checked = false;
        }

        public bool validaciones()
        {
            if (txt_Apellidos.Text.Trim() == "" || txt_Cedula.Text.Trim() == ""
                 || txt_Direccion.Text.Trim() == "" || txt_Correos.Text.Trim() == ""
                 || txt_Nombres.Text.Trim() == "" || txt_telefono.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiarcajas();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
