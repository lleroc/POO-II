using System;
using System.Collections.Generic;

namespace Data_Base_firts.Models;

public partial class DocumentacionOt
{
    public int DocId { get; set; }

    public int OtId { get; set; }

    public int UsuarioId { get; set; }

    public string Tipo { get; set; } = null!;

    public string? Contenido { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual OrdenesTrabajo Ot { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
