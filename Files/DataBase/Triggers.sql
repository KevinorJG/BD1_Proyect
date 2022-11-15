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
on Clients
for insert
as 
	Update Clients
	set Names = dbo.CleanInput(Names),
	LastNames = dbo.CleanInput(LastNames),
	Direction = dbo.CleanInput(Direction),
	Phone = dbo.CleanInput(Phone),
	Nacionality = dbo.CleanInput(Nacionality),
	Identification = dbo.CleanInput(Identification)	
	where Id_Client = (select Id_Client from inserted);
go

create trigger tgDeleteClient
on Clients
for Delete
as
	declare @value int
	set @value = (select id_Client from deleted)
	if((select  from Cards 
		where id_Client = @value)) = 'Activo'
		BEGIN
			RAISERROR ('Aun ',11,1)
		END
	delete Clients from Clients
	where Id_Client = @value

go
drop trigger tgDeleteClient
delete from Clients where Id_Client = 29
select * from ClientsView
select * from CardsView
select * from Accounts
