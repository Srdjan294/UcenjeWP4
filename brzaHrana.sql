use master;
go
drop database if exists brzaHrana;
go 
create database brzaHrana collate Croatian_CI_AS;
go

use brzaHrana;

create table korisnici(
sifra int not null primary key identity(1,1),
ime varchar(100) not null,
prezime varchar(100) not null,
email varchar(200) not null
);

create table jelovnici(
sifra int not null primary key identity(1,1),
naziv_jela varchar(100) not null,
kategorija varchar(100) not null,
cijena decimal(18,2) not null
);

create table narudzbe(
sifra int not null primary key identity(1,1),
korisnik int not null,
adresa varchar(200),
datum datetime not null,
ukupna_cijena decimal(18,2) not null,
);

create table stavke(
narudzba int not null,
jelovnik int not null,
kolicina int not null
);



alter table narudzbe add foreign key (korisnik) references korisnici(sifra);
alter table stavke add foreign key (narudzba) references narudzbe(sifra);
alter table stavke add foreign key (jelovnik) references jelovnici(sifra);