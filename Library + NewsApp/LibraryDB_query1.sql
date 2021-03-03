create database LibraryDB
use LibraryDB
create table Books (
	Id int not null identity primary key,
	Title nvarchar(255) not null,
	Author nvarchar(100) not null,
	Year int,
	Copies int not null
)

insert into Books (Title, Author, Year, Copies)
values ('Harry Potter and the Chamber of Secrets', 'J. K. Rowling', 1998, 3)
insert into Books (Title, Author, Year, Copies)
values ('Harry Potter and the Prisoner of Azkaban', 'J. K. Rowling', 1999, 4)
insert into Books (Title, Author, Year, Copies)
values ('Syntactic Structures', 'Noam Chomsky', 1959, 1)
insert into Books (Title, Author, Year, Copies)
values ('Born a Crime', 'Trevor Noah', 2016, 5)
insert into Books (Title, Author, Year, Copies)
values ('The Neverending Story', 'Michael Ende', 1972, 1)
insert into Books (Title, Author, Year, Copies)
values ('Moominland Midwinter', 'Tove Jansson', 1941, 3)
insert into Books (Title, Author, Year, Copies)
values ('Death on the Nile', 'Agatha Christi3', 1929, 7)

