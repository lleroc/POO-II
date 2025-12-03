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

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_usuarios frm_Usuarios = new frm_usuarios();
            frm_Usuarios.Show();
        }
    }
}
