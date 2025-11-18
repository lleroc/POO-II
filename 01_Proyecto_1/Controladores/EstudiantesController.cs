namespace _01_Proyecto_1.Controladores
{
    using _01_Proyecto_1.Modelos;
    public class EstudiantesController
    {
        List<Estudiante> listaEstudiantes = new List<Estudiante>();
              
        //CRUD
        public List<Estudiante> todos()
        {
            return listaEstudiantes;
        }
        public Estudiante uno(int id) {
            return listaEstudiantes
                .FirstOrDefault(e => e.Id == id);
        }
        public Estudiante insertar(Estudiante estudiante)
        {
            listaEstudiantes.Add(estudiante);
            return estudiante;
        }
        public (Estudiante, string error) actualizado(int id, Estudiante estudiante) {
            var estudiante_de_la_Lista = listaEstudiantes
                .FirstOrDefault(e => e.Id == id);
            try
            {
                estudiante_de_la_Lista.Nombres = estudiante.Nombres;
                estudiante_de_la_Lista.Fecha_Nacimiento = estudiante.Fecha_Nacimiento;
                estudiante_de_la_Lista.Cedula = estudiante.Cedula;
                estudiante_de_la_Lista.Telefono = estudiante.Telefono;
                estudiante_de_la_Lista.Apellidos = estudiante.Apellidos;
                estudiante_de_la_Lista.Correo = estudiante.Correo;
                estudiante_de_la_Lista.Direccion = estudiante.Direccion;
                return (estudiante_de_la_Lista,null);
            }
            catch (Exception ex)
            {
                return (null, ex.Message);
            }
            //estudiante_de_la_Lista = estudiante; 
        }
        public bool Eliminar (int id)
        {
            var estudiane = listaEstudiantes.FirstOrDefault(e => e.Id == id);
            if (estudiane.Id == 0)
            {
                return false;
            }
            else { 
                listaEstudiantes.RemoveAt(estudiane.Id);
                return true;
            }
        }
    }
}
