
CREATE TABLE Orders
(
	ID nvarchar primary key NOT NULL,
	ProductID nvarchar NOT NULL, 
	CustomerID nvarchar NOT NULL
)
GO

CREATE TABLE Products (
    ProductsID int NOT NULL,
    Name nvarchar NOT NULL,
    Price double,
    PRIMARY KEY (ID),
    FOREIGN KEY (OrdersID) REFERENCES Orders(ID)
);
GO

CREATE TABLE Customers (
    CustomersID int NOT NULL,
    Firstname nvarchar NOT NULL,
    Lastname nvarchar NOT NULL,
	CardNumber nvarchar NOT NULL,
    PRIMARY KEY (ID),
    FOREIGN KEY (OrdersID) REFERENCES Orders(ID)
);
GO

INSERT INTO Orders ID
VALUES
    0001,
    0021,
    0031;