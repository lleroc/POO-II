using _01_Proyecto_1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Proyecto_1.Controladores
{
    public class DocenteController
    {
        List<DocenteModelo> listaDocente = new List<DocenteModelo>();
        public DocenteController() { }

        public List<DocenteModelo> todos()
        {
            return listaDocente;
        }
        public DocenteModelo uno(int id)
        {
            return listaDocente.FirstOrDefault(d => d.Id == id);
        }
        public (bool, string error) insertar(DocenteModelo modelo)
        {
            try
            {
                listaDocente.Add(modelo);
                return (true, null);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string error) actualizar(int id, DocenteModelo modelo)
        {
            try
            {
                var docente = listaDocente.FirstOrDefault(d => d.Id == id);
                if (docente.Id != id)
                {
                    return (false, "No se encontro el usuario");
                }
                docente = modelo;
                return (true, null);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
        public (bool, string error) eliminar(int id)
        {
            try
            {
                var docente = listaDocente.FirstOrDefault(d => d.Id == id);
                listaDocente.Remove(docente);
                return (true, null);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

    }
}
