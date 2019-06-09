CREATE SEQUENCE dbo.MenuSeqId  
    START WITH 100  
    INCREMENT BY 1;

create table dbo.MenuMaster
(
	Id int not null default (next value for dbo.MenuSeqId ),
	MenuName nvarchar(50) not null,
	MenuTitle nvarchar(50) not null,
	UserRole nvarchar(50) null,
	ParentMenuId int null,
	Controller nvarchar(100) null,
	Action nvarchar(100) null,
	Priority smallint null,
	IconName nvarchar(100) null,
	IsHeading bit null,
	MenuClassContent nvarchar(100) null,
	HtmlAfterTitle  nvarchar(100) null,
	CreateDate datetime null,
	UserId nvarchar(100) null
)