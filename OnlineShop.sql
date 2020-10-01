create database OnlineShop;
use OnlineShop;


create table AdminUser(
adminId int identity primary key,
adminName varchar(50),
adminPass varchar(50),
email varchar(50),
);





create table Brands(
brandId int identity primary key,
brandName  varchar(20)
);



create table Products(
productId int identity primary key,
productName varchar(50),
brandId int,
datem datetime,
price decimal,
img varchar(200),
sale float,
priceSale decimal default 0,

);






create table Transactions(
tranId  bigint identity primary key,
status int default '0',
userName varchar(50),
userMail varchar(50),
userPhone varchar(20),
userAddress varchar(100),
payment varchar(50) default '',
total decimal,
);

create table Oders(
tranId bigint,
oderId int identity primary key,
productId int,
price decimal,
quatity int, 
size int,
statusOrder int ,
createDay date default '',
);

ALTER TABLE Products
 ADD CONSTRAINT fk_brands_products
   FOREIGN KEY (brandId)
   REFERENCES Brands (brandId);



ALTER TABLE Oders
 ADD CONSTRAINT fk_transcactions_oders
   FOREIGN KEY (tranId)
   REFERENCES Transactions (tranId);

ALTER TABLE Oders
 ADD CONSTRAINT fk_products_oders
   FOREIGN KEY (productId)
   REFERENCES Products (productId);

   insert into Brands values('Nike');
   insert into Brands values('Fila');
   insert into Brands values('Adidas');

   ---delete from Products;

    insert into Products values('NB 574 Mossgreen','1','','3500000','/Image/SanPham/images/SanPham/NB 574 Mossgreen.jpg','0',0);
    insert into Products values('NB 009','1','2020/04/10','3500000','/Image/SanPham/images/SanPham/NB 009.jpg','0.4',0); 
    insert into Products values('NB 996','1','2020/02/10','3500000','/Image/SanPham/images/SanPham/NB 996.jpg','0.3',0);
	insert into Products values('NB 373','1','2020/02/10','3500000','/Image/SanPham/images/SanPham/NB 373.jpg','0',0);
	insert into Products values('Ari Jordan 3 Retro SE','1','2020/02/10','7347000','/Image/SanPham/images/SanPham/Ari Jordan 3 Retro SE.jpg','0',0);
	
	insert into Products values('Jordan Zoom Trunner Advance','1','2020/02/10','3239000','/Image/SanPham/images/SanPham/Jordan Zoom Trunner Advance.jpg','0.2',0);
	insert into Products values('Nike Air Zoom Pegasus 37','1','2020/02/10','3519000','/Image/SanPham/images/SanPham/Nike Air Zoom Pegasus 37.jpg','0.1',0);
	insert into Products values('Nike Air Max 270 React SE','1','2020/02/10','4699000','/Image/SanPham/images/SanPham/Nike Air Max 270 React SE.jpg','0',0);
	insert into Products values('Nike NSW React Vision Essential','1','2020/02/10','3829000','/Image/SanPham/images/SanPham/Nike NSW React Vision Essential.jpg','0.4',0); 
	insert into Products values('Air Jordan XXXIV Low PF','1','2020/02/10','4849000','/Image/SanPham/images/SanPham/Air Jordan XXXIV Low PF.jpg','0',0);
	insert into Products values('Nike Air Zoom Pegasus 37','1','2020/02/10','3519000','/Image/SanPham/images/SanPham/Nike Air Zoom Pegasus 37.jpg','0',0);
	insert into Products values('Nike Mercurial Superfly 7 Elite FG','1','2020/02/10','8059000','/Image/SanPham/images/SanPham/Nike Mercurial Superfly 7 Elite FG.jpg','0',0);
	insert into Products values('Nike SB GTS Return','1','2020/02/10','2349000','/Image/SanPham/images/SanPham/Nike SB GTS Return.jpg','0',0);
	insert into Products values('Nike CruzrOne','1','2020/02/10','4409000','/Image/SanPham/images/SanPham/Nike CruzrOne.jpg','0',0);
			

	insert into Products values('FI.LA oakmont cream','2','2020/05/10','1300000','/Image/SanPham/images/SanPham/FI_LA oakmont cream.jpg','0.4',0);
	insert into Products values('FI.LA Ray Tracer','2','2020/02/10','1870000','/Image/SanPham/images/SanPham/FI_LA Ray Tracer.jpg','0',0);
	insert into Products values('FI.LA Barricade XT 97','2','2020/02/10','1800000','/Image/SanPham/images/SanPham/FI_LA Barricade XT 97.jpg','0',0);
	insert into Products values('FI.LA oakmont tan','2','2020/02/10','2300000','/Image/SanPham/images/SanPham/FI_LA oakmont tan.jpg','0',0);
	insert into Products values('FI.LA oakmont','2','2020/02/10','1500000','/Image/SanPham/images/SanPham/FI_LA oakmont.jpg','0.2',0);
	

	insert into Products values('SUPERSTAR','3','2020/04/20','3200000','/Image/SanPham/images/SanPham/SUPERSTAR.jpg','0.1',0);
	insert into Products values('ULTRABOOST 19','3','2020/05/15','5000000','/Image/SanPham/images/SanPham/ULTRABOOST 19.jpg','0.2',0);
	insert into Products values('ALPHAEDGE 4D','3','2020/02/10','7500000','/Image/SanPham/images/SanPham/ALPHAEDGE 4D.jpg','0',0);
	insert into Products values('SAMBA OG','3','2020/02/10','2500000','/Image/SanPham/images/SanPham/SAMBA OG.jpg','0',0);
	insert into Products values('NMD_R1 PRIDE','3','2020/02/10','3400000','/Image/SanPham/images/SanPham/NMD_R1 PRIDE.jpg','0.1',0);
	insert into Products values('STAN SMITH','3','2020/02/10','2300000','/Image/SanPham/images/SanPham/STAN SMITH.jpg','0',0);
	insert into Products values('ULTRABOOST 20','3','2020/02/10','5000000','/Image/SanPham/images/SanPham/ULTRABOOST 20.jpg','0',0);
	insert into Products values('SL ANDRIDGE W','3','2020/02/10','2700000','/Image/SanPham/images/SanPham/SL ANDRIDGE W.jpg','0',0);
	insert into Products values('CONTINENTAL 80 W','3','2020/02/10','2500000','/Image/SanPham/images/SanPham/CONTINENTAL 80 W.jpg','0',0);
	insert into Products values('NMD_R1 PK','3','2020/02/10','4500000','/Image/SanPham/images/SanPham/NMD_R1 PK.jpg','0',0);
	


	insert into AdminUser values('admin1','12345','9thanhtra@gmail.com');
	insert into AdminUser values('admin2','123456','congsonhl1999@gmail.com');


	
	
	
	drop table Transactions;
	drop table Oders;
	drop table Products;



		

	----trigger
	
CREATE TRIGGER [dbo].[Trigger_Datem] ON [dbo].[Products] FOR INSERT AS BEGIN
    Declare @Id int
    set @Id = (select productId from inserted)

    Update [dbo].[Products]
    Set datem = GetDate()
    Where productId = @Id
END
 

 CREATE TRIGGER [dbo].[Trigger_price] ON [dbo].[Products] FOR INSERT AS BEGIN
    Declare @Id int
    set @Id = (select productId from inserted)

    Update [dbo].[Products]
    Set priceSale = price*(1-sale)
    Where productId = @Id
END
 


