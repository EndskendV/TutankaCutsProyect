create database Tutankacuts
go
use tutankacuts
go
create table Usuarios(USR varchar(50),PSWRD varchar(50), TipoUSR varchar(50),IDuser int)
insert into Usuarios values ('Misa',123,'Admin',1)
insert into Usuarios (USR,PSWRD,TipoUSR,IDuser) values ('Jose',123,'Recepcionista',2)
alter table usuarios alter column USR varchar(50) not null
alter table Usuarios add Constraint PK_Usr primary key(USR)
alter table usuarios  add Nombre varchar(50), Apellido varchar(50)
alter table usuarios  add Sueldo money  null,  Horario varchar(50)  null
USE [Tutankacuts]
GO
select * from Usuarios

  update Usuarios set PSWRD=456 where USR='jose'

GO

create table Client(NameC varchar(50),APC varchar(50), Tel varchar(15) primary key,
Mail varchar(50), FNAC date)
go
/*
drop Rule NumberRule as @Value like '[0-9]';;--Limita a 15 NUms
go
exec sp_unbindrule 'Client.Tel'*/
go
alter table Client add constraint CheckDate Check(FNAC<getdate())
go
create view VistaName as Select Tel,NameC from Client
go
create table Citas(Tel varchar(15),NameC varchar(50),FCita date, TimeAtt Time,
Barbero varchar(50),Tipo varchar(50), Asist varchar(50))

select * from VistaName where Tel like '66481%'
go
Create view Barberos as Select Nombre  from Usuarios where TipoUSR like 'Barbero'
go
select * from Barberos
use tutankacuts
alter table Citas
create proc 
