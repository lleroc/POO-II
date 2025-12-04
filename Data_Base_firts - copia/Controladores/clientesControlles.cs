using Data_Base_firts.Models;


namespace Data_Base_firts.Controladores
{
    public class clientesControlles
    {
        private readonly MecanicaContext _context = new MecanicaContext();
        public List<Cliente> GetAllClientes()
        {
            return _context.Clientes.OrderBy(u => u.Nombre).ToList();
        }
        public Cliente GetUsuarioById(int id)
        {
            return _context.Clientes
                .FirstOrDefault(u => u.ClienteId == id);

        }
        public bool AddCliente(Cliente cliente)
        {
            try
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Updatecliente(Cliente cliente)
        {
            try
            {
                //_context.Usuarios.Update(usuario);
                var cliente1 = _context.Clientes.Find(cliente.ClienteId);
                if (cliente1 != null)
                {
                    cliente1.Nombre = cliente.Nombre;
                    cliente1.Apellido = cliente.Apellido;
                    cliente1.Email = cliente.Email;
                    cliente1.Telefono = cliente.Telefono;
                    cliente1.Direccion = cliente.Direccion;
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteCliente(int id)
        {
            try
            {
                var cliente1 = _context.Clientes.Find(id);
                if (cliente1 != null)
                {
                    _context.Clientes.Remove(cliente1);
                    _context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
       
        public bool EmailExists(string email)
        {
            var cliente = _context.Clientes.FirstOrDefault(u => u.Email == email);
            if (cliente == null)
            {
                return true;  //no existen registr con ese email
            }
            else
            {
                return false; //existen registro con ese email
            }
        }
      
    }
}
