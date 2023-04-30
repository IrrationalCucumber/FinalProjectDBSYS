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

create table ARTWORKS
(
	artID int IDENTITY (1,1),
	userID int,
	artTitle varchar(50),
	artType varchar(30),
	artDescription text,
	artImage image,
	PRIMARY KEY (artID),
	--FOREIGN KEY (userID) references ACCOUNTS(userID)
)

create table COMMENTS
(
	commentID int IDENTITY (1,1),
	commentText text,
	userID int,
	artID int
)




drop table RECIPE

select * from BOOKMARK
