# MonitoringDashboard
MonitoringDashboard/
├── Controllers/
│   ├── ResultsController.cs
│   └── LogsController.cs
├── Models/
│   └── Result.cs
├── Services/
│   └── LogService.cs
├── Views/
│   ├── Shared/
│   │   └── _Layout.cshtml
│   ├── Results/
│   │   └── Index.cshtml
│   └── Logs/
│       └── Index.cshtml
├── wwwroot/
│   └── css/
│   └── js/
├── appsettings.json
├── Program.cs
├── Startup.cs (if using .NET 5)
└── README.md
# MonitoringDashboard

A responsive ASP.NET Core MVC dashboard using Bootstrap to:

- Display results from a SQL Server database
- Monitor and display log file entries

## Tech Stack

- ASP.NET Core MVC
- Bootstrap 5
- Entity Framework Core
- SQL Server
- Log file monitoring via File I/O

## Setup

1. Clone the repo
2. Update `appsettings.json` with your DB connection
3. Run `dotnet ef migrations add InitialCreate`
4. Run `dotnet ef database update`
5. Run the app: `dotnet run`

## License

MIT
