

use Financiera
drop view ClientsView
drop view CardsView
drop view AccountsView

create view ClientsView as
select (CL.Id_Client) as ID,(CL.Names) as Nombres,(CL.LastNames) as Apellidos, (CL.Nacionality) as Nacionalidad,
(CL.Identification) as Identificación, (CL.BirthDate) as Fecha_Nacimiento,(CL.Phone) as Número_Telefonico,(CL.Direction) as Domicilio
from Clients as CL

create view CardsView as
select (CL.Names +' '+ Cl.LastNames) as Cliente, 
CL.Identification,
(C.NumerCard) as Tarjeta,
C.OpenDate as 'Fecha Emisión',
C.ExpiredDate as 'Fecha Expiración',
C.MaxAmountCordoba as 'Transacción Máxima en Córdobas',
C.MaxAmountDolar as 'Transaccion Máxima en Dólares',
C.FechaCorte as 'Fecha Corte',
C.FechaPago as 'Fecha Pago'
from Cards as C inner join Clients as Cl on C.id_Client = CL.Id_Client

create view AccountsView as
select
AC.Id_Account as ID,
(select (C.Names+' '+C.LastNames) from Clients as C where C.Id_Client = Ac.id_Client) as Cliente,
(select H.Name_ from Hideline as H where H.Id_Hideline = AC.id_Hideline) as Titular,
(select H.Name_ from Hideline as H where H.Id_Hideline = AC.id_Hideline) as 'Identificacion_Titular',
(select C.Identification from Clients as C where C.Id_Client = AC.id_Client) as 'Identificacion_Cliente',
AC.Type_Account as 'Tipo_cuenta',
AC.Type_Coin as 'Tipo_moneda' ,
AC.Status_ as 'Estado_cuenta'
from Accounts as AC where id_Hideline is null or id_Hideline is not null or id_Client is null or id_Client is not null