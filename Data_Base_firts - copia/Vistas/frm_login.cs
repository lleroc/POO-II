namespace _02_CRUD.Vistas
{
    using Data_Base_firts;
    using Data_Base_firts.Controladores;
    using Data_Base_firts.Models;
    using Data_Base_firts.Vistas.Principal;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class frm_login : Form
    {
        private readonly usuariosControllers _usuariosControllers = new usuariosControllers();
        

        public frm_login()
        {
            InitializeComponent();
        }


        private void btn_Login1_Click(object sender, EventArgs e)
        {
           var usuario = _usuariosControllers.
                Authenticate(txt_correo.Text.Trim(), txt_contrasenia.Text.Trim());
            if (usuario != null)
            {
                Program.logueado = true;
                Program.usuarioActualId = usuario.UsuarioId;
                Program.rol = usuario.Rol.NombreRol;
                Program.rolId = usuario.RolId;
                Program.nombreUsuario = usuario.NombreCompleto;


                MessageBox.Show("Inicio de sesión exitoso");
                frm_principal principalForm = new frm_principal();
                principalForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos");
            }
        }

        private void btn_login2_Click(object sender, EventArgs e)
        {
          txt_contrasenia.Text = "";
            txt_correo.Text = "";
        }

        private void txt_correo_Leave(object sender, EventArgs e)
        {
            bool ok = Regex.IsMatch(txt_correo.Text,
               @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
               RegexOptions.IgnoreCase);

            if (!ok)
            {
                txt_correo.Text = "";
                txt_correo.Focus();
                MessageBox.Show("El formato de Correo no es valido");
            }

        }
        
       
    }
}
