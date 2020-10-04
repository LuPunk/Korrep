/*CREATE DATABASE naplo						-- adatbázis létrehozása
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

USE naplo;									-- adatbázis használata

CREATE TABLE diak								-- tábla létrehozása
(
	diakid INT NOT NULL AUTO_INCREMENT,			-- egész típusú mező létrehozása (a mező értéke nem lehet definiálatlan, a mező automatikusan kap értéket)
	nev VARCHAR(20),							-- karakterlánc típusú mező létrehozása (a mező értéke maximum 20 karakterből állhat)
	telepules VARCHAR(20),
	PRIMARY KEY(diakid)							-- egyszerű elsődleges kulcs definiálása
);

-- 2. feladat

INSERT INTO diak (nev, telepules)				-- rekord beszúrása
VALUES ("Antal Armand", "Szolnok");
INSERT INTO diak (nev, telepules)
VALUES ("Balogh Béla", "Szolnok");
INSERT INTO diak (nev, telepules)
VALUES ("Czene Cecília", "Szolnok");
INSERT INTO diak (nev, telepules)
VALUES ("Debrődi Dénes", "Abony");
INSERT INTO diak (nev, telepules)
VALUES ("Englert Elemér", "Abony");
INSERT INTO diak (nev, telepules)
VALUES ("Farády Ferenc", "Abony");
INSERT INTO diak (nev, telepules)
VALUES ("Gaudi Gergely", "Cegléd");
INSERT INTO diak (nev, telepules)
VALUES ("Hende Henrik", "Cegléd");
INSERT INTO diak (nev, telepules)
VALUES ("Istenes Imre", "Cegléd");
INSERT INTO diak (nev, telepules)
VALUES ("Járdán János", "Martfű");

INSERT INTO diak (nev)
VALUES ("Tégla Tódor");

*/
USE naplo;

/*SELECT telepules, COUNT(diakid) AS "tanuloszam"
FROM diak
GROUP BY telepules;
*/

/*UPDATE diak
SET atlag = 3.5
WHERE diakid = 1;

UPDATE diak
SET atlag = 4.2
WHERE diakid = 2;

UPDATE diak 
SET atlag = 3.4
WHERE diakid = 3;

UPDATE diak
SET atlag = 3.8
WHERE diakid > 3;

SELECT * FROM diak;

SELECT telepules, MAX(atlag) AS "maxatlag"
FROM diak
GROUP BY telepules;

SELECT telepules, MIN(atlag) AS "minatlag"
FROM diak
GROUP BY telepules;

-- AVG - average angol szó, azt jelenti átlag
SELECT telepules, AVG(atlag) AS "atlag"
FROM diak
GROUP BY telepules;
*/
-- INT: az angol integer szóból
/*ALTER TABLE diak
ADD verseny INT;*/

/*UPDATE diak
SET verseny = 2
WHERE diakid <= 3;

UPDATE diak
SET verseny = 4
WHERE diakid > 3 AND diakid <= 6;

UPDATE diak
SET verseny = 1
WHERE diakid > 6;*/

/*SELECT telepules, SUM(verseny) AS "versenyszam"
FROM diak
GROUP BY telepules;

SELECT telepules, COUNT(diakid) AS "jobbak"
FROM diak
WHERE atlag > 3.0
GROUP BY telepules;

SELECT telepules, COUNT(diakid) AS "jobbak"
FROM diak
WHERE atlag > 3.0
GROUP BY telepules
HAVING COUNT(diakid) >= 3;*/

/*ALTER TABLE diak
ADD tantargy varchar(20);*/

/*UPDATE diak
SET tantargy = "Matematika"
WHERE diakid IN (1,3,5,7,9);

UPDATE diak
SET tantargy = "Magyar nyelv"
WHERE diakid IN (2,4,6,8,10);

UPDATE diak 
SET tantargy = "Testnevelés"
WHERE diakid IN (3,6,9);*/

/*UPDATE diak
SET tantargy = "Magyar nyelv"
WHERE diakid = 5;*/

SELECT telepules, tantargy, COUNT(diakid) AS "eredmeny"
FROM diak
GROUP BY telepules, tantargy;

SELECT nev
FROM diak
WHERE nev LIKE '%a%';

SELECT nev
FROM diak
WHERE nev LIKE 'B%';

SELECT nev
FROM diak
WHERE nev LIKE '__n%';