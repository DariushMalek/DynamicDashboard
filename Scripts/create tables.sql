CREATE SEQUENCE dbo.MenuSeqId  
    START WITH 100  
    INCREMENT BY 1;

create table dbo.MenuMaster
(
	Id int not null default (next value for dbo.MenuSeqId ),
	MenuTitle nvarchar(50) not null,
	UserRoleId int null,
	ParentMenuId int null,
	MenuURL nvarchar(100) null,
	MenuAction nvarchar(100) null,
	CreateDate datetime null,
	UserId int null
)