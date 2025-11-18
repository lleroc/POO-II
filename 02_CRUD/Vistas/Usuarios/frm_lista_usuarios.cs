using _02_CRUD.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_CRUD.Vistas.Usuarios
{
    public partial class frm_lista_usuarios : Form
    {
        private readonly Usuarios_Controller _usuarios = new Usuarios_Controller();

        public frm_lista_usuarios()
        {
            InitializeComponent();
        }

        private void frm_lista_usuarios_Load(object sender, EventArgs e)
        {

            cargarlista();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var fmr_insertar = new frm_insertar_usuario();
            fmr_insertar.ShowDialog();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (lst_lista_usuarios.SelectedIndex != 0)
            {
                int valor = _usuarios.eliminar((int)lst_lista_usuarios.SelectedValue);
                if (valor == 1) MessageBox.Show("No se encontro al usuario para eliminar");
                if (valor == 2) MessageBox.Show("Se guardo con exito");
                if (valor == 3) MessageBox.Show("Ocurrio un error al guardar");
                if (valor == 4) MessageBox.Show("Ocurrio un error al guardar");

                cargarlista();
            }
        }

        public void cargarlista() {
            lst_lista_usuarios.DataSource = _usuarios.todos_usuarios();
            lst_lista_usuarios.ValueMember = "Id_Usuario";
            lst_lista_usuarios.DisplayMember = "nombre_completo";

        }
    }
}
