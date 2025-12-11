using System;
using System.Collections.Generic;

namespace Data_Base_firts.Models;

public partial class Vehiculo
{
    public int VehiculoId { get; set; }

    public int ClienteId { get; set; }

    public string Placa { get; set; }

    public string Marca { get; set; }

    public string Modelo { get; set; }

    public int? Anio { get; set; }

    public string TipoMotor { get; set; }

    public int? Kilometraje { get; set; }

    public virtual Cliente Cliente { get; set; }

    public virtual ICollection<OrdenesTrabajo> OrdenesTrabajos { get; set; } = new List<OrdenesTrabajo>();
}
