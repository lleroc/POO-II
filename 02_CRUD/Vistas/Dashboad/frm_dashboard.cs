namespace _02_CRUD.Vistas.Dashboad
{
    using _02_CRUD.Vistas.Usuarios;
    public partial class frm_dashboard : Form
    {
        public frm_dashboard()
        {
            InitializeComponent();
        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_usuarios = new frm_lista_usuarios();
            frm_lista_usuarios.ShowDialog();
        }

        private void agregaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_insrtar = new frm_insertar_usuario();
            frm_insrtar.ShowDialog();   
        }
    }
}
