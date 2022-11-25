create login Empleado with password = '123456'
create login Administrador with password = '123456'
go

use Financiera

create User User1 from login Empleado
create user User2 from login Administrador

--Otorgando permisos

grant insert,select,update on Clients to User1,User2
grant insert,select,update,delete on Clients to User2
grant insert,select,delete on Cards to User1,User2
grant insert,select,delete on Accounts to User1,User2
grant select on ClientsView to User1,User2
grant select on CardsView to User1,User2
grant select on AccountsView to User1,User2
grant execute on sp_ValidarAcceso to User1,User2
grant execute on sp_InsertClient to User1,User2
grant execute on sp_InsertCard to User1,User2
grant execute on sp_InsertAccount to User1,User2
grant execute on sp_BuscarClient to User1,User2
grant execute on sp_BuscarTarjeta to User1,User2
grant execute on sp_BuscarCuenta to User1,User2
grant execute on sp_UpdateClient to User1,User2
grant execute on ReporteCuenta to User1,User2
grant execute on ReporteTarjeta to User1,User2


