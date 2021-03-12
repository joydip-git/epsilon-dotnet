create procedure InsertProduct
@pname varchar(50),
@pdesc varchar(max),
@price decimal(18,2)
as
begin
insert into products(productname,productdescription,price) values(@pname,@pdesc,@price)
end