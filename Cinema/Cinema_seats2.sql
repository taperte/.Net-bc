create table AuditoriumSeats (
	Id int not null identity primary key,
	AuditoriumId int not null foreign key references Auditoriums(Id),
	SeatId int not null foreign key references Seats(Id),
	SeatCount int not null
)

create table ScreeningSeats (
	Id int not null identity primary key,
	ScreeningId int not null foreign key references Screenings(Id),
	SeatId int not null foreign key references Seats(Id),
	SeatCount int not null
)

create table MovieGenres (
	Id int not null identity primary key,
	MovieId int not null foreign key references Movies(Id),
	GenreId int not null foreign key references Genres(Id)
)

alter table ScreeningSeats add AuditoriumSeatsId int not null foreign key references AuditoriumSeats(Id)

exec sp_rename 'ScreeningSeats', 'AvailableSeats'

alter table AvailableSeats add Id int not null identity primary key

alter table Auditoriums drop column BasicSeats
alter table Auditoriums drop column Sofa
alter table Auditoriums drop column Balcony
alter table Screenings drop column BasicSeats
alter table Screenings drop column Sofa
alter table Screenings drop column Balcony

alter table Bookings add SeatsID int not null foreign key references AvailableSeats(Id)

alter table Auditoriums drop column TotalCapacity
alter table Screenings drop column TotalCapacity

exec sp_rename 'Bookings.SeatsID', 'AvailableSeatsId', 'COLUMN';
alter table AvailableSeats add [Type] nvarchar(20)

alter table AvailableSeats add [Count] int

alter table Screenings add TotalSeatCount int