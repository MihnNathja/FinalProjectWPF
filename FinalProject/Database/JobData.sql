CREATE TABLE Jobs (
 ID int not null,
 Name varchar(100),
 CompanyName varchar(255) ,
 Salary varchar(100),
 Location varchar(100)
);

INSERT INTO Jobs(ID, Name, CompanyName, Salary, Location)
VALUES (1,'BA','FPT','Dưới 10tr', 'HCM');

INSERT INTO Jobs(ID, Name, CompanyName, Salary, Location)
VALUES (2,'DA','FPT','10tr - 15tr', 'HCM');


SELECT * FROM Jobs