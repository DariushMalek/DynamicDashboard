CREATE SEQUENCE dbo.MenuSeqId  
    START WITH 100  
    INCREMENT BY 1;

create table dbo.MenuMaster
(
	Id int not null default (next value for dbo.MenuSeqId ),
	MenuTitle nvarchar(50) not null,

)