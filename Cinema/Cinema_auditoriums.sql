create table Auditoriums (
	Id int not null identity primary key,
	[Name] nvarchar(50) not null,
	BasicSeats int not null,
	Sofa int not null,
	Balcony int not null,
	TotalCapacity int
)

insert into Auditoriums([Name], BasicSeats, Sofa, Balcony) values('Auditorium 1', 120, 0, 0)
insert into Auditoriums([Name], BasicSeats, Sofa, Balcony) values('Auditorium 2', 120, 4, 2)
insert into Auditoriums([Name], BasicSeats, Sofa, Balcony) values('Auditorium 3', 160, 6, 2)
insert into Auditoriums([Name], BasicSeats, Sofa, Balcony) values('Auditorium 4', 160, 6, 2)
insert into Auditoriums([Name], BasicSeats, Sofa, Balcony) values('Auditorium 5', 180, 8, 2)

alter table Movies add AuditoriumId int foreign key references Auditoriums(Id)

alter table Bookings add AuditoriumId int foreign key references Auditoriums(Id)
