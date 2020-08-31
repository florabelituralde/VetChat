CREATE TABLE [UserInformation]
(
  [UserID]			int				NOT NULL,
  [Email]			nvarchar(50)	NOT NULL,
  [Username]		nvarchar(50)	NOT NULL,
  [Password]		nvarchar(50)	NOT NULL,
  [Firstname]		nvarchar(50)	NOT NULL,
  [Lastname]		nvarchar(50)	NOT NULL,
  [Contact]			int				NOT NULL,
  [Branch]			nvarchar(50)	NOT NULL,
  [DateOfEntry]		date			NOT NULL,
  [ETS]				date			NOT NULL,
  CONSTRAINT PK_UserID
  PRIMARY KEY ([UserID])
);

CREATE TABLE [GroupData] (
  [GroupID]			int				NOT NULL,
  [UserID]			int				NOT NULL,
  [GroupName]		nvarchar(50)	NOT NULL,
  [MembersCount]	int
  CONSTRAINT PK_GroupID
  PRIMARY KEY ([GroupID])
);

CREATE TABLE [AdminData] 
(
  [AdminID]			int		NOT NULL,
  [UserID]			int		NOT NULL,
  [GroupID]			int		NOT NULL,
  CONSTRAINT PK_AdminID
  PRIMARY KEY ([AdminID])
);

ALTER TABLE dbo.GroupData
	ADD CONSTRAINT FK_GroupData_UserID
	FOREIGN KEY(UserID)
	REFERENCES dbo.UserInformation(UserID)

ALTER TABLE dbo.AdminData
	ADD CONSTRAINT FK_AdminData_GroupID
	FOREIGN KEY(GroupID)
	REFERENCES dbo.GroupData(GroupID)

ALTER TABLE dbo.UserInformation
	ADD CONSTRAINT FK_UserInformation_AdminData
	FOREIGN KEY(UserID)
	REFERENCES dbo.AdminData(UserID)
