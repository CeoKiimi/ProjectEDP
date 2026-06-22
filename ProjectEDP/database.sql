

CREATE TABLE [dbo].[Admin]
(
    [adminID] INT NOT NULL,
    [adminName] NVARCHAR(50) NOT NULL,
    [password] VARCHAR(255) NOT NULL,

    PRIMARY KEY CLUSTERED ([adminID] ASC),
    UNIQUE NONCLUSTERED ([adminName] ASC)
);

INSERT INTO [dbo].[Admin] ([adminID], [adminName], [password])
VALUES (1, 'ADMIN', '12345678');

CREATE TABLE [dbo].[Customer]
(
    [customerID] INT NOT NULL,
    [custName] VARCHAR(80) NULL,
    [custEmail] VARCHAR(50) NULL,
    [password] VARCHAR(255) NULL,
    [contactNo] VARCHAR(20) NULL,

    PRIMARY KEY CLUSTERED ([customerID] ASC),
    UNIQUE NONCLUSTERED ([custEmail] ASC)
);

CREATE TABLE [dbo].[Pricing_Catalog]
(
    [pricingID] INT IDENTITY(1,1) NOT NULL,
    [serviceName] NVARCHAR(100) NOT NULL,
    [price] DECIMAL(10,2) NOT NULL,

    PRIMARY KEY CLUSTERED ([pricingID] ASC),
    UNIQUE NONCLUSTERED ([serviceName] ASC)
);

INSERT INTO [dbo].[Pricing_Catalog] ([serviceName], [price])
VALUES 
('Pickup', 5.00),
('Delivery', 8.00),
('Specialty Laundry', 15.00);

CREATE TABLE [dbo].[Reservation]
(
    [reservationID] INT IDENTITY(1,1) NOT NULL,
    [customerID] INT NOT NULL,
    [serviceType] NVARCHAR(100) NOT NULL,
    [reservationDate] DATE NOT NULL,
    [timeSlot] NVARCHAR(50) NOT NULL,
    [paymentMethod] NVARCHAR(50) NOT NULL,
    [deliveryAddress] NVARCHAR(255) NULL,
    [specialtyDetails] NVARCHAR(255) NULL,
    [totalAmount] DECIMAL(10,2) NOT NULL DEFAULT 0,
    [status] NVARCHAR(50) NOT NULL DEFAULT 'Pending',
    [createdAt] DATETIME NOT NULL DEFAULT GETDATE(),

    PRIMARY KEY CLUSTERED ([reservationID] ASC)
);

CREATE TABLE [dbo].[Order]
(
    [orderID] INT IDENTITY(1,1) NOT NULL,
    [reservationID] INT NOT NULL,
    [customerID] INT NOT NULL,
    [orderStatus] NVARCHAR(50) NOT NULL DEFAULT 'Processing',
    [orderDate] DATETIME NOT NULL DEFAULT GETDATE(),
    [completedDate] DATETIME NULL,

    PRIMARY KEY CLUSTERED ([orderID] ASC)
);

CREATE TABLE [dbo].[Payment]
(
    [paymentID] INT IDENTITY(1,1) NOT NULL,
    [orderID] INT NOT NULL,
    [reservationID] INT NOT NULL,
    [customerID] INT NOT NULL,
    [paymentMethod] NVARCHAR(50) NOT NULL,
    [paymentStatus] NVARCHAR(50) NOT NULL DEFAULT 'Paid',
    [paymentDate] DATETIME NOT NULL DEFAULT GETDATE(),
    [amount] DECIMAL(10,2) NOT NULL DEFAULT 0,

    PRIMARY KEY CLUSTERED ([paymentID] ASC)
);
IF NOT EXISTS (SELECT 1 FROM Pricing_Catalog WHERE serviceName = 'Pickup')
BEGIN
    INSERT INTO Pricing_Catalog (serviceName, price)
    VALUES ('Pickup', 5.00);
END;

IF NOT EXISTS (SELECT 1 FROM Pricing_Catalog WHERE serviceName = 'Delivery')
BEGIN
    INSERT INTO Pricing_Catalog (serviceName, price)
    VALUES ('Delivery', 8.00);
END;

IF NOT EXISTS (SELECT 1 FROM Pricing_Catalog WHERE serviceName = 'Specialty Laundry')
BEGIN
    INSERT INTO Pricing_Catalog (serviceName, price)
    VALUES ('Specialty Laundry', 15.00);
END;

IF NOT EXISTS (SELECT 1 FROM Pricing_Catalog WHERE serviceName = 'Same Day Delivery')
BEGIN
    INSERT INTO Pricing_Catalog (serviceName, price)
    VALUES ('Same Day Delivery', 10.00);
END;

IF NOT EXISTS (SELECT 1 FROM Pricing_Catalog WHERE serviceName = 'Folding')
BEGIN
    INSERT INTO Pricing_Catalog (serviceName, price)
    VALUES ('Folding', 10.00);
END;

IF NOT EXISTS (SELECT 1 FROM Pricing_Catalog WHERE serviceName = 'Sensitive Skin Laundry Care')
BEGIN
    INSERT INTO Pricing_Catalog (serviceName, price)
    VALUES ('Sensitive Skin Laundry Care', 20.00);
END;

IF NOT EXISTS (SELECT 1 FROM Pricing_Catalog WHERE serviceName = 'Dry Cleaning')
BEGIN
    INSERT INTO Pricing_Catalog (serviceName, price)
    VALUES ('Dry Cleaning', 20.00);
END;