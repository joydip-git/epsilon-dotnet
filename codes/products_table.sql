--create database epsilondb
use epsilondb
create table products(
productid int identity(100,1) primary key,
productname varchar(50) not null,
productdescription varchar(max),
price decimal(18,2) default(0)
)

insert into products values('dell xps','new laptop from dell',67000.00)
insert into products values('hp probook','new laptop from hp',57000.00)
insert into products values('lenovo beast','new laptop from lenovo',47000.00)