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
go
alter table Client add constraint CheckDate Check(FNAC<getdate())
go
create view VistaName as Select Tel,NameC from Client
go
use tutankacuts
create table Citas(Tel varchar(15),NameC varchar(50),FCita date, TimeAtt Time,
Barbero varchar(50),Tipo varchar(50), Asist varchar(50),CitaNum int identity(1,1) primary key)

alter table dbo.Citas add constraint chk_Tel2 check (Tel not like '%[a-Z]%')
alter table Client add constraint chk_tel check (Tel not like '%[a-Z]%')
go
insert into Citas (Tel )values ('667f6666')
select * from Citas

select * from VistaName where Tel like '%66481%'
go
Create view Barberos as Select Nombre  from Usuarios where TipoUSR like 'Barbero'
go
select * from Barberos

use Tutankacuts
create table Productos(IDProduct int identity(1,1) primary key, NameProducto varchar(50),
Unidades int default 0,TipoPrd varchar(50),Price money, Contenido varchar(50),
Proveedor varchar(50))
alter table Productos add constraint Chk_Unidades check(Unidades>=0)
insert into Productos values ('Shampoo',40,'Shampoo',65,'245 mL','P1'),
('Jabon',default,'Jabon',65,'45 g','P2')

go
CREATE FUNCTION CalcularPago (@IDProduct int, @Cantidad int)
RETURNS money
AS
BEGIN
    DECLARE @Price money;
    SELECT @Price = Price FROM Productos WHERE IDProduct = @IDProduct;
    RETURN @Price * @Cantidad;
END
go
CREATE TABLE Venta (
    IDVenta int identity(1,1) primary key,
    IDProduct int foreign key references Productos(IDProduct),
    Cantidad int,
    Pago AS dbo.CalcularPago(IDProduct, Cantidad),
    RecibioUSR varchar(50) foreign key references Usuarios(USR),
	FechaVenta date default getdate()
);
