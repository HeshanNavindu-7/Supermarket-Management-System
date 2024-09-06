create database supermarket;

use supermarket;



create table signuptable
(firstname varchar(10) , lastname varchar(30), email varchar(30), DOB date, cnumber int,gender varchar(10),
password varchar(10),cpassword varchar(10));
insert into signuptable
(firstname,lastname,email,DOB,cnumber,gender,password,cpassword )
values
('heshan','navindu','heshhh123@gmail.com','2001-01-10',0876543221,'male','123456','123456');

Select * from signuptable;
