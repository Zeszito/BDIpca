create procedure Create_Client
    (@ID int, @Name char(50), @DataDeNascimento datetime, @CartaoCidadao char(12), @ReservaID int=null)
as begin transaction
    insert into Cliente
    values (@ID, @Name, @DataDeNascimento, @CartaoCidadao, @ReservaID)
if @@error <>0
rollback transaction
else
commit transaction
