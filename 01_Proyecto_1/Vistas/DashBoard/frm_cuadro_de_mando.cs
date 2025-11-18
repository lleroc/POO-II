namespace _01_Proyecto_1.Vistas.DashBoard
{
    using _01_Proyecto_1.Vistas.Docentes;
    using _01_Proyecto_1.Vistas.Calculadora;
    public partial class frm_cuadro_de_mando : Form
    {
        public frm_cuadro_de_mando()
        {
            InitializeComponent();
        }

        private void listarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void listarDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_contenedor.Controls.Clear();
            var cu_docente = new Lista_Docentes();
            cu_docente.Dock = DockStyle.Fill;
            panel_contenedor.Controls.Add(cu_docente);
            cu_docente.BringToFront();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_calculadora calculadora = new frm_calculadora();
            calculadora.ShowDialog();
        }
    }
}
