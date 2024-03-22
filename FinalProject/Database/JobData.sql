CREATE TABLE Jobs (
 Name varchar(100),
 CompanyName varchar(255) ,
 Salary varchar(100),
 Location varchar(100)
);

INSERT INTO Jobs(Name, CompanyName, Salary, Location)
VALUES ('BA','FPT','Dưới 10tr', 'HCM');

INSERT INTO Jobs(Name, CompanyName, Salary, Location)
VALUES ('DA','FPT','10tr - 15tr', 'HCM');


SELECT * FROM Jobs