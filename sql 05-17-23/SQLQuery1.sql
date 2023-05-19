use online_art_gallery_database_final

create table ACCOUNTS
(
	userID int IDENTITY (1, 1),
	username varchar(20) NOT NULL,
	password varchar(20) null,
	accountType varchar(10) null,
	accountVerified varchar(10) default 'unverified',
	dateAdded date null,
	LastName varchar(30) null,
	FirstName varchar(30) null,
	email varchar(50) null,
	contactNum int null,
	userBio text null,
	addressProvince varchar(30) null,
	addressCity varchar(30) null,
	addressBarangay varchar(30) null,
	addressStreet varchar(50) null,
	addressHome varchar(20) null,
	PRIMARY KEY (username)
)

create table ARTWORKS
(
	artID int IDENTITY (1,1),
	username varchar(20),
	artTitle varchar(50),
	artWidth int,
	artLength int,
	artPrice int,
	artType varchar(30),
	artDescription text,
	artImage image,
	artAvailable varchar(10),
	artVerified varchar(10) DEFAULT 'unverified',
	dateAdded date,
	PRIMARY KEY (artID),
	FOREIGN KEY (username) references ACCOUNTS(username)
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

Drop table BOOKMARK
Drop table ARTWORKS
Drop table ACCOUNTS

select * from ACCOUNTS
select * from ARTWORKS

Delete from ACCOUNTS WHERE username = 'test'


insert into ACCOUNTS (username, password, accountType, accountVerified, dateAdded)
values('admin','admin','admin', 'verified' ,GETDATE())

--query for updating ARTWORK
UPDATE ARTWORKS 
SET artTitle = "",
artWidth = "",
artLength = "",
artPrice = "",
artDescription = "",
artType = "",
artAvailable = ""
WHERE artID =  AND username = ""

--query for updating ACCOUNT
