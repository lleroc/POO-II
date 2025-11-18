
namespace _02_CRUD.Controladores
{
    using _02_CRUD.Config;
    using _02_CRUD.Modelos;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics.CodeAnalysis;
    using System.Security.Permissions;

    public class Usuarios_Controller
    {
        private Usuario_Model _usuario_Model = new Usuario_Model();
        private readonly conexion _cn = new conexion();
        
        public List<Usuario_Model> todos_usuarios() {
            
            var lista_usaurios = new List<Usuario_Model>();
            using (var con = _cn.obtenerConexion())
            {
                con.Open();
                string cadena = "select *, (Nombre_Usuario + ' ' + Apellido_Usuario) as nombre_completo from usuarios order by nombre_completo";

                using (var command = new SqlCommand(cadena, con))
                {
                    using (var lector = command.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var usuario = new Usuario_Model
                            {
                                Apellido_Usuario = lector["Apellido_Usuario"].ToString(),
                                Cedula_Usuario = lector["Cedula_Usuario"].ToString(),
                                contasenia = lector["contasenia"].ToString(),
                                Nombre_Usuario = lector["Nombre_Usuario"].ToString(),
                                Estado = Convert.ToBoolean(lector["Estado"]),
                                Fecha_Ingreso = Convert.ToDateTime(lector["Fecha_Ingreso"]),
                                Id_Usuario = (int)lector["Id_Usuario"],
                                nombre_completo = lector["nombre_completo"].ToString()
                            };
                            lista_usaurios.Add(usuario);
                        }
                    }
                }

            }
        
            return lista_usaurios;
        }


        public (Usuario_Model, string error) insertar(Usuario_Model usuario) {

            if (usuario == null) return (null,"Los campos son requeridos");

            using (var cn = _cn.obtenerConexion())
            {
                
                string cadena = @"insert into usuarios(Nombre_Usuario, Apellido_Usuario, Cedula_Usuario,  Estado, contasenia, Correo_Usuario) values (@Nombre_Usuario, @Apellido_Usuario, @Cedula_Usuario, @Estado,@contasenia, @Correo_Usuario); select CAST(scope_identity() as int)";

                using (var cmd = new SqlCommand(cadena, cn))
                {
                    cmd.Parameters.Add("@Nombre_Usuario", SqlDbType.NVarChar,50).Value = usuario.Nombre_Usuario;
                    cmd.Parameters.Add("@Apellido_Usuario", SqlDbType.NVarChar, 50).Value = usuario.Apellido_Usuario;
                    cmd.Parameters.Add("@Cedula_Usuario", SqlDbType.NVarChar, 50).Value = usuario.Cedula_Usuario;
                    cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = usuario.Estado;
                    cmd.Parameters.Add("@contasenia", SqlDbType.NVarChar, 50).Value = usuario.contasenia;
                    cmd.Parameters.Add("@Correo_Usuario", SqlDbType.NVarChar, 50).Value = usuario.Correo_Usuario;

                    try
                    {
                        cn.Open();
                        int id = (int)cmd.ExecuteScalar();
                        if (id >= 1)
                        {
                            usuario.Id_Usuario = id;
                            return (usuario,"");
                        }
                        else { 
                            return (null,"Ocurrio un error al guardar");
                        }
                    }
                    catch (Exception ex)
                    {
                        return (null, "Ocurrio un error al guardar" + ex.Message);
                    }
                }
            }
        
        
        }


        public int eliminar(int Id_Usuario) {
            if (Id_Usuario == 0) return 1;  // id vacio
            using (var cn = _cn.obtenerConexion())
            {
                string cadena = @"delete from Usuarios where Id_Usuario = @Id_Usuario";
                using (var cmd = new SqlCommand(cadena,cn))
                {
                    cmd.Parameters.Add("Id_Usuario", SqlDbType.Int).Value = Id_Usuario;
                    cn.Open();
                    try
                    {
                        int filaafectadas = cmd.ExecuteNonQuery();
                        if (filaafectadas > 0)
                        {
                            return 2 ; // ok se guardo con exito
                        }
                        else {
                            return 3 ; //error al guardar
                        }
                    }
                    catch (Exception ex)
                    {
                        return 4; // error 
                    }
                }

            }
        
        }
    }
}
