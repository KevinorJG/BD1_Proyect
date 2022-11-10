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