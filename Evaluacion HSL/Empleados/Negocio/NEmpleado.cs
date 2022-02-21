using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEmpleado
    {
        DEmpleado dEmpleado = new DEmpleado();
        public void Agregar(Empleado nEmpleado)
        {
            dEmpleado.Agregar(nEmpleado);
        }

        public List<Empleado> Consultar()
        { 
            return dEmpleado.Consultar();
        }

        public Empleado Consultar(int id)
        { 
          return dEmpleado.Consultar(id);
        }

        public void Actualizar(Empleado empleado) 
        {
            dEmpleado.Actualizar(empleado);
        }

        public void Eliminar(int id)
        { 
            dEmpleado.Eliminar(id);
        }
    }
}
