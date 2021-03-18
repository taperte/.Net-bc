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