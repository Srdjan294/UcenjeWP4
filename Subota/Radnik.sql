use master;
go
drop database if exists radnik;
go
create database radnik collate Croatian_CI_AS;
go

use radnik;


create table radnik(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
nadredeni int not null
);

alter table radnik add foreign key (nadredeni) references radnik(sifra);