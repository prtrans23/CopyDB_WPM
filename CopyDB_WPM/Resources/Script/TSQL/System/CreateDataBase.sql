IF NOT EXISTS (
    SELECT name
        FROM sys.databases
        WHERE name = N'{dbName}'
)
CREATE DATABASE {dbName}