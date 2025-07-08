CREATE DATABASE ProjectOOP;
use ProjectOOP;


--CREATING TABLE [Rental]
CREATE TABLE Rentals(
	rentalId INT NOT NULL PRIMARY KEY,
	rentalDate Date NOT NULL,
	returnDate Date NOT NULL
);

--creating junction table 
CREATE TABLE VehRentCustPay(
	customerId INT NOT NULL,
	rentalId INT NOT NULL,
	paymentId INT NOT NULL,
	rentStatus INT NOT NULL,
	numberPlate VARCHAR(20)

	CONSTRAINT vrcp_fk1 FOREIGN KEY(customerId) REFERENCES Customers(customerId),
	CONSTRAINT vrcp_fk2 FOREIGN KEY(rentalId) REFERENCES Rentals(rentalId),
	CONSTRAINT vrcp_fk3 FOREIGN KEY(paymentId) REFERENCES Payments(paymentId)
);

-- Inserting one row into the VehRentCustPay table
INSERT INTO VehRentCustPay (customerId, rentalId, paymentId, rentStatus, numberPlate)
VALUES (1, 500, 1000, 0, 'ABC123');

--Get next rental id
CREATE PROCEDURE GetNewRentalID
AS 
BEGIN

	SELECT MAX(Rentals.rentalId)+1 
	AS ID
	FROM Rentals;

END;

CREATE PROCEDURE Get_FullRentalData
AS
BEGIN
	
	SELECT VehRentCustPay.customerId,  .VehRentCustPay.rentalId,
	VehRentCustPay.paymentId,
	Customers.customerName, Rentals.rentalDate, 
	Rentals.returnDate,
	Payments.paymentAmount, Payments.paymentStatus
	FROM VehRentCustPay 
	INNER JOIN Customers 
	ON VehRentCustPay.customerId = Customers.customerId 
	INNER JOIN ProjectOOP.dbo.Rentals 
	ON VehRentCustPay.rentalId = Rentals.rentalId
	INNER JOIN Payments
	ON VehRentCustPay.paymentId = Payments.paymentId;

END;


--UPDATE full data into junction table

CREATE PROCEDURE Update_FullRentalsData(
	@RentalId INT, 
	@RentalDate Date,
	@ReturnDate Date,
	@CustomerID INT,
	@CustomerName VARCHAR(70),
	@VehicleNumbPlate VARCHAR(20),
	@PaymentId INT,
	@PaymentStatus INT,
	@CardNumber VARCHAR(50),
	@PaymentAmount Decimal(18,2),
	@RentStatus INT
)
AS
BEGIN
	
	UPDATE Rentals 
	SET Rentals.rentalDate = @RentalDate,
	Rentals.returnDate = @ReturnDate
	WHERE Rentals.rentalId = @RentalId;


	EXEC Update_Payments @PaymentId, @RentalId, @CustomerID, @PaymentStatus, @CardNumber, @PaymentAmount;

END;

--Insert full data into junction table

CREATE PROCEDURE Insert_FullRentalsData(
	@RentalId INT, 
	@RentalDate Date,
	@ReturnDate Date,
	@CustomerID INT,
	@CustomerName VARCHAR(70),
	@VehicleNumbPlate VARCHAR(20),
	@PaymentId INT,
	@PaymentStatus INT,
	@CardNumber VARCHAR(50),
	@PaymentAmount Decimal(18,2),
	@RentStatus INT
)
AS
BEGIN
	
	INSERT INTO Rentals 
	VALUES (
		@RentalId,
		@RentalDate,
		@ReturnDate
	) ;

	EXEC Insert_Payments @PaymentId, @RentalId, @CustomerID, @PaymentStatus, @CardNumber, @PaymentAmount;

	INSERT INTO VehRentCustPay 
	VALUES (
		@CustomerID,
		@RentalId,
		@PaymentId,
		@RentStatus,
		@VehicleNumbPlate
	);

END;


--Procedure [Insert_Rentals]
CREATE PROCEDURE Insert_Rentals(
	@Id INT, 
	@RentalDate Date,
	@ReturnDate Date
)
AS
BEGIN
	
	INSERT INTO Rentals 
	VALUES (
		@Id,
		@RentalDate,
		@ReturnDate
	) ;
	
END;

--displaying [Rentals]
CREATE PROCEDURE Get_Rentals
AS
BEGIN
	
	SELECT * 
	FROM Rentals;

END;


