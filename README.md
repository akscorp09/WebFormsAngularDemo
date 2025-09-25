# WebForms + AngularJS + SQL Demo

This is a sample project demonstrating:

- ASP.NET Web Forms (.aspx)
- SQL Server connection via ADO.NET
- Exposing data via `[WebMethod]`
- AngularJS in client to fetch and display data

## Setup Steps

1. Create a SQL Server database (e.g. `MyDatabase`).
2. Create `Users` table:
   ```sql
   CREATE TABLE Users (
     Id INT IDENTITY(1,1) PRIMARY KEY,
     Name NVARCHAR(100),
     Email NVARCHAR(100)
   );

   INSERT INTO Users (Name, Email)
   VALUES ('Alice', 'alice@example.com'),
          ('Bob', 'bob@example.com');
