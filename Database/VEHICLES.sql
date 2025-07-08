CREATE DATABASE ProjectOOP;
use ProjectOOP;

--CREATE TABLE [Cars]
CREATE TABLE Cars(
	numberPlate VARCHAR(20) NOT NULL PRIMARY KEY,
	vehicleBrand VARCHAR(50),
	vehicleModel VARCHAR(50),
	vehiclePrice Decimal(13,2) CHECK ( vehiclePrice > 0 ),
	numbOfPassenger INT NOT NULL
);


--CREATE TABLE [Truck]
CREATE TABLE Trucks(
	numberPlate VARCHAR(20) NOT NULL PRIMARY KEY,
	vehicleBrand VARCHAR(50),
	vehicleModel VARCHAR(50),
	vehiclePrice Decimal(13,2) CHECK ( vehiclePrice > 0 ),
	loadCapacity INT NOT NULL CHECK ( loadCapacity > 0 )
);

--View to get available car or truck
CREATE VIEW availableCarsView AS
SELECT Cars.numberPlate, Cars.vehicleBrand, Cars.vehicleModel
FROM Cars WHERE Cars.numberPlate NOT IN (
	SELECT VehRentCustPay.numberPlate 
	FROM VehRentCustPay 
);

CREATE VIEW availableTruckView AS
SELECT Trucks.numberPlate, Trucks.vehicleBrand, Trucks.vehicleModel
FROM Trucks WHERE Trucks.numberPlate NOT IN (
	SELECT VehRentCustPay.numberPlate 
	FROM VehRentCustPay
);

--Get specific columns for combo box
CREATE PROCEDURE Get_BrandModelCar

AS
BEGIN

	SELECT Cars.numberPlate, Cars.vehicleBrand, Cars.vehicleModel 
	FROM Cars 
	INNER JOIN VehRentCustPay
	ON Cars.numberPlate = VehRentCustPay.numberPlate
	INNER JOIN Rentals
	ON VehRentCustPay.rentalId = Rentals.rentalId

	WHERE ProjectOOP.dbo.Rentals.returnDate < GETDATE();
	

END;

CREATE PROCEDURE Get_BrandModelTruck
AS
BEGIN

	SELECT Trucks.numberPlate, Trucks.vehicleBrand, Trucks.vehicleModel 
	FROM Trucks
	INNER JOIN VehRentCustPay
	ON Trucks.numberPlate = VehRentCustPay.numberPlate
	INNER JOIN Rentals
	ON VehRentCustPay.rentalId =Rentals.rentalId

	WHERE returnDate < GETDATE();
	

END;


CREATE PROCEDURE Update_Car(
	@Brand VARCHAR(50),
	@Model VARCHAR(50),
	@Price DECIMAL (13,2),
	@NumbPlate VARCHAR(20),
	@NumbOfPassenger INT
)
AS
BEGIN
	
	UPDATE Cars
	SET 
	vehicleBrand = @Brand,
	vehicleModel = @Model,
	vehiclePrice = @Price,
	numbOfPassenger = @NumbOfPassenger
	WHERE numberPlate = @NumbPlate;

END;

--displaying [Cars]
CREATE PROCEDURE Get_Cars
AS
BEGIN
	
	SELECT * 
	FROM Cars;

END;


CREATE PROCEDURE Get_Trucks
AS
BEGIN
	
	SELECT * 
	FROM Trucks;

END;

CREATE PROCEDURE Update_Truck(
	@Brand VARCHAR(50),
	@Model VARCHAR(50),
	@Price DECIMAL(13,2),
	@NumbPlate VARCHAR(20),
	@LoadCapacity INT
)
AS
BEGIN
	
	UPDATE Trucks
	SET 
	vehicleBrand = @Brand,
	vehicleModel = @Model,
	vehiclePrice = @Price,
	loadCapacity = @LoadCapacity
	WHERE numberPlate = @NumbPlate;

END;


CREATE PROCEDURE Insert_Cars(
	@Brand VARCHAR(50),
	@Model VARCHAR(50),
	@Price DECIMAL(13,2),
	@NumbPlate VARCHAR(20),
	@NumbOfPassenger INT
)
AS
BEGIN
	
	INSERT INTO Cars 
	VALUES (
		@NumbPlate,
		@Brand,
		@Model,
		@Price,
		@NumbOfPassenger
	) ;

END;


CREATE PROCEDURE Insert_Trucks(
	@Brand VARCHAR(50),
	@Model VARCHAR(50),
	@Price DECIMAL(13,2),
	@NumbPlate VARCHAR(20),
	@LoadCapacity INT
)
AS
BEGIN

INSERT INTO Trucks 
	VALUES (
		@NumbPlate,
		@Brand,
		@Model,
		@Price,
		@LoadCapacity
	) ;

END;

Create Procedure Check_CarPlate(
@NumPlate VARCHAR(50)
)
AS BEGIN 
Select COUNT(Cars.numberPlate) AS count_ From Cars
Where Cars.numberPlate = @NumPlate;

END;

Create Procedure Check_TruckPlate(
@NumPlate VARCHAR(50)
)
AS BEGIN 
Select COUNT(Trucks.numberPlate) AS count_ From Trucks
Where Trucks.numberPlate = @NumPlate;

END;