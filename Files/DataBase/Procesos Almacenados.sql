	/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [id_Client]
      ,[Names]
      ,[LastNames]
      ,[Direction]
      ,[Phone]
      ,[Birthdate]
      ,[Nacionality]
      ,[Identification]
  FROM [Financiera].[dbo].[Clients]

  drop procedure sp_InsertClient
  drop procedure sp_InsertEmployee

  create procedure sp_InsertClient
	@names nvarchar(50),
	@lastnames nvarchar(50),
	@Direction nvarchar(50),
	@phone nvarchar(15),
	@Birth date,
	@Nation nvarchar(20),
	@dni nvarchar(20)
	as	
	DECLARE @value1 nvarchar(50),
			@value2 nvarchar(50),
			@value3 nvarchar(50),
			@value4 nvarchar(15),
			@value5 date,
			@value6 nvarchar(20),
			@value7 nvarchar(20)
	set @value1 = [dbo].[CleanInput](@names)
	set @value2 = [dbo].[CleanInput](@lastnames)
	set @value3 = [dbo].[CleanInput](@Direction)
	set @value4 = [dbo].[CleanInput](@phone)
	set @value5 = [dbo].[CleanInput](@Birth)
	set @value6 = [dbo].[CleanInput](@Nation)
	set @value7 = [dbo].[CleanInput](@dni)
	insert into Clients(Names,LastNames,Direction,Phone,Birthdate,Nacionality,Identification)
	values (@value1,@value2,@value3,@value4,@value5,@value6,@value7)
  
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

create procedure sp_BuscarClient
@Identification nvarchar(20)
as
if exists(select C.Id_Client from Clients as C
			where C.Identification = @Identification)
			BEGIN
			select * from Clients
			END
			else
			BEGIN
			RAISERROR ('Cliente no existe',11,1)
			END

create procedure sp_ClientAccount
@Identification nvarchar(20)
as
	if exists(select C.Identification from Clients as C inner join Accounts as A on C.Id_Client = A.id_Client
				where C.Identification = @Identification)
				BEGIN
				select (C.Names+' '+C.LastNames) as Client,C.Identification, A.Type_Account,A.Type_Coin,A.Status_,A.OpenDate,ACD.Deposito from Clients as C 
				inner join Accounts as A on C.Id_Client = A.id_Client
				inner join AccountDetails ACD on A.Id_Account = ACD.id_Account
 				END
				else
				BEGIN
				RAISERROR ('No existe',11,1)
				END
go
create procedure sp_InsertCard(
@id_Client int,
@NameCard nvarchar(10),
@TypeCard nvarchar(15),
@TypeCoin nvarchar(15),
@OpenDate date,
@ExpireDate date,
@MaxAmount money,
@MinAmount money,
@Description nvarchar(25)
)
as
	insert into Cards  (id_Client,NameCard,TypeCard,TypeCoin, Description_,MaxAmount,MinAmount,OpenDate,ExpiredDate)
	values(@id_Client,dbo.CleanInput(@NameCard),dbo.CleanInput(@TypeCard),dbo.CleanInput(@TypeCoin),dbo.CleanInput(@Description),@MaxAmount,@MinAmount,@OpenDate,@ExpireDate)
go

create procedure sp_InsertAccount(
@id_Client int,
@id_Hideline int,
@Description nvarchar(25),
@TypeAccount nvarchar(15),
@TypeCoin nvarchar(15),
@Status nvarchar(10),
@MinAmount money,
@OpenDate date
)
as
insert into Accounts (id_Client,id_Hideline,Description_,Type_Account,Type_Coin,Status_,MinAmount,OpenDate)
values(@id_Client,@id_Hideline,dbo.CleanInput(@Description),dbo.CleanInput(@TypeAccount),dbo.CleanInput(@TypeCoin),dbo.CleanInput(@Status),@MinAmount,@OpenDate)
go

create procedure sp_UpdateClient(
@id_Client int,
@Direction nvarchar(20),
@Phone nvarchar(10),
@Nationality nvarchar(20),
@Identification nvarchar(20)
)
as
UPDATE Clients
set Direction = @Direction, Phone = @Phone, Nacionality = @Nationality, Identification = @Identification
where Id_Client = @id_Client
go

backup database Financiera
to disk = 'D:\Financiera.bak'