create table Araclar
(
id int identity(1,1),
plaka varchar(10)not null,
marka varchar(30) not null,
model varchar(100)not null,
yil smallint not null,
yakitturu char(1) not null,
vites char(1) not null,
motorhacmi smallint not null,
fiyat int not null,
sinif varchar(30) not null
);

alter table Araclar alter column fiyat decimal(10,2) not null;

alter proc sp_AracEkle
@plaka varchar(10),@marka varchar(30),@model varchar(100),@yil smallint,@yakitturu char(1),@vites char(1),@motorhacmi smallint,@fiyat decimal(10,2),@sinif char(1)
as
begin
insert into Araclar values
(@plaka,@marka,@model,@yil,@yakitturu,@vites,@motorhacmi,@fiyat,@sinif)
end;

exec sp_AracEkle '34FK2001','Dodge','Viper ACR',2017,'B','M',8400,10000,'S';

select * from Araclar;

create table Markalar
(
id int identity(1,1),
marka varchar(30) not null
);

delete from Araclar where marka = 'Dodge';

create table Yakitlar
(
id int identity(1,1),
yakitKodu char(1) not null,
yakitAdi varchar(10) not null
);

insert into Yakitlar values ('B','Benzin'),('D','Diesel'),('G','Gaz'),('E','Elektrik'),('H','Hibrit');

alter table Yakitlar add constraint PK_Yakitlar_yakitKodu primary key (yakitKodu);

alter table Araclar add foreign key (yakitturu)
references dbo.Yakitlar(yakitKodu);

exec sp_AracEkle '34FK2001','Dodge','Viper ACR',2017,'Y','M',8400,10000,'Spor'; --çalışmaz

create table Vitesler
(
id int identity(1,1),
vitesKodu char(1) not null,
vitesAdi varchar(25) not null
);

insert into Vitesler values ('M','Manuel'),('O','Otomatik'),('Y','Yarı Otomatik');

alter table Vitesler add constraint PK_Vitesler_vitesKodu primary key (vitesKodu);

select * from Vitesler;
select * from Yakitlar;

alter table Araclar add foreign key (vites)
references dbo.Vitesler(vitesKodu);

exec sp_AracEkle '34FK2001','Dodge','Viper ACR',2017,'B','U',8400,10000,'Spor'; --çalışmaz

insert into Markalar values
('Acura'),
('Aion'),
('Alfa Romeo'),
('Anadol'),
('Aston Martin'),
('Audi'),
('Bentley'),
('BMW'),
('Bugatti'),
('Buick'),
('Cadillac'),
('Caterham'),
('Chery'),
('Chevrolet'),
('Chrysler'),
('Citroën'),
('Dacia'),
('Daewoo'),
('Daihatsu'),
('Dodge'),
('DS Automobiles'),
('Eagle'),
('Ferrari'), 
('Fiat'),
('Fisker'), 
('Ford'),
('Geely'),
('Honda'),
('Hyundai'), 
('Ikco'),
('Infiniti'), 
('Jaguar'), 
('Kia'),
('Lada'),
('Lamborghini'),
('Lancia'),
('Leapmotor'),
('Lexus'),
('Lincoln'),
('Lotus'),
('Marcos'),
('Maserati'), 
('Mazda'),
('McLaren'),
('Mercedes-Benz'),
('MG'),
('Mini'),
('Mitsubishi'),
('Moskwitsch'),
('Nissan'), 
('Opel'),
('ORA'),
('Peugeot'),
('Pontiac'),
('Porsche'),
('Proton'),
('Renault'),
('RKS'),
('Rolls-Royce'), 
('Rover'),
('Saab'),
('Saturn'),
('Seat'),
('Skoda'),
('Smart'),
('Subaru'),
('Suzuki'),
('Tata'),
('Tesla'),
('Tofaş'),
('Toyota'),
('Volkswagen'),
('Volvo');

select * from Markalar;

alter table Markalar add constraint PK_Markalar_Marka primary key (marka);

alter table Araclar add foreign key (marka)
references dbo.Markalar(marka);

alter proc sp_AracListele
as
begin
select plaka as 'Plaka',
marka as 'Marka',
model as 'Model',
yil as 'Yıl',
yakitAdi as 'Yakıt Türü',
vitesAdi as 'Vites Türü',
motorhacmi as 'Motor Hacmi',
sinifAdi as 'Sınıf',
fiyat as 'Günlük Fiyat',
(((fiyat*7)*70)/100) as 'Haftalık Fiyat', --Haftalık %30 indirim
(((fiyat*30)*500)/100) as 'Aylık Fiyat' --Haftalık %50 indirim
from Araclar inner join Vitesler on Vitesler.vitesKodu = Araclar.vites inner join Yakitlar on Yakitlar.yakitKodu = Araclar.yakitturu
inner join Siniflar on Siniflar.sinifKodu = Araclar.sinif
end;

select plaka as 'Plaka',
marka as 'Marka',
model as 'Model',
yil as 'Yıl',
yakitAdi as 'Yakıt Türü',
vitesAdi as 'Vites Türü',
motorhacmi as 'Motor Hacmi',
sinifAdi as 'Sınıf'
from Araclar inner join Vitesler on Vitesler.vitesKodu = Araclar.vites inner join Yakitlar on Yakitlar.yakitKodu = Araclar.yakitturu
inner join Siniflar on Siniflar.sinifKodu = Araclar.sinif;

select * from Araclar inner join Vitesler on Vitesler.vitesKodu = Araclar.vites inner join Yakitlar on Yakitlar.yakitKodu = Araclar.yakitturu;

exec sp_AracListele;

alter table Araclar add constraint PK_Araclar_Plaka primary key (plaka);

select * from Yakitlar;

select * from Araclar;

delete from Araclar where marka = 'Maserati';

create table Siniflar
(
id int identity(1,1),
sinifKodu char(1) not null,
sinifAdi varchar(25) not null
);

insert into Siniflar values
('O','Otomobil'),
('P','Arazi, SUV & Pickup'),
('B','Motosiklet'),
('V','Minivan & Panelvan'),
('T','Ticari Araçlar'),
('E','Elektrikli Araçlar'),
('S','Spor Araçlar'),
('K','Klasik Araçlar'),
('D','Modifiye Araçlar'),
('A','ATV'),
('U','UTV'),
('N','Karavan');

select * from Siniflar;

delete from Araclar where marka = 'Dodge';
delete from Araclar where marka = 'Mini';

alter table Siniflar add constraint PK_Siniflar_SinifKodu primary key (sinifKodu);

alter table Araclar alter column sinif char(1) not null;

alter table Araclar add foreign key (sinif)
references dbo.Siniflar(sinifKodu);

insert into Siniflar values
('O','Otomobil'); --çalışmaz

exec sp_AracListele;

alter proc sp_AracBul
@marka varchar(30),@model varchar(100),@minyil smallint,@maxyil smallint,@yakitturu char(1),@vites char(1),@motorhacmimin smallint,@motorhacmimax smallint,@minfiyat decimal(10,2),@maxfiyat decimal(10,2)
as
begin
select plaka as 'Plaka',
marka as 'Marka',
model as 'Model',
yil as 'Yıl',
yakitAdi as 'Yakıt Türü',
vitesAdi as 'Vites Türü',
motorhacmi as 'Motor Hacmi',
sinifAdi as 'Sınıf',
fiyat as 'Günlük Fiyat',
(((fiyat*7)*70)/100) as 'Haftalık Fiyat', --Haftalık %30 indirim
(((fiyat*30)*500)/100) as 'Aylık Fiyat' --Haftalık %50 indirim
from Araclar
inner join Vitesler on Vitesler.vitesKodu = Araclar.vites
inner join Yakitlar on Yakitlar.yakitKodu = Araclar.yakitturu
inner join Siniflar on Siniflar.sinifKodu = Araclar.sinif
where marka like @marka and model like @model and yil < @maxyil and yil > @minyil and yakitturu = @yakitturu and vites = @vites and motorhacmi < @motorhacmimax and motorhacmi > @motorhacmimin and fiyat < @maxfiyat and fiyat > @minfiyat
end;

create proc sp_ModelBul
@marka varchar(30)
as
begin
select model from Araclar where marka = @marka
end;

exec sp_ModelBul 'Dodge';

exec sp_AracBul 'Dodge','Viper ACR',2000,2020,'B','M',1000,9000,2000,20000;


select DISTINCT model from Araclar where marka like 'Dodge';

select DISTINCT sinifAdi from Araclar inner join Siniflar on Siniflar.sinifKodu = Araclar.sinif where model like 'Viper ACR';

create proc sp_AracSil
@plaka varchar(10)
as
begin
delete from Araclar where plaka = @plaka
end;

exec sp_AracSil '34YK1950';