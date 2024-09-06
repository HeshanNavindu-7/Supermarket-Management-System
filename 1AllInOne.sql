use AllInOne;
CREATE TABLE tblsignup
(
	[signup_Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [role] VARCHAR(50) NOT NULL, 
    [firstname] VARCHAR(50) NOT NULL, 
    [lastname] VARCHAR(50) NOT NULL, 
    [email] VARCHAR(50) NOT NULL, 
    [cnumber] INT NULL, 
    [gender] VARCHAR(50) NULL, 
    [birthday] DATE NULL, 
    [password] VARCHAR(50) NOT NULL, 
    [cpassword] VARCHAR(50) NOT NULL
)
insert into tblsignup values 
('Admin','hesh','navi','hesh@gmail.com',0777878787,'male','2002-2-2','hehe12','hehe12');
select *from tblsignup;

select *from tblitem where catogery='care item';
insert into tblitem values 
('baby food','baby item',200,100);
insert into tblitem values 
('soap','care item',300,60);
select *from tblsignin;
select *from tbladduser;
insert into tbladduser values
('Admin','admin123','admin');
insert into tbladduser values
('Cashior','cashior123','Cashior');
CREATE TABLE tbladduser
(
	[User_Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [User_Name] VARCHAR(50) NOT NULL, 
    [password] VARCHAR(50) NOT NULL, 
    [Role] VARCHAR(50) NOT NULL
)
