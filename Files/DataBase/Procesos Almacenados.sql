	/****** Script for SelectTopNRows command from SSMS  ******/

create procedure sp_InsertClient
@names nvarchar(50),
@lastnames nvarchar(50),
@Direction nvarchar(50),
@phone nvarchar(15),
@Birth date,
@Nation nvarchar(20),
@dni nvarchar(20)
as		
	insert into Clients(Names,LastNames,Direction,Phone,Birthdate,Nacionality,Identification)
	values (@names,@lastnames,@Direction,@phone,@Birth,@Nation,@dni)
	go
  
create procedure [dbo].[sp_ValidarAcceso]
@usuario varchar(50)
as
if exists (Select DNI from Employees
            where DNI = @Usuario and Status_ = 'Habilitado' )
			 select 'Acceso Exitoso' as Resultado, (E.Names +' '+E.Surnames) as NameEmployee, E.Roll
			 from Employees E			 
			 else
			 Select 'Acceso Denegado' as Resultado

create procedure sp_InsertEmployee
@Dni nvarchar(20),
@Names nvarchar(20),
@Surnames nvarchar(20),
@Roll nvarchar(15),
@Status nvarchar(10)
as
if not exists(select EM.DNI,EM.Roll from Employees AS EM
			where Em.DNI = @Dni and EM.Roll = @Roll)
			BEGIN
			insert into Employees(DNI,Names,Surnames,Roll,Status_) values(@Dni,@Names,@Surnames,@Roll,@Status)
			print 'Empleado añadido'
			END
			else
			BEGIN
			RAISERROR ('Empleado ya existe',11,1)
			END
go

create procedure sp_BuscarClient
@Identification nvarchar(20)
as
if exists(select C.Id_Client from Clients as C
			where C.Identification = @Identification)
			BEGIN
			select * from ClientsView where Identificación = @Identification
			END
			else
			BEGIN
			RAISERROR ('Cliente no existe',11,1)
			END
go

create procedure sp_InsertCard(
@identi nvarchar(20),
@NameCard nvarchar(10),
@TypeCard nvarchar(15),
@TypeCoin nvarchar(15),
@OpenDate date,
@ExpireDate date,
@MaxAmountD money,
@MaxAmountC money,
@BaseAmountD money,
@BaseAmountC money,
@FechaPago date,
@FechaCorte date,
@NCard nvarchar(22)
)
as
DECLARE @identify int

		set @identify = (select Id_Client from Clients where Identification = @identi)
		insert into Cards(id_Client,NameCard,TypeCard,TypeCoin,OpenDate,ExpiredDate,
		MaxAmountDolar,MaxAmountCordoba,AmounBaseDolar,AmountBaseCordoba,FechaCorte,FechaPago,NumerCard)
		values(@identify,@NameCard,@TypeCard,@TypeCoin,@OpenDate,@ExpireDate,@MaxAmountD,@MaxAmountC,@BaseAmountD,@BaseAmountC,@FechaCorte,@FechaPago,@NCard)
go

create procedure sp_InsertAccount(
@identify nvarchar(20),
@id_Hideline int,
@TypeAccount nvarchar(15),
@TypeCoin nvarchar(15),
@saldo money,
@OpenDate date,
@Status nvarchar(20)
)
as
DECLARE @id int
	SET @id = (select Id_Client from Clients where Identification = @identify)
insert into Accounts (id_Client,id_Hideline,Type_Account,Type_Coin,Saldo,OpenDate,Status_)
values(@id,@id_Hideline,dbo.CleanInput(@TypeAccount),dbo.CleanInput(@TypeCoin),@saldo,@OpenDate,@Status)
go

create procedure sp_UpdateClient(
@id_Client int,
@Direction nvarchar(50),
@Phone nvarchar(10),
@Nationality nvarchar(20),
@Identification nvarchar(20),
@Date Date
)
as
UPDATE Clients
set Direction = @Direction, Phone = @Phone, Nacionality = @Nationality, Identification = @Identification,BirthDate = @Date
where Id_Client = @id_Client
go

create procedure sp_BuscarTarjeta(
@Identification nvarchar(20)
)
as
if exists(select C.id_Client from Clients as C
			where C.Identification = @Identification)
			BEGIN
			DECLARE @id int
			SET @id = (select Id_Client from Clients where Clients.Identification = @Identification)
			select * from CardsView where CardsView.Identification = @Identification
			END
			else
			BEGIN
			RAISERROR ('Tarjeta no existe',11,1)
			END

go
create procedure sp_BuscarCuenta(
@Identification nvarchar(20)
)
as
if exists(select C.id_Client from Clients as C
			where C.Identification = @Identification)
			BEGIN
			select * from AccountsView where AccountsView.[Identificacion_Cliente] = @Identification
			END
			else
			BEGIN
			RAISERROR ('Cuenta no existe',11,1)
			END
go

create procedure ReporteCuenta(
@Id_ACC int
)
as 
select AD.TransactionDate,
AC.id_Client,
AC.Id_Account,
Cl.Names+' '+CL.LastNames as Titular,
AD.typeMove as 'Tipo_Moviento',
AD.TypeGestion as 'Tipo_Gestion',
AD.description_ as 'Descripcion',
AD.Deposito,
AD.Retiro,
AC.Saldo
from AccountDetails as AD inner join Accounts as AC on AD.id_Account = AC.Id_Account
inner join Clients as CL on AC.id_Client = CL.Id_Client
where AC.Id_Account = @Id_ACC
go

create procedure ReporteTarjeta(
@Id_Card int
)
as
select 
CD.Pago,
CD.Retiro,
CD.TransactionDate,
CD.TypeGestion,
CD.NombreComercio,
CD.CodigoComercio,
CD.DireccionComercio,
CD.Telefono,
C.NameCard,
C.NumerCard,
(CL.Names+' '+CL.LastNames) as Propietario,
Cl.Identification
from CardDetails as CD inner join Cards as C
on CD.id_Card = C.Id_Card inner join Clients as Cl
on C.id_Client = CL.Id_Client
where C.Id_Card = @Id_Card
go


backup database Financiera
to disk = 'D:\Financiera.bak'