using Microsoft.EntityFrameworkCore;
namespace mysql.DATOS
{
    public class Mysql_DBContext:DbContext
    {
        public Mysql_DBContext(DbContextOptions<Mysql_DBContext> op):base(op)
        {
        }

        public DbSet<PacienteModel> Pacientes { get; set; }

    }
}
