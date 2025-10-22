namespace CarRepairShop.Queries
{
    public static class TableQueries
    {
        private const string _usersTable = @"
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Users] (
        ID INT PRIMARY KEY IDENTITY(1,1),
        Name NVARCHAR(255) NOT NULL,
        Surname NVARCHAR(255) NOT NULL,
        Admin BIT NOT NULL DEFAULT 0
    );
END";

        private const string _credentialsTable = @"
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserCredentials]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[UserCredentials] (
        ID INT PRIMARY KEY IDENTITY(1,1),
        UserID INT NOT NULL FOREIGN KEY REFERENCES Users(ID),
        Login NVARCHAR(100) NOT NULL UNIQUE,
        PasswordHash NVARCHAR(255) NOT NULL
    );
END";

        private const string _contractorsTable = @"
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Contractors')
BEGIN
    CREATE TABLE [Contractors] (
        [ID] INT PRIMARY KEY IDENTITY(1,1),
        [Name] NVARCHAR(255) NOT NULL,
        [Surname] NVARCHAR(255) NOT NULL,
        [Email] NVARCHAR(255) NOT NULL,
        [PhoneNumber] NVARCHAR(255) NOT NULL
    );
END
";

        private const string _contractorsCarsTable = @"
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ContractorsCars')
BEGIN
    CREATE TABLE [ContractorsCars] (
        [ID] INT PRIMARY KEY IDENTITY(1,1),
        [ContractorID] INT NOT NULL,
        [BrandName] NVARCHAR(255) NOT NULL,
        [ModelName] NVARCHAR(255) NOT NULL,
        [VIN] INT NOT NULL,
        [Year] INT NOT NULL,
        [LicensePlate] NVARCHAR(255) NOT NULL,
        [FuelTypeID] INT NOT NULL,
        [EngineCapacity] FLOAT NOT NULL,
        [Mileage] INT NOT NULL
    );
END
";

        private const string _consumableMaterialsTable = @"
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConsumableMaterials]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[ConsumableMaterials] (
        ID INT PRIMARY KEY IDENTITY(1,1),
        Name NVARCHAR(255) NOT NULL,
        Quantity INT NOT NULL
    );
END";

        private const string _fuelTypes = @"
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FuelTypes]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[FuelTypes] (
        ID INT PRIMARY KEY IDENTITY(1,1),
        Name NVARCHAR(255) NOT NULL
    );
END";

        private const string _materialTypes = @"
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'MaterialTypes')
BEGIN
    CREATE TABLE [MaterialTypes] (
        [ID] INT PRIMARY KEY IDENTITY(1,1),
        [Name] NVARCHAR(255) NOT NULL
    );
END
";

        private const string _languages = @"
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Languages]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Languages] (
        ID INT PRIMARY KEY IDENTITY(1,1),
        Name NVARCHAR(255) NOT NULL,
        CultureCode NVARCHAR(255) NOT NULL
    );
END";

        private const string _languagesAdd = @"
SET IDENTITY_INSERT [dbo].[Languages] ON;

IF NOT EXISTS (SELECT 1 FROM [dbo].[Languages] WHERE ID = 1)
BEGIN
    INSERT INTO [dbo].[Languages] (ID, Name, CultureCode) VALUES (1, 'English', 'en-US');
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[Languages] WHERE ID = 2)
BEGIN
    INSERT INTO [dbo].[Languages] (ID, Name, CultureCode) VALUES (2, 'Polski', 'pl-PL');
END

SET IDENTITY_INSERT [dbo].[Languages] OFF;";


        private const string _permissionsTable = @"
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Permissions]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Permissions] (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        Name NVARCHAR(100) NOT NULL UNIQUE
    );
END";

        private const string _permissionsAdd = @"
IF NOT EXISTS (SELECT 1 FROM [dbo].[Permissions] WHERE [Name] = 'Contractors')
    INSERT INTO [dbo].[Permissions] ([Name]) VALUES ('Contractors');

IF NOT EXISTS (SELECT 1 FROM [dbo].[Permissions] WHERE [Name] = 'CRM')
    INSERT INTO [dbo].[Permissions] ([Name]) VALUES ('CRM');

IF NOT EXISTS (SELECT 1 FROM [dbo].[Permissions] WHERE [Name] = 'Services')
    INSERT INTO [dbo].[Permissions] ([Name]) VALUES ('Services');

IF NOT EXISTS (SELECT 1 FROM [dbo].[Permissions] WHERE [Name] = 'Warehouse')
    INSERT INTO [dbo].[Permissions] ([Name]) VALUES ('Warehouse');

IF NOT EXISTS (SELECT 1 FROM [dbo].[Permissions] WHERE [Name] = 'Statistics')
    INSERT INTO [dbo].[Permissions] ([Name]) VALUES ('Statistics');

IF NOT EXISTS (SELECT 1 FROM [dbo].[Permissions] WHERE [Name] = 'Users')
    INSERT INTO [dbo].[Permissions] ([Name]) VALUES ('Users');

IF NOT EXISTS (SELECT 1 FROM [dbo].[Permissions] WHERE [Name] = 'Settings')
    INSERT INTO [dbo].[Permissions] ([Name]) VALUES ('Settings');";

        private const string _userPermissionsTable = @"
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserPermissions]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[UserPermissions] (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        UserID INT NOT NULL,
        PermissionID INT NOT NULL,
        AllowDisplay BIT NOT NULL DEFAULT 0,
        AllowEdit BIT NOT NULL DEFAULT 0,
        CONSTRAINT FK_UserPermissions_Users FOREIGN KEY (UserID) REFERENCES dbo.Users(ID) ON DELETE CASCADE,
        CONSTRAINT FK_UserPermissions_Permissions FOREIGN KEY (PermissionID) REFERENCES dbo.Permissions(ID) ON DELETE CASCADE
    );
END";

        private const string _crmTable = @"
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='CRM_Task' AND xtype='U')
BEGIN
    CREATE TABLE [dbo].[CRM_Task] (
        [TaskID] INT IDENTITY(1,1) PRIMARY KEY,
        [MechanicID] INT NOT NULL,
        [ContractorID] INT NOT NULL,
        [CarID] INT NOT NULL,
        [Comment] NVARCHAR(MAX) NULL,
        [StartDate] DATETIME NOT NULL,
        [Completed] BIT NOT NULL,
        [EndDate] DATETIME NULL,
        [Price] FLOAT NOT NULL
    );
END
";

        private const string _crmMappingsTable = @"
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='CRM_Services' AND xtype='U')
BEGIN
    CREATE TABLE [dbo].[CRM_Services] (
        [ID] INT IDENTITY(1,1) PRIMARY KEY,
        [TaskID] INT NOT NULL,
        [ServiceID] INT NOT NULL,
        [Quantity] INT NOT NULL
    );
END
";

        private const string _servicesTable = @"
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Services')
BEGIN
    CREATE TABLE [Services] (
        [ID] INT PRIMARY KEY IDENTITY(1,1),
        [Name] NVARCHAR(255) NOT NULL,
        [Duration] FLOAT NOT NULL,
        [StandardCost] FLOAT NOT NULL,
        [WarrantyMonths] INT NOT NULL,
        [IsActive] BIT NOT NULL
    );
END
";

        private const string _demoUser = @"
IF NOT EXISTS (SELECT TOP 1 * FROM Users)
BEGIN
    SET IDENTITY_INSERT Users ON;
    
    INSERT INTO Users (ID, Name, Surname, Admin) VALUES (1, 'Demo', 'Account', 1);
    
    SET IDENTITY_INSERT Users OFF;
END
";

        private const string _demoCredentials = @"
IF NOT EXISTS (SELECT TOP 1 * FROM UserCredentials)
BEGIN
    SET IDENTITY_INSERT UserCredentials ON;

    INSERT INTO UserCredentials (ID, UserID, Login, PasswordHash) VALUES (1, 1, 'Demo', '$2b$10$pT43RFMjfN9tn2XIDB4I7eoqPx5d49oSMUj970KbkXz9QiOJOYzo2');

    SET IDENTITY_INSERT UserCredentials OFF;
END
";

        public static string GetTableChecksQuery()
        {
            var sb = new System.Text.StringBuilder();

            sb.AppendLine(_usersTable);
            sb.AppendLine();
            sb.AppendLine(_credentialsTable);
            sb.AppendLine();
            sb.AppendLine(_contractorsTable);
            sb.AppendLine();
            sb.AppendLine(_contractorsCarsTable);
            sb.AppendLine();
            sb.AppendLine(_consumableMaterialsTable);
            sb.AppendLine();
            sb.AppendLine(_fuelTypes);
            sb.AppendLine();
            sb.AppendLine(_materialTypes);
            sb.AppendLine();
            sb.AppendLine(_languages);
            sb.AppendLine();
            sb.AppendLine(_languagesAdd);
            sb.AppendLine();
            sb.AppendLine(_permissionsTable);
            sb.AppendLine();
            sb.AppendLine(_permissionsAdd);
            sb.AppendLine();
            sb.AppendLine(_userPermissionsTable);
            sb.AppendLine();
            sb.AppendLine(_crmTable);
            sb.AppendLine();
            sb.AppendLine(_crmMappingsTable);
            sb.AppendLine();
            sb.AppendLine(_servicesTable);
            sb.AppendLine();
            sb.AppendLine(_demoUser);
            sb.AppendLine();
            sb.AppendLine(_demoCredentials);

            return sb.ToString();
        }
    }
}