/****** Object:  Table [dbo].[Menu]    Script Date: 11/27/2014 11:31:19 ******/
SET IDENTITY_INSERT [dbo].[Menu] ON
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID]) VALUES (1, NULL, 'Home', 'Index', N'预算管理（公司）', N'预算管理', 1, NULL)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID]) VALUES (2, NULL, 'Home', 'Index', N'账号管理', N'账号管理', 2, NULL)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID]) VALUES (3, NULL, 'Home', 'Index', N'公司管理', N'公司管理', 3, NULL)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID]) VALUES (4, NULL, 'Home', 'Index', N'预算管理（集团）', N'预算管理', 4, NULL)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID]) VALUES (5, NULL, 'Home', 'Index', N'损益预算（公司）', N'损益预算', 1, 1)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID]) VALUES (6, NULL, 'Home', 'Index', N'账号信息', N'账号信息', 1, 2)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID]) VALUES (7, NULL, 'Home', 'Index', N'密码修改', N'密码修改', 2, 2)
INSERT [dbo].[Menu] ([ID], [Area], [Controller], [Action], [Name], [ShowName], [Order], [ParentMenuID]) VALUES (8, NULL, 'Home', 'Index', N'损益预算（集团）', N'损益预算', 1, 4)
SET IDENTITY_INSERT [dbo].[Menu] OFF


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
