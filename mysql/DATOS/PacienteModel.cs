namespace mysql.DATOS
{
    public class PacienteModel
    {
        public int id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateOnly Fecha_Nacimiento { get; set; }
        public string Cedula { get; set; }
    }
}
