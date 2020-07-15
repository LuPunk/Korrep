USE centrum;

/*Hogyan nézzük meg mi van a táblában?*/

SELECT *
FROM fajta;

/*Rendezett lekérdezés*/
/*Order by*/
/*ABC/Növekvő: ASC (ascending), Visszafele ABC/Csökkenő: DESC (descending)*/

SELECT nev, kerulet
FROM gazda
ORDER BY kerulet, nev;

/*Rövidebben*/
SELECT nev, kerulet
FROM gazda
ORDER BY 2,1;

/*Különböző elemek*/
/*DISTINCT nincs ismétlődő elem, mindent egyszer jelenít meg*/

SELECT DISTINCT kerulet
FROM gazda
ORDER BY kerulet;

/*Feltételes lekérdezés*/
/*WHERE*/
/*...WHERE mezo_amit_szurni_akarsz KULCSSZO(relációsjel/between,like stb.) FELTÉTEL
/* = egyenlő, < > kisebb/nagyobb, >= <= kisebb egyenlő/nagyobb egyenlő, <> nem egyenlő
BETWEEN : valami tartományon belül, LIKE %Kovács% : ami tartalmazza, hogy Kovács, IN ('valami1', 'valami2', 'valami3')
AND: és (mind2 igaz), OR vagy (valamelyik 2 közül igaz)*/

/*Egyenlő*/
SELECT nev
FROM gazda
WHERE kerulet = 18;

/*Kisebb/Nagyobb*/
SELECT nev, kerulet
FROM gazda
WHERE kerulet > 16
ORDER BY 2;

/*Nem egyenlő*/
SELECT nev, kerulet
FROM gazda
WHERE kerulet <> 17
ORDER BY 2;

/*Between*/
/*Itt az AND azt jelenti 11 és 18 között*/
SELECT nev, kerulet
FROM gazda
WHERE kerulet BETWEEN 11 AND 18
ORDER BY kerulet;

/*Két betű között: NEM BETWEEN HANEM KISEBB/NAGYOBB*/
SELECT nev
FROM gazda
WHERE nev >= 'a' AND nev < 'f'
ORDER BY nev;

/*LIKE*/
/*Tartalmazza a megadott dolgot*/
SELECT nev
FROM gazda
WHERE nev LIKE '%Andrea%'
ORDER BY 1;

/*IN*/
/*Megadott listában legyen benne*/
SELECT nev, kerulet
FROM gazda
WHERE kerulet IN (1,18,22)
ORDER BY 1;

/*Összetett feltétel*/
SELECT nev, kerulet
FROM gazda
WHERE nev LIKE '%Sándor%' AND kerulet = 18;

SELECT nev, kerulet
FROM gazda
WHERE nev LIKE '%Sándor%' OR kerulet = 18;

/*-------------------------------------------------------*/
/*Számlálás: COUNT(*)/COUNT(mezo_neve)*/
SELECT COUNT(*)
FROM gazda;

SELECT DISTINCT COUNT(kerulet)
FROM gazda;

/*Átlagszámítás: AVG()*/
SELECT AVG(dij)
FROM kezeles;

/*Összegzés: SUM()*/
SELECT SUM(dij)
FROM kezeles;

/*Max/Min: MAX()/MIN()*/
SELECT MIN(dij)
FROM kezeles;

SELECT MAX(dij)
FROM kezeles;