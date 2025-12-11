using System;
using System.Collections.Generic;

namespace Data_Base_firts.Models;

public partial class OrdenesTrabajo
{
    public int OtId { get; set; }

    public int VehiculoId { get; set; }

    public int RecepcionistaId { get; set; }

    public int? MecanicoAsignadoId { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFinalizacion { get; set; }

    public string DescripcionProblema { get; set; }

    public string Estado { get; set; }

    public decimal? CostoTotal { get; set; }

    public virtual ICollection<DocumentacionOt> DocumentacionOts { get; set; } = new List<DocumentacionOt>();

    public virtual Factura Factura { get; set; }

    public virtual ICollection<ManoObra> ManoObras { get; set; } = new List<ManoObra>();

    public virtual Usuario MecanicoAsignado { get; set; }

    public virtual ICollection<PiezasUsadasOt> PiezasUsadasOts { get; set; } = new List<PiezasUsadasOt>();

    public virtual Usuario Recepcionista { get; set; }

    public virtual Vehiculo Vehiculo { get; set; }
}
