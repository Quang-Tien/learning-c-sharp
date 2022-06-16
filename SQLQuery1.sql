use company;

select * from Employee e 
INNER JOIN Department d
ON e.department_id = d.id;

select * from Employee;

insert into Department
VALUES( 'F1', '29 ABC DE'),
	  ( 'F2', '31 ABC DE');

insert into Employee
VALUES('Johnny', '2020-12-17', '18 XYZ HCMC', '1'),
('William', '2018-8-12', '100 MNC HCMC', '2');

