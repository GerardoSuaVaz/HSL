//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class empleadosEntities : DbContext
    {
        public empleadosEntities()
            : base("name=empleadosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Puesto> Puesto { get; set; }
    
        public virtual int cEmpleados(string nombre, string apellido, string curp, string rfc, Nullable<System.DateTime> fechaNacimiento, Nullable<int> idPuesto)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var curpParameter = curp != null ?
                new ObjectParameter("Curp", curp) :
                new ObjectParameter("Curp", typeof(string));
    
            var rfcParameter = rfc != null ?
                new ObjectParameter("Rfc", rfc) :
                new ObjectParameter("Rfc", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("fechaNacimiento", fechaNacimiento) :
                new ObjectParameter("fechaNacimiento", typeof(System.DateTime));
    
            var idPuestoParameter = idPuesto.HasValue ?
                new ObjectParameter("idPuesto", idPuesto) :
                new ObjectParameter("idPuesto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("cEmpleados", nombreParameter, apellidoParameter, curpParameter, rfcParameter, fechaNacimientoParameter, idPuestoParameter);
        }
    
        public virtual int dEmpleados(Nullable<int> idEmpleado)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("idEmpleado", idEmpleado) :
                new ObjectParameter("idEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dEmpleados", idEmpleadoParameter);
        }
    
        public virtual ObjectResult<rEmpleados_Result> rEmpleados(Nullable<int> idEmpleado)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("idEmpleado", idEmpleado) :
                new ObjectParameter("idEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<rEmpleados_Result>("rEmpleados", idEmpleadoParameter);
        }
    
        public virtual int uEmpleados(Nullable<int> idEmpleado, string nombre, string apellido, string curp, string rfc, Nullable<System.DateTime> fechaNacimiento, Nullable<int> idPuesto)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("idEmpleado", idEmpleado) :
                new ObjectParameter("idEmpleado", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var curpParameter = curp != null ?
                new ObjectParameter("Curp", curp) :
                new ObjectParameter("Curp", typeof(string));
    
            var rfcParameter = rfc != null ?
                new ObjectParameter("Rfc", rfc) :
                new ObjectParameter("Rfc", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("fechaNacimiento", fechaNacimiento) :
                new ObjectParameter("fechaNacimiento", typeof(System.DateTime));
    
            var idPuestoParameter = idPuesto.HasValue ?
                new ObjectParameter("idPuesto", idPuesto) :
                new ObjectParameter("idPuesto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uEmpleados", idEmpleadoParameter, nombreParameter, apellidoParameter, curpParameter, rfcParameter, fechaNacimientoParameter, idPuestoParameter);
        }
    }
}
