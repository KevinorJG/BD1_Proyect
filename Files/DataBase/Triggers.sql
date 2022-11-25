
Create trigger tg_UpdateClient
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
	
alter trigger tgInsertClient
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

alter trigger tgInsertAccount
on Accounts
for insert
as
DECLARE @Error int
	BEGIN TRAN
		update Accounts
		set Type_Account = dbo.CleanInput(Type_Account),
		Type_Coin = dbo.CleanInput(Type_Coin),
		Status_ = dbo.CleanInput(Status_)
		where Id_Account = (select Id_Account from inserted)
	SET @Error = @@ERROR
		if(@@Error<>0)
		BEGIN
			ROLLBACK TRAN
			RAISERROR('Ocurrio un error al insertar',11,1)
			PRINT(error_message())
		END
		ELSE
			COMMIT TRAN
go

alter trigger DepositoCuenta
on AccountDetails
For insert
as
DECLARE @Error int
	BEGIN TRAN
		UPDATE AC
		SET Saldo =(AC.Saldo + I.Deposito)
		FROM Accounts AS AC INNER JOIN INSERTED AS I
		ON AC.Id_Account = I.id_Account
	SET @Error = @@ERROR
		if(@@Error<>0)
		BEGIN
			ROLLBACK TRAN
			RAISERROR('Ocurrio un error al insertar los datos',11,1)
			PRINT(error_message())
		END
		ELSE
			COMMIT TRAN
go

alter trigger RetiroCuenta
on AccountDetails
For insert
as
BEGIN
		DECLARE @Error int
		BEGIN TRAN
		DECLARE @cantidad money
		SET @cantidad = (select Retiro from inserted)

		if(@cantidad > (select Saldo from Accounts) )
		BEGIN
			RAISERROR('La cantidad a retirar supera el saldo actual',11,1)
			ROLLBACK TRAN
		END
		ELSE
		BEGIN
		BEGIN TRAN INSERCION
			UPDATE AC
			SET Saldo =(AC.Saldo - I.Retiro)
			FROM Accounts AS AC INNER JOIN INSERTED AS I
			ON AC.Id_Account = I.id_Account

			SET @Error = @@ERROR
			If (@@Error<>0) GOTO ERROR
			COMMIT TRAN
			ERROR:
				If (@@Error<>0)
				BEGIN
					RAISERROR('Error al insertar',11,1)
					PRINT(error_message())
					ROLLBACK TRAN
				END 
		END		
END