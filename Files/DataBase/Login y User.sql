create login Empleado with password = '123456'
create login Administrador with password = '123456'
go

use Financiera

create User Kevin from login Empleado
create user Francisco from login Administrador

--Otorgando permisos

grant insert,select,update on Clients to Kevin
grant insert,select,update,delete on Clients to Francisco
grant select on ClientsView to Kevin
grant select on CardsView to Kevin
grant select on AccountsView to Kevin
grant execute on sp_ValidarAcceso to Kevin
grant execute on sp_InsertClient to Kevin
grant execute on sp_InsertCard to Kevin
grant execute on sp_InsertAccount to Kevin
grant execute on sp_BuscarClient to kevin
grant execute on sp_BuscarTarjeta to Kevin
grant execute on sp_UpdateClient to Kevin


grant execute on sp_ValidarAcceso to Francisco
grant execute on sp_InsertClient to Francisco

