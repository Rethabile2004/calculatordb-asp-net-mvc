Click here to watch the video demo on youtube: [![Watch the Video](https://img.shields.io/badge/YouTube-Watch%20Video-red?style=for-the-badge&logo=youtube&logoColor=white)](https://youtu.be/HDpnD1Cw9tQ?si=4Jex6abS5IgYaDPG)

# CalculatorAppDB

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity_Framework_Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQLite](https://img.shields.io/badge/SQLite-003B57?style=for-the-badge&logo=sqlite&logoColor=white)

**CalculatorAppDB** is a web-based calculator management system built using **ASP.NET Core MVC** and **Entity Framework Core**.  
The application allows users to manage a database of calculators by performing **Create**, **Read**, **Update**, and **Delete (CRUD)** operations.

---

## Features

- **Add**, **edit**, **view**, and **delete** calculator records  
- **Custom validation** for calculator functions using `VerifyFunctionsAttribute`  
- **Repository pattern** for clean, maintainable architecture  
- **SQLite database** integration with automatic seeding  
- **Data annotations** for model validation and display formatting  
- Built using **dependency injection** for modularity  

---

## Getting Started

### Prerequisites
- Visual Studio 2022 (or newer)  
- .NET 8 SDK installed  

### Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Rethabile2004/calculatorDb-ASP.NET-MVC.git
   cd calculatorDb-ASP.NET-MVC


2. **Open the project in Visual Studio.**
3. **Build the solution.**
4. **Run the application (F5).**
The app will launch in your browser at a local port, e.g. `https://localhost:7241/`.

---

## Database Setup

The project uses **SQLite** for data storage.

To create and seed the database:

1. Run the application.
2. Navigate to `/Home/SeedDatabase` in your browser.
3. The system will create and populate the database automatically.

---

## Validation

Validation is handled through a custom attribute:

`VerifyFunctionsAttribute` – ensures only approved function values are allowed (e.g., 240, 300, 315, 400, 417, 422, 552, 605, 640).

This maintains **data integrity** and provides **clear feedback** to the user.

---

## Built With

* C# (.NET 8) [(learn.microsoft.com)](https://learn.microsoft.com/en-us/dotnet/csharp/)
* ASP.NET Core MVC [(learn.microsoft.com)](https://learn.microsoft.com/en-us/aspnet/core/mvc/overview)
* Entity Framework Core [(learn.microsoft.com)](https://learn.microsoft.com/en-us/ef/core/)
* [SQLite](https://www.sqlite.org/index.html)
* Razor Pages [(learn.microsoft.com)](https://learn.microsoft.com/en-us/aspnet/core/razor-pages/)
* Dependency Injection

---

## Credit

[Rethabile Eric Siase](https://github.com/Rethabile2004/)

