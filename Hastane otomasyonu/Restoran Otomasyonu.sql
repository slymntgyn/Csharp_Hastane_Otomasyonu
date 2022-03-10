
create table masa(
MasaSayisi int primary key
);
create table OdemeTuru(
OdemeTuru int primary key IDENTITY(1,1),
Adi Varchar(50)
);
create table Hesap(
HesapNo int Primary key IDENTITY(1,1),
SiparisNo int,
odemeTürüNo int,
tutar money,
Tarih datetime,
constraint fk_OdemeTuru foreign key (OdemeTürüNo) references OdemeTuru(OdemeTuru));

create table yönetici(
kullanıcıno int  Primary key IDENTITY(1,1),
tc varchar(100),
sifre varchar(100),
Soyadi Varchar(100),
adi Varchar(100)
);

create table personel(
KullaniciNo int primary key IDENTITY(1,1),
tc Varchar(50),
Sifre	Varchar(50),
Adi	Varchar(50),
Soyadi	Varchar(50)
);
create table siparis(
SiparisNo int primary key IDENTITY(1,1),
MasaNo int,
Hesap varchar(10),
constraint fk_siparis foreign key (MasaNo) references masa(MasaSayisi)
);
create table siparisürün(
SiparisÜrünNo int IDENTITY(1,1) primary key ,
SiparisNo int,
UrunNo int,
UrunAdet int
);
create table UrunGrubu
(
UrunGrubu int IDENTITY(1,1) primary key,
Adi varchar(50) unique,
);
create table ürün(
UrunNo int primary key IDENTITY(1,1),
Adi varchar(50),
Fiyati money,
UrunGrupNo int,
ResimYolu varchar(200),
constraint fk_urungrup foreign key (UrunGrupNo) references UrunGrubu(UrunGrubu)
);
/*
SELECT Siparis.MasaNo AS [Masa Numarası], Hesap.Tarih, OdemeTuru.Adi AS [Ödeme Türü], Hesap.Tutar, Hesap.HesapNo, Hesap.SiparisNo
FROM Siparis INNER JOIN (OdemeTuru INNER JOIN Hesap ON OdemeTuru.OdemeTuru = Hesap.odemeTürüNo) ON Siparis.SiparisNo = Hesap.SiparisNo;
*/

insert into personel (tc,Sifre,Adi,Soyadi) values ('52764762212','123','Ahmet','Gezici');
insert into personel (tc,Sifre,Adi,Soyadi) values ('23211130014','123','Betül','Ayak');
insert into personel (tc,Sifre,Adi,Soyadi) values ('18311493718','123','Burak','Kaya');
insert into personel (tc,Sifre,Adi,Soyadi) values ('92227209564','123','Mustafa','Ak');
insert into personel (tc,Sifre,Adi,Soyadi) values ('68738425014','123','Esma','öter');

insert into yönetici (tc,sifre,adi,Soyadi) values ('61802857704','süleyman123','Süleyman','Tugyan');
insert into yönetici (tc,sifre,adi,Soyadi) values ('43709245228','Hasan123','Hasan Tayyip','Kurt');
insert into yönetici (tc,sifre,adi,Soyadi) values ('38284920332','ali132','Ali','Kılca');
insert into yönetici (tc,sifre,adi,Soyadi) values ('91888976174','wedat123','Abulimiti','Yilixiati');
insert into yönetici (tc,sifre,adi,Soyadi) values ('52468623376','alperen123','apleren enes','ceylan');
insert into yönetici (tc,sifre,adi,Soyadi) values ('35893972882','alieraslan123','ali','eraslan');



insert into UrunGrubu(Adi) values('sıcak içecekler');
insert into UrunGrubu(Adi) values('soğuk içeçekler');
insert into UrunGrubu(Adi) values('kahvaltılık yiyecekler');
 insert into UrunGrubu(Adi) values('ana menü');
insert into UrunGrubu(Adi) values('tatlılar');


insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('çay','4.00','1','Ürünler/tea.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('türk kahvesi','5.00','1','Ürünler/TurkKahvesi.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('ekinezya çayı','3.00','1','Ürünler/EkinezyaCayi.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('papatya çayı','3.00','1','Ürünler/cup of tea.png');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('cappucino','7.00','1','Ürünler/cappucino.jpg ');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('elma çayı','4.00','1','Ürünler/elmacay.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('salep ','4.00','1','Ürünler/salep.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('karadut ','4.00','1','Ürünler/karadut.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('limon çayı','5.00','1','Ürünler/Limon.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('böğürtlen çayı','6.00','1','Ürünler/boguurtlen.jpg ');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('kivi çayı','5.00','1','Ürünler/Limon.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('limon çayı','5.00','1','Ürünler/kivi.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('nescafe','6.00','1','Ürünler/Coffee-icon2.png');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('elma çayı','4.00','1','Ürünler/ElmaCayi.jpg ');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('karadut','6.00','1','Ürünler/karadut.jpg ');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('kuşburnu','5.00','1','Ürünler/kusburnu.jpg ');
 



insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('coco cola','8.00','2','Ürünler/Coke Zero-128.png');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('fanta','7.00','2','Ürünler/fanta.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('gazoz','6.00','2','Ürünler/gazoz.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('soğuk çay','7.00','2','Ürünler/icetea.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('portakal suyu','6.00','2','Ürünler/Long-Island-Iced-Tea-icon.png');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('soda','4.00','2','Ürünler/soda.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('ayran','4.00','2','Ürünler/utas_ayran_bardak.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('muzlu süt','5.00','2','Ürünler/MuzluSut.jpg');







insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('sucuklu yumurta','15.00','3','Ürünler/sucukluyumurta.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('kaşarlı tost','8.00','3','Ürünler/tost.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('ekmek arası sosis','8.00','3','Ürünler/yengen.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('karşık menemen','20.00','3','Ürünler/karisikmenemen.jpg');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('peynirli menemen','15.00','3','Ürünler/peynirlimenemen.jpg ');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('omlet','10.00','3','Ürünler/omlet.jpg ');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('kızarmış patates','10.00','3','Ürünler/kızarmispatates.jpg ');
insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('karışık kahvalti','20.00','3','Ürünler/kahvalti.jpg ');
 










 insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('patates kızartması','10.00','4','Ürünler/peynirlimenemen.jpg ');
 insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('hammurger','15.00','4','Ürünler/peynirlimenemen.jpg ');
 insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('cheseburger','17.00','4','Ürünler/cheseburger.jpg ');
 insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('kuymak','10.00','4','Ürünler/kuymak.jpg ');
 insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('pizza','13.00','4','Ürünler/pizza-icon.png ');
 insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('sosis','10.00','4','ürünler/Ürünlersosis.jpg ');
 insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('salata','8.00','4','Ürünler/Salad-icon.png ');
 insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('ekmek','3.00','4','Ürünler/1399595297_toast.png ');
  



 
 insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('yaş pasta','30.00','5','Ürünler/cake-icon.png ');
 insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('çilekli dondurma','7.00','5','Ürünler/ice-cream-icon.png');
 insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('çiz kek','8.00','5','Ürünler/strawberry-cake-icon.png');
 insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('künefe','13.00','5','Ürünler/künefe.png');
 insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('baklava','15.00','5','Ürünler/baklava.png');
 insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('sütlaç','8.00','5','Ürünler/sütlaç.png');
 insert into ürün(Adi,Fiyati,UrunGrupNo,ResimYolu) values('kazandibi','12.00','5','Ürünler/kazandibi.png');
 
