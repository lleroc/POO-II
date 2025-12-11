using System;
using System.Collections.Generic;

namespace Data_Base_firts.Models;

public partial class PiezasUsadasOt
{
    public int DetalleId { get; set; }

    public int OtId { get; set; }

    public int PiezaId { get; set; }

    public int CantidadUsada { get; set; }

    public decimal PrecioUnitario { get; set; }

    public virtual OrdenesTrabajo Ot { get; set; }

    public virtual Inventario Pieza { get; set; }
}
