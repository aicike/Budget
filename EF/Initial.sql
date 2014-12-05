/****** Object:  Table [dbo].[Menu]    Script Date: 11/27/2014 11:31:19 ******/
SET IDENTITY_INSERT [dbo].[Menu] ON

--集团
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID],AccountType) VALUES (1, NULL, 'Company', 'Index', N'公司管理', N'公司管理', 1, NULL,0)

INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID],AccountType) VALUES (11, NULL, 'Home', 'Index', N'预算管理', N'预算管理', 2, NULL,0)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID],AccountType) VALUES (12, NULL, 'ProfitLoss', 'GroupIndex', N'损益预算', N'损益预算', 1, 11,0)

INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID],AccountType) VALUES (21, NULL, 'Home', 'Index', N'账号管理', N'账号管理', 3, NULL,0)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID],AccountType) VALUES (22, NULL, 'Home', 'Index', N'个人信息', N'个人信息', 1, 21,0)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID],AccountType) VALUES (23, NULL, 'Home', 'Index', N'修改密码', N'修改密码', 2, 21,0)

INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID],AccountType) VALUES (31, NULL, 'Home', 'Index', N'系统配置', N'系统配置', 4, NULL,0)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID],AccountType) VALUES (32, NULL, 'Role', 'Index', N'角色管理', N'角色管理', 1, 31,0)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID],AccountType) VALUES (33, NULL, 'GroupAccount', 'Index', N'集团人员管理', N'集团人员管理', 2, 31,0)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID],AccountType) VALUES (34, NULL, 'Coefficient', 'Index', N'预算系数管理', N'预算系数管理', 3, 31,0)

--公司
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID],AccountType) VALUES (101, NULL, 'Home', 'Index', N'预算管理', N'预算管理', 1, NULL,1)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID],AccountType) VALUES (102, NULL, 'ProfitLoss', 'Index', N'损益预算', N'损益预算', 1, 101,1)

INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID],AccountType) VALUES (111, NULL, 'Home', 'Index', N'账号管理', N'账号管理', 2, NULL,1)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID],AccountType) VALUES (112, NULL, 'Home', 'Index', N'个人信息', N'个人信息', 1, 111,1)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID],AccountType) VALUES (113, NULL, 'Home', 'Index', N'修改密码', N'修改密码', 2, 111,1)

SET IDENTITY_INSERT [dbo].[Menu] OFF

/****** Object:  Table [dbo].[MenuOption]    Script Date: 12/05/2014 12:46:05 ******/
SET IDENTITY_INSERT [dbo].[MenuOption] ON
INSERT [dbo].[MenuOption] ([MenuID], [Name], [Action], [Order]) VALUES (1, N'公司列表', N'Index', 1)
INSERT [dbo].[MenuOption] ([MenuID], [Name], [Action], [Order]) VALUES (1, N'创建公司', N'Add', 2)
INSERT [dbo].[MenuOption] ([MenuID], [Name], [Action], [Order]) VALUES (1, N'修改公司', N'Edit', 3)
INSERT [dbo].[MenuOption] ([MenuID], [Name], [Action], [Order]) VALUES (1, N'管理用户', N'CompanyAccount', 4)

INSERT [dbo].[MenuOption] ([MenuID], [Name], [Action], [Order]) VALUES (1, N'1', N'1', 1)
INSERT [dbo].[MenuOption] ([MenuID], [Name], [Action], [Order]) VALUES (1, N'1', N'1', 1)
INSERT [dbo].[MenuOption] ([MenuID], [Name], [Action], [Order]) VALUES (1, N'1', N'1', 1)
INSERT [dbo].[MenuOption] ([MenuID], [Name], [Action], [Order]) VALUES (1, N'1', N'1', 1)
INSERT [dbo].[MenuOption] ([MenuID], [Name], [Action], [Order]) VALUES (1, N'1', N'1', 1)
INSERT [dbo].[MenuOption] ([MenuID], [Name], [Action], [Order]) VALUES (1, N'1', N'1', 1)
INSERT [dbo].[MenuOption] ([MenuID], [Name], [Action], [Order]) VALUES (1, N'1', N'1', 1)
SET IDENTITY_INSERT [dbo].[MenuOption] OFF



/****** Object:  Table [dbo].[Group]    Script Date: 11/27/2014 14:40:46 ******/
SET IDENTITY_INSERT [dbo].[Group] ON
INSERT [dbo].[Group] ([ID], [Name]) VALUES (1, N'华夏汽贸')
SET IDENTITY_INSERT [dbo].[Group] OFF


/****** Object:  Table [dbo].[GroupAccount]    Script Date: 11/27/2014 14:40:46 ******/
SET IDENTITY_INSERT [dbo].[GroupAccount] ON
INSERT [dbo].[GroupAccount] ([ID], [GroupID], [AccountNumber], [AccountPwd], [Name], [Phone], [Email]) VALUES (1, 1, N'huaxia', N'm8YlpCH5g1U=', N'华夏', N'huaxia', N'huaxia')
SET IDENTITY_INSERT [dbo].[GroupAccount] OFF


/****** Object:  Table [dbo].[Company]    Script Date: 11/27/2014 14:40:46 ******/
SET IDENTITY_INSERT [dbo].[Company] ON
INSERT [dbo].[Company] ([ID], [GroupID], [Name]) VALUES (1, 1, N'福特')
INSERT [dbo].[Company] ([ID], [GroupID], [Name]) VALUES (2, 1, N'雪佛兰')
SET IDENTITY_INSERT [dbo].[Company] OFF


/****** Object:  Table [dbo].[CompanyAccount]    Script Date: 11/27/2014 14:40:46 ******/
SET IDENTITY_INSERT [dbo].[CompanyAccount] ON
INSERT [dbo].[CompanyAccount] ([ID], [CompanyID], [AccountNumber], [AccountPwd], [Name], [Phone], [Email]) VALUES (1, 1, N'fute', N'm8YlpCH5g1U=', N'福特', N'fute', N'fute')
INSERT [dbo].[CompanyAccount] ([ID], [CompanyID], [AccountNumber], [AccountPwd], [Name], [Phone], [Email]) VALUES (2, 2, N'xuefulan', N'm8YlpCH5g1U=', N'雪佛兰', N'xuefulan', N'xuefulan')
SET IDENTITY_INSERT [dbo].[CompanyAccount] OFF

/******----------------------------******/
SET IDENTITY_INSERT [dbo].[ParticularYear] ON
INSERT [dbo].[ParticularYear] ([ID], [Year]) VALUES (1, 2015)
SET IDENTITY_INSERT [dbo].[ParticularYear] OFF


/******----------------------------******/
SET IDENTITY_INSERT [dbo].[BudgetClass] ON
INSERT [dbo].[BudgetClass] ([ID], [Name],[CoefficientURL]) VALUES (1, '损益预算','/Coefficient/ProfitLoss_Coefficient')
SET IDENTITY_INSERT [dbo].[BudgetClass] OFF


/******----------------------------******/
SET IDENTITY_INSERT [dbo].[ProfitLoss_Coefficient] ON
INSERT [dbo].[ProfitLoss_Coefficient] ([ID], [CompanyID],[FenQiShuLiang],[XinBaoShuLiang],[XuBaoShuLiang],[GuaPaiShuLiang],[ErShouCheXiaoShouShuLiang],[ZhuYingShouRu_ZhengChe]
,[ZhuYingShouRu_ZhuangShiZhuangHuang],[ZhuYingShouRu_FenQi],[ZhuYingShouRu_XinBao],[ZhuYingShouRu_XuBao],[ZhuYingShouRu_GuaPai],[ZhuYingShouRu_ErShouChe],[ZhuYingChengBen_ZhengChe]
,[ZhuYingChengBen_WeiXiuPeiJian],[ZhuYingChengBen_ZhuangShiZhuangHuang]) VALUES (1, 1,0.16,0.88,0.3,0.35,0.01,10,0.025,0.33,0.068,0.058,0.085,0.1,0.986,0.8,0.6)
INSERT [dbo].[ProfitLoss_Coefficient] ([ID], [CompanyID],[FenQiShuLiang],[XinBaoShuLiang],[XuBaoShuLiang],[GuaPaiShuLiang],[ErShouCheXiaoShouShuLiang],[ZhuYingShouRu_ZhengChe]
,[ZhuYingShouRu_ZhuangShiZhuangHuang],[ZhuYingShouRu_FenQi],[ZhuYingShouRu_XinBao],[ZhuYingShouRu_XuBao],[ZhuYingShouRu_GuaPai],[ZhuYingShouRu_ErShouChe],[ZhuYingChengBen_ZhengChe]
,[ZhuYingChengBen_WeiXiuPeiJian],[ZhuYingChengBen_ZhuangShiZhuangHuang]) VALUES (2, 2,0.16,0.88,0.3,0.35,0.01,10,0.025,0.33,0.068,0.058,0.085,0.1,0.986,0.8,0.6)
SET IDENTITY_INSERT [dbo].[ProfitLoss_Coefficient] OFF
