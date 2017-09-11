create database inautixADOaug2017
use inautixADOaug2017
create table cities 
(
cityid int identity (1,1) primary key,
cityname varchar(30)



)
insert cities values ('chennai')
insert cities values ('muibai')
insert cities values ('pune')
insert cities values ('madurai')


select * from cities 
create table customer
(
customerid int identity (1000,1) primary key,
customername varchar (100),
customerage int,
customercityid int foreign key references cities(cityid),
customerpassword varchar(30)

)

select * from customer
select customerid,customername,customerage,cityname,customerpassword
from customer
join cities on
customer.customercityid=cities.cityid where customerid=1001
create table items
(
itemid int identity (1,1) primary key,
itemname varchar(30)

)
insert items values ('mobile')
insert items values ('laptop')
insert items values ('tab')
insert items values ('tv')
insert items values(' computer desktop')


select * from customer
select * from items
select * from orders


create table orders 
(
orderid int identity (10000,1) primary key,
customerid int foreign key references customer(customerid),
itemid int foreign key references items(itemid),
itemqty int ,
itemprice int,
orderdate datetime
)
select orders.customerid,items.itemname,orders.itemqty,orders.itemprice,orders.orderdate
from orders
join items 
on orders.itemid= items.itemid
where orderid=10002

alter table items add itemprice int
update items set itemprice =8000 where itemid=2
update items set itemprice =2500 where itemid=3
update items set itemprice =1500 where itemid=4
update items set itemprice =10000 where itemid=5
alter table orders drop column itemprice



