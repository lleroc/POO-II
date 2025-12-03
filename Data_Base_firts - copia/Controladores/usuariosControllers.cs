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
            return _context.Usuarios
                .Where(u => u.Activo == true)
                .Include(rol => rol.Rol)
                .OrderBy(u => u.Nombre)
                .ToList();
        }
        public Usuario GetUsuarioById(int id)
        {
            return _context.Usuarios
                .Where(u => u.Activo == true)
                .Include(rol => rol.Rol)
                .FirstOrDefault(u => u.UsuarioId == id);
                
        }
        public bool AddUsuario(Usuario usuario)
        {
            try
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
        public bool UpdateUsuario(Usuario usuario)
        {
           try
            {
                //_context.Usuarios.Update(usuario);
                var usu = _context.Usuarios.Find(usuario.UsuarioId);
                if (usu != null)
                {
                    usu.RolId = usuario.RolId;
                    usu.Nombre = usuario.Nombre;
                    usu.Apellido = usuario.Apellido;
                    usu.Email = usuario.Email;
                    usu.PasswordHash = usuario.PasswordHash;
                    usu.Activo = usuario.Activo;
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
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
        public bool EmailExists(string email)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == email);
            if (usuario == null)
            {
                return true;  //no existen registr con ese email
            }
            else
            {
                return false; //existen registro con ese email
            }
        }
        public List<Role> GetAllRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
