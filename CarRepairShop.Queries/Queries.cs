namespace CarRepairShop.Queries
{
    public static class Queries
    {
        const string CreateUserTable = @"
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Users] (
        ID INT PRIMARY KEY IDENTITY(1,1),
        Name NVARCHAR(255) NOT NULL,
        Surname NVARCHAR(255) NOT NULL,
        Admin BIT NOT NULL DEFAULT 0
    );
END";

        const string CreateCredentialsTable = @"
CREATE TABLE UserCredentials (
    ID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL FOREIGN KEY REFERENCES Users(ID),
    Login NVARCHAR(100) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL);";

        const string CreateWorkshopTable = @"
CREATE TABLE ConsumableMaterials (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Quantity INT NOT NULL);";

        const string FuelTypes = @"CREATE TABLE FuelTypes (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL);";

        const string Languages = @"
CREATE TABLE Languages (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    CultureCode NVARCHAR(255) NOT NULL);";

        const string AddLanguages = @"
SET IDENTITY_INSERT Languages ON;

INSERT INTO Languages (ID, Name, CultureCode) VALUES (1, 'English', 'en-US');
INSERT INTO Languages (ID, Name, CultureCode) VALUES (2, 'Polski', 'pl-PL');

SET IDENTITY_INSERT Languages OFF;";

        const string DefaultSettings = @"
CREATE TABLE DefaultSettings (
    ID INT PRIMARY KEY IDENTITY(1,1),
    PasswordHash NVARCHAR(255) NOT NULL);";

        const string InsertDefaultSettings = @"
SET IDENTITY_INSERT DefaultSettings ON;

INSERT INTO DefaultSettings (ID, PasswordHash) VALUES (1, '$2b$10$xsvHerooVxU4SRVW0WjipuFweipWo4mh9lAiuG6.azcx3ebUhlZ96');

SET IDENTITY_INSERT DefaultSettings OFF;";

        const string CreatePermissionsTable = @"
CREATE TABLE [dbo].[Permissions] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(100) NOT NULL UNIQUE
);";

        const string AddPermissions = @"
INSERT INTO [dbo].[Permissions] ([Name]) VALUES 
('Contractors'),
('CRM'),
('Services'),
('Warehouse'),
('Statistics'),
('Users'),
('Settings');";

        const string CreateUserPermissionsTable = @"
CREATE TABLE [dbo].[UserPermissions] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY,
    [UserID] INT NOT NULL,
    [PermissionID] INT NOT NULL,
    [AllowDisplay] BIT NOT NULL DEFAULT 0,
    [AllowEdit] BIT NOT NULL DEFAULT 0,
    CONSTRAINT FK_UserPermissions_Users FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users]([ID]) ON DELETE CASCADE,
    CONSTRAINT FK_UserPermissions_Permissions FOREIGN KEY ([PermissionID]) REFERENCES [dbo].[Permissions]([ID]) ON DELETE CASCADE
);";

        const string CreateCRMTable = @"
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

        const string CreateCRMMappingsTable = @"
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
    }
}
