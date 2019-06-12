declare @UserId nvarchar(450), @RoleId nvarchar(450)
select top 1 @UserId = UR.UserId, @RoleId = R.Id
from dbo.AspNetUserRoles UR
inner join dbo.AspNetRoles R on R.Id = UR.RoleId
where R.Name = 'Admin'

--insert into dbo.MenuMaster (MenuName, MenuTitle, RoleId, ParentMenuId, Controller, Action, CreateDate, UserId, Priority)
--select 'Home', N'', @RoleId, null, 'Home', 'GoHome', GETDATE(), @UserId, 1

INSERT [dbo].[MenuMaster] ([Id], [MenuName], [MenuTitle], [UserRole], [ParentMenuId], [Controller], [Action], [CreateDate], [UserId], [Priority], [IconName], [IsHeading], [MenuClassContent], [HtmlAfterTitle]) VALUES (102, N'Home', N'ÎÇהו', N'Admin', NULL, N'Home', N'GoHome', CAST(N'2019-06-09T15:19:18.980' AS DateTime), N'8b46df72-534c-410d-8170-445a0bdbd595', 1, N'icon-home', 0, N'class="start active open"', N'<span class="selected"></span>
        <span class="arrow open"></span>')
