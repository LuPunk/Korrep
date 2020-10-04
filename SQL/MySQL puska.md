# MySQL puska (Készítette: Kovács Luca)



## Fontosabb kulcsszavak

| Kifejezés              | Jelentés                                                     |
| ---------------------- | ------------------------------------------------------------ |
| **adatbázis**          | Logikailag összefüggő információ, a tárolt adatok összessége |
| **tábla**              | Logikailag összetartozó adatok sorokból (rekord) és oszlopokból (mező) álló elrendezése (pl. email cím-jelszó, vagy egy osztály adatai) |
| **rekord**             | Az adatbázis sorai                                           |
| **mező**               | Az adatbázis oszlopai. Értékeitől függően különböző típusa lehet (pl. szöveges, szám, dátum) |
| **elsődleges kulcs**   | Egy olyan adat/tulajdonság (azonosító) mely segítségével egyértelműen beazonosíthatjuk az adott elemet |
| **külső/idegen kulcs** | A táblák közötti kapcsolatoknál fontos. Azokat az adatokat/tulajdonságokat, amelyek egy másik táblában elsődleges kulcsként funkcionálnak, külső/idegen kulcsnak nevezzük |

---



## 1. Az adatbázis szerkezetével való műveletek

### 1.1.1 Adatbázis létrehozása

```mysql
CREATE DATABASE adatbazis_neve
CHAR SET utf8
COLLATE utf8_hungarian_ci;
```

**Magyarázat:**

- **CREATE DATABASE adatbazis_neve**: Létrehozza az adatbázist 'adatbazis_neve' néven
- **CHAR SET utf8**: Az adatbázis karakterkódolása UTF-8 lesz
- **COLLATE utf8_hungarian_ci**: Mi alapján rendezi az adatokat. A **ci** jelölés (angolul *case insensitive*) arra utal, hogy nem tesz különbséget kis- és nagybetű között (pl: 'a' és 'A' ugyanaz)



### 1.1.2 Adatbázis törlése

```mysql
DROP DATABASE adatbazis_neve;
```

**Magyarázat:**

A **DROP DATABASE adatbazis_neve** parancs kitörli az 'adatbazis_neve' nevű adatbázist. Amennyiben nincs ilyen nevű adatbázis, hibaüzenetet fog dobni.

Amennyiben csak akkor szeretnénk törölni az adatbázist, ha létezik (ezzel elkerülve a hibaüzeneteket) akkor használjuk az alábbi parancsot:

```mysql
DROP DATABASE IF EXISTS adatbazis_neve;
```



### 1.1.3 Adatbázis használata

```mysql
USE adatbazis_neve;
```

**Magyarázat:**

A **USE adatbazis_neve** parancs kiválasztja 'adatbazis_neve' nevű adatbázist, így az e sor után következő műveletek ebben az adatbázisban lesznek végrehajtva

---



### 1.2.1 Tábla létrehozása

```mysql
CREATE TABLE tabla_neve (
	mezo1 tipus,
    mezo2 tipus,
    mezo3 tipus,
    ...
)
```

**Magyarázat:**

A **CREATE TABLE tabla_neve** parancs létrehoz egy táblát 'tabla_neve' néven. A zárójelen belül meg kell adni a mezők (oszlopok) nevét, típusát.

**A leggyakrabban használt adattípusok:**

| Adattípus        | Jelentése                                                    |
| ---------------- | ------------------------------------------------------------ |
| CHAR(*méret*)    | A zárójelben megadott FIX hosszúságú szöveges adat. A szöveges adatokat a számítógép mindig a megadott méreten fogja tárolni (pl. ha a méret 20, és csak 5 karakter hosszú szöveget írok bele, a számítógép akkor is 20 karakternyi helyen fogja tárolni a memóriában. Az üres karaktereket kiegészíti szóközzel) |
| VARCHAR(*méret*) | A zárójelben megadott VÁLTOZÓ hosszúságú szöveges adat. A számítógép (a megadott méretig) mindig annyi karakternyi helyen tárolja a memóriában, amennyi karakterből az adat áll |
| INT              | Egész számok típusa. Értéktartománya **-2 147 483 648**-tól **2 147 483 647**-ig tart. |
| FLOAT            | Lebegőpontos (tört, nem egész) számok típusa. 24 tizedesjegyig pontos |
| DATE()           | Dátum típus. Formátuma: YYYY-MM-DD (pl: 2000-01-01)          |
| DATETIME()       | Dátum és idő típusa. Formátuma: YYYY-MM-DD HH:MM:SS (pl. 2000-01-01 21:34:12) |
| TIME()           | Idő típusa. Formátuma: HH:MM:SS (pl: 20:12:34)               |

Lehetőség van kulcsszavak megadására is, amelyek plusz tulajdonságokkal ruházzák fel az adott mezőt (pl. a mezőben nem lehet üres adat, vagy kijelölhetjük az elsődleges kulcsot is). A kulcsszavak használatakor így néz ki a fenti parancs:

```mysql
CREATE TABLE tabla_neve (
	mezo1 tipus kulcsszó,
    mezo2 tipus kulcsszó,
    mezo3 tipus kulcsszó,
    ...
)
```

**A leggyakrabban használt kulcsszavak**

| Kulcsszó       | Jelentése                                                    |
| -------------- | ------------------------------------------------------------ |
| NOT NULL       | Az adott mezőben nem lehet üres érték. Mindig kell, hogy legyen benne adat. |
| UNIQUE         | Az adott mezőben minden adatnak különbözőnek kell lennie. Vagyis a mezőben (oszlopban) nem lehet két, ugyanolyan adat. |
| PRIMARY KEY    | Az elsődleges kulcs megadása. Az elsődleges kulcs magában hordozza a *NOT NULL* és a(z) *UNIQUE* tulajdonságokat, hiszen az elsődleges kulcs nem lehet üres és egyedinek is kell lennie, hiszen így tud beazonosítani egyértelműen egy adott elemet |
| AUTO_INCREMENT | Egy egyedi számot generál az adott mezőben növekvő sorrendben. Alapértelmezetten 1-től kezdi egyesével generálni a számokat. |



### 1.2.2 Tábla törlése

A tábla törlésének két féle módja van: 

**1.módszer: Kitörli az adatokat és magát a táblát is**

```mysql
DROP TABLE tabla_neve;
```

**Magyarázat:**

A **DROP TABLE tabla_neve** parancs kitörli egy az egyben a 'tabla_neve' táblát. Ez törli az adatokat és magát a szerkezetet is. Ennél a parancsnál is használható az **IF EXISTS**, amely lehetővé teszi a hibák elkerülését.

**2.módszer: Kitörli az adatokat, de a tábla szerkezete megmarad**

```mysql
TRUNCATE TABLE tabla_neve;
```

**Magyarazat:**

A **TRUNCATE TABLE tabla_neve** parancs gyakorlatilag kitörli a 'tabla_neve' nevű táblából az adatokat. A parancs lefutása után a tábla szerkezete megmarad, így gyakorlatilag lesz egy üres táblánk, amiben nem lesznek adatok.



### 1.2.3 Elsődleges kulcs megadása

Az elsődleges kulcsot a tábla létrehozásánál kell megadni. Amennyiben ez nem történt meg, később a tábla szerkesztésével tudjuk utólag beállítani.

#### 1. Módszer

```mysql
CREATE TABLE tabla_neve (
	mezo1 tipus PRIMARY KEY,
    mezo2 tipus,
    ...
)
```

#### 2. Módszer

```mysql
CREATE TABLE tabla_neve (
	mezo1 tipus,
    mezo2 tipus,
    mezo3 tipus,
    ...
    
    PRIMARY KEY (mezo1)
)
```



### 1.2.4 Idegen kulcs megadása

Az idegen kulcs megadásánál tisztában kell lennünk, hogy a mező amelyet idegen kulcsként szeretnénk megadni, az melyik másik táblában elsődleges kulcs és az ott milyen néven szerepel.

```mysql
CREATE TABLE tabla_neve (
	mezo1 tipus,
    mezo2 tipus,
    mezo3 tipus,
    ...
    
    PRIMARY KEY (mezo1)
    FOREIGN KEY (mezo2) REFERENCES tabla2_neve(mezo1)
)
```

**Magyarázat:**

A **FOREIGN KEY (mezo2) REFERENCES tabla2_neve(mezo1)** parancs a következőt jelenti: a 'tabla_neve' táblában a *mezo2*-t beállítottuk idegen kulcsnak. A 'tabla_neve' táblában, a *mezo2* értékei egy másik, 'tabla2_neve' nevű táblában elsődleges kulcsként fognak szerepelni. Vagyis ha a 'tabla_neve' tábla *mezo2* mezőjében látunk egy értéket, akkor az egyértelműen be fog tudni azonosítani egy elemet a 'tabla2_neve' táblában.

**Példa:**

![](D:\!STORAGE\Pictures\Downloaded pics\cegesrendelesek1.png)

A fenti példában egy bolt rendeléseihez kapcsolódó adatok láthatóak. A *Cégek* nevű tábla tartalmazza azon cégek adatait, ahonnan rendel a bolt, míg a *Termékek* tábla tartalmazza a termékek adatait, amit lehet rendelni. Mint a képen látható, a *Rendelések* tábla, melyben a bolt leadja rendeléseit, minden rendeléshez megad egy cégkódot ahonnan rendelte az árut. Mivel a cégkód alapján a *Cégek* táblából ki tudjuk keresni a cég adatait, nem szükséges tárolni ezeket a *Rendelések* táblában (ugyanez igaz a termékekre is), ezzel rengeteg helyet tudunk megspórolni, mind az adatbázisban mind a memóriában.

Ebben a példában két idegen kulcs szerepel. Ezek a *Rendelések* táblában vannak. Az egyik a **cégKód**, a másik a **termékKód**. Mint látjuk, mindkét mező egy másik táblában elsődleges kulcsként szerepel. Nézzük meg ezen kulcsok megadását a *Rendelések* táblában:

```mysql
CREATE TABLE Rendelesek (
	az INT NOT NULL,
    datum DATE(),
    mennyiseg INT,
    ar DOUBLE
    cegKod INT NOT NULL,
    termekKod INT NOT NULL,
    
    PRIMARY KEY (az)
    FOREIGN KEY (cegKod) REFERENCES Cegek(cegKod)
    FOREIGN KEY (termekKod) REFERENCES Termekek(termekKod)
);
```

