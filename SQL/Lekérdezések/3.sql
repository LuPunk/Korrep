USE centrum;

/*MAI NAP:
GROUP BY/HAVING: csoportosítás/feltétel
LIMIT: hány sort jelenítsen meg
AS: mező átnevezése a lekérdezése
Dátum típus*/


/*Mező megjelentítése más néven: AS 'név'*/

/*Csoportosítás*/
/*GROUP BY*/

/*Megszámoljuk, hogy hány darab kezelés volt típusonként*/
SELECT kezelestipusId AS 'Kezelés azonosítója', COUNT(*) AS 'Kezelések száma'
FROM kezeles
GROUP BY 1;

/*Összesen mennyit fizettek egyes kezelésekért*/
SELECT kezelestipusId AS 'Kezelés azonosítója', SUM(dij) AS 'Összbevétel'
FROM kezeles
GROUP BY 1;

/*Példa: Átlagéletkor nemenként*/
/*SELECT nem, AVG(eletkor)
FROM tanulok
GROUP BY nem;*/

/*Kerületenként hány gazda van?*/
SELECT kerulet AS 'Kerület száma', COUNT(nev) AS 'Gazdák száma'
FROM gazda
GROUP BY 1;

/*Írja annak a kerületnek a számát és a benne lévő gazdák számát (hány db) ahol a legtöbb gazda található*/
/*LIMIT <szam>: megadható hány sort jelenítsen*/
SELECT kerulet AS 'Kerület száma', COUNT(nev) AS 'Gazdák száma'
FROM gazda
GROUP BY 1
ORDER BY 2 DESC /*Descending: csökkenő*/
LIMIT 1;

/*u.a, csak hol van a legkevesebb*/
SELECT kerulet AS 'Kerület száma', COUNT(nev) AS 'Gazdák száma'
FROM gazda
GROUP BY 1 
ORDER BY 2 ASC /*alapértelmezett, Ascending: növekvő*/
LIMIT 1;

/*Csoportosítás, DE van feltétel*/
/*WHERE: csak akkor veszi bele a számlálásba, ha igaz a feltétel
HAVING: a CSOPORTOSÍTÁSRA való feltétel, MINDIG CSAK GROUP BY UTÁN: pl 30-nál több gazdát tartalmazó kerület*/
/*Példa: CSAK azokat írja ki ahol 30nál gazda van a kerület*/
SELECT kerulet, COUNT(*)
FROM gazda
GROUP BY 1
HAVING COUNT(*) > 30;

/*Példa: jelenítse meg azokat a kezelés azonosítókat és összebevételeket ahol a bevétel elérte a 450.000Ft-ot*/
SELECT kezelestipusId AS 'Kezelés azonosítója', SUM(dij) AS 'Összbevétel'
FROM kezeles
GROUP BY 1
HAVING SUM(dij) >= 450000;


/*Próba: kezeléstípusonként a legnagyobb/legkisebb ár:*/
SELECT kezelestipusId, MAX(dij)
FROM kezeles
GROUP BY 1;

SELECT kezelestipusId, MIN(dij)
FROM kezeles
GROUP BY 1;

/*Kezelésenként átlagosan mennyit kell fizetni*/
SELECT kezelestipusId, AVG(dij)
FROM kezeles
GROUP BY 1;

/*---------------------------------*/
/*Dátum típus: év-hónap-nap, óra:perc:másodperc, év-hónap nap óra:perc:másodperc
év -> YEAR()
hónap -> MONTH()
nap -> DAY()
óra -> HOUR()
perc -> MINUTE()
másodperc -> SECOND()
*/


/*2017-ben mennyi kezelés volt (amit 2017-ben kezdtek)*/
/*YEAR(mezo_neve): visszaadja a mezőben található dátum évét*/
SELECT count(*)
FROM kezeles
WHERE YEAR(kezdet) = 2017;

/*Hónap/nap: MONTH, DAY*/
/*Havonta hány kezelést kezdtek el*/
SELECT MONTH(kezdet), count(*)
FROM kezeles 
GROUP BY 1;

/*Január egyes napjain hány kezelést kezdtek el*/
SELECT DAY(kezdet), count(*)
FROM kezeles
WHERE MONTH(kezdet) = 1
GROUP BY 1;

/*Mennyi ideig tartottak a kezelések (nap)*/
/*DATEDIFF(vége,eleje): hány nap telt el két dátum között (inkább év-hónap-nap hasznos)*/
SELECT kezdet, veg, DATEDIFF(veg,kezdet)
FROM kezeles;

/*Mennyi ideig tartottak a kezelések (óra/másodperc)*/
/*TIMEDIFF(vége,eleje): hány nap telt el két dátum között (inkább óra:perc:másodpercnél hasznos) */
SELECT kezdet, veg, TIMEDIFF(veg,kezdet)
FROM kezeles;


/*adattípus boolean: igaz/hamis*/
/*igaz: true vagy 1
hamis: false vagy 0*/

/*példa:*/
/*use vcloud ;
select * from employee;

select name 
from employee
where enabled = true /*vagy enabled = 1*/