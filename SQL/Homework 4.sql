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
-- Step #1: 
-- --------------------------------------------------------------------------------

CREATE TABLE TTeams
(
	 intTeamID		INTEGER
	,strTeam		VARCHAR(50)
	,intPlayerID	INTEGER

	,CONSTRAINT TTeams_PK PRIMARY KEY ( intTeamID )
)


CREATE TABLE TPlayers
(
	 intPlayerID	INTEGER
	,strPlayer		VARCHAR(50)

	,CONSTRAINT TPlayers_PK PRIMARY KEY ( intPlayerID )
)

