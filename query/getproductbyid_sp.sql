create procedure GetProductById
@pid int
as
begin
select * from products where productid = @pid
end