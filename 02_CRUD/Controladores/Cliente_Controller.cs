namespace _02_CRUD.Controladores
{
    using _02_CRUD.Config;
    using _02_CRUD.Modelos;
    using Microsoft.Identity.Client;

    public class Cliente_Controller
    {
        public readonly sqlServer_dbcontext _Ciente_Dbcontext = new sqlServer_dbcontext();
        public List<ClienteModel> todos() {
            var list = new List<ClienteModel>();
            list = _Ciente_Dbcontext.Clientes.ToList();
            foreach (var item in list) {
                item.Nombre_Completo = item.Nombres + " " + item.Apellidos;
            }
            return list;
        }

        public ClienteModel uno(int id) {
            return _Ciente_Dbcontext.Clientes.FirstOrDefault(c => c.id == id);
        }

        public string insertar(ClienteModel clienteModel) {
            if (clienteModel == null)
            {
                return "Debe completar las cajas de texto para guardar al cliente";
            }
            else { 
                _Ciente_Dbcontext.Add(clienteModel);
                _Ciente_Dbcontext.SaveChanges();
                return "ok";
            }
        }

        public string editar(ClienteModel clienteModel) {
            if (clienteModel == null)
            {
                return "Debe completar las cajas de texto para guardar al cliente";
            }
            else
            {
                //_Ciente_Dbcontext.Update(clienteModel);
                var cliente = _Ciente_Dbcontext.Clientes.FirstOrDefault(c=> c.id == clienteModel.id);
                
                cliente.Nombres = clienteModel.Nombres;
                cliente.Apellidos = clienteModel.Apellidos;
                cliente.Direcion = clienteModel.Direcion;
                cliente.Estado = clienteModel.Estado;
                cliente.RUC = clienteModel.RUC;
                cliente.Telefono = clienteModel.Telefono;
                cliente.Correo = clienteModel.Correo;

                _Ciente_Dbcontext.SaveChanges();
                return "ok";
            }
        }

        public string eliminar(int id) {
            if (id !=0)
            {
                _Ciente_Dbcontext.Remove(id);
                _Ciente_Dbcontext.SaveChanges();
                return "ok";
            }
            else
            {
                return "Seleccion un Cliente para eliminarlo";
            }
        }
       public string eliminacion_suave(int id) {
            if (id <= 0) return "Error al eliminar, el usuario no existe";
            var cliente = _Ciente_Dbcontext.Clientes.FirstOrDefault(c => c.id == id);
            if (cliente != null)
            {
                cliente.Estado = false;
                _Ciente_Dbcontext.SaveChanges();
                return "ok";
            }
            else
            {
                return "Ocurio un error al guardar";
            }
       }
    }
}
