-- --------------------------------------------------------------------------------
-- Name: <Your name>
-- Class: SQL #1
-- Abstract: Homework 1
-- --------------------------------------------------------------------------------

-- --------------------------------------------------------------------------------
-- Options
-- --------------------------------------------------------------------------------
SET NOCOUNT ON
USE dbSQL1

-- --------------------------------------------------------------------------------
-- Step #1: Create Tables
-- --------------------------------------------------------------------------------
DROP TABLE TEmployeeParkingSpots
DROP TABLE TEmployees
DROP TABLE TParkingSpots


CREATE TABLE TEmployees
(
	 intEmployeeID		INTEGER			NOT NULL
	,strFirstName		VARCHAR(50)		NOT NULL
	,strMiddleName		VARCHAR(50)		NOT NULL
	,strLastName		VARCHAR(50)		NOT NULL
	,dtmDateOfHire		DATETIME		NOT NULL
	,strPosition		VARCHAR(50)		NOT NULL

	,CONSTRAINT TEmployees_PK PRIMARY KEY ( intEmployeeID )
)

CREATE TABLE TParkingSpots
(
	 intParkingSpotID	INTEGER			NOT NULL
	,strParkingSpot		VARCHAR(50)		NOT NULL

	,CONSTRAINT TParkingSpots_PK PRIMARY KEY ( intParkingSpotID )
)

CREATE TABLE TEmployeeParkingSpots
(
	 intEmployeeID		INTEGER			NOT NULL
	,intParkingSpotID	INTEGER			NOT NULL

	,CONSTRAINT TEmployeeParkingSpots_PK PRIMARY KEY (intEmployeeID, intParkingSpotID)
	,CONSTRAINT TEmployeeParkingSpots_intParkingSpotID_UN UNIQUE (intParkingSpotID)
)




-- --------------------------------------------------------------------------------
-- Step #2: Create Foreign Keys
-- --------------------------------------------------------------------------------
ALTER TABLE TEmployeeParkingSpots ADD CONSTRAINT TEmployeeParkingSpots_TEmployees_FK
	FOREIGN KEY ( intEmployeeID ) REFERENCES TEmployees( intEmployeeID )

ALTER TABLE TEmployeeParkingSpots ADD CONSTRAINT TEmployeeParkingSpots_TParkingSpots_FK
	FOREIGN KEY (intParkingSpotID ) REFERENCES TParkingSpots( intParkingSpotID )



-- --------------------------------------------------------------------------------
-- Step #3: 
-- --------------------------------------------------------------------------------
INSERT INTO TEmployees( intEmployeeID, strFirstName, strMiddleName, strLastName, dtmDateOfHire, strPosition )
VALUES( '1', 'Samuel', 'J', 'Adams', '2007/05/11', 'Project Manager' )

INSERT INTO TEmployees( intEmployeeID, strFirstName, strMiddleName, strLastName, dtmDateOfHire, strPosition )
VALUES( '2', 'Stella', 'Marie', 'Baily', '2009/03/15', 'DBA' )

INSERT INTO TEmployees( intEmployeeID, strFirstName, strMiddleName, strLastName, dtmDateOfHire, strPosition )
VALUES( '3', 'James', 'Earl', 'Jones', '2010/09/21', 'Programmer' )

INSERT INTO TEmployees( intEmployeeID, strFirstName, strMiddleName, strLastName, dtmDateOfHire, strPosition )
VALUES( '4', 'John', 'Q', 'Smith', '2011/07/17', 'Programmer' )

INSERT INTO TEmployees( intEmployeeID, strFirstName, strMiddleName, strLastName, dtmDateOfHire, strPosition )
VALUES( '5', 'Jim', 'Bob', 'Wilson', '2005/01/01', 'President' )



-- --------------------------------------------------------------------------------
-- Step #6: Assign 2 parkings spots to 1 employee
-- --------------------------------------------------------------------------------
INSERT INTO TEmployeeParkingSpots ( intEmployeeID, intParkingSpotID )
VALUES ( 1, 6 )





-- --------------------------------------------------------------------------------
-- Step #7: Assign the same parking spot to 3 different employees
-- --------------------------------------------------------------------------------
INSERT INTO TEmployeeParkingSpots ( intEmployeeID, intParkingSpotID )
VALUES ( 2, 6 )




-- --------------------------------------------------------------------------------
-- Step #9: 
-- --------------------------------------------------------------------------------
DELETE FROM TEmployeeParkingSpots
Where
	intEmployeeID = 6

DELETE FROM TEmployees
where
	intEmployeeID = 6

-- --------------------------------------------------------------------------------
-- Step #10: 
-- --------------------------------------------------------------------------------
INSERT INTO TEmployeeParkingSpots (intEmployeeID , intParkingSpotID)
VALUES ( 6, 5)

-- --------------------------------------------------------------------------------
-- Step #18: 
-- --------------------------------------------------------------------------------

UPDATE TEmployees
SET
	intEmployeeID = intEmployeeID + 1

UPDATE TEmployeeParkingSpots
SET
	intEmployeeID = intEmployeeID + 1


--lesson is













