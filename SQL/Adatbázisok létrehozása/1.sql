/*HOGYAN KÉSZÍTSÜNK ADATBÁZIST?*/

DROP DATABASE IF EXISTS elso; 

CREATE DATABASE elso
CHAR SET utf8                /*Karaktertábla*/
COLLATE utf8_hungarian_ci;   /*Mi alapján rendezze a szöveges adatokat*/

/*TÁBLÁK: sor - rekord, oszlopok - mező*/
/* Felépítés: adatbázis -> táblák -> mező: rekordokat rakod*/

/*Tábla*/

USE elso; /*Használd az elso adatbázist*/

DROP TABLE IF EXISTS etlap;

CREATE TABLE etlap (

/* mező neve, típus, kiegészítő (nem kötelező)*/
	etel varchar(255) primary key,  /*Szöveg: változó hosszúságó 255 karakterig*/
    ar int not null, /*Not null: az adat nem lehet üres, muszáj írni valamit*/
    allergen bool
);

CREATE TABLE beszallitok (
	azon int primary key auto_increment,
    neve varchar(255),
    cim varchar(255),
    telefonszam varchar(40)
    );
 */  
    
/*Adatok feltöltése*/

/*INSERT INTO etlap VALUES ("Palacsinta",200,false);*/
/*INSERT INTO etlap VALUES ("Rétes",300,true);
INSERT INTO etlap VALUES ("Kakaós csiga",200,false);
INSERT INTO etlap VALUES ("Barack", 100, false);*/
/*INSERT INTO etlap VALUES ("Tej", 180,false);*/

/*INSERT INTO beszallitok (neve,cim,telefonszam) VALUES ("Pista bácsi","Szolnok","+36301111111");
INSERT INTO beszallitok (neve,cim,telefonszam) VALUES ("Jenő", "Kecskemét", "+36302222222");
INSERT INTO beszallitok (telefonszam, neve, cim) VALUES ("+36303333333", "Géza", "Budapest");*/

/*Lekérdezés*/

SELECT *
FROM etlap;

SELECT *
FROM beszallitok;
