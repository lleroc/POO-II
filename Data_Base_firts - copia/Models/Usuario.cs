using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data_Base_firts.Models;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public int RolId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public bool? Activo { get; set; }

    public virtual ICollection<DocumentacionOt> DocumentacionOts { get; set; } = new List<DocumentacionOt>();

    public virtual ICollection<ManoObra> ManoObras { get; set; } = new List<ManoObra>();

    public virtual ICollection<OrdenesTrabajo> OrdenesTrabajoMecanicoAsignados { get; set; } = new List<OrdenesTrabajo>();

    public virtual ICollection<OrdenesTrabajo> OrdenesTrabajoRecepcionista { get; set; } = new List<OrdenesTrabajo>();

    public virtual Role Rol { get; set; } = null!;


    //no se envia a la base de datos
    [NotMapped]
    [DisplayName("Nombre Completo")]
    public string NombreCompleto
    {
        get { return $"{Nombre} {Apellido}"; }
    }
    
}
