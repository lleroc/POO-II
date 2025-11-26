

namespace _02_CRUD.Controladores
{
    using _02_CRUD.Config;
    using _02_CRUD.Modelos;
    using System.Data;
    using System.Data.SqlClient;
    public class AuthController
    {
        private readonly conexion _cn = new conexion();

        public Usuario_Model login1(Login_Model login) {

            using (var cn = _cn.obtenerConexion())
            {
                cn.Open();
                string cadena = "SELECT Usuarios.* FROM " + 
                    "Usuarios where" + 
                    " Correo_Usuario ='" + login.Correo_Usuario +"' " +
                    "and contasenia = '"+ login.contasenia +"' and estado=1 ";

                using (SqlCommand cmd = new SqlCommand(cadena, cn))
                {
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        if (lector == null) return null;
                        lector.Read();
                        Usuario_Model usuario = new Usuario_Model
                        {
                            Apellido_Usuario = lector["Apellido_Usuario"].ToString(),
                             Cedula_Usuario = lector["Cedula_Usuario"].ToString(),
                             contasenia = lector["contasenia"].ToString(),
                             Correo_Usuario = lector["Correo_Usuario"].ToString(),
                             Estado = (bool)lector["Estado"],
                             Nombre_Usuario = lector["Nombre_Usuario"].ToString(),
                             Id_Usuario = (int)lector["Id_Usuario"],
                        };
                        return usuario;
                    }

                }


            }
        
        }



        public Usuario_Model login2(Login_Model login)
        {

            using (var cn = _cn.obtenerConexion())
            {
                cn.Open();
                string cadena = "SELECT Usuarios.* FROM " +
                    "Usuarios where" +
                    " Correo_Usuario ='" + login.Correo_Usuario + "' " +
                     "and estado=1 ";

                using (SqlCommand cmd = new SqlCommand(cadena, cn))
                {
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        if (lector.HasRows){
                            lector.Read();
                            if (lector["contasenia"].ToString() == login.contasenia)
                            {
                                Usuario_Model usuario = new Usuario_Model
                                {
                                    Apellido_Usuario = lector["Apellido_Usuario"].ToString(),
                                    Cedula_Usuario = lector["Cedula_Usuario"].ToString(),
                                    contasenia = lector["contasenia"].ToString(),
                                    Correo_Usuario = lector["Correo_Usuario"].ToString(),
                                    Estado = (bool)lector["Estado"],
                                    Nombre_Usuario = lector["Nombre_Usuario"].ToString(),
                                    Id_Usuario = (int)lector["Id_Usuario"],
                                };
                                return usuario;
                            }
                            else
                            {
                                return null;
                            }

                        }
                        else
                        {
                            return null;
                        }


                    }

                }


            }

        }

        public bool VerificaCedula(char[] validarCedula)
        {
            int aux = 0, par = 0, impar = 0, verifi;
            for (int i = 0; i < 9; i += 2)
            {
                aux = 2 * int.Parse(validarCedula[i].ToString());
                if (aux > 9)
                    aux -= 9;
                par += aux;
            }
            for (int i = 1; i < 9; i += 2)
            {
                impar += int.Parse(validarCedula[i].ToString());
            }

            aux = par + impar;
            if (aux % 10 != 0)
            {
                verifi = 10 - (aux % 10);
            }
            else
                verifi = 0;
            if (verifi == int.Parse(validarCedula[9].ToString()))
                return true;
            else
                return false;
        }
    }
}
