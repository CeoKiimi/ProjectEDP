-- kalau blom ada database, xyh drop table la
DROP TABLE IF EXISTS [dbo].[Payment];
DROP TABLE IF EXISTS [dbo].[Order];
DROP TABLE IF EXISTS [dbo].[Reservation];
DROP TABLE IF EXISTS [dbo].[Pricing_Catalog];
DROP TABLE IF EXISTS [dbo].[Customer];
DROP TABLE IF EXISTS [dbo].[Admin];

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