
using _02_CRUD.Controladores;
using _02_CRUD.Modelos;

namespace _02_CRUD.Vistas.Usuarios
{
    public partial class frm_insertar_usuario : Form
    {
        private readonly Usuarios_Controller _usuarios_controller = new Usuarios_Controller();
        private readonly AuthController _auth_controller = new AuthController();
        public frm_insertar_usuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Cedula_Leave(object sender, EventArgs e)
        {
            validacioncedula();
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

            var usuario_model = new Usuario_Model
            {
                Apellido_Usuario = txt_Apellidos.Text.Trim(),
                Cedula_Usuario = txt_Cedula.Text.Trim(),
                contasenia = txt_Contrasenia.Text.Trim(),
                Correo_Usuario = txt_Correos.Text.Trim(),
                Estado = chb_Estado.Checked == true,
                Nombre_Usuario = txt_Nombres.Text.Trim()
            };

            var nuevo_usuario = _usuarios_controller.insertar(usuario_model);
            if (nuevo_usuario.Item1 == null)
            {
                MessageBox.Show(nuevo_usuario.error);
            }
            else
            {
                MessageBox.Show("Se guardo con éxito");
                limpiarcajas();
                var frm_lista = new frm_lista_usuarios();
                frm_lista.Show();
                this.Close();
            }
        }
        public void limpiarcajas()
        {
            txt_Apellidos.Text = "";
            txt_Cedula.Text = string.Empty;
            txt_Contrasenia.Text = "";
            txt_Correos.Text = "";
            txt_Nombres.Text = "";
            chb_Estado.Checked = false;
        }

        public bool validaciones()
        {
            if (txt_Apellidos.Text.Trim() == "" || txt_Cedula.Text.Trim() == ""
                 || txt_Contrasenia.Text.Trim() == "" || txt_Correos.Text.Trim() == ""
                 || txt_Nombres.Text.Trim() == "")
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.limpiarcajas();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
