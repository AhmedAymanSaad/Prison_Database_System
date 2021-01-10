-------------Database creation-------------

create database Prison
Go

use Prison

------------Table Creation-----------------


create table Log_In
(
ID int,
Password int,
Usertype varchar(50),
Primary key (ID)
)

create table Solitary_Confinement
(
Solitarycellnumber int,
Starttime date ,
duration decimal (18,2),
primary key(Solitarycellnumber)
)

create table Sector
(
SectorID int,
primary key(SectorID)
)


create table Cell
(
Cellnumber int,
Repairs varchar(50),
primary key(Cellnumber),
SectorID int,
FloorNumber int,
Wing varchar(50),
foreign key (SectorID) references Sector
)



create table Released_Convict
(
nationalID int,
Fname varchar(50) not null,
Minit char(1) not null,
Lname varchar(50) not null,
primary key (nationalID),
Status varchar(50),
Originalsentence varchar(50),
ReleaseDate date,
ProbationPeriod int,
)

create table Guard
(
ID int,
Fname varchar(50) not null,
Minit char(1) not null,
Lname varchar(50) not null,
primary key (ID),
Type varchar(50),
Supervisor_ID int,
Foreign key (Supervisor_ID) references Guard,
Sectorno int,
Foreign key (Sectorno) references Sector,
Username int,
foreign key (Username) references Log_In

)

create table Visitor
(
National_ID int,
Fname varchar(50) not null,
Minit char(1) not null,
Lname varchar(50) not null,
primary key (National_ID),
Phone_Number int,
Username int,
foreign key (Username) references Log_In

)


create table Facility
(
Facilitynumber int,
Expenses int,
Facilitytype varchar(50),
primary key(Facilitynumber),
Sectorno int,
foreign key (Sectorno) references Sector
)

create table Inmate
(
ID int,
Fname varchar(50) not null,
Mname char(50) not null,
Lname varchar(50) not null,
primary key (ID),
Charge varchar(50) not null,
Sentence decimal (18,2) not null,
ConvictionDate date  not null,
Cellno int,
Foreign key (Cellno) references Cell,
SolitaryCellnumber int,
BehaviourScore int,
foreign key (SolitaryCellnumber) references Solitary_Confinement,

)

create table Prisoner_Employment
(
JobID int identity(1,1),
Salary int,
Jobdescription varchar(50),
primary key(JobID),
Inmateassigned int,
foreign key (Inmateassigned) references Inmate
)





create table Visiting
(
InmateID int,
VisitorID int,
primary key (InmateID,VisitorID,StartDate),
StartDate datetime,
EndDate datetime,
foreign key (InmateID) references Inmate,
foreign key (VisitorID) references Visitor
)





create table Work_Place
(
JobID int,
Facilityno int,
primary key (JobID,Facilityno),
foreign key (JobID) references Prisoner_Employment,
foreign key (Facilityno) references Facility
)
create table Relation
(
InmateID int,
VisitorID int,
primary key (InmateID,VisitorID),
Relation varchar(50),
foreign key (InmateID) references Inmate,
foreign key (VisitorID) references Visitor
)




insert into Sector
values
(1),
(2),
(3)

insert into Solitary_Confinement 
values
(10,null,null),
(11,null,null),
(12,null,null)


insert into Log_In
values
(10001000,20202020,'Warden'),
(100123,100,'Guard'),
(101123,101,'Guard'),
(102123,102,'Guard'),
(103123,103,'Guard'),
(104123,104,'Guard')

insert into Guard
values
(1,'Sayed','W','Fathy','Warden',null,null,10001000),
(100,'wtv','Q','Gamal','HeadGuard',null,1,100123),
(101,'wtv1','E','Said','Guard',null,1,101123),
(102,'Ali','G','Moaz','Guard',100,2,102123),
(103,'Ahmed','F','Amr','GateGuard',100,2,103123),
(104,'Mohamed','U','Omar','Guard',null,2,104123)

insert into Cell
values
(1,null,1,3,'West'),
(2,'Bed Repairs',1,3,'South'),
(3,null,1,3,'East'),
(200,'Broken Water Pipe',2,1,'North')

insert into Inmate
values
(1,'Assir','Ibrahim','Wtv','Murder',25,'1998-12-06',1,null,0),
(2,'Gamal','saed','Elas','Stealing',3.4,'2018-12-01',1,null,null),
(3,'Fady','Ibrahim','Wtvsa','Money Laundering',3.07,'2010-7-20',2,null,40),
(4,'Rady','wahed','Wsdatv','Molesting',3,'2017-1-23',3,null,null),
(5,'Hady','gameel','Wtsdav','Drug Dealing',3,'2015-11-04',200,null,10)


insert into Facility
values
(1,10000,'Clinic',1),
(10,5000,'Bathroom',2)


insert into Visitor
values
(11234,'Shaymaa','I','mohamed',1004565329,null),
(10324,'Reem','A','hany',1008975329,null),
(15465,'Yara','A','radwan',1231565329,null),
(17687,'Radwa','A','Elas',1004565678,null)

insert into Visiting
values
(1,11234,'2021-02-01 8:30:00','2021-02-01 9:00:00'),
(2,10324,'2021-02-01 9:30:00','2021-02-01 10:00:00'),
(3,15465,'2021-04-07 11:15:00','2021-04-07 11:45:00'),
(1,11234,'2021-05-15 20:30:00','2021-05-15 21:00:00'),
(1,11234,'2019-04-15 20:30:00','2019-04-15 21:00:00')

insert into Relation
values
(1,11234,'Mother'),
(2,10324,'Sister'),
(3,15465,'Lawyer')

--Stored Procedures--
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure GetEmptyCells
@inmatecount int,
@cnum int
as
begin 
(select Cellno, count(*)
from Inmate join Cell on Cellno=Cellnumber
where Cellno!=@cnum and Repairs is null 
group by Cellno
having count(*)+@inmatecount <= 3)
end
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure GetInmateCountInCell
@cnum int
as
begin 
select count(*)
from Inmate join Cell on Cellno=Cellnumber
where Cellno=@cnum
group by Cellno
end
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure TransferCells
@cnumnew int,
@cnumold int
as
begin 
update Inmate SET Cellno=@cnumnew
where Cellno=@cnumold
end
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure RepairFacility
@facnum int
as
begin 
update Facility set Expenses=0
where Facilitynumber=@facnum
end
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure RepairCell
@cnum int
as
begin 
update Cell set Repairs = null
where Cellnumber=@cnum
end
go




-----------inserting Employee Foreign key--------------
--alter table Employee add foreign key (DNO) references Department

---------------Inserting values into tables----------------
--insert into Employee 
--values
--('John','B','Smith',123456789,'1965-09-11','731 Fondren, Houston, TX','M',30000,null,null),
--('Franklin','T','Wong',333445555,'1955-12-08','638 Voss, Houston, TX','M',40000,null,null),
--('Joyce','A','English',453453453,'1972-07-31','5631 Rice, Houston, T','F',25000,null,null),
--('Ramesh','K','Narayan',666884444,'1962-09-15','975 Fire Oak, Humble, TX','M',38000,null,null),
--('James','E','Borg',888665555,'1937-11-10','450 Stone, Houston, TX','M',55000,null,null),
--('Jennifer','S','Wallace',987654321,'1941-06-20','291 Berry, Bellaire, TX','F',43000,null,null),
--('Ahmad','V','Jabbar',987987987,'1969-03-29','980 Dallas, Houston, TX','M',25000,null,null),
--('Alicia','J','Zelaya',999887777,'1968-01-19','3321,Castle, Spring, TX','F',25000,null,null)

--insert into Department
--values
--('Headquarters',1,888665555,'1981-06-19'),
--('Administration',4,987654321,'1995-01-01'),
--('Research',5,333445555,'1988-05-22')

--insert into Dept_Locations
--values
--(1	,'Houston'),
--(4	,'Stafford'),
--(5	,'Bellaire')

--insert into Project
--values
--('ProductX',1,'Bellaire',5),
--('ProductY',2,'Sugarland',5)

--insert into Works_On
--values
--(123456789	,1	,32.5),
--(123456789	,2	,7.5),
--(888665555	,20	,null)

--update Employee set Super_SSN = 333445555, Dno = 5	where SSN = 123456789
--update Employee set Super_SSN = 333445555, Dno = 5	where SSN = 666884444
--update Employee set Super_SSN = NULL, Dno = 1		where SSN = 888665555
