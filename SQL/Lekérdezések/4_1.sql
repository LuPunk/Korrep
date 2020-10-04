use vcloud;

select * from employee;
select * from office;
select * from division;
select * from department;

/*Több táblás lekérdezés*/
/*Tábla_neve.mező_neve*/

select id, email, departmentid
from employee;

/*Példa: írja ki a dolgozók azon, email, részlegét*/
SELECT employee.id, employee.email, department.name
FROM employee JOIN department ON employee.departmentId = department.id;

/*SELECT employee.name, office.name
FROM employee JOIN office ON employee.officeid = office.id;*/

SELECT employee.id, employee.email
FROM employee JOIN department ON employee.departmentId = department.id
WHERE department.name like '%support%';

SELECT division.name AS 'divízió', count(employee.id) as 'létszám'
FROM division JOIN employee ON employee.divisionId = division.id
GROUP BY division.name
HAVING count(employee.id) >= 10;

/*-------------------------------------------------------------------*/

use centrum;

SELECT kezelestipus.jelleg, count(kezeles.id) as 'darabszám'
FROM kezelestipus JOIN kezeles ON kezelestipus.id = kezeles.kezelestipusId
GROUP BY 1;

SELECT kezelestipus.jelleg, kezeles.kezdet, kezeles.veg, kezeles.dij
FROM kezelestipus JOIN kezeles ON kezelestipus.id = kezeles.kezelestipusId
WHERE YEAR(kezeles.veg) = 2017 AND MONTH(kezeles.veg) >= 10 AND kezelestipus.jelleg LIKE '%gyógy%';

