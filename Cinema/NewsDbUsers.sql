--1. Create new database table Users (Id, Username, Email, Password)
create table Users (
	Id int not null identity primary key,
	Username nvarchar(50) not null,
	Email nvarchar(100) not null,
	[Password] nvarchar(100) not null
)