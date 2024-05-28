use master;
go
drop database if exists ispit;
go
create database ispit collate Croatian_CI_AS;
go

use ispit;

create table IspitniRok(
sifra int not null primary key identity(1,1),
predmet varchar(100) not null,
vrstaIspita varchar(100) not null,
datum datetime,
pristupio bit not null
);

create table Pristupnici(
sifra int not null primary key identity(1,1),
ispitniRok int not null,
student varchar(100) not null,
brojBodova int not null,
ocjena int not null
);

alter table Pristupnici add foreign key (ispitniRok) references IspitniRok(sifra);