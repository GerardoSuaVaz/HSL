using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPuesto
    {
        DPuesto dpuesto = new DPuesto();

        public List<Puesto> Consultar()
        { 
          return dpuesto.Consultar();
        }
    }
}
