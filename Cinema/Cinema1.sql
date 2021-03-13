create table Genres (
	Id int not null identity primary key,
	Genre nvarchar(100) not null
)

 create table Movies (
	Id int not null identity primary key,
	GenreId int foreign key references Genres(Id),
	Title nvarchar(100) not null,
	Director nvarchar(100) not null,
	[Year] int not null,
	ScreeningTime1 datetime,
	ScreeningTime2 datetime,
	ScreeningTime3 datetime,
	ScreeningTime4 datetime,
	ScreeningTime5 datetime
 )

 create table Bookings (
	Id int not null identity primary key,
	MovieId int foreign key references Movies(Id),
	BookedTime datetime not null
 )

 alter table Movies add Duration int not null

 insert into Genres (Genre) values ('Drama')
 insert into Genres (Genre) values ('Comedy')
 insert into Genres (Genre) values ('Action')
 insert into Genres (Genre) values ('Sci-fi')
 insert into Genres (Genre) values ('Horror')
 insert into Genres (Genre) values ('Animation')
 insert into Genres (Genre) values ('Documentary')

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, ScreeningTime3, ScreeningTime4, ScreeningTime5, Duration)
 values (6, 'Wolfwalkers', 'Tomm Moore, Ross Stewart', 2020, '2021-03-10 14:30:00', '2021-03-10 16:30:00', '2021-03-11 17:30:00', '2021-03-12 14:30:00', '2021-03-12 18:30:00', 103)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, ScreeningTime3, ScreeningTime4, ScreeningTime5, Duration)
 values (1, 'And Then We Danced', 'Levan Akin', 2019, '2021-03-10 18:30:00', '2021-03-10 20:30:00', '2021-03-11 18:00:00', '2021-03-12 16:00:00', '2021-03-12 20:00:00', 113)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, ScreeningTime3, Duration)
 values (1, 'Lost in Translation', 'Sofia Coppola', 2003, '2021-03-11 17:30:00', '2021-03-13 19:30:00', '2021-03-15 20:00:00', 102)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, Duration)
 values (4, 'The Matrix', 'Lana Wachowski, Lilly Wachowski', 1999, '2021-03-12 20:30:00', '2021-03-13 20:30:00', 136)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, Duration)
 values (2, 'Boy', 'Taika Waititi', 2010, '2021-03-14 18:00:00', '2021-03-15 16:00:00', 87)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, ScreeningTime3, ScreeningTime4, ScreeningTime5, Duration)
 values (2, 'What We Do in the Shadows', 'Jemaine Clement, Taika Waititi', 2014, '2021-03-10 18:45:00', '2021-03-10 21:30:00', '2021-03-11 16:00:00', '2021-03-12 17:30:00', '2021-03-13 18:00:00', 86)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, ScreeningTime3, ScreeningTime4, ScreeningTime5, Duration)
 values (3, 'Thor: Ragnarok', 'Taika Waititi', 2017, '2021-03-11 14:30:00', '2021-03-11 19:00:00', '2021-03-11 21:00:00', '2021-03-13 17:45:00', '2021-03-14 18:00:00', 130)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, ScreeningTime3, Duration)
 values (3, 'The Avengers', 'Joss Whedon', 2012, '2021-03-11 15:30:00', '2021-03-12 16:30:00', '2021-03-12 19:30:00', 143)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, Duration)
 values (2, 'The Apartment', 'Billy Wilder', 1960, '2021-03-10 15:00:00', 125)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, ScreeningTime3, ScreeningTime4, Duration)
 values (5, 'Dark Water', 'Hideo Nakata', 2002, '2021-03-10 21:30:00', '2021-03-11 21:30:00', '2021-03-12 21:30:00', '2021-03-13 21:30:00', 101)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, Duration)
 values (5, 'It Follows', 'David Robert Mitchell', 2014, '2021-03-12 21:30:00', '2021-03-13 21:30:00', 100)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, Duration)
 values (5, 'The Innocents', 'Jack Clayton', 1961, '2021-03-14 20:30:00', '2021-03-15 19:30:00', 100)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, Duration)
 values (1, 'Four White Shirts', 'Ronalds Kalnins', 1967, '2021-03-11 18:00:00', '2021-03-15 20:45:00', 76)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, ScreeningTime3, ScreeningTime4, ScreeningTime5, Duration)
 values (4, 'Brazil', 'Terry Gilliam', 1985, '2021-03-10 17:00:00', '2021-03-10 21:00:00', '2021-03-12 18:45:00', '2021-03-13 15:30:00', '2021-03-13 20:30:00', 132)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, ScreeningTime3, Duration)
 values (6, 'Howl''s Moving Castle', 'Hayao Miyazaki', 2004, '2021-03-11 14:30:00', '2021-03-11 16:30:00', '2021-03-13 18:00:00', 119)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, Duration)
 values (7, 'Exit through the Gift Shop', 'Banksy', 2010, '2021-03-12 19:30:00', '2021-03-13 19:30:00', 87)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, ScreeningTime3, Duration)
 values (6, 'Song of the Sea', 'Tom Moore', 2014, '2021-03-13 14:30:00', '2021-03-14 14:30:00', '2021-03-14 17:30:00', 93)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, ScreeningTime3, Duration)
 values (1, '20th Century Women', 'Mike Mills', 2016, '2021-03-11 19:30:00', '2021-03-12 19:30:00', '2021-03-13 19:30:00', 119)

 insert into Movies (GenreId, Title, Director, [Year], ScreeningTime1, ScreeningTime2, Duration)
 values (7, 'The Salt of the Earth', 'Wim Wenders', 2014, '2021-03-15 19:00:00', '2021-03-16 20:30:00', 110)

 alter table Movies add Poster nvarchar(500)
 alter table Movies add OriginalTitle nvarchar(100)