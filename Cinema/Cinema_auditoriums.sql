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

create table Screenings (
	Id int not null identity primary key,
	[Time] datetime not null,
	MovieId int not null foreign key references Movies(Id)
)

alter table Movies drop column ScreeningTime1
alter table Movies drop column ScreeningTime2
alter table Movies drop column ScreeningTime3
alter table Movies drop column ScreeningTime4
alter table Movies drop column ScreeningTime5

alter table Bookings drop column BookedTime
alter table Bookings drop column AuditoriumId
alter table Bookings add ScreeningId int foreign key references Screenings(Id)

alter table Screenings add BasicSeats int
alter table Screenings add Sofa int
alter table Screenings add Balcony int
alter table Screenings add TotalCapacity int