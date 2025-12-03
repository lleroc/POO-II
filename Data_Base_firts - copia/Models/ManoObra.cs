using System;
using System.Collections.Generic;

namespace Data_Base_firts.Models;

public partial class ManoObra
{
    public int ManoObraId { get; set; }

    public int OtId { get; set; }

    public int MecanicoId { get; set; }

    public string? DescripcionTarea { get; set; }

    public decimal HorasTrabajadas { get; set; }

    public decimal TarifaHora { get; set; }

    public virtual Usuario Mecanico { get; set; } = null!;

    public virtual OrdenesTrabajo Ot { get; set; } = null!;
}
