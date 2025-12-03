using System;
using System.Collections.Generic;

namespace Data_Base_firts.Models;

public partial class Presupuesto
{
    public int PresupuestoId { get; set; }

    public int ClienteId { get; set; }

    public DateTime FechaEmision { get; set; }

    public decimal TotalEstimado { get; set; }

    public string Estado { get; set; } = null!;

    public virtual Cliente Cliente { get; set; } = null!;
}
