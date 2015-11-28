-- --------------------------------------------------------------------------------
-- Name: Daniel Shepherd
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
DROP TABLE TFriends
CREATE TABLE TFriends
(
	 strFirstName	VARCHAR(50)
	,strLastName	VARCHAR(50)
	,strPhoneNumber	VARCHAR(50)
	,dtmDateOfBirth	DATETIME
	,strAddress		VARCHAR(100)
)



-- --------------------------------------------------------------------------------
-- Step #2: Insert statements
-- --------------------------------------------------------------------------------
INSERT INTO TFriends( strFirstName, strLastName )
VALUES( 'Aaron', 'Espelage' )

INSERT INTO TFriends( strFirstName, strLastName )
VALUES( 'Cameron', 'Oaks' )

INSERT INTO TFriends( strFirstName, strLastName )
VALUES( 'Ross', 'Castor' )

INSERT INTO TFriends( strFirstName, strLastName )
VALUES( 'Trob', 'Frank' )

INSERT INTO TFriends( strFirstName, strLastName )
VALUES( 'Ben', 'Sission' )



-- --------------------------------------------------------------------------------
-- Step #3: Select statements
-- --------------------------------------------------------------------------------
SELECT
	 strFirstName
FROM
	TFriends

SELECT
	 strFirstName
	 ,strLastName
FROM
	TFriends

SELECT
	  strFirstName
	 ,strLastName
	 ,strPhoneNumber
FROM
	TFriends

SELECT
	 strFirstName
	 ,strLastName
	 ,strPhoneNumber
	 ,dtmDateOfBirth
FROM
	TFriends

SELECT
	 strFirstName
	 ,strLastName
	 ,strPhoneNumber
	 ,dtmDateOfBirth
	 ,strAddress
FROM
	TFriends



-- --------------------------------------------------------------------------------
-- Step #4: Update statements
-- --------------------------------------------------------------------------------
UPDATE TFriends
SET
		strFirstName	= 'Trobert'
		,strLastName	= 'Frankfurt'
WHERE
		strFirstName = 'Trob'
	AND	strLastName = 'Frank'

UPDATE TFriends
SET
		strPhoneNumber	= '513-403-3310'
WHERE
		strFirstName = 'Aaron'
	AND	strLastName = 'Espelage'

UPDATE TFriends
SET
	 strPhoneNumber	= '513-382-0450'
	,strAddress	= 'Bridgetown'
WHERE
		strFirstName = 'Trobert'
	AND	strLastName = 'Frankfurt'

UPDATE TFriends
SET
	 strFirstName	= 'Feedback'
	,dtmDateOfBirth	= '01/01/1991'
WHERE
	strLastName = 'Sisson'

UPDATE TFriends
SET
	 strAddress	= 'Bridgetown'
	,strPhoneNumber	= '513-288-0503'
WHERE
		strFirstName = 'Ross'
	AND	strLastName = 'Castor'



-- --------------------------------------------------------------------------------
-- Step #5: Delete statements
-- --------------------------------------------------------------------------------
DELETE FROM TFriends
WHERE strFirstName = 'Aaron'

DELETE FROM TFriends
WHERE strLastName = 'Oaks'

DELETE FROM TFriends
WHERE strPhoneNumber = '513-382-0450'

DELETE FROM TFriends
WHERE strAddress = 'Bridgetown'
	AND	strLastName = 'Sisson'

DELETE FROM TFriends
WHERE	strFirstName	= 'Trobert'
	AND	strLastName		= 'Frankfurt'
