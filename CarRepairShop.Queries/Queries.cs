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
    }
}
