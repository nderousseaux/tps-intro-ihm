--------------------Exercices du cours--------------------

--Exo 1--
-- Afficher  les employés dont le salaire est supérieur  à  la  moyenne des salaires de leurs départements
SELECT *
FROM emp e
WHERE e.sal<( SELECT AVG(sal)
              FROM emp e2
              WHERE e.deptno = e2.deptno);


--Exo 2--
-- Pour  chacun  des  départements,  afficher  son  nom,  sa  localisation,  et  le nombre de salariés qui y travaillent
SELECT d.dname, d.loc, ( SELECT COUNT(*)
                        FROM emp e
                        WHERE e.deptno=d.deptno) "NOMBRE DE SALARIES"
FROM dept d;


--Exo 3--
--Pour  chaque manager, afficher  son  nom, sa  fonction, ainsi  que le nombre de ses subordonnés.
SELECT e.ename, e.job, ( SELECT COUNT(*)
                        FROM emp e2
                        WHERE e2.mgr = e.empno)
FROM emp e
WHERE e.empno IN (SELECT mgr FROM emp);


--Exo 4--
--Pour  tous les  départements  comptant  plus  de 3 salariés,  afficher  le  nom du département, sa localisation ainsi que la moyenne des salaires versés.
SELECT d.dname, d.loc, (  SELECT AVG(e.sal)
                          FROM emp e
                          WHERE e.deptno = d.deptno) "SALAIRE MOYEN"
FROM dept d
WHERE ( SELECT COUNT(*)
        FROM emp e
        WHERE e.deptno = d.deptno) > 2;


--------------------Exercices des requêtes GROUP BY/Having--------------------

--Exo 1--
--Noms et nombres d'habitants des villages de plus de 5 habitants
SELECT v.nom, ( SELECT COUNT(*)
                FROM gaulois g
                WHERE v.vilno = g.vilno) "NOMBRE D'HABITANTS"
FROM village v
WHERE ( SELECT COUNT(*)
        FROM gaulois g
        WHERE v.vilno = g.vilno)>5;

--Exo 2--
--Afficher  la  liste  suivante  :  Nom  du  gaulois,  nom  de  son village et nombre de casques emportés,
-- pour les gaulois ayant remporté plus de 10 casques en guise de trophée.
SELECT g.nom, v.nom, (  SELECT SUM(t.nbcasque)
                        FROM trophee t
                        WHERE t.gauno = g.gauno
                        GROUP BY t.gauno) "NOMBRE DE CASQUES"
FROM gaulois g, village v
WHERE g.vilno = v.vilno
AND g.gauno IN (    SELECT t.gauno
                    FROM trophee t
                    GROUP BY t.gauno
                    HAVING SUM(t.nbcasque)>10);


SELECT t.gauno, SUM(t.nbcasque)
FROM trophee t
GROUP BY t.gauno
HAVING SUM(t.nbcasque)>10;