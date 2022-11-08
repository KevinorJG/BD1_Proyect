Create database Financiera
go
use Financiera
go


--1
create table Employees
(
Id_Employee int primary key identity(1,1) not null,
DNI nvarchar(20) not null,
Names nvarchar(20)not null,
Roll nvarchar(15)not null,
Status_ nvarchar(10)not null,
Surnames nvarchar(20) not null
)

--3
create table Clients
(
Id_Client int primary key identity(1,1) not null,
Names nvarchar(50)not null,
LastNames nvarchar (50) not null,
BirthDate date not null,
Direction nvarchar(20)not null,
Identification nvarchar(20)not null,
Nacionality nvarchar(20)not null,
Phone nvarchar(10) not null
)
--4
create table Cards
(
Id_Card int primary key identity(1,1) not null,
id_Client int not null,
NameCard nvarchar(10)not null,
TypeCard nvarchar(15)not null,
TypeCoin nvarchar(15)not null,
Description_ nvarchar(25)not null,
MaxAmount money not null,
MinAmount money not null,
OpenDate date not null,
ExpiredDate date not null
)
--5
create table CardDetails
(
Id_CardDetails int primary key identity(1,1) not null,
id_Card int not null,
id_Employee int not null,
Deposito money not null,
Retiro money not null,
TransactionDate date not null
)
--6
create table Accounts
(
Id_Account int primary key identity(1,1) not null,
id_Client int not null,
id_Hideline int not null,
Description_ nvarchar(25) not null,
Type_Account nvarchar(15)not null,
Type_Coin nvarchar(15)not null,
Status_ nvarchar(10)not null,
MinAmount money not null,
OpenDate date not null
)
--7
create table Hideline
(
Id_Hideline int primary key identity(1,1) not null,
Identification nvarchar(20) not null,
Name_ nvarchar(20) not null,
Phone nvarchar(20) not null

)
--8
create table AccountDetails
(
Id_AccountDetails int primary key identity(1,1) not null,
id_Account int not null,
id_Employee int not null,
Deposito money not null,
Retiro money not null,
TransactionDate date not null
)
--Cards a Cliente
Alter table Cards
add foreign key (Id_Client) references Clients(id_Client)
--Cards a CardsDetail
Alter table CardDetails
add foreign key (id_Card) references Cards(Id_Card)
--Cliente a cuenta 
Alter table Accounts
add foreign key (Id_Client) references Clients(id_Client)
--Cuenta a Hideline
Alter table Accounts
add foreign key (Id_Hideline) references Hideline(Id_Hideline)
--Cuenta a dettale de cuenta
Alter table AccountDetails
add foreign key (id_Account) references Accounts(Id_Account)

Alter table AccountDetails
add foreign key (Id_Employee) references Employees(Id_Employee)

Alter table CardDetails
add foreign key (Id_Employee) references Employees(Id_Employee)



alter table Accounts
add Id_Hideline int

ALTER AUTHORIZATION ON DATABASE::[Financiera] TO [sa]

drop table Clients
drop table Employees
drop table AccountDetails
drop table Accounts
drop table Cards
drop table CardDetails
drop table Hideline