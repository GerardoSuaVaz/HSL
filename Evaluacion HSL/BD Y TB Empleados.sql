create database empleados;

use empleados;

create table Puesto(
idPuesto int primary key identity(1,1) not null,
clave varchar (10) not null,
nomPuesto varchar (60) not null
);

select * from Puesto;

create table Empleado(
idEmpleado int primary key identity(1,1) not null,
Nombre varchar (30) not null,
Apellido varchar (70) not null,
Curp varchar (18) not null,
Rfc varchar (13) not null,
fechaNacimiento date not null,
idPuesto int not null,
foreign key (idPuesto) References Puesto(idPuesto) 
);

select * from Empleado;

insert into Puesto values ('ADMIN', 'Administracion') 
insert into Puesto values ('CONT', 'Contabilidad')
insert into Puesto values ('MANT', 'Mantenimiento')
insert into Puesto values ('VENT', 'Ventas')
insert into Puesto values ('FIN', 'Finanzas')

