Create database Financiera
go
use Financiera
go


--1
create table Employees
(
Id_Employee int primary key not null,
DNI nvarchar(20),
Names nvarchar(20),
Roll nvarchar(15),
Status_ nvarchar(10),
Surnames nvarchar(20)
)
--2
create table EmployeeTransaction
(
Id_Transaction int primary key not null,
id_Emloyee int not null,
id_Client int not null,

)
--3
create table Client
(
Id_Client int primary key not null,
Names nvarchar(50),
LastNames nvarchar (50),
BirthDate date,
Direction nvarchar(20),
Identification nvarchar(20),
Nacionality nvarchar(20),
Phone nvarchar(10)
)
--4
create table Cards
(
Id_Card int primary key not null,
id_Client int not null,
NameCard nvarchar(10),
TypeCard nvarchar(15),
TypeCoin nvarchar(15),
Description_ nvarchar(25),
MaxAmount money,
MinAmount money,
OpenDate date,
ExpiredDate date
)
--5
create table CardDetails
(
Id_CardDetails int primary key not null,
id_Card int not null,
id_Emplooye int not null,
Deposito money,
Retiro money,
TransactionDate date
)
--6
create table Accounts
(
Id_Account int primary key not null,
id_Client int not null,
id_Hideline int not null,
Description_ nvarchar(25),
Type_Account nvarchar(15),
Type_Coin nvarchar(15),
Status_ nvarchar(10),
MinAmount money,
OpenDate date
)
--7
create table Hideline
(
Id_Hideline int primary key not null,
Identification nvarchar(20),
Name_ nvarchar(20),
Phone nvarchar(20)

)
--8
create table AccountDetails
(
Id_AccountDetails int primary key not null,
id_Account int not null,
id_Employee int not null,
Deposito money,
Retiro money,
TransactionDate date
)
--Empleado a empleado transac
Alter table EmployeeTransaction
add foreign key (id_Emloyee) references Employees(Id_Employee)

--Cliente a Transac
Alter table EmployeeTransaction
add foreign key (id_Client) references Client(Id_Client)
--Cards a Cliente
Alter table Cards
add foreign key (id_Client) references Client(Id_Client)
--Cards a CardsDetail
Alter table CardDetails
add foreign key (id_Card) references Cards(Id_Card)
--Cliente a cuenta 
Alter table Accounts
add foreign key (id_Client) references Client(Id_Client)
--Cuenta a Hideline
Alter table Accounts
add foreign key (id_Hideline) references Hideline(Id_Hideline)
--Cuenta a dettale de cuenta
Alter table AccountDetails
add foreign key (id_Account) references Accounts(Id_Account)


