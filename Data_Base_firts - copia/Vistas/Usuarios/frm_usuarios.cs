
namespace Data_Base_firts.Vistas.Usuarios
{
    using Data_Base_firts.Controladores;
    public partial class frm_usuarios : Form
    {
        private readonly usuariosControllers _usuariosController = new usuariosControllers();
        int usuarioId_editar = 0;
        public frm_usuarios()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_usuarios_Load(object sender, EventArgs e)
        {
            carga_lista();

        }
        private void carga_lista()
        {
            var lista_usuarios = _usuariosController.GetAllUsuarios();

            lst_lista_usuarios.DataSource = lista_usuarios;
            lst_lista_usuarios.DisplayMember = "NombreCompleto";
            lst_lista_usuarios.ValueMember = "UsuarioId";

            cmb_rol.DataSource = _usuariosController.GetAllRoles();
            cmb_rol.DisplayMember = "NombreRol";
            cmb_rol.ValueMember = "RolId";

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            acctivacajas();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (usuarioId_editar > 0) return;
            var email = _usuariosController.EmailExists(txt_email.Text.Trim());
            if (email == false)
            {
                txt_email.Focus();
                txt_email.Text = "";
                MessageBox.Show("El correo electrónico ya está en uso. Por favor, ingrese otro.", "Gestion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chb_estado_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_estado.Checked)
            {
                chb_estado.Text = "Activo";
            }
            else
            {
                chb_estado.Text = "Inactivo";
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (verificarCampos() == false) return;
            var resultado = false;
            var usuario = new Data_Base_firts.Models.Usuario
            {
                Nombre = txt_nombre.Text.Trim(),
                Apellido = txt_apellido.Text.Trim(),
                Email = txt_email.Text.Trim(),
                PasswordHash = txt_contrasenia.Text.Trim(),
                Activo = chb_estado.Checked,
                RolId = (int)cmb_rol.SelectedValue
            };
            if (usuarioId_editar != 0)
            {
                //editar
                usuario.UsuarioId = usuarioId_editar;
                resultado = _usuariosController.UpdateUsuario(usuario);
            }
            else
            {
                resultado = _usuariosController.AddUsuario(usuario);
            }
            if (resultado)
            {
                MessageBox.Show("Usuario agregado con éxito.", "Gestion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_campos();
                carga_lista();
                usuarioId_editar = 0;
            }
            else
            {
                MessageBox.Show("Error al agregar el usuario. Por favor, intente nuevamente.", "Gestion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool verificarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_apellido.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_contrasenia.Text) ||
                cmb_rol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Gestion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void limpiar_campos()
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_email.Text = "";
            txt_contrasenia.Text = "";
            chb_estado.Checked = false;
            cmb_rol.SelectedIndex = -1;

            btn_nuevo.Enabled = true;
            lst_lista_usuarios.Enabled = true;
            btn_editar.Enabled = true;

            btn_Guardar.Enabled = false;
            btn_cancelar.Enabled = false;

            txt_apellido.Enabled = false;
            txt_nombre.Enabled = false;
            txt_email.Enabled = false;
            txt_contrasenia.Enabled = false;
            chb_estado.Enabled = false;

            cmb_rol.Enabled = false;

        }
        public void acctivacajas()
        {
            btn_nuevo.Enabled = false;
            lst_lista_usuarios.Enabled = false;
            btn_editar.Enabled = false;

            btn_Guardar.Enabled = true;
            btn_cancelar.Enabled = true;

            txt_apellido.Enabled = true;
            txt_nombre.Enabled = true;
            txt_email.Enabled = true;
            txt_contrasenia.Enabled = true;
            chb_estado.Enabled = true;

            cmb_rol.Enabled = true;

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (lst_lista_usuarios.SelectedItem == null)
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
            var usuario = _usuariosController.GetUsuarioById((int)lst_lista_usuarios.SelectedValue);
            if (usuario == null)
            {
                MessageBox.Show("No se encontro al usuario", "Gestion de Usuarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_apellido.Text = usuario.Apellido;
                txt_nombre.Text = usuario.Nombre;
                txt_email.Text = usuario.Email;
                txt_contrasenia.Text = usuario.PasswordHash;
                chb_estado.Checked = usuario.Activo ?? false;
                cmb_rol.SelectedValue = usuario.RolId;
                
                if (opcion == 1)
                {
                    usuarioId_editar = usuario.UsuarioId;
                    acctivacajas();
                } 
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lst_lista_usuarios_DoubleClick(object sender, EventArgs e)
        {
            uno(0);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (lst_lista_usuarios.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.", "Gestion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
               var resultado = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?"
                   , "Gestion de Usuarios", 
                   MessageBoxButtons.YesNo, 
                   MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes) {
                    var usuarioId = (int)lst_lista_usuarios.SelectedValue;
                    var eliminar = _usuariosController.DeleteUsuario(usuarioId);
                    if (eliminar)
                    {
                        MessageBox.Show("Usuario eliminado con éxito.", "Gestion de Usuarios", 
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
    }
}
