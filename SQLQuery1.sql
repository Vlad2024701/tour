use tours
drop table Tours
drop table Users

use tours

create table Tours
(
    Id INT identity,
    TourName VARCHAR(50),
    TourDescription VARCHAR(200),
    TourTimeStart DateTime,
    TourTimeEnd DateTime,
	CONSTRAINT PK_Tour_Id PRIMARY KEY (Id) 
)

create table Users
(
    Id INT identity,
    Login VARCHAR(50),
    Password VARCHAR(200),
    Name DateTime,
    Email DateTime,
	CONSTRAINT PK_User_Id PRIMARY KEY (Id) 
	--FOREIGN KEY (CustomerId) REFERENCES Customers (Id) ON DELETE CASCADE
)


create table Hotels
(
	Id int identity,
	Name varchar(30),
	CONSTRAINT PK_Hotel_Id PRIMARY KEY (Id) 

)

insert into Tours (TourName, TourDescription, TourTimeStart, TourTimeEnd)
values ('Minsk to Brest', 'very wonderful', CAST('2023-03-04 15:32:06' AS DateTime), CAST('2023-03-09 15:32:06' AS DateTime)),
('Minsk to Vitebsk', 'very cool journey', CAST('2023-03-04 15:32:06' AS DateTime), CAST('2023-03-09 15:32:06' AS DateTime))


select * from Tours
select * from Users

