Create trigger tg_UpdatetClient
on Clients 
AFTER UPDATE
as	
	BEGIN
	UPDATE Clients
	set Direction = dbo.CleanInput(Direction),
	Phone = dbo.CleanInput(Phone),
	Nacionality = dbo.CleanInput(Nacionality),
	Identification = dbo.CleanInput(Identification)	
	END
	go
	
create trigger tgInsertClient
on CLients
FOR INSERT 
as
DECLARE @value1 nvarchar(50)
DECLARE @value2 nvarchar(50)
DECLARE @value3 nvarchar(50)
DECLARE @value4 nvarchar(20)
DECLARE @value5 nvarchar(20)
DECLARE @value6 date
DECLARE @value7 nvarchar(15)
	
	set @value1 = dbo.CleanInput((select Names from inserted))
	set @value2 = dbo.CleanInput((select LastNames from inserted))
	set @value3 = dbo.CleanInput((select Direction from inserted))
	set @value4 = dbo.CleanInput((select Identification from inserted))
	set @value5 = dbo.CleanInput((select Nacionality from inserted))
	set @value6 = dbo.CleanInput((select BirthDate from inserted))
	set @value7 = dbo.CleanInput((select Phone from inserted))



	drop trigger tgInsertClient
		insert into Clients(Names,LastNames,Direction,Identification,Nacionality,BirthDate,Phone)
	values(@value1,@value2,@value3,@value4,@value5,@value6,@value7
);