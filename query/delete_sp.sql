create procedure DeleteProduct
@pid int
as
begin
delete from products where productid = @pid
end