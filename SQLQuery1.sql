create database RECORDS

use RECORDS

create table ACCOUNTS
(
	userID int IDENTITY (1, 1),
	username varchar(20) NOT NULL,
	password varchar(20),
	LastName varchar(30),
	FirstName varchar(30),
	email varchar(50),
	accountType varchar(10),
	PRIMARY KEY (userID)
)

create table RECIPE
(
	recipeID int IDENTITY (1, 1) NOT NULL,
	recipeName varchar(50),
	recipeMainIngredient varchar(30),
	recipeIngredients varchar(MAX),
	recipeSteps varchar(MAX),
	recipeSteps2 varchar(max),
	recipeImage image,
	recipeType varchar(20),
	PRIMARY KEY (recipeID)
)

create table BOOKMARK
(
	bookmarkID int,
	userID int,
	recipeID int,
	primary key (bookmarkID),
	FOREIGN KEY (userID) REFERENCES ACCOUNTS(userID),
	FOREIGN KEY (recipeID) REFERENCES RECIPE(recipeID)
)

drop table ACCOUNTS

select * from ACCOUNTS
