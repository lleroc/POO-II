namespace _02_CRUD.Vistas.Clientes
{
    using _02_CRUD.Controladores;
    using _02_CRUD.Vistas.Usuarios;

    public partial class frm_lista_clientes : Form
    {
        private readonly Cliente_Controller _cliente_controller = new Cliente_Controller();
        public frm_lista_clientes()
        {
            InitializeComponent();
        }

        private void frm_lista_clientes_Load(object sender, EventArgs e)
        {
            lst_lista_clientes.Items.Clear();
            lst_lista_clientes.DataSource = _cliente_controller.todos();
            lst_lista_clientes.DisplayMember = "Nombre_Completo";
            lst_lista_clientes.ValueMember = "id";
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (lst_lista_clientes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el usuario para editar");
            }
            else
            {
                int id_Usuario = (int)lst_lista_clientes.SelectedValue;

                var edita_cliente = new frm_editar_cliente(id_Usuario);
                edita_cliente.ShowDialog();
                this.Close();
            }
        }
    }
}
