alter table Movies add Country nvarchar(255)
alter table Movies add Abstract nvarchar(2000)
alter table Movies add Trailer nvarchar(500)

create table Seats (
	Id int not null identity primary key,
	[Name] nvarchar(20) not null,
	Coefficient decimal(4, 2) not null
)

alter table Movies alter column Trailer nvarchar(1000)

alter table Bookings alter column TotalPrice decimal(8, 2)

exec sp_rename 'Seats.Name', 'Type', 'COLUMN';

alter table Bookings add SeatType int foreign key references Seats(Id)

exec sp_rename 'Bookings.SeatType', 'SeatId', 'COLUMN';