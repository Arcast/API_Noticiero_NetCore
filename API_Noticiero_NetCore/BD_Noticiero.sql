
--create database Noticiero

use Noticiero

create table Autor(
AutorID int identity(1,1) primary key,
nombre varchar(100),
Apellido varchar(100)
)

create table Noticia(
NoticiaId int identity(1,1) primary key,
Titulo varchar(120),
Descripcion varchar(200),
Contenido varchar(max),
Fecha datetime,
AutorID int,
constraint fk_NotiAut foreign key (AutorID) references Autor(AutorID)
)
