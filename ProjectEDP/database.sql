CREATE TABLE [dbo].[Admin]
(
	[adminID] INT NOT NULL PRIMARY KEY, 
    [adminName] NVARCHAR(50) NULL UNIQUE, 
    [password] VARCHAR(255),

);

CREATE TABLE [dbo].[Customer]
(
	[customerID] INT NOT NULL PRIMARY KEY, 
    [custName] VARCHAR(80) NULL, 
    [custEmail] VARCHAR(50) UNIQUE NULL, 
    [password] VARCHAR(255) NULL, 
    [contactNo] INT NULL
);

CREATE TABLE [dbo].[Order]
(
	[orderID] INT NOT NULL PRIMARY KEY,
	[customerID] INT NOT NULL, 
    CONSTRAINT [FK_Order_Customer] FOREIGN KEY ([customerID]) REFERENCES [Customer]([customerID]),

	[date] DATE,
	[time_slot] VARCHAR(50),
	[pickup_location] TEXT,


);

CREATE TABLE [dbo].[Pricing_Catalog]
(
	[itemID ] VARCHAR(10) NOT NULL PRIMARY KEY, 
    [itemName] VARCHAR(100) NULL, 
    [charge_type] VARBINARY(20) NULL, 
    [unit_price] DECIMAL(10, 2) NULL
);

CREATE TABLE [dbo].[Payment]
(
	[paymentID] INT NOT NULL PRIMARY KEY, 
	[orderID] INT NOT NULL, 
	CONSTRAINT [FK_Payment_Order] FOREIGN KEY ([orderID]) REFERENCES [Order]([orderID]),
	
	[payment_method] VARCHAR(30) NULL, 
	[payment_date] DATE NULL, 
	[amount_paid] DECIMAL(10, 2) NULL
)






