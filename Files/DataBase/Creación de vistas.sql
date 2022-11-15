
create view AccountsView as
select (CL.Names+''+CL.Last_Names) as Nombre,Cl.Identification,AC.Type_Account,AC.Type_Coin,AC.Status  
from Accounts as Ac inner join Clients as Cl on Ac.id_Client = Ac.id_Client
go
create view ClientView as 
Select from Clients

use Financiera

create view ClientsView as
select (CL.Id_Client) as ID,(CL.Names) as Nombres,(CL.LastNames) as Apellidos, (CL.Nacionality) as Nacionalidad,
(CL.Identification) as Identificaci�n, (CL.BirthDate) as Fecha_Nacimiento,(CL.Phone) as N�mero_Telefonico,(CL.Direction) as Domicilio
from Clients as CL

select * from ClientsView

execute sp_BuscarClient '001-1110603-1028G'

create view CardsView as
select (CL.Names +' '+ Cl.LastNames) as Cliente, CL.Identification,(C.NumerCard) as Tarjeta,C.OpenDate as 'Fecha Emisi�n',C.ExpiredDate as 'Fecha Expiraci�n',
C.MaxAmountCordoba as 'Transacci�n M�xima en C�rdobas',C.MaxAmountDolar as 'Transaccion M�xima en D�lares',C.FechaCorte as 'Fecha Corte',C.FechaPago as 'Fecha Pago'
from Cards as C inner join Clients as Cl on C.id_Client = CL.Id_Client
GO
use Financiera
create view AccountsView as
select (C.Names+''+C.LastNames) as Cliente,C.Identification as 'Identificaci�n Cliente',(HI.Name_) as Titular,HI.Identification as 'Identificaci�n Titular',
AC.Type_Account as 'Tipo de cuenta',AC.Type_Coin as 'Tipo de moneda' ,AC.Status_ as 'Estado de la cuenta'
from Accounts as AC inner join Clients as C on AC.id_Client = C.Id_Client inner join Hideline as Hi
on AC.id_Hideline = HI.Id_Hideline