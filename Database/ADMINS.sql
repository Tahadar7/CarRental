CREATE DATABASE ProjectOOP;
use ProjectOOP;

--CREATING  TABLE [ADMINS]

CREATE TABLE Admins(
	username VARCHAR(11) NOT NULL PRIMARY KEY,
	passwd VARCHAR(80) NOT NULL,
	name_ VARCHAR(40) NOT NULL,
	email VARCHAR(40) NOT NULL,
	address_ VARCHAR(100) NOT NULL,
	cell VARCHAR(15),
	activeStatus INT DEFAULT 0,
);


--Handling sign up
CREATE PROCEDURE HandleSignUp(
	@Username VARCHAR(11),
	@Passwd VARCHAR(80),
	@Name_ VARCHAR(40),
	@Email VARCHAR(40),
	@Address_ VARCHAR(100),
	@Cell VARCHAR(15)
)
AS
BEGIN
	INSERT INTO Admins
	VALUES(
		@Username, @Passwd,
		@Name_, @Email,
		@Address_, @Cell,
		0
	);
END;


--Handle Login
CREATE PROCEDURE HandleLogin(
	@Username VARCHAR(11),
	@Passwd VARCHAR(80)
)
AS
BEGIN

	SELECT name_, username, cell, address_, email 
	FROM Admins
	WHERE 
	Admins.username = @Username
	AND Admins.Passwd = @Passwd
	AND Admins.activeStatus = 1;
	
END;

--Get un approved admin
CREATE PROCEDURE Get_UnAppAdmin
AS
BEGIN
	
	SELECT Admins.username,
	Admins.name_, 
	Admins.email, 
	Admins.address_, 
	Admins.cell
	FROM ProjectOOP.dbo.Admins
	WHERE  Admins.activeStatus = 0;

END;

--Aprove admin
CREATE PROCEDURE Approve_Admin
(
	@Username  VARCHAR(11)
)
AS 
BEGIN
	UPDATE Admins
	SET activeStatus = 1
	WHERE Admins.username = @Username;
END;


--Check Available Username

CREATE PROCEDURE Check_Username(
	@Username VARCHAR(11)
)
AS
BEGIN
	SELECT COUNT(Admins.username) AS US 
	FROM Admins 
	WHERE Admins.username = @Username ;
END;



--Update Admin Procedure

CREATE PROCEDURE Update_AdminData(
	@Username VARCHAR(11),
	@Passwd VARCHAR(80),
	@Name_ VARCHAR(40),
	@Email VARCHAR(40),
	@Address_ VARCHAR(100),
	@Cell VARCHAR(15)
)
AS
BEGIN
	UPDATE Admins 
	SET
		Admins.email = @Email,
		Admins.cell = @Cell,
		Admins.address_ = @Address_,
		Admins.passwd = @Passwd,
		Admins.name_ = @Name_
	WHERE username = @Username;

END;
