use Orari
create table UserGroup(
Prioriteti int NOT NULL primary key,
Emri varchar(10) not null
)

--Aksesi per Student
insert into UserGroup VALUES(1 , 'Student')
--Asistent
insert into UserGroup VALUES(2, 'Asistent')
--Profesor
insert into UserGroup VALUES(3, 'Profesor')
--Rektor
insert into UserGroup VALUES(4, 'Rektor')




create table Users (
IDuseri int not null IDENTITY(1,1) PRIMARY KEY,
Emri varchar(20) not null,
Mbiemri varchar(20) not null,
Gjinia char(1) not null check(Gjinia = 'M' or Gjinia = 'F'),
Shteti varchar(20) ,
Qyteti varchar(30) ,
Username varchar(25) not null,
Password varchar(25) not null,
[Data e lindjes] DATE,
Mosha as datediff(year,[Data e lindjes],CONVERT(date, getdate())),
Statusi int foreign key references UserGroup(prioriteti),
[E-Mail] varchar(45) not null
)


create table Lenda(
IDLenda int primary key identity(1,1),
[Emri i lendes] varchar(30) not null,
Lloji char(1) check(Lloji = 'Z' or Lloji = 'O') not null,
Orë varchar(3) not null
)


create table Ligjeruesit(
IDLigjeruesi int Identity(1,1) ,
IDProfesori int foreign key references Users(IDuseri) not null,
IDLenda int foreign key REFERENCES Lenda(IDLenda) not null,
Lloji char(1) check(Lloji = 'L' or Lloji = 'U') not null,
Unique (IDLigjeruesi),
Primary Key (IDProfesori , IDLenda)
)


create table Orari(
IDOrari int primary key identity(1,1),
IDLigjeruesi int foreign key references Ligjeruesit(IDLigjeruesi),
[Emri/Numri i salles] varchar(10) not null,
Dita varchar(2) CHECK (Dita in ('H' , 'M' , 'Me' , 'E' , 'P')),
OraFillimit Time not null,
OraMbarimit Time not null,
Semestri int not null check(Semestri in (1,2,3,4,5,6)),
unique (Dita,OraFillimit , oraMbarimit ,Semestri,[Emri/Numri i salles]),
Drejtimi varchar(30) not null
)


create table LendetEZgjedhura(
idLendaZgjedhur int identity(1,1) unique,
Studenti int foreign key references Users(idUseri),
idLigjeruesi int foreign key references Ligjeruesit(IDLigjeruesi),
Semestri int not null check(Semestri in (1,2,3,4,5,6)),
[Data e zgjedhjes] as CONVERT(date, getdate()),
primary key(Studenti , idLigjeruesi)
)

create table KerkesaPerNderrim(
idKerkesa int identity(1,1) primary key,
Lenda int foreign key references LendetEZgjedhura(idLendaZgjedhur),
OraFillimit time not null,
OraMbarimit Time not null,
Dita varchar(2) CHECK (Dita in ('H' , 'M' , 'Me' , 'E' , 'P')),
approved bit default 0
)


create table feedback(
idFeedback int primary key identity(1,1),
Studenti int foreign key references users(idUseri),
[Lenda] int foreign key references LendetEZgjedhura(idLendaZgjedhur),
Mesazhi text not null,
MesazhiRreth char(1) check (MesazhiRreth = 'P' or MesazhiRreth = 'L'),
[Data e feedback] as CONVERT(date, getdate())
)



CREATE TABLE chat (
c_id int NOT NULL PRIMARY KEY identity(1,1),
message varbinary(max) not null,
type char(1) not null check(type in ('V','Z','T','F'))
)


create table chatUsers(
cu_id int primary key identity(1,1),
chat_id int foreign key references chat(c_id) not null,
user_id_from int foreign key references users(iduseri) not null,
user_id_to int foreign key references users(iduseri) not null,
ip_user int not NULL
)





