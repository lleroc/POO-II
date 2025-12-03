using System;
using System.Collections.Generic;

namespace Data_Base_firts.Models;

public partial class Role
{
    public int RolId { get; set; }

    public string NombreRol { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
