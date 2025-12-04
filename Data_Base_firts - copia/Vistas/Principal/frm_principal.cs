using Data_Base_firts.Vistas.Clientes;
using Data_Base_firts.Vistas.Usuarios;
namespace Data_Base_firts.Vistas.Principal
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            if (Program.logueado != true) this.Close();

            lbl_nombre.Text = Program.nombreUsuario;
            lbl_rol.Text = Program.rol;

            timer1.Start();

            if (Program.rolId != 2)
            {
                usuariosToolStripMenuItem.Enabled = false;
            }


        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_usuarios frm_Usuarios = new frm_usuarios();
            frm_Usuarios.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_reloj.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_clientes frm_Clientes = new frm_clientes();
            frm_Clientes.Show();
        }
    }
}
