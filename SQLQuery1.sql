create database RECORDS

use RECORDS

create table ACCOUNTS
(
	userID int IDENTITY (1, 1),
	username varchar(20) NOT NULL,
	password varchar(20),
	accountType varchar(10),
	accountVerified varchar(10) default 'verified',
	dateAdded date,
	PRIMARY KEY (username)
)
create table USERDETAILS
(
	userID int IDENTITY (1,1),
	username varchar(20),
	LastName varchar(30),
	FirstName varchar(30),
	email varchar(50),
	contactNum int,
	addressProvince varchar(30),
	addressCity varchar(30),
	addressBarangay varchar(30),
	addressStreet varchar(50),
	addressHome varchar(20),
	
)

create table ARTWORKS
(
	artID int IDENTITY (1,1),
	username varchar(30),
	artTitle varchar(50),
	artWidth int,
	artHeight int,
	artPrice int,
	artType varchar(30),
	artDescription text,
	artImage image,
	artAvailable varchar(10),
	artVerified varchar(10) DEFAULT 'not verified',
	dateAdded date,
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
