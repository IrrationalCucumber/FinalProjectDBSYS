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
	contactNum int,
	PRIMARY KEY (username)
)

create table ARTWORKS
(
	artID int IDENTITY (1,1),
	userID int,
	artTitle varchar(50),
	artWidth int,
	artHeight int,
	artPrice int,
	artType varchar(30),
	artDescription text,
	artImage image,
	PRIMARY KEY (artID),
	FOREIGN KEY (username) references ACCOUNTS(username)
)

create table COMMENTS
(
	commentID int IDENTITY (1,1),
	commentText text,
	userID int,
	artID int
)
create table TRANSACTION
(
	transactionID int IDENTITY (1,1)
	username varchar(30),
	artID int,
	FOREIGN KEY (artID)
)
drop table ACCOUNTS

select * from ACCOUNTS
