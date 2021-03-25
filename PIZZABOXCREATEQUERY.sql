CREATE DATABASE PizzaBox_P1;
USE PizzaBox_P1;

CREATE TABLE ATopping( 
ID int NOT NULL,
ToppingName varchar(50),
ToppingPrice decimal(5,2),
PRIMARY KEY (ID));

CREATE TABLE ACrust( 
ID int NOT NULL,
CrustName varchar(50),
CrustPrice decimal(5,2),
PRIMARY KEY (ID));

CREATE TABLE ASize( 
ID int NOT NULL,
SizeName varchar(50),
SizePrice decimal(5,2),
PRIMARY KEY (ID));

CREATE TABLE ACustomer( 
ID int NOT NULL,
LocationID int NOT NULL,
CustomerName varchar(50),
PRIMARY KEY (ID));

CREATE TABLE AStore( 
ID int NOT NULL,
StoreName varchar(50),
PRIMARY KEY (ID));

CREATE TABLE APizza(
ID int NOT NULL,
PizzaName varchar(50) NOT NULL,
Size int,
Crust int,
Price Decimal(5,2),
PRIMARY KEY (ID),
FOREIGN KEY (Size) REFERENCES ASize(ID),
FOREIGN KEY (Crust) REFERENCES ACrust(ID)
);

CREATE TABLE APizzaTopping(
ToppingID int,
PizzaID int
);

CREATE Table AOrder(
OrderID int NOT NULL,
StoreID int NOT NULL,
CustomerID int,
TimeOrdered DateTime NOT NULL,
Total Decimal(5,2),
PRIMARY KEY(OrderID),
FOREIGN KEY (StoreID) REFERENCES AStore(ID),
FOREIGN KEY (CustomerID) REFERENCES ACustomer(ID)
);


CREATE TABLE AOrderedPizza(
ID int NOT NULL,
OrderID int NOT NULL,
PizzaName varchar(50) NOT NULL,
Size int,
Crust int,
Price Decimal(5,2),
PRIMARY KEY (ID),
FOREIGN KEY (OrderID) REFERENCES AOrder(OrderID),
FOREIGN KEY (Size) REFERENCES ASize(ID),
FOREIGN KEY (Crust) REFERENCES ACrust(ID)
);

CREATE TABLE AOrderedTopping(
ToppingID int,
PizzaID int
);

