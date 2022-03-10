/*CREATE SCHEMA Hastane Otomasyonu;*/
create table Admin(
adminID varchar(250)  primary key,
kullaniciAdi varchar(250),
sifre varchar(250)
);
create table klinik(
klinikID int IDENTITY(1,1) primary key,
klinikAdi varchar(250)
);
create table doktor(
doktorID varchar(250) primary key,
doktorAdiSoyadi varchar(250),
klinikID int,
kullanciAdi varchar(250),
sifre varchar(250),
constraint fk_doktor foreign key (klinikID) references klinik(klinikID)
);
create table hasta(
TC varchar(250) primary key,
adi varchar(250),
soyadi varchar(250),
parola varchar(250),
anneAdi varchar(50),
babaAdi varchar(50),
dogumTarihi varchar(250),
dogumYeri varchar(250),
cinsiyeti varchar(50),
cepTel varchar(250),
ePosta varchar(250)
);
create table hastane(
hastaneID int IDENTITY(1,1) primary key,
hastaneAdi varchar (250),
ili  varchar(50),
ilcesi varchar(50),
kapasitesi int
);
create table randevu(
randevuID int IDENTITY(1,1) primary key,
doktorID varchar(250),
klinikID int,
TC varchar(250),
tarih date,
saat varchar(250),
tarihVeSaat varchar(250) unique,
constraint fk_randevu1 foreign key (doktorID) references doktor(doktorID),
constraint fk_randevu2 foreign key (klinikID) references klinik(klinikID),
constraint fk_randevu3 foreign key (TC) references hasta(TC)
);
create table nakiller(
nakilID varchar(250) primary key,
hastaTC varchar(250),
nakilEdilenHastane int,
constraint fk_nakiller foreign key (hastaTC) references hasta(TC),
constraint fk_nakiller2 foreign key(nakilEdilenHastane) references hastane(hastaneID),
);
create table yatis(
yatisID varchar(250) primary key,
hastaID varchar(250),
constraint fk_yatis foreign key (hastaID) references hasta(TC)
);
create table tahlil(
tahlilID varchar(255),
hastaTC varchar(250),
tahlilAdi varchar(250),
constraint fk_tahlil foreign key (hastaTC) references hasta(TC)
);

create table röntgen(
röntgenID varchar(250),
hastaTC  varchar(250),
bölgeninAdi varchar(250),
kacacidancekilecek int,
constraint fk_röntgen foreign key (hastaTC) references hasta(TC)
);

insert into Admin (adminID,kullaniciAdi,sifre) values ('79618818604','admin1','1');
insert into Admin (adminID,kullaniciAdi,sifre) values ('54347979840','admin2','2');
insert into Admin (adminID,kullaniciAdi,sifre) values ('17294961436','admin3','3');
insert into Admin (adminID,kullaniciAdi,sifre) values ('89246371280','admin4','4');


INSERT INTO klinik (klinikAdi) VALUES ('Çocuk Sagligi Ve Hastaliklari');
INSERT INTO klinik (klinikAdi) VALUES ('Deri Ve Zührevi Hastaliklari (Cildiye)');
INSERT INTO klinik (klinikAdi) VALUES ('Enfeksiyon Hastaliklari');
INSERT INTO klinik (klinikAdi) VALUES ('Fizik Tedavi Ve Rehabilitasyon');
INSERT INTO klinik (klinikAdi) VALUES ('Genel Cerrahi');
INSERT INTO klinik (klinikAdi) VALUES ('Göğüs Cerrahisi');
INSERT INTO klinik (klinikAdi) VALUES ('ic Hastaliklari (Dahiliye)');
INSERT INTO klinik (klinikAdi) VALUES ('Kadin Hastaliklari ve Dogum');
INSERT INTO klinik (klinikAdi) VALUES ('Kalp ve Damar Cerrahisi');
INSERT INTO klinik (klinikAdi) VALUES ('Kardiyoloji');
INSERT INTO klinik (klinikAdi) VALUES ('Kulak Burun Boðaz Hastaliklari');
INSERT INTO klinik (klinikAdi) VALUES ('Nöroloji');
INSERT INTO klinik (klinikAdi) VALUES ('Ortopedi Ve Travmatoloji');
INSERT INTO klinik (klinikAdi) VALUES ('Ruh Sagligi Ve Hastaliklari (Psikiyatri)');
INSERT INTO klinik (klinikAdi) VALUES ('Üroloji');


insert into doktor(doktorID,doktorAdiSoyadi,klinikID,kullanciAdi,sifre) values ('49076478184','Alex de souza','5','doktor1','Türkiye');
insert into doktor(doktorID,doktorAdiSoyadi,klinikID,kullanciAdi,sifre) values ('28227628838','Muhammed Bazit Deliloğlu','5','doktor2','1');
insert into doktor(doktorID,doktorAdiSoyadi,klinikID,kullanciAdi,sifre) values ('32143639922','Elzem Evrenos','5','doktor3','1');
insert into doktor(doktorID,doktorAdiSoyadi,klinikID,kullanciAdi,sifre) values ('84617209322','Mükerrem Zeynep Ağca','7','doktor4','2');
insert into doktor(doktorID,doktorAdiSoyadi,klinikID,kullanciAdi,sifre) values ('61579918400','Ersin Görgülü','7','doktor5','2');
insert into doktor(doktorID,doktorAdiSoyadi,klinikID,kullanciAdi,sifre) values ('62774897392','Halid İlhan','7','doktor6','2');
insert into doktor(doktorID,doktorAdiSoyadi,klinikID,kullanciAdi,sifre) values ('27399133614','Can Güney Bülbül','2','doktor7','3');
insert into doktor(doktorID,doktorAdiSoyadi,klinikID,kullanciAdi,sifre) values ('64021250448','Esma Eda	Revan','2','doktor8','3');
insert into doktor(doktorID,doktorAdiSoyadi,klinikID,kullanciAdi,sifre) values ('86120241318','Tayyip Sadıkoğlu','2','doktor9','3');


insert into hasta (TC,adi,soyadi,parola,anneAdi,babaAdi,dogumTarihi,dogumYeri,cinsiyeti,cepTel,ePosta) values ('80376533982','Süleyman','Tugyan','1','mümüne','ali ihsan','10.03.2001','konya','erkek','03323323232','ins.1907@gmail.com');
insert into hasta (TC,adi,soyadi,parola,anneAdi,babaAdi,dogumTarihi,dogumYeri,cinsiyeti,cepTel,ePosta) values ('51355411768','Fenerbahçe','Taraftari','2','Stavrini','lefter','19.07.1907','Kadiköy','erkek','033219071907','fenerbahce@hootmail.com');
insert into hasta (TC,adi,soyadi,parola,anneAdi,babaAdi,dogumTarihi,dogumYeri,cinsiyeti,cepTel,ePosta) values ('96581813528','Atahan','Adanır','3','Meltem','volkan','10.03.1998','konya','erkek','03322522525','altay@outlook.com');


insert into hastane (hastaneAdi,ili,ilcesi,kapasitesi) values ('Konya egitim ve arastirma hastanesi','konya','meram','2000');
insert into hastane (hastaneAdi,ili,ilcesi,kapasitesi) values ('Eregli egitim ve arastirma hastanesi','Konya','eregli','1000');
insert into hastane (hastaneAdi,ili,ilcesi,kapasitesi) values ('Sanliurfa egitim ve arastirma hastanesi','sanliurfa','sanliurfa','1500');
/*
insert into randevu(doktorID,klinikID,TC,tarih,saat,tarihVeSaat) values ('98765432101','1','12345678901','10.09.2021','14:00','10.09.2021-14:00 Doktoru: 98765432101');
insert into randevu(doktorID,klinikID,TC,tarih,saat) values ('98765432102','2','12345678902','15.09.2021','09:00');
insert into randevu(doktorID,klinikID,TC,tarih,saat) values ('98765432103','3','12345678903','05.10.2021','11:00');
*/
/*
insert into nakiller (nakilID,hastaTC,nakilEdilenHastane) values ('12345678901','12345678901','3');
insert into nakiller (nakilID,hastaTC,nakilEdilenHastane) values ('12345678902','12345678902','1');
insert into nakiller (nakilID,hastaTC,nakilEdilenHastane) values ('12345678903','12345678903','2');
*/
/*
insert into yatis(yatisID,hastaID) values ('12345678901','12345678901');
insert into yatis(yatisID,hastaID) values ('12345678902','12345678902');
insert into yatis(yatisID,hastaID) values ('12345678903','12345678903');
*/
/*
insert into tahlil(tahlilID,hastaTC,tahlilAdi) values ('12345678901','12345678901','kan tahlili');
insert into tahlil(tahlilID,hastaTC,tahlilAdi) values ('12345678902','12345678902','Gaita tahlili');
insert into tahlil(tahlilID,hastaTC,tahlilAdi) values ('12345678903','12345678903','idrar tahlili');
*/