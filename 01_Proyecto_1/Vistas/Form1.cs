using _01_Proyecto_1.Controladores;
using _01_Proyecto_1.Modelos;
using _01_Proyecto_1.Vistas;

namespace _01_Proyecto_1
{
    public partial class Form1 : Form
    {
        EstudiantesController estudiantesController =
            new EstudiantesController();
        public Form1()
        {
            InitializeComponent();
            var estudian = new Estudiante
            {
                Apellidos = "Llerena Ocaña",
                Cedula = "123456789",
                Correo = "lleroc1@gail.com",
                Direccion = "Ambato",
                Fecha_Nacimiento = new DateOnly(1988, 3, 1),
                Id = 1,
                Nombres = "Luis Antonio",
                Telefono = "0987654321"
            };
            estudiantesController.insertar(estudian);
        }

        private void btn_Cargar_Lista_Click(object sender, EventArgs e)
        {
            // lst_Lista_Estudiantes.Items.Clear();
            lst_Lista_Estudiantes.DataSource = estudiantesController.todos();
            lst_Lista_Estudiantes.ValueMember = "Id";
            lst_Lista_Estudiantes.DisplayMember = "Apellidos";
        }

        private void btn_Nuevo_Estudiante_Click(object sender, EventArgs e)
        {
            var nuevo_estudiante = new frm_Insrtar_Estudiantes();
            nuevo_estudiante.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
