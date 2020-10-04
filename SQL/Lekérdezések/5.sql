/*Adatbázis módosítások*/

/*1. Adatbázis létrehozása*/

CREATE DATABASE nev
CHAR SET utf8
COLLATE utf8_hungarian_ci;

/*2. Adatbázis törlése*/

DROP DATABASE nev;
/*Csak akkor töröljük, ha létezik*/
DROP DATABASE IF EXISTS nev;

/*-----------------------*/

/*3. Táblák létrehozása*/

CREATE TABLE nev (
/* oszlop_neve tipusa *módosítók**/
	oszlop1 int, /*primary key-t ide is lehet írni*/
    /*pl*/
    /*oszlop1 int primary key*/
    oszlop2 varchar(255) not null,
    oszlop3 bool,
    oszlop4 int auto_increment,
    
    /*Kulcsok létrehozás*/
    /*elsődleges*/
    PRIMARY KEY (oszlop1),
    /*külső kulcs*/
    FOREIGN KEY (oszlop2) REFERENCES masik_tabla(oszlop3)
);

/*4. Táblák törlése*/

/*DROP: kitörli a táblát és az adatokat*/
DROP TABLE nev;

/*TRUNCATE: csak az adatokat törli ki de a szerkezet megmarad*/
TRUNCATE TABLE nev;


/*Táblák módosítása*/

/*Oszlop hozzáadása*/
ALTER TABLE tabla_neve
ADD mezo_neve int;

/*Oszlop törlése*/
ALTER TABLE tabla_neve
DROP COLUMN oszlop_neve;

/*Oszlop módosítása*/
ALTER TABLE tabla_neve
MODIFY COLUMN oszlop4 varchar(255);

/*Oszlop átnevezése*/
ALTER TABLE tabla
RENAME COLUMN oszlop_regi TO oszlop_uj;

/*----------------------*/
/*Adatok módosítása*/
/*UPDATE - SET - WHERE*/

UPDATE tabla_neve
SET nev = 'Pista', varos = 'Szolnok'
WHERE id = 4;

/*HA KIMARAD A WHERE MINDENT MEGVÁLTOZTAT*/
UPDATE tabla
SET nev = 'Jani';

/*Adatok törlése/Sorok/Rekordok törlése*/
DELETE FROM tabla
WHERE id = 4;

DELETE FROM tabla
WHERE nev LIKE '%Kovács Pista%';

/*Adatok/Sor beillesztése*/
INSERT INTO tabla (oszlop1, oszlop2, oszlop3)
VALUES ('érték1', 'érték2', 'érték3');


/*------------------------*/
/*Példa*/
UPDATE tabla
SET iranyitoszam = 5000
WHERE varos = 'Szolnok';

/*KGP példája: HA a név nem elsődleges kulcs*/
UPDATE tabla
SET varos = "Zagyvarékas", lakcim = "Utca út 1", nev = "Nagy Pista"
WHERE id = 123;

/*KGP példája: HA a név elsődleges kulcs*/
/*Összeírom az új adatokat*/
DELETE FROM tabla
WHERE nev LIKE '%Kovács Pista%';

INSERT INTO tabla (nev, varos, lakcim)
VALUES ('Nagy Pista', 'Zagyvarékas', 'Utca út 1');

/*-------------------------------------*/
/*Egymásba ágyazott lekérdezések*/
/*Példa Tégla Tódor*/
UPDATE diak
SET nev = 'Törlendő Tódor'
WHERE diakid = (SELECT diakid FROM diak WHERE nev LIKE '%Tégla Tódor%' AND varos LIKE '%Szolnok%');

/*NOT kulcsszó*/
SELECT * 
FROM tabla 
WHERE MONTH(datum) NOT IN (1,2,3,4);

/*ugyanezt jelenti*/
SELECT * 
FROM tabla
WHERE MONTH(datum) > 4;

/*ugyanezt jelenti*/
SELECT *
FROM tabla
WHERE MONTH(datum) BETWEEN 5 AND 12;

/*-------------------------------*/
/*Operátor: %*/
SELECT nev
FROM diak 
WHERE MONTH(szuldat) % 2 = 0




