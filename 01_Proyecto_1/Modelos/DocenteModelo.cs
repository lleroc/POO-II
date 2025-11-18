using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Proyecto_1.Modelos
{
    public class DocenteModelo
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public string Titulo { get; set; }
        public string Abreviatura { get; set; }
        public bool Estado { get; set; }
    }
}
