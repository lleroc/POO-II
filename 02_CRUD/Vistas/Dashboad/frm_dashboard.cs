namespace _02_CRUD.Vistas.Dashboad
{
    using _02_CRUD.Vistas.Usuarios;
    using _02_CRUD.Vistas.Clientes;
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

        private void editarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_usuarios = new frm_lista_usuarios();
            frm_lista_usuarios.ShowDialog();
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_lista_clientes Lista_Clentes = new frm_lista_clientes();
            Lista_Clentes.ShowDialog();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_agregar_cliente _Agregar_Cliente = new frm_agregar_cliente();
            _Agregar_Cliente.ShowDialog();
        }

        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_lista_clientes Lista_Clentes = new frm_lista_clientes();
            Lista_Clentes.ShowDialog();
        }
    }
}
