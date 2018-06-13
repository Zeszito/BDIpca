/*create procedure Create_Client
    (@Name char(50), @DataDeNascimento datetime, @CartaoCidadao char(12), @ReservaID int=null)
as begin transaction
    insert into Cliente
    values (@Name, @DataDeNascimento, @CartaoCidadao, @ReservaID)
if @@error <>0
rollback transaction
else
commit transaction*/

create procedure Create_Vinho
    (@Name char(50), @ValorUni int, @AnoProduçao int, @NumeroGarrafas int, @ProduçaoID int=null)
as begin transaction
    insert into Vinho
    values (@Name, @ValorUni, @AnoProduçao, @NumeroGarrafas, @ProduçaoID)
if @@error <>0
rollback transaction
else
commit transaction