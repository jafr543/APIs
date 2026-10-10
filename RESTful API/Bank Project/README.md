# Bank Backend

A RESTful banking backend built with C#, ASP.NET Core Web API, Entity Framework Core, and SQL Server. The project focuses on layered architecture, data validation, and core banking operations.

## Features

- People: Shared personal information used by clients and system users.
- Clients: Create, retrieve, and delete clients, with personal details linked through People.
- Users: Manage system users, their permissions, and active status.
- Accounts: Create and manage bank accounts. Balance changes are handled through transactions rather than a general account-update endpoint.
- Transactions: Deposit, withdraw, and transfer money between accounts.
- Entity Framework Core: Database access, LINQ queries, and asynchronous operations.
- Layered architecture: Separates API controllers, business logic, and data access.

## Architecture

API Controllers
      |
      v
Business Layer (BL)
      |
      v
Data Access Layer (DAL)
      |
      v
Entity Framework Core / DbContext
      |
      v
SQL Server
`People is shared by Clients and Users. When creating a client or user, the backend creates the associated person record and links it internally, so the UI does not need to provide a PersonId`.

## Main Technologies

- C#
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- REST APIs
- Dependency Injection
- Async/Await

## Getting Started

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Configure the SQL Server connection string in the application's configuration.
4. Ensure the database schema is available and matches the EF Core entities.
5. Set the API project as the startup project and run it.
6. Test the endpoints using Swagger or an API client, if enabled in the project.

> Note: Update the configuration and database setup instructions to match your local environment before running the project.

## Planned Next Steps

- Add JWT-based authentication and authorization.
- Build a user interface for interacting with the API.
