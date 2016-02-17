create database dbAS

go

use  dbAS


create table Perfil(
idPerfil int identity primary key not null,
descripcion nvarchar(50)
)

create table Usuario(
idUsuario int identity primary key not null,
nombre nvarchar(50),
usuario nvarchar(50),
contrasena nvarchar(50),
perfil int not null,
foreign key (perfil) references Perfil(idPerfil)
)

create table Evento(
idEvento int identity primary key not null,
fecha date,
nombre nvarchar(50),
)

create table Miembro(
idMiembro nvarchar(50),
nombre nvarchar(75),
numeroCedula nvarchar(50) primary key not null,
correo nvarchar(50),
telefono nvarchar(60),
Estado int,
Confirmo int,
Elimino int default(0)
)

create table EventoMiembro(
idEM int identity primary key not null,
evento int not null,
miembro nvarchar(50),
fecha date,
usuario int not null,
estado int default(0),
foreign key (usuario) references Usuario(idUsuario),
foreign key (miembro) references Miembro(numeroCedula),
foreign key (evento) references Evento(idEvento)
)