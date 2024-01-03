create database exafinalpe;
go
use exafinalpe;
go
create table telefono(
codTels int primary key identity,
telefono varchar(9),
telDescrip varchar(30)
);
go
create table departamento(
idDepartamento int primary key identity,
nombreDepto varchar(30),
cantEmpleados int,
codTels int

);
go
alter table departamento
add constraint fkCodTels
foreign key(codTels)
references telefono(codTels)
go
create table empleado(
codEmpleado int primary key identity,
nombres varchar(30),
apellidos varchar(30),
idDepartamento int,
salario float,
edad int
);
go
alter table empleado
add constraint fk_idDepartamento
foreign key(idDepartamento)
references departamento(idDepartamento);

select * from empleado;

select * from departamento;

select * from telefono;

create procedure rptTelefono
@idDep int
as
select t.telefono ,d.idDepartamento, d.nombreDepto from departamento d inner join telefono t on d.codTels = t.codTels where idDepartamento = @idDep;


create procedure rptEmpleado
@salario decimal (6,2)
as
select * from empleado where salario >= @salario;




create procedure rptDepartamento
@cantidadE int
as
select * from departamento where cantEmpleados >= @cantidadE;

exec rptDepartamento @cantidadE = 8;