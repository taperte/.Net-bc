alter table Movies add Price decimal(4, 2)
alter table Bookings add TicketCount int
alter table Bookings add TotalPrice int
alter table Bookings alter column TotalPrice decimal(4, 2)