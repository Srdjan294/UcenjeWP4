use master;
go
drop database if exists racun;
go
create database racun collate Croatian_CI_AS;
go

use racun;

create table Racun(
sifra int not null primary key identity(1,1),
redniBroj int not null,
datum datetime,
kupac varchar(55),
placeno bit not null
);

create table StavkeRacuna(
racun int not null,
artikl varchar(55),
cijena decimal(18,2) not null,
kolicina int not null,
pospust decimal(18,2) not null
);

alter table StavkeRacuna add foreign key (racun) references racun(sifra);