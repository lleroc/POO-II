using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Data_Base_firts.Models;

public partial class MecanicaContext : DbContext
{
    public MecanicaContext()
    {
    }

    public MecanicaContext(DbContextOptions<MecanicaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<DocumentacionOt> DocumentacionOts { get; set; }

    public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<ManoObra> ManoObras { get; set; }

    public virtual DbSet<OrdenesTrabajo> OrdenesTrabajos { get; set; }

    public virtual DbSet<PiezasUsadasOt> PiezasUsadasOts { get; set; }

    public virtual DbSet<Presupuesto> Presupuestos { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=mecanica;uid=root;pwd=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.24-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PRIMARY");

            entity.ToTable("clientes");

            entity.HasIndex(e => e.Email, "email").IsUnique();

            entity.Property(e => e.ClienteId)
                .HasColumnType("int(11)")
                .HasColumnName("cliente_id");
            entity.Property(e => e.Apellido)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("apellido");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<DocumentacionOt>(entity =>
        {
            entity.HasKey(e => e.DocId).HasName("PRIMARY");

            entity.ToTable("documentacion_ot");

            entity.HasIndex(e => e.OtId, "ot_id");

            entity.HasIndex(e => e.UsuarioId, "usuario_id");

            entity.Property(e => e.DocId)
                .HasColumnType("int(11)")
                .HasColumnName("doc_id");
            entity.Property(e => e.Contenido)
                .HasColumnType("text")
                .HasColumnName("contenido");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.OtId)
                .HasColumnType("int(11)")
                .HasColumnName("ot_id");
            entity.Property(e => e.Tipo)
                .IsRequired()
                .HasColumnType("enum('Nota','Foto','Archivo')")
                .HasColumnName("tipo");
            entity.Property(e => e.UsuarioId)
                .HasColumnType("int(11)")
                .HasColumnName("usuario_id");

            entity.HasOne(d => d.Ot).WithMany(p => p.DocumentacionOts)
                .HasForeignKey(d => d.OtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("documentacion_ot_ibfk_1");

            entity.HasOne(d => d.Usuario).WithMany(p => p.DocumentacionOts)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("documentacion_ot_ibfk_2");
        });

        modelBuilder.Entity<Efmigrationshistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId).HasName("PRIMARY");

            entity
                .ToTable("__efmigrationshistory")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ProductVersion)
                .IsRequired()
                .HasMaxLength(32);
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.FacturaId).HasName("PRIMARY");

            entity.ToTable("facturas");

            entity.HasIndex(e => e.OtId, "ot_id").IsUnique();

            entity.Property(e => e.FacturaId)
                .HasColumnType("int(11)")
                .HasColumnName("factura_id");
            entity.Property(e => e.EstadoPago)
                .IsRequired()
                .HasColumnType("enum('Pendiente','Pagado','Anulado')")
                .HasColumnName("estado_pago");
            entity.Property(e => e.FechaEmision)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("fecha_emision");
            entity.Property(e => e.Impuesto)
                .HasPrecision(10, 2)
                .HasColumnName("impuesto");
            entity.Property(e => e.MontoNeto)
                .HasPrecision(10, 2)
                .HasColumnName("monto_neto");
            entity.Property(e => e.MontoTotal)
                .HasPrecision(10, 2)
                .HasColumnName("monto_total");
            entity.Property(e => e.OtId)
                .HasColumnType("int(11)")
                .HasColumnName("ot_id");

            entity.HasOne(d => d.Ot).WithOne(p => p.Factura)
                .HasForeignKey<Factura>(d => d.OtId)
                .HasConstraintName("facturas_ibfk_1");
        });

        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => e.PiezaId).HasName("PRIMARY");

            entity.ToTable("inventario");

            entity.HasIndex(e => e.CodigoSku, "codigo_sku").IsUnique();

            entity.Property(e => e.PiezaId)
                .HasColumnType("int(11)")
                .HasColumnName("pieza_id");
            entity.Property(e => e.CodigoSku)
                .HasMaxLength(50)
                .HasColumnName("codigo_sku");
            entity.Property(e => e.NombrePieza)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("nombre_pieza");
            entity.Property(e => e.PrecioCosto)
                .HasPrecision(10, 2)
                .HasColumnName("precio_costo");
            entity.Property(e => e.PrecioVenta)
                .HasPrecision(10, 2)
                .HasColumnName("precio_venta");
            entity.Property(e => e.StockActual)
                .HasColumnType("int(11)")
                .HasColumnName("stock_actual");
            entity.Property(e => e.StockMinimo)
                .HasColumnType("int(11)")
                .HasColumnName("stock_minimo");
        });

        modelBuilder.Entity<ManoObra>(entity =>
        {
            entity.HasKey(e => e.ManoObraId).HasName("PRIMARY");

            entity.ToTable("mano_obra");

            entity.HasIndex(e => e.MecanicoId, "mecanico_id");

            entity.HasIndex(e => e.OtId, "ot_id");

            entity.Property(e => e.ManoObraId)
                .HasColumnType("int(11)")
                .HasColumnName("mano_obra_id");
            entity.Property(e => e.DescripcionTarea)
                .HasMaxLength(255)
                .HasColumnName("descripcion_tarea");
            entity.Property(e => e.HorasTrabajadas)
                .HasPrecision(5, 2)
                .HasColumnName("horas_trabajadas");
            entity.Property(e => e.MecanicoId)
                .HasColumnType("int(11)")
                .HasColumnName("mecanico_id");
            entity.Property(e => e.OtId)
                .HasColumnType("int(11)")
                .HasColumnName("ot_id");
            entity.Property(e => e.TarifaHora)
                .HasPrecision(6, 2)
                .HasColumnName("tarifa_hora");

            entity.HasOne(d => d.Mecanico).WithMany(p => p.ManoObras)
                .HasForeignKey(d => d.MecanicoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mano_obra_ibfk_2");

            entity.HasOne(d => d.Ot).WithMany(p => p.ManoObras)
                .HasForeignKey(d => d.OtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mano_obra_ibfk_1");
        });

        modelBuilder.Entity<OrdenesTrabajo>(entity =>
        {
            entity.HasKey(e => e.OtId).HasName("PRIMARY");

            entity.ToTable("ordenes_trabajo");

            entity.HasIndex(e => e.MecanicoAsignadoId, "mecanico_asignado_id");

            entity.HasIndex(e => e.RecepcionistaId, "recepcionista_id");

            entity.HasIndex(e => e.VehiculoId, "vehiculo_id");

            entity.Property(e => e.OtId)
                .HasColumnType("int(11)")
                .HasColumnName("ot_id");
            entity.Property(e => e.CostoTotal)
                .HasPrecision(10, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("costo_total");
            entity.Property(e => e.DescripcionProblema)
                .HasColumnType("text")
                .HasColumnName("descripcion_problema");
            entity.Property(e => e.Estado)
                .IsRequired()
                .HasColumnType("enum('Pendiente','Aprobado','En Proceso','Finalizado','Facturado','Cancelado')")
                .HasColumnName("estado");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.FechaFinalizacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_finalizacion");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.MecanicoAsignadoId)
                .HasColumnType("int(11)")
                .HasColumnName("mecanico_asignado_id");
            entity.Property(e => e.RecepcionistaId)
                .HasColumnType("int(11)")
                .HasColumnName("recepcionista_id");
            entity.Property(e => e.VehiculoId)
                .HasColumnType("int(11)")
                .HasColumnName("vehiculo_id");

            entity.HasOne(d => d.MecanicoAsignado).WithMany(p => p.OrdenesTrabajoMecanicoAsignados)
                .HasForeignKey(d => d.MecanicoAsignadoId)
                .HasConstraintName("ordenes_trabajo_ibfk_3");

            entity.HasOne(d => d.Recepcionista).WithMany(p => p.OrdenesTrabajoRecepcionista)
                .HasForeignKey(d => d.RecepcionistaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ordenes_trabajo_ibfk_2");

            entity.HasOne(d => d.Vehiculo).WithMany(p => p.OrdenesTrabajos)
                .HasForeignKey(d => d.VehiculoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ordenes_trabajo_ibfk_1");
        });

        modelBuilder.Entity<PiezasUsadasOt>(entity =>
        {
            entity.HasKey(e => e.DetalleId).HasName("PRIMARY");

            entity.ToTable("piezas_usadas_ot");

            entity.HasIndex(e => e.OtId, "ot_id");

            entity.HasIndex(e => e.PiezaId, "pieza_id");

            entity.Property(e => e.DetalleId)
                .HasColumnType("int(11)")
                .HasColumnName("detalle_id");
            entity.Property(e => e.CantidadUsada)
                .HasColumnType("int(11)")
                .HasColumnName("cantidad_usada");
            entity.Property(e => e.OtId)
                .HasColumnType("int(11)")
                .HasColumnName("ot_id");
            entity.Property(e => e.PiezaId)
                .HasColumnType("int(11)")
                .HasColumnName("pieza_id");
            entity.Property(e => e.PrecioUnitario)
                .HasPrecision(10, 2)
                .HasColumnName("precio_unitario");

            entity.HasOne(d => d.Ot).WithMany(p => p.PiezasUsadasOts)
                .HasForeignKey(d => d.OtId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("piezas_usadas_ot_ibfk_1");

            entity.HasOne(d => d.Pieza).WithMany(p => p.PiezasUsadasOts)
                .HasForeignKey(d => d.PiezaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("piezas_usadas_ot_ibfk_2");
        });

        modelBuilder.Entity<Presupuesto>(entity =>
        {
            entity.HasKey(e => e.PresupuestoId).HasName("PRIMARY");

            entity.ToTable("presupuestos");

            entity.HasIndex(e => e.ClienteId, "cliente_id");

            entity.Property(e => e.PresupuestoId)
                .HasColumnType("int(11)")
                .HasColumnName("presupuesto_id");
            entity.Property(e => e.ClienteId)
                .HasColumnType("int(11)")
                .HasColumnName("cliente_id");
            entity.Property(e => e.Estado)
                .IsRequired()
                .HasColumnType("enum('Pendiente','Aprobado','Rechazado','Convertido a OT')")
                .HasColumnName("estado");
            entity.Property(e => e.FechaEmision)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("fecha_emision");
            entity.Property(e => e.TotalEstimado)
                .HasPrecision(10, 2)
                .HasColumnName("total_estimado");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Presupuestos)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("presupuestos_ibfk_1");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RolId).HasName("PRIMARY");

            entity.ToTable("roles");

            entity.HasIndex(e => e.NombreRol, "nombre_rol").IsUnique();

            entity.Property(e => e.RolId)
                .HasColumnType("int(11)")
                .HasColumnName("rol_id");
            entity.Property(e => e.NombreRol)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("nombre_rol");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PRIMARY");

            entity.ToTable("usuarios");

            entity.HasIndex(e => e.Email, "email").IsUnique();

            entity.HasIndex(e => e.RolId, "rol_id");

            entity.Property(e => e.UsuarioId)
                .HasColumnType("int(11)")
                .HasColumnName("usuario_id");
            entity.Property(e => e.Activo)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("activo");
            entity.Property(e => e.Apellido)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("apellido");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.PasswordHash)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("password_hash");
            entity.Property(e => e.RolId)
                .HasColumnType("int(11)")
                .HasColumnName("rol_id");

            entity.HasOne(d => d.Rol).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("usuarios_ibfk_1");
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.VehiculoId).HasName("PRIMARY");

            entity.ToTable("vehiculos");

            entity.HasIndex(e => e.ClienteId, "cliente_id");

            entity.HasIndex(e => e.Placa, "placa").IsUnique();

            entity.Property(e => e.VehiculoId)
                .HasColumnType("int(11)")
                .HasColumnName("vehiculo_id");
            entity.Property(e => e.Anio)
                .HasColumnType("int(11)")
                .HasColumnName("anio");
            entity.Property(e => e.ClienteId)
                .HasColumnType("int(11)")
                .HasColumnName("cliente_id");
            entity.Property(e => e.Kilometraje)
                .HasColumnType("int(11)")
                .HasColumnName("kilometraje");
            entity.Property(e => e.Marca)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("marca");
            entity.Property(e => e.Modelo)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("modelo");
            entity.Property(e => e.Placa)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("placa");
            entity.Property(e => e.TipoMotor)
                .IsRequired()
                .HasColumnType("enum('Diesel','Eléctrico','Híbrido')")
                .HasColumnName("tipo_motor");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Vehiculos)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("vehiculos_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
