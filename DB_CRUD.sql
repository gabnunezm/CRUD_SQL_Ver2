create database Practica
go


-- PRODUCTOS
select * from Productos
create table Productos 
(
Id int identity (1,1) primary key,
Nombre nvarchar (100),
Descripcion nvarchar (100),
Marca nvarchar (100),
Precio float,
Stock int
)

insert into Productos 
values
('Gaseosa','3 litros','marcacola',7.5,24),
('Chocolate','Tableta 100 gramos','iberica',12.5,36)

--USUARIOS
CREATE TABLE Usuarios
(
  [Id_Usuario] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  [Nombre] VARCHAR (50) NULL,
  [Usuario] VARCHAR (50) 
NULL,
  [Password] VARCHAR (50) NULL,
  [Tipo_usuario] VARCHAR (50) NULL
)

Select * from Usuarios 

Insert into Usuarios values ('Mario', 'Mario03', '123' , 'admin'),
('Jose' , 'Jose03', '123', 'Usuario');





---PROCEDIMIENTOS ALMACENADOS 
--------------------------MOSTRAR 
go
create proc MostrarProductos
as
select *from Productos
go

--------------------------INSERTAR 
create proc InsetarProductos
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@precio float,
@stock int
as
insert into Productos values (@nombre,@descrip,@marca,@precio,@stock)
go

------------------------ELIMINAR
create proc EliminarProducto
@idpro int
as
delete from Productos where Id=@idpro
go
------------------EDITAR

create proc EditarProductos
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@precio float,
@stock int,
@id int
as
update Productos set Nombre=@nombre, Descripcion=@descrip, Marca=@marca, Precio=@precio, Stock=@stock where Id=@id
go