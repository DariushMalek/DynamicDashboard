declare @UserId nvarchar(450), @RoleId nvarchar(450)
select top 1 @UserId = UR.UserId, @RoleId = R.Id
from dbo.AspNetUserRoles UR
inner join dbo.AspNetRoles R on R.Id = UR.RoleId
where R.Name = 'Admin'

insert into dbo.MenuMaster (MenuName, MenuTitle, RoleId, ParentMenuId, Controller, Action, CreateDate, UserId, Priority)
select 'Home', N'', @RoleId, null, 'Home', 'GoHome', GETDATE(), @UserId, 1
