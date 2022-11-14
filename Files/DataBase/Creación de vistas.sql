
create view AccountsView as
select (CL.Names+''+CL.Last_Names) as Nombre,Cl.Identification,AC.Type_Account,AC.Type_Coin,AC.Status  
from Accounts as Ac inner join Clients as Cl on Ac.id_Client = Ac.id_Client
go
create view ClientView as 
Select from Clients

use Financiera

create view ClientsView as
select (CL.Id_Client) as ID,(CL.Names) as Nombres,(CL.LastNames) as Apellidos, (CL.Nacionality) as Nacionalidad,
(CL.Identification) as Identificación, (CL.BirthDate) as Fecha_Nacimiento,(CL.Phone) as Número_Telefonico,(CL.Direction) as Domicilio
from Clients as CL

select * from ClientsView

execute sp_BuscarClient '001-1110603-1028G'

create view CardsView as
select (CL.Names +' '+ Cl.LastNames) as Cliente, CL.Identification,(C.NameCard) as Tarjeta, C.TypeCard,C.TypeCoin,C.OpenDate,C.ExpiredDate
from Cards as C inner join Clients as Cl on C.id_Client = CL.Id_Client