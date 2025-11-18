namespace _02_CRUD.Vistas
{
    using _02_CRUD.Controladores;
    using _02_CRUD.Modelos;
    using _02_CRUD.Vistas.Dashboad;
    using System.ComponentModel;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class frm_login : Form
    {
        private readonly AuthController _authController = new AuthController();
        int _coontador = 3;
        public frm_login()
        {
            InitializeComponent();
        }


        private void btn_Login1_Click(object sender, EventArgs e)
        {
            Login_Model model = new Login_Model
            {
                contasenia = txt_contrasenia.Text.Trim(),
                Correo_Usuario = txt_correo.Text.Trim()
            };

            Usuario_Model usuario = _authController.login1(model);

            if (usuario != null)
            {
                MessageBox.Show("Bienvenido al Sistema");
            }
            else
            {
                _coontador--;
                if (_coontador == 0)
                {
                    MessageBox.Show("Usted a sobre pasado el numero de intentos");
                    this.Close();
                }
                else
                {
                    string mmeensaje = "\"Error al iniciar session, su numero de intento "
                        + _coontador.ToString();
                    MessageBox.Show(mmeensaje);
                }
            }
        }

        private void btn_login2_Click(object sender, EventArgs e)
        {
            Login_Model model = new Login_Model
            {
                contasenia = txt_contrasenia.Text.Trim(),
                Correo_Usuario = txt_correo.Text.Trim()
            };

            Usuario_Model usuario = _authController.login2(model);

            if (usuario != null)
            {
                MessageBox.Show("Bienvenido al Sistema");
                var dash = new frm_dashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                _coontador--;
                if (_coontador == 0)
                {
                    MessageBox.Show("Usted a sobre pasado el numero de intentos");
                    this.Close();
                }
                else
                {
                    string mmeensaje = "\"Error al iniciar session, su numero de intento "
                        + _coontador.ToString();
                    MessageBox.Show(mmeensaje);
                }
            }
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
