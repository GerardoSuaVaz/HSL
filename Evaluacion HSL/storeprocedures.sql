/*Agregar*/
create procedure cEmpleados 
      @Nombre varchar (30),
      @Apellido varchar (70),
      @Curp varchar (18),
      @Rfc varchar (13),
	  @fechaNacimiento date,
      @idPuesto int 
as
begin
      insert into Empleado values (@Nombre, @Apellido, @Curp, @Rfc, @fechaNacimiento, @idPuesto)
end

exec cEmpleados @Nombre = 'Juan Gerardo', 
                @Apellido = 'Suarez Vasquez', 
				@Curp = 'SUVJ920930HOCRSN05', 
				@Rfc = 'SUVJ920930MC4', 
				@fechaNacimiento = '09-30-1992',
				@idPuesto = 1
/*Detalles/Consultar*/
create procedure rEmpleados (@idEmpleado int)
as
begin
   select * from Empleado
   where idEmpleado = @idEmpleado
end

exec rEmpleados @idEmpleado = 6
/*Actualizar*/
create procedure uEmpleados (@idEmpleado int, 
                             @Nombre varchar (30),
                             @Apellido varchar (70),
                             @Curp varchar (18),
                             @Rfc varchar (13),
	                         @fechaNacimiento date,
                             @idPuesto int)
as
begin
   update Empleado set Nombre = @Nombre, 
                       Apellido  = @Apellido,
                       Curp  = @Curp,
                       Rfc = @Rfc,
                       fechaNacimiento = @fechaNacimiento, 
                       idPuesto = @idPuesto
		  where idEmpleado = @idEmpleado
end
 /*Eliminar */       
exec uEmpleados @idEmpleado = 1, 
                @Nombre ='Gerardo' , 
                @Apellido = 'Suarez', 
				@Curp ='SUVJ920930HOCRN05',
				@Rfc = 'SUVJ920930MC4',
				@fechaNacimiento = '09-30-1992',
				@idPuesto = 1

create procedure dEmpleados  @idEmpleado int
as
begin
    delete from Empleado where idEmpleado = @idEmpleado
end

exec dEmpleados @idEmpleado = 1
