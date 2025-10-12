# CalculatorAppDB

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

## Technologies Used

- **C# (.NET 8)**
- **ASP.NET Core MVC**
- **Entity Framework Core**
- **SQLite**
- **Razor Pages**
- **Dependency Injection**

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

## How to Run

1. Clone the repository:  
   ```bash
   git clone https://github.com/Rethabile2004/calculatorDb-ASP.NET-MVC.git


Open the project in Visual Studio 2022 (or newer).

Build the solution.

Press F5 to run the app.

The app will launch in your browser at a local port, e.g. https://localhost:7241/.

# Credit

[Rethabile Eric Siase](https://github.com/Rethabile2004/)
