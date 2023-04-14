CREATE TABLE [dbo].[ACCOUNTS]
(
	[userID] INT NOT NULL , 
    [username] VARCHAR(30) NOT NULL, 
    [password] VARCHAR(20) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [FirstName] VARCHAR(50) NULL, 
    [email] VARBINARY(50) NULL, 
    PRIMARY KEY ([username])
)
