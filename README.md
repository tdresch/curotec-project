# curotec-project

This is a test project based on Curotec challenge.

# API

Curotec API is implemented in .NET 8 using controllers.
Its using EF Core migrations with the concept of Code First to publish and create the tables and any change required.
The database is hosted in Azure. To run the system locally, an exception must be created at the SQL Server Firewall, adding the client IP.

# UI

CurotecUI was generated with [Angular CLI] version 16.2.16.
It`s using FormModules to the components.
The services are using HttpClient to reach the .NET API.
