
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/04/2019 06:13:32
-- Generated from EDMX file: C:\Users\LAXY\Documents\PoultryManager\PoultryManager\PoultryManager\PoultryModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PoultryManager];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Account]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Account];
GO
IF OBJECT_ID(N'[dbo].[Eggs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Eggs];
GO
IF OBJECT_ID(N'[dbo].[Expense]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Expense];
GO
IF OBJECT_ID(N'[dbo].[Feeding]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Feeding];
GO
IF OBJECT_ID(N'[dbo].[Sales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sales];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Accounts'
CREATE TABLE [dbo].[Accounts] (
    [UserID] int IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(30)  NOT NULL,
    [Password] nvarchar(30)  NOT NULL,
    [Username] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'Eggs'
CREATE TABLE [dbo].[Eggs] (
    [Date] datetime  NOT NULL,
    [CollectedEggs] int  NOT NULL,
    [GoodEggs] int  NULL,
    [BadEggs] int  NULL
);
GO

-- Creating table 'Feedings'
CREATE TABLE [dbo].[Feedings] (
    [Date] datetime  NOT NULL,
    [FeedName] nvarchar(50)  NOT NULL,
    [Quantity] int  NOT NULL,
    [Weight] float  NULL,
    [Comment] nvarchar(max)  NULL
);
GO

-- Creating table 'Sales'
CREATE TABLE [dbo].[Sales] (
    [Date] datetime  NOT NULL,
    [SoldItems] nvarchar(30)  NOT NULL,
    [Price] int  NOT NULL,
    [Qty] int  NOT NULL,
    [Comment] nvarchar(max)  NULL
);
GO

-- Creating table 'Expenses'
CREATE TABLE [dbo].[Expenses] (
    [Date] datetime  NOT NULL,
    [Category] nvarchar(50)  NULL,
    [ExpAmount] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserID] in table 'Accounts'
ALTER TABLE [dbo].[Accounts]
ADD CONSTRAINT [PK_Accounts]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- Creating primary key on [Date] in table 'Eggs'
ALTER TABLE [dbo].[Eggs]
ADD CONSTRAINT [PK_Eggs]
    PRIMARY KEY CLUSTERED ([Date] ASC);
GO

-- Creating primary key on [Date] in table 'Feedings'
ALTER TABLE [dbo].[Feedings]
ADD CONSTRAINT [PK_Feedings]
    PRIMARY KEY CLUSTERED ([Date] ASC);
GO

-- Creating primary key on [Date] in table 'Sales'
ALTER TABLE [dbo].[Sales]
ADD CONSTRAINT [PK_Sales]
    PRIMARY KEY CLUSTERED ([Date] ASC);
GO

-- Creating primary key on [Date] in table 'Expenses'
ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [PK_Expenses]
    PRIMARY KEY CLUSTERED ([Date] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------