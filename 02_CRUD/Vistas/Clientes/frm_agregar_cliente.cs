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
    public partial class frm_agregar_cliente : Form
    {
        private readonly AuthController _auth_controller = new AuthController();
        private readonly Cliente_Controller _cliente_Controller = new Cliente_Controller();
        public frm_agregar_cliente()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!validaciones())
            {
                MessageBox.Show("Complete los campos para guadar e usuario");
                return;
            }
            if (!validacioncedula())
            {
                MessageBox.Show("La cedula ingresada no es correcta");
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
                Telefono = txt_telefono.Text.Trim()
            };
            var nuevo_cliente = _cliente_Controller.insertar(cliente);
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

        public bool validacioncedula()
        {
            if (txt_Cedula.Text.Length != 10)
            {
                MessageBox.Show("La cedula ingresada no contiene 10 caracteres");
                return false;
            }
            bool validacion = _auth_controller.VerificaCedula(txt_Cedula.Text.ToCharArray());
            if (!validacion)
            {
                MessageBox.Show("El numero de cedula ingresado es incorrecto");
                txt_Cedula.Text = string.Empty;
                txt_Cedula.Focus();
                return false;
            }
            return true;

        }

    }
}
