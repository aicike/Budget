/****** Object:  Table [dbo].[Menu]    Script Date: 11/27/2014 11:31:19 ******/
SET IDENTITY_INSERT [dbo].[Menu] ON
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID]) VALUES (1, NULL, NULL, NULL, N'预算管理（公司）', N'预算管理', 1, NULL)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID]) VALUES (2, NULL, NULL, NULL, N'账号管理', N'账号管理', 2, NULL)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID]) VALUES (3, NULL, NULL, NULL, N'公司管理', N'公司管理', 3, NULL)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID]) VALUES (4, NULL, NULL, NULL, N'预算管理（集团）', N'预算管理', 4, NULL)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID]) VALUES (5, NULL, NULL, NULL, N'损益预算（公司）', N'损益预算', 1, 1)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID]) VALUES (6, NULL, NULL, NULL, N'账号信息', N'账号信息', 1, 2)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID]) VALUES (7, NULL, NULL, NULL, N'密码修改', N'密码修改', 2, 2)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID]) VALUES (8, NULL, NULL, NULL, N'公司管理', N'公司管理', 1, 3)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID]) VALUES (9, NULL, NULL, NULL, N'损益预算（集团）', N'损益预算', 1, 4)
SET IDENTITY_INSERT [dbo].[Menu] OFF
