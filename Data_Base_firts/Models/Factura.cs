using System;
using System.Collections.Generic;

namespace Data_Base_firts.Models;

public partial class Factura
{
    public int FacturaId { get; set; }

    public int? OtId { get; set; }

    public DateTime FechaEmision { get; set; }

    public decimal MontoNeto { get; set; }

    public decimal Impuesto { get; set; }

    public decimal MontoTotal { get; set; }

    public string EstadoPago { get; set; } = null!;

    public virtual OrdenesTrabajo? Ot { get; set; }
}
