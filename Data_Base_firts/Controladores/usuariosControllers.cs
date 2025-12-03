using Data_Base_firts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Base_firts.Controladores
{
    public class usuariosControllers
    {
        private readonly MecanicaContext _context = new MecanicaContext();
        public List<Usuario> GetAllUsuarios()
        {
            return _context.Usuarios.Include(rol => rol.Rol).ToList();
        }
        public Usuario GetUsuarioById(int id)
        {
            return _context.Usuarios.Include(rol => rol.Rol)
                .FirstOrDefault(u => u.UsuarioId == id);
                
        }
        public void AddUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }
        public void UpdateUsuario(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }
        public void DeleteUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }
        public Usuario Authenticate(string email, string password)
        {
            return _context.Usuarios.Include(rol => rol.Rol)
                .FirstOrDefault(u => u.Email == email && u.PasswordHash == password);
        }
    }
}
