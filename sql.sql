select * from LocalTtoir where (LEFT(AnimalType,1) = '豬' or LEFT(AnimalType,1) = '羊'or LEFT(AnimalType,1) = '牛'or LEFT(AnimalType,1) = '其他')  order by FarmNo 
select * from LocalTtoir where (LEFT(AnimalType,1) = '豬' or LEFT(AnimalType,1) = '羊'or LEFT(AnimalType,1) = '牛'or LEFT(AnimalType,1) = '其他')  and (SupName like '%" 
"create table LocalTtoir ("
"FarmNo varchar(6),"
 "SupName varchar(50),"
 "ZipCode varchar(3),"
"MailAddress varchar(100),"
"Address varchar(100),"
 "AnimalType varchar(50))"

select * from LocalTtoir order by FarmN
