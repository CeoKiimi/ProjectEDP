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