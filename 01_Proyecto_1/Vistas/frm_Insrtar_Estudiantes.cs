using _01_Proyecto_1.Controladores;
using _01_Proyecto_1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Proyecto_1.Vistas
{
    public partial class frm_Insrtar_Estudiantes : Form
    {
        EstudiantesController estudiantesController = 
            new EstudiantesController();
        public frm_Insrtar_Estudiantes()
        {
            InitializeComponent();
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            var contador = estudiantesController.todos();
            var estudian = new Estudiante
            {
                Apellidos = txtApellidos.Text.Trim(),
                Cedula = txt_Cedula.Text.Trim(),
                Correo = txt_Correo.Text.Trim(),
                Direccion = txt_Direccion.Text.Trim(),
                Id = contador.Count() + 1,
                Nombres = txt_Nombres.Text.Trim(),
                Telefono = txtTelefono.Text.Trim()
            };
            var resultado = estudiantesController.insertar(estudian);

            if (resultado.Id > 0)
            {
                MessageBox.Show("Se guardo con exito");
                this.Close();
            }
             
        }
    }
}
