create procedure UpdateProduct
@pid int,
@pname varchar(50),
@pdesc varchar(max),
@price decimal(18,2)
as
begin
update products set productname=@pname,productdescription=@pdesc,price=@price where productid=@pid
end