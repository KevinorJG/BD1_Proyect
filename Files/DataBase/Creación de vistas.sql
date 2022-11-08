
create view AccountsView as
select (CL.Names+''+CL.Last_Names) as Nombre,Cl.Identification,AC.Type_Account,AC.Type_Coin,AC.Status  
from Accounts as Ac inner join Clients as Cl on Ac.id_Account = Ac.id_Client
go
create view ClientView as 
Select from Clients