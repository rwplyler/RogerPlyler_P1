CREATE DATABASE Project1;
USE Project1;

CREATE TABLE ACustomer( 
ID int NOT NULL,
FName varChar(50),
LName varchar(50),
PRIMARY KEY (ID));

CREATE TABLE AStore( 
ID int NOT NULL,
StoreName varchar(50),
PRIMARY KEY (ID));

Create Table AnItem(
ID int Not Null,
ItemName varchar(50),
Price decimal(10,2),
Primary Key(ID));

Create Table InventoryDetail(
StoreID int,
ItemID int,
Amount int);

Create Table AOrder(
OrderID int,
StoreID int,
OrderTime DateTime,
Total Decimal(10,2),
Primary Key(OrderID));

Create Table AOrderDetail(
OrderID int,
ItemID int,
Total Decimal(10,2));