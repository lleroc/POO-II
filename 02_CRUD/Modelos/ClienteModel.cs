using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _02_CRUD.Modelos
{
    public class ClienteModel
    {
        public int id { get; set; }

        [Required(ErrorMessage ="El campo es requirido")]
        [Length(3,100,ErrorMessage ="El numero de caractes esta entre 3 y 100")]
        public string Nombres { get; set; }
        
        [Required(ErrorMessage = "El campo es requirido")]
        public string Apellidos { get; set; }
        
        [Required(ErrorMessage = "El campo es requirido")]

        public string Direcion { get; set; }
        [Required(ErrorMessage = "El campo es requirido")]

        public string RUC { get; set; }
        [Required(ErrorMessage = "El campo es requirido")]

        public string Telefono { get; set; }
        [Required(ErrorMessage = "El campo es requirido")]
        public string Correo { get; set; }

        public bool Estado { get; set; }


        [NotMapped]
        public string Nombre_Completo { get; set; } 
     

    }
}
