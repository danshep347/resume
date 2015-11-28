-- 

--------------------------------------------------------------------------------
-- Name: Daniel Shepherd
-- Class: SQL #1
-- Abstract: Homework 2
--------------------------------------------------------------------------------



--------------------------------------------------------------------------------
-- Options
--------------------------------------------------------------------------------
SET NOCOUNT ON
USE dbSQL1



--------------------------------------------------------------------------------
-- Step #1: Create Tables
--------------------------------------------------------------------------------
DROP TABLE TEmployees
DROP TABLE TParkingSpots
DROP TABLE TEmployeeParkingSpots

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



--------------------------------------------------------------------------------
-- Step #2: Insert statements for TEmployees
--------------------------------------------------------------------------------
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



--------------------------------------------------------------------------------
-- Step #3: Insert statements for TParkingSpots
--------------------------------------------------------------------------------
INSERT INTO TParkingSpots ( intParkingSpotID, strParkingSpot )
VALUES( 1, 'Level 1, Spot 1' )

INSERT INTO TParkingSpots ( intParkingSpotID, strParkingSpot )
VALUES( 2, 'Level 1, Spot 2' )

INSERT INTO TParkingSpots ( intParkingSpotID, strParkingSpot )
VALUES( 3, 'Level 1, Spot 3' )

INSERT INTO TParkingSpots ( intParkingSpotID, strParkingSpot )
VALUES( 4, 'Level 1, Spot 4' )

INSERT INTO TParkingSpots ( intParkingSpotID, strParkingSpot )
VALUES( 5, 'Level 1, Spot 5' )



INSERT INTO TParkingSpots ( intParkingSpotID, strParkingSpot )
VALUES( 6, 'Level 2, Spot 1' )

INSERT INTO TParkingSpots ( intParkingSpotID, strParkingSpot )
VALUES( 7, 'Level 2, Spot 2' )

INSERT INTO TParkingSpots ( intParkingSpotID, strParkingSpot )
VALUES( 8, 'Level 2, Spot 3' )

INSERT INTO TParkingSpots ( intParkingSpotID, strParkingSpot )
VALUES( 9, 'Level 2, Spot 4' )

INSERT INTO TParkingSpots ( intParkingSpotID, strParkingSpot )
VALUES( 10, 'Level 2, Spot 5' )



INSERT INTO TParkingSpots ( intParkingSpotID, strParkingSpot )
VALUES( 11, 'Level 3, Spot 1' )

INSERT INTO TParkingSpots ( intParkingSpotID, strParkingSpot )
VALUES( 12, 'Level 3, Spot 2' )

INSERT INTO TParkingSpots ( intParkingSpotID, strParkingSpot )
VALUES( 13, 'Level 3, Spot 3' )

INSERT INTO TParkingSpots ( intParkingSpotID, strParkingSpot )
VALUES( 14, 'Level 3, Spot 4' )

INSERT INTO TParkingSpots ( intParkingSpotID, strParkingSpot )
VALUES( 15, 'Level 3, Spot 5' )



--------------------------------------------------------------------------------
-- Step #4: Assign Parking Spots
--------------------------------------------------------------------------------
INSERT INTO TEmployeeParkingSpots ( intEmployeeID, intParkingSpotID )
VALUES ( 1, 1 )

INSERT INTO TEmployeeParkingSpots ( intEmployeeID, intParkingSpotID )
VALUES ( 2, 2 )

INSERT INTO TEmployeeParkingSpots ( intEmployeeID, intParkingSpotID )
VALUES ( 3, 3 )

INSERT INTO TEmployeeParkingSpots ( intEmployeeID, intParkingSpotID )
VALUES ( 4, 4 )

INSERT INTO TEmployeeParkingSpots ( intEmployeeID, intParkingSpotID )
VALUES ( 5, 5 )



--------------------------------------------------------------------------------
-- Step #5: Add Xavier to TEmployees
--------------------------------------------------------------------------------
INSERT INTO TEmployees( intEmployeeID, strFirstName, strMiddleName, strLastName, dtmDateOfHire, strPosition )
VALUES( '6', 'Cody', 'L', 'Xavier', '2012/09/01', 'Project Manager' )



--------------------------------------------------------------------------------
-- Step #6: Delete Wilson from TEmployees
--------------------------------------------------------------------------------
DELETE FROM TEmployees
WHERE
	intEmployeeID = 5



--------------------------------------------------------------------------------
-- Step #7: Give Xavier a parking spot on level 1
--------------------------------------------------------------------------------
UPDATE TEmployeeParkingSpots
SET
	intEmployeeID = 6
WHERE
	intEmployeeID = 5



--------------------------------------------------------------------------------
-- Step #8: Move the first 3 employees from level 1 to level 2
--------------------------------------------------------------------------------
UPDATE TEmployeeParkingSpots
SET
	intParkingSpotID = 6
WHERE
	intParkingSpotID = 1

UPDATE TEmployeeParkingSpots
SET
	intParkingSpotID = 7
WHERE
	intParkingSpotID = 2

UPDATE TEmployeeParkingSpots
SET
	intParkingSpotID = 8
WHERE
	intParkingSpotID = 3



--------------------------------------------------------------------------------
-- Step #9: Move remaining employees from level 1 to level 3
--------------------------------------------------------------------------------
UPDATE TEmployeeParkingSpots
SET
	intParkingSpotID = 11
WHERE
	intParkingSpotID = 4

UPDATE TEmployeeParkingSpots
SET
	intParkingSpotID = 12
WHERE
	intParkingSpotID = 5



--------------------------------------------------------------------------------
-- Step #10: Show all employees but the president
--------------------------------------------------------------------------------
SELECT
	*
FROM
	TEmployees
WHERE
	strPosition <> 'President'



--------------------------------------------------------------------------------
-- Step #11: Show all employees but the programmers or DBAs
--------------------------------------------------------------------------------
SELECT
	*
FROM
	TEmployees
WHERE
	strPosition <> 'Programmer'
AND strPosition <> 'DBA'



--------------------------------------------------------------------------------
-- Step #12: Middle name and date of hire for all employees
--------------------------------------------------------------------------------
SELECT
	 strMiddleName
	,dtmDateOfHire
	,CONVERT( VARCHAR, dtmDateOfHire, 111 ) As strDateOfHire
FROM
	TEmployees



--------------------------------------------------------------------------------
-- Step #13: Show all parking spots on level 1
--------------------------------------------------------------------------------
SELECT
	*
FROM
	TParkingSpots
WHERE
	strParkingSpot LIKE 'Level 1, %'



--------------------------------------------------------------------------------
-- Step #14: Show all parking spots that are either 2 or 4
--------------------------------------------------------------------------------
SELECT
	*
FROM
	TParkingSpots
WHERE
	strParkingSpot LIKE 'Level %, Spot 2'
OR	strParkingSpot LIKE 'Level %, Spot 4'

--------------------------------------------------------------------------------
-- Step #15: Delete Wilson from TEmployees
--------------------------------------------------------------------------------
UPDATE TEmployees
SET
	intEmployeeID = intEmployeeID + 1

UPDATE TEmployeeParkingSpots
SET
	intEmployeeID = intEmployeeID + 1



--------------------------------------------------------------------------------
-- Step #16: Lesson
--------------------------------------------------------------------------------

--The lesson learned is if you change the primary key in one table, you have to update all the records in the child tables and thats a pain.






