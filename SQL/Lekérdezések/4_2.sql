/*Külső kulcs létrehozása*/

CREATE TABLE valami (
	int id,
    varchar nev,
    int masiktabla_azon,
    
    PRIMARY KEY (id),
    FOREIGN KEY (masiktabla_azon) REFERENCES masik(id)
);
    
    
create table masik (
	int id primary key,
    varchar masik_nev
);