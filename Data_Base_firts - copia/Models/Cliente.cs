using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data_Base_firts.Models;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public string Telefono { get; set; }

    public string Email { get; set; }

    public string Direccion { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<Presupuesto> Presupuestos { get; set; } = new List<Presupuesto>();

    public virtual ICollection<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();

    [NotMapped]
    public string NombreCompleto => $"{Nombre} {Apellido}";
}
