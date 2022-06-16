use company;


create table Department(
	id int primary key not null identity(1,1),
	name nvarchar(10) not null,
	location nvarchar(200) not null

);


create table Employee(
	id int primary key not null identity(1,1),
	name nvarchar(100) not null,
	startingDate date not null, 
	address nvarchar (200),
	department_id int not null references Department(id)
);