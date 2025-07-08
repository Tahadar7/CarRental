CREATE DATABASE ProjectOOP;
use ProjectOOP;

--CREATING TABLE [CUSTOMER]
CREATE TABLE Customers(
	customerId INT NOT NULL PRIMARY KEY,
	customerName VARCHAR(70) NOT NULL,
	customerAge INT NOT NULL CHECK ( customerAge >= 18 ),
	customerAddress VARCHAR(200),
	customerCell VARCHAR(20) NOT NULL,
	customerIsVip INT NOT NULL
);


--Procedure [Get next customer from table]
CREATE PROCEDURE GetNewCusId
AS
BEGIN
	
	SELECT MAX(Customers.customerId)+1 
	AS ID
	FROM Customers;

END;

--Procedure For [Insert values into customer table]
CREATE PROCEDURE Insert_Customer(
	@Id INT, 
	@Age INT, 
	@IsVip INT,
	@Cell VARCHAR(20),
	@Name VARCHAR(70), 
	@Address VARCHAR(200)
)
AS
BEGIN
	
	INSERT INTO Customers 
	VALUES (
		@Id,
		@Name,
		@Age,
		@Address,
		@Cell,
		@IsVip
	) ;

END;


--displaying [Customers]
CREATE PROCEDURE Get_Customers
AS
BEGIN
	
	SELECT * 
	FROM Customers;

END;


--Update customer data
CREATE PROCEDURE Update_Customer(
	@Id INT, 
	@Age INT, 
	@IsVip INT,
	@Cell VARCHAR(20),
	@Name VARCHAR(70), 
	@Address VARCHAR(200)
)
AS
BEGIN
	
	UPDATE Customers
	SET customerId = @Id,
	customerAge = @Age,
	customerIsVip = @IsVip,
	customerCell = @Cell,
	customerName = @Name,
	customerAddress = @Address
	WHERE customerId = @Id;

END;


--Check customer found or not

create PROCEDURE Check_Customer_ID(
	@Id INT 
)
AS
BEGIN
	
	SELECT COUNT(Customers.customerId) 
	AS count_ 
	FROM Customers 
	WHERE customerId = @Id ;

END;



CREATE PROCEDURE Check_CustomerName(
	@Id INT 
)
AS
BEGIN
	SELECT Customers.customerName 
	FROM Customers 
	WHERE customerId = @Id;

END;

