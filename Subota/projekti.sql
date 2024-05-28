use master;
go
drop database if exists projekti;
go
create database projekti collate Croatian_CI_AS;
go

use projekti;

create table projekt(
sifra int not null primary key identity(1,1),
naziv varchar(45),
datumpocetka datetime,
datumkraja datetime
);

create table odjel(
sifra int not null primary key identity(1,1),
naziv varchar(45)
);

create table sudjeluje(
zaposlenik int not null,
projekt int not null,
datumpristupanja datetime
);

create table zaposlenik(
sifra int not null primary key identity(1,1),
nadredeni int,
ime varchar(45),
prezime varchar(45),
datumrodenja datetime,
placa decimal(18,2),
odjel int not null
);

alter table sudjeluje add foreign key (projekt) references projekt(sifra);
alter table sudjeluje add foreign key (zaposlenik) references zaposlenik(sifra);
alter table zaposlenik add foreign key (nadredeni) references zaposlenik(sifra);
alter table zaposlenik add foreign key (odjel) references odjel(sifra);
