USE naplo;

/*CREATE TABLE osztalyzat (
	osztalyzatid INT NOT NULL AUTO_INCREMENT,
    tantargy VARCHAR(20),
    ertek INT,
    diakid INT,
    
    PRIMARY KEY (osztalyzatid)
);*/

/*
INSERT INTO osztalyzat (tantargy, ertek, diakid)
VALUES ("matematika",2,1);

INSERT INTO osztalyzat (tantargy, ertek, diakid)
VALUES ("magyar nyelv",4,2);

INSERT INTO osztalyzat (tantargy, ertek, diakid)
VALUES ("matematika",3,3);

INSERT INTO osztalyzat (tantargy, ertek, diakid)
VALUES ("programozás",5,4);

INSERT INTO osztalyzat (tantargy, ertek, diakid)
VALUES ("matematika",1,5);

INSERT INTO osztalyzat (tantargy, ertek, diakid)
VALUES ("programozás",3,6);

INSERT INTO osztalyzat (tantargy, ertek, diakid)
VALUES ("magyar nyelv",5,7);

INSERT INTO osztalyzat (tantargy, ertek, diakid)
VALUES ("magyar nyelv",1,8);

INSERT INTO osztalyzat (tantargy, ertek, diakid)
VALUES ("programozás",4,9);

INSERT INTO osztalyzat (tantargy, ertek, diakid)
VALUES ("matematika",3,10);*/

/*ALTER TABLE osztalyzat
ADD FOREIGN KEY (diakid) REFERENCES diak(diakid);*/

SELECT diak.nev, osztalyzat.tantargy, ertek
FROM diak JOIN osztalyzat ON diak.diakid = osztalyzat.diakid;

SELECT diak.nev, osztalyzat.tantargy, ertek
FROM diak LEFT JOIN osztalyzat ON diak.diakid = osztalyzat.diakid;

SELECT diak.nev, osztalyzat.tantargy, COUNT(osztalyzatid) AS "osztalyzatszam"
FROM diak JOIN osztalyzat ON diak.diakid = osztalyzat.diakid
GROUP BY 1, 2;

SELECT diak.nev
FROM diak JOIN osztalyzat ON diak.diakid = osztalyzat.diakid
WHERE osztalyzat.tantargy LIKE "%programozás%" AND ertek = 5;