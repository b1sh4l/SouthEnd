USE [master]
GO
/****** Object:  Database [CoffeeShopManagementSystem]    Script Date: 8/24/2021 3:56:56 PM ******/
CREATE DATABASE [CoffeeShopManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CoffeeShopManagementSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CoffeeShopManagementSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CoffeeShopManagementSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CoffeeShopManagementSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CoffeeShopManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET QUERY_STORE = OFF
GO
USE [CoffeeShopManagementSystem]
GO
/****** Object:  Table [dbo].[blockedCustomerList]    Script Date: 8/24/2021 3:56:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[blockedCustomerList](
	[BlockId] [nchar](10) NOT NULL,
	[CustomerMobileNo] [nchar](30) NULL,
 CONSTRAINT [PK_blockedCustomerList] PRIMARY KEY CLUSTERED 
(
	[BlockId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[coldBeverage]    Script Date: 8/24/2021 3:56:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coldBeverage](
	[cBeverageId] [nchar](10) NOT NULL,
	[BeverageName] [nchar](20) NOT NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_coldBeverage] PRIMARY KEY CLUSTERED 
(
	[cBeverageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 8/24/2021 3:56:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[EmployeeId] [nchar](10) NOT NULL,
	[EmployeeName] [nchar](30) NOT NULL,
	[Job] [nchar](20) NOT NULL,
	[Salary] [float] NOT NULL,
	[JoiningDate] [date] NOT NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employeeColumnName]    Script Date: 8/24/2021 3:56:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employeeColumnName](
	[Id] [nchar](10) NULL,
	[ColumnName] [nchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employeeJob]    Script Date: 8/24/2021 3:56:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employeeJob](
	[Id] [nchar](10) NOT NULL,
	[JobName] [nchar](20) NOT NULL,
 CONSTRAINT [PK_employeeJob] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[food]    Script Date: 8/24/2021 3:56:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[food](
	[FoodID] [nchar](10) NOT NULL,
	[FoodName] [nchar](30) NOT NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED 
(
	[FoodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hotBeverage]    Script Date: 8/24/2021 3:56:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hotBeverage](
	[hBeverageId] [nchar](10) NOT NULL,
	[BeverageName] [nchar](20) NOT NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_hotBeverage] PRIMARY KEY CLUSTERED 
(
	[hBeverageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inventory]    Script Date: 8/24/2021 3:56:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventory](
	[ItemID] [nchar](10) NOT NULL,
	[ItemName] [nchar](30) NOT NULL,
	[UnitOfMeasure] [nchar](20) NOT NULL,
	[QuantityInStock] [float] NOT NULL,
	[UnitPrice] [float] NOT NULL,
	[LastRestockDate] [date] NOT NULL,
 CONSTRAINT [PK_inventory] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inventoryColumnList]    Script Date: 8/24/2021 3:56:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventoryColumnList](
	[Id] [nchar](10) NOT NULL,
	[ColumnName] [nchar](30) NOT NULL,
 CONSTRAINT [PK_inventoryColumnList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orderColumnName]    Script Date: 8/24/2021 3:56:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderColumnName](
	[Id] [nchar](10) NOT NULL,
	[ColumnName] [nchar](30) NOT NULL,
 CONSTRAINT [PK_orderColumnName] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orderManagement]    Script Date: 8/24/2021 3:56:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderManagement](
	[CustomerMobileNo] [nvarchar](50) NOT NULL,
	[OrderedItem] [nchar](100) NULL,
	[Qty] [nchar](30) NULL,
	[TotalPrice] [float] NULL,
	[OrderDate] [datetime] NULL,
 CONSTRAINT [PK_orderManagement] PRIMARY KEY CLUSTERED 
(
	[CustomerMobileNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[systemAdministration]    Script Date: 8/24/2021 3:56:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[systemAdministration](
	[Id] [nchar](10) NOT NULL,
	[EmployeeId] [nchar](10) NOT NULL,
	[UserName] [nchar](30) NOT NULL,
	[Password] [nchar](20) NOT NULL,
	[Role] [nchar](20) NOT NULL,
 CONSTRAINT [PK_systemAdminitration] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[blockedCustomerList] ([BlockId], [CustomerMobileNo]) VALUES (N'102031    ', N'01236547896                   ')
GO
INSERT [dbo].[coldBeverage] ([cBeverageId], [BeverageName], [Price]) VALUES (N'cb-001    ', N'Frozen Mocha        ', 255)
INSERT [dbo].[coldBeverage] ([cBeverageId], [BeverageName], [Price]) VALUES (N'cb-002    ', N'Flavoured Late      ', 300)
INSERT [dbo].[coldBeverage] ([cBeverageId], [BeverageName], [Price]) VALUES (N'cb-003    ', N'Flavoured Creme     ', 355)
INSERT [dbo].[coldBeverage] ([cBeverageId], [BeverageName], [Price]) VALUES (N'cb-004    ', N'Fruit Smoothies     ', 365)
INSERT [dbo].[coldBeverage] ([cBeverageId], [BeverageName], [Price]) VALUES (N'cb-005    ', N'Iced Tea            ', 260)
GO
INSERT [dbo].[employee] ([EmployeeId], [EmployeeName], [Job], [Salary], [JoiningDate]) VALUES (N'e-001     ', N'Michael Scott                 ', N'Manager             ', 20000, CAST(N'2020-01-01' AS Date))
INSERT [dbo].[employee] ([EmployeeId], [EmployeeName], [Job], [Salary], [JoiningDate]) VALUES (N'e-002     ', N'Jim Halpert                   ', N'Server              ', 15000, CAST(N'2020-01-03' AS Date))
INSERT [dbo].[employee] ([EmployeeId], [EmployeeName], [Job], [Salary], [JoiningDate]) VALUES (N'e-003     ', N'Pam Beesly                    ', N'Greeter             ', 15000, CAST(N'2020-01-03' AS Date))
INSERT [dbo].[employee] ([EmployeeId], [EmployeeName], [Job], [Salary], [JoiningDate]) VALUES (N'e-004     ', N'Ryan Howard                   ', N'Barista             ', 17000, CAST(N'2020-01-02' AS Date))
INSERT [dbo].[employee] ([EmployeeId], [EmployeeName], [Job], [Salary], [JoiningDate]) VALUES (N'e-005     ', N'Dwight Schrute                ', N'Kitchen Porter      ', 12000, CAST(N'2020-01-02' AS Date))
GO
INSERT [dbo].[employeeColumnName] ([Id], [ColumnName]) VALUES (N'ec-001    ', N'EmployeeId                    ')
INSERT [dbo].[employeeColumnName] ([Id], [ColumnName]) VALUES (N'ec-002    ', N'EmployeeName                  ')
INSERT [dbo].[employeeColumnName] ([Id], [ColumnName]) VALUES (N'ec-003    ', N'Job                           ')
INSERT [dbo].[employeeColumnName] ([Id], [ColumnName]) VALUES (N'ec-004    ', N'Salary                        ')
INSERT [dbo].[employeeColumnName] ([Id], [ColumnName]) VALUES (N'ec-005    ', N'JoiningDate                   ')
GO
INSERT [dbo].[employeeJob] ([Id], [JobName]) VALUES (N'ej-001    ', N'Manager             ')
INSERT [dbo].[employeeJob] ([Id], [JobName]) VALUES (N'ej-002    ', N'Server              ')
INSERT [dbo].[employeeJob] ([Id], [JobName]) VALUES (N'ej-003    ', N'Greeter             ')
INSERT [dbo].[employeeJob] ([Id], [JobName]) VALUES (N'ej-004    ', N'Barista             ')
INSERT [dbo].[employeeJob] ([Id], [JobName]) VALUES (N'ej-005    ', N'Kitchen Porter      ')
GO
INSERT [dbo].[food] ([FoodID], [FoodName], [Price]) VALUES (N'f-001     ', N'Chicken Sandwich              ', 250)
INSERT [dbo].[food] ([FoodID], [FoodName], [Price]) VALUES (N'f-002     ', N'Grilled Chicken Sandwich      ', 270)
INSERT [dbo].[food] ([FoodID], [FoodName], [Price]) VALUES (N'f-003     ', N'Grilled Cheese                ', 280)
INSERT [dbo].[food] ([FoodID], [FoodName], [Price]) VALUES (N'f-004     ', N'Chocolate Cake                ', 180)
INSERT [dbo].[food] ([FoodID], [FoodName], [Price]) VALUES (N'f-005     ', N'Blueberry Cheesecake          ', 375)
GO
INSERT [dbo].[hotBeverage] ([hBeverageId], [BeverageName], [Price]) VALUES (N'b-001     ', N'Espresso            ', 155)
INSERT [dbo].[hotBeverage] ([hBeverageId], [BeverageName], [Price]) VALUES (N'b-002     ', N'Tea                 ', 160)
INSERT [dbo].[hotBeverage] ([hBeverageId], [BeverageName], [Price]) VALUES (N'b-003     ', N'Americano           ', 250)
INSERT [dbo].[hotBeverage] ([hBeverageId], [BeverageName], [Price]) VALUES (N'b-004     ', N'Cappuccino          ', 300)
INSERT [dbo].[hotBeverage] ([hBeverageId], [BeverageName], [Price]) VALUES (N'b-005     ', N'Late                ', 300)
INSERT [dbo].[hotBeverage] ([hBeverageId], [BeverageName], [Price]) VALUES (N'b-006     ', N'Hot Chocolate       ', 320)
GO
INSERT [dbo].[inventory] ([ItemID], [ItemName], [UnitOfMeasure], [QuantityInStock], [UnitPrice], [LastRestockDate]) VALUES (N'i-001     ', N'Espresso Roasted Coffee       ', N'kg                  ', 22, 2760, CAST(N'2021-01-06' AS Date))
INSERT [dbo].[inventory] ([ItemID], [ItemName], [UnitOfMeasure], [QuantityInStock], [UnitPrice], [LastRestockDate]) VALUES (N'i-002     ', N'Brazil Ground Coffee          ', N'kg                  ', 26, 2640, CAST(N'2021-06-05' AS Date))
INSERT [dbo].[inventory] ([ItemID], [ItemName], [UnitOfMeasure], [QuantityInStock], [UnitPrice], [LastRestockDate]) VALUES (N'i-003     ', N'Instant Coffee Mix            ', N'kg                  ', 10, 5000, CAST(N'2021-06-06' AS Date))
INSERT [dbo].[inventory] ([ItemID], [ItemName], [UnitOfMeasure], [QuantityInStock], [UnitPrice], [LastRestockDate]) VALUES (N'i-004     ', N'Liquid Milk                   ', N'liter               ', 14, 75, CAST(N'2021-06-03' AS Date))
INSERT [dbo].[inventory] ([ItemID], [ItemName], [UnitOfMeasure], [QuantityInStock], [UnitPrice], [LastRestockDate]) VALUES (N'i-005     ', N'Milk Powder                   ', N'kg                  ', 16, 690, CAST(N'2021-06-10' AS Date))
INSERT [dbo].[inventory] ([ItemID], [ItemName], [UnitOfMeasure], [QuantityInStock], [UnitPrice], [LastRestockDate]) VALUES (N'i-006     ', N'Sugar                         ', N'kg                  ', 12, 145, CAST(N'2021-06-03' AS Date))
INSERT [dbo].[inventory] ([ItemID], [ItemName], [UnitOfMeasure], [QuantityInStock], [UnitPrice], [LastRestockDate]) VALUES (N'i-007     ', N'Grounded Chicken              ', N'kg                  ', 12, 145, CAST(N'2021-03-06' AS Date))
GO
INSERT [dbo].[inventoryColumnList] ([Id], [ColumnName]) VALUES (N'ic-001    ', N'ItemID                        ')
INSERT [dbo].[inventoryColumnList] ([Id], [ColumnName]) VALUES (N'ic-002    ', N'ItemName                      ')
INSERT [dbo].[inventoryColumnList] ([Id], [ColumnName]) VALUES (N'ic-003    ', N'UnitOfMeasure                 ')
INSERT [dbo].[inventoryColumnList] ([Id], [ColumnName]) VALUES (N'ic-004    ', N'QuantityInStock               ')
INSERT [dbo].[inventoryColumnList] ([Id], [ColumnName]) VALUES (N'ic-005    ', N'UnitPrice                     ')
INSERT [dbo].[inventoryColumnList] ([Id], [ColumnName]) VALUES (N'ic-006    ', N'LastRestockDate               ')
GO
INSERT [dbo].[orderColumnName] ([Id], [ColumnName]) VALUES (N'oc-001    ', N'CustomerMobileNo              ')
INSERT [dbo].[orderColumnName] ([Id], [ColumnName]) VALUES (N'oc-002    ', N'OrderedItem                   ')
INSERT [dbo].[orderColumnName] ([Id], [ColumnName]) VALUES (N'oc-003    ', N'Qty                           ')
INSERT [dbo].[orderColumnName] ([Id], [ColumnName]) VALUES (N'oc-004    ', N'TotalPrice                    ')
INSERT [dbo].[orderColumnName] ([Id], [ColumnName]) VALUES (N'oc-005    ', N'OrderDate                     ')
GO
INSERT [dbo].[orderManagement] ([CustomerMobileNo], [OrderedItem], [Qty], [TotalPrice], [OrderDate]) VALUES (N'01236547896', N'Espresso            ,Frozen Mocha        ,Chicken Sandwich                                          ', N'1,0,5                         ', 1405, CAST(N'2021-08-24T10:14:39.910' AS DateTime))
INSERT [dbo].[orderManagement] ([CustomerMobileNo], [OrderedItem], [Qty], [TotalPrice], [OrderDate]) VALUES (N'012365479654', N'Espresso            ,Flavoured Late      ,Grilled Cheese                                            ', N'1,2,2                         ', 1315, CAST(N'2021-08-24T15:26:14.837' AS DateTime))
INSERT [dbo].[orderManagement] ([CustomerMobileNo], [OrderedItem], [Qty], [TotalPrice], [OrderDate]) VALUES (N'01254789654', N'Americano           ,Fruit Smoothies     ,Chocolate Cake                                            ', N'1,3,6                         ', 2425, CAST(N'2021-08-24T08:29:59.367' AS DateTime))
INSERT [dbo].[orderManagement] ([CustomerMobileNo], [OrderedItem], [Qty], [TotalPrice], [OrderDate]) VALUES (N'014578965412', N'Espresso, Cappucino, Sandwich                                                                       ', N'1,3,0                         ', 150, CAST(N'2021-08-24T08:18:51.397' AS DateTime))
INSERT [dbo].[orderManagement] ([CustomerMobileNo], [OrderedItem], [Qty], [TotalPrice], [OrderDate]) VALUES (N'01458796541', N'Espresso            ,Flavoured Creme     ,Grilled Chicken Sandwich                                  ', N'2,3,2                         ', 1915, CAST(N'2021-08-24T08:29:04.593' AS DateTime))
INSERT [dbo].[orderManagement] ([CustomerMobileNo], [OrderedItem], [Qty], [TotalPrice], [OrderDate]) VALUES (N'017584563215', N'Espresso            ,Flavoured Creme     ,Chocolate Cake                                            ', N'3,3,4                         ', 2250, CAST(N'2021-08-24T14:05:55.513' AS DateTime))
INSERT [dbo].[orderManagement] ([CustomerMobileNo], [OrderedItem], [Qty], [TotalPrice], [OrderDate]) VALUES (N'01759456321', N'Tea                 ,Flavoured Creme     ,Chicken Sandwich                                          ', N'1,2,0                         ', 870, CAST(N'2021-08-24T08:19:25.870' AS DateTime))
GO
INSERT [dbo].[systemAdministration] ([Id], [EmployeeId], [UserName], [Password], [Role]) VALUES (N'adm-001   ', N'e-001     ', N'mscott                        ', N'mscott001           ', N'admin               ')
INSERT [dbo].[systemAdministration] ([Id], [EmployeeId], [UserName], [Password], [Role]) VALUES (N'adm-002   ', N'e-002     ', N'jhalpert                      ', N'jhal002             ', N'user                ')
INSERT [dbo].[systemAdministration] ([Id], [EmployeeId], [UserName], [Password], [Role]) VALUES (N'adm-003   ', N'e-003     ', N'pbeesly                       ', N'pam003              ', N'user                ')
INSERT [dbo].[systemAdministration] ([Id], [EmployeeId], [UserName], [Password], [Role]) VALUES (N'adm-004   ', N'e-004     ', N'rhoward                       ', N'ryan004             ', N'user                ')
INSERT [dbo].[systemAdministration] ([Id], [EmployeeId], [UserName], [Password], [Role]) VALUES (N'adm-005   ', N'e-005     ', N'dwights                       ', N'ds005               ', N'user                ')
GO
USE [master]
GO
ALTER DATABASE [CoffeeShopManagementSystem] SET  READ_WRITE 
GO
