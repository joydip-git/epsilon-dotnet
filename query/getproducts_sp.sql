create procedure GetProducts
as
begin
select productid as ID, productname as NAME, productdescription as DESCRIPTION, price as PRICE from products
end