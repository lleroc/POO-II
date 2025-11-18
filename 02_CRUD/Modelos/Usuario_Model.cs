namespace _02_CRUD.Modelos
{
    public class Usuario_Model
    {
        public int Id_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Apellido_Usuario { get; set; }
        public string Cedula_Usuario { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public bool Estado { get; set; }
        public string contasenia { get; set; }
        public string Correo_Usuario { get; set; }
        //es solo de lectura 
        public string nombre_completo { get; set; }

    }
}
