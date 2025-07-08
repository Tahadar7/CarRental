CREATE DATABASE ProjectOOP;
use ProjectOOP;

-- CREATE TABLE [Payments]
CREATE TABLE Payments (
    paymentId INT NOT NULL PRIMARY KEY,               
    cardNumber VARCHAR(50) NOT NULL,                    
    paymentAmount DECIMAL(18, 2) NOT NULL CHECK (paymentAmount > 0), 
    paymentStatus INT NOT NULL,                         
    customerId INT NOT NULL,                            
    rentalId INT NOT NULL,                              
    CONSTRAINT pay_fk1 FOREIGN KEY (customerId) REFERENCES Customers(customerId), 
    CONSTRAINT pay_fk2 FOREIGN KEY (rentalId) REFERENCES Rentals(rentalId)       
);

-- Get new payment id 
CREATE PROCEDURE GetNewPaymentID
AS 
BEGIN

	SELECT MAX(Payments.paymentId)+1 
	AS ID
	FROM Payments;

END;

--Procedure [Insert_Payments]
CREATE PROCEDURE Insert_Payments(
	@Id INT,
	@RentalId INT,
	@CustomerId INT,
	@PaymentStatus INT,
	@CardNumber VARCHAR(50),
	@PaymentAmount DECIMAL(18, 2)
)

AS
BEGIN
	
	INSERT INTO Payments 
	VALUES (
		@Id,
		@CardNumber,
		@PaymentAmount,
		@PaymentStatus,
		@CustomerId,
		@RentalId
	) ;

END;

CREATE PROCEDURE Update_Payments(
	@Id INT,
	@RentalId INT,
	@CustomerId INT,
	@PaymentStatus INT,
	@CardNumber VARCHAR(50),
	@PaymentAmount DECIMAL(18, 2)
)
AS
BEGIN
	
	UPDATE Payments 
	SET Payments.cardNumber = @CardNumber,
	Payments.paymentAmount = @PaymentAmount,
	Payments.paymentStatus = @PaymentStatus
	WHERE Payments.paymentId = @Id 

END;

