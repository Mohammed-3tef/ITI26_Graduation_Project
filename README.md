# Mazeed+

[![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?logo=dotnet&logoColor=white)](https://learn.microsoft.com/aspnet/core)
[![Entity Framework Core](https://img.shields.io/badge/Entity%20Framework%20Core-8.0-68217A?logo=dotnet&logoColor=white)](https://learn.microsoft.com/ef/core/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-2022-CC2927?logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server)
[![License: MPL 2.0](https://img.shields.io/badge/License-MPL%202.0-3DA639.svg)](LICENSE)

> A full-stack e-commerce platform built during the ITI Summer Training 2026 Full Stack .NET track.

Mazeed+ gives shoppers a complete product discovery and checkout experience, while providing administrators with tools for catalog, order, discount, and sales management. The application is built as a layered ASP.NET Core solution with Entity Framework Core and SQL Server.

## Highlights

- Product catalog with categories, brands, item variants, photos, and search/filtering
- Shopping cart, wishlist, checkout, shipping details, and order history
- Paymob payment integration
- Discount and promo-code workflows
- Product reviews, rating summaries, and personalized home recommendations
- ASP.NET Core Identity authentication with Google sign-in support
- Email confirmation, password reset, and contact email templates
- Admin catalog, user, order, discount, and dashboard management
- Real-time user notifications through SignalR
- SQL Server persistence with Entity Framework Core migrations

## Technology Stack

| Area | Technologies |
| --- | --- |
| Web application | ASP.NET Core MVC, Razor Views, .NET 8 |
| Business layer | C#, dependency injection, AutoMapper, in-memory caching |
| Data layer | Entity Framework Core 8, SQL Server, repository/unit-of-work patterns |
| Authentication | ASP.NET Core Identity, Google OAuth |
| Payments | Paymob |
| Real-time updates | SignalR |
| Documentation | Draw.io ERD in [`docs/ERD.drawio`](docs/ERD.drawio) |

## Solution Structure

```text
src/
|-- Mazeed.PL/   Presentation layer: MVC controllers, views, static assets, startup
|-- Mazeed.BLL/  Business logic, services, view models, mappings, email templates
|-- Mazeed.DAL/  Entities, DbContext, repositories, seeders, migrations
`-- Mazeed.sln   Visual Studio solution
```

The project follows a presentation/business/data separation:

```text
Mazeed.PL -> Mazeed.BLL -> Mazeed.DAL -> SQL Server
```

## Prerequisites

- .NET 8 SDK
- SQL Server or an accessible SQL Server database
- Visual Studio 2022/2026 or VS Code with C# tooling
- Paymob credentials for payment flows
- SMTP credentials for email flows
- Google OAuth credentials if Google sign-in is enabled

Verify the SDK installation:

```bash
dotnet --version
```

## Getting Started

From the repository root:

```bash
cd src
dotnet restore Mazeed.sln
dotnet build Mazeed.sln
dotnet ef database update --project Mazeed.DAL --startup-project Mazeed.PL
dotnet run --project Mazeed.PL
```

The application will print its local HTTP and HTTPS URLs when it starts. Open the HTTPS URL in a browser.

For development, you can also open [`src/Mazeed.sln`](src/Mazeed.sln) in Visual Studio and run `Mazeed.PL` as the startup project.

## Configuration

Application configuration is read from `src/Mazeed.PL/appsettings.json` and the environment-specific settings file. Do not commit connection strings, API keys, OAuth secrets, SMTP passwords, or payment credentials.

For local development, use user secrets or environment variables. Example user-secret commands:

```bash
cd src/Mazeed.PL
dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=localhost;Database=Mazeed;Trusted_Connection=True;TrustServerCertificate=True"
dotnet user-secrets set "Authentication:Google:ClientId" "your-client-id"
dotnet user-secrets set "Authentication:Google:ClientSecret" "your-client-secret"
dotnet user-secrets set "Paymob:ApiKey" "your-paymob-api-key"
```

Configure the remaining `EmailSettings` and `Paymob` values through the same mechanism or through your deployment platform's secret store. Review the configuration files before sharing or deploying this repository, and rotate any credentials that may already have been exposed.

## Database Migrations

Create a migration after changing an entity or the database model:

```bash
dotnet ef migrations add <MigrationName> --project src/Mazeed.DAL --startup-project src/Mazeed.PL
```

Apply migrations:

```bash
dotnet ef database update --project src/Mazeed.DAL --startup-project src/Mazeed.PL
```

The database initializer and seeders live in `src/Mazeed.DAL/Database` and `src/Mazeed.DAL/Seeders`.

## API Areas

The MVC application also exposes API-oriented endpoints for authenticated operations, including:

- `/api/cart`
- `/api/discounts`
- `/api/notifications`
- `/api/reviews`
- `/api/wishlist`

The SignalR notification hub is available at `/hubs/notifications`.

## Development Notes

- Keep secrets in user secrets or deployment environment variables.
- Keep database changes in versioned EF Core migrations.
- Preserve the PL/BLL/DAL dependency direction when adding features.
- Update the ERD when the domain model changes.

## License

This project is distributed under the terms of the [Mozilla Public License 2.0](LICENSE).
