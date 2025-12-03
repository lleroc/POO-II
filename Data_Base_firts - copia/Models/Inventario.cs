using System;
using System.Collections.Generic;

namespace Data_Base_firts.Models;

public partial class Inventario
{
    public int PiezaId { get; set; }

    public string NombrePieza { get; set; } = null!;

    public string? CodigoSku { get; set; }

    public int StockActual { get; set; }

    public int StockMinimo { get; set; }

    public decimal? PrecioCosto { get; set; }

    public decimal PrecioVenta { get; set; }

    public virtual ICollection<PiezasUsadasOt> PiezasUsadasOts { get; set; } = new List<PiezasUsadasOt>();
}
