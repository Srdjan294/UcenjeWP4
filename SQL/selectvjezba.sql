--use edunovaWP4;

select * from smjerovi where sifra=1;

select * from grupe;

select a.naziv as smjer, b.naziv as grupa, *
from smjerovi a inner join grupe b
on a.sifra = b.smjer
where b.naziv like '%4%';


select a.naziv as smjer, b.naziv as grupa, *
from smjerovi a left join grupe b
on a.sifra = b.smjer
where b.smjer is null;


select a.naziv as smjer, b.naziv as grupa, d.ime, d.prezime
from smjerovi a inner join grupe b
on a.sifra = b.smjer
inner join clanovi c on b.sifra = c.grupa
inner join polaznici d on c.polaznik = d.sifra;



select a.naziv as smjer, d.ime, d.prezime
from smjerovi a inner join grupe b
on a.sifra = b.smjer
inner join clanovi c on b.sifra = c.grupa
inner join polaznici d on c.polaznik = d.sifra
where b.naziv = 'WP5';



--use svastara;

-- izlistaj sve nazive općina u Osječko baranjskoj županiji

select b.naziv
from zupanije a inner join opcine b
on a.sifra = b.zupanija
where a.naziv like '%zadar%';


-- izlistati sve nazive mjesta u OBŽ

select b.naziv as opcina, c.naziv as mjesto
from zupanije a inner join opcine b
on a.sifra = b.zupanija
inner join mjesta c on b.sifra = c.opcina
where a.naziv like '%baranj%'
order by 1,2;


-- ispisati sve nazive općina s brojem mjesta 
-- u općinama u OBŽ

select b.naziv as opcina, count(b.naziv) as mjesta
from zupanije a inner join opcine b
on a.sifra = b.zupanija
inner join mjesta c on b.sifra = c.opcina
where a.naziv like '%baranj%'
group by b.naziv
having count(b.naziv) > 10
order by 2 desc;

-- izlistajte jedinstvena imena kupaca

select distinct ime from kupci order by 1;

-- koje ime se najčešće koristi

select prezime, count(sifra) from kupci 
group by prezime order by 2 desc;


select top 10 mjesto from kupci;

-- iz kojih mjesta dolaze koji kupci 
--( ne postoji vanjski ključ ali se podaci mogu spojiti)

select b.naziv, a.ime, a.prezime 
from kupci a inner join mjesta b
on a.mjesto = b.sifra;

update kupci set mjesto=9999999
where sifra = 15156;

select top 10 * from kupci;


--traženje igle u plastu sijena

select count(*) from artikli;
-- 52601

select distinct artikl from artiklinaprimci;
-- 52599

-- podupit

select * from artikli
where sifra not in 
(select distinct artikl from artiklinaprimci);

-- obriši ih
delete from artikli where sifra in(90661,79102);

