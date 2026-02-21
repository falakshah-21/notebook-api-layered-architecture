# 📒 Notebook API – Layered Architecture (ASP.NET Core)

A structured ASP.NET Core Web API built to practice clean architecture principles, dependency injection, Entity Framework Core, and asynchronous CRUD operations.

This project demonstrates how a real-world backend application is organized using service and repository layers.


## 🚀 Tech Stack

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server (LocalDB)
- Dependency Injection
- Async/Await
- Postman (API Testing)


## 🧱 Architecture

The project follows a layered architecture pattern:

Controller  
   ↓  
Service (Business Logic)  
   ↓  
Repository (Data Access)  
   ↓  
Database  

### Principles Applied

- Separation of Concerns  
- Interface-based contracts  
- Dependency Injection  
- Async database operations  
- Clean project structure  

Controllers are kept thin.  
Business logic is implemented inside Services.  
Database access logic is handled inside Repository layer.


## 📌 Features

- CRUD operations for Notebook entity
- Entity Framework Core integration
- Code-first migrations
- Asynchronous database operations
- Proper service abstraction


## 🗄 Database Configuration

This project uses **SQL Server LocalDB**.

Connection string:

```

Server=(localdb)\MSSQLLocalDB;Database=NotebookDb;Trusted_Connection=True;

```

- Uses Windows Authentication  
- No password required  
- Safe for local development  


## ▶️ How To Run This Project

Follow these steps to run this project on your system:

### 1️⃣ Clone the Repository

```

git clone [https://github.com/falakshah-21/notebook-api-layered-architecture.git]

```

Navigate into the folder:

```

cd notebook-api-layered-architecture

```

### 2️⃣ Open in Visual Studio

Make sure you have:
- .NET SDK installed
- SQL Server LocalDB available


### 3️⃣ Apply Database Migrations

Open **Package Manager Console** inside Visual Studio and run:

```

Update-Database

```

This will automatically create the database in LocalDB.


### 4️⃣ Run the Project


### 5️⃣ Test Using Postman

Open Postman and test these endpoints:

GET     /api/notes  
GET     /api/notes/{id}  
POST    /api/notes  
PUT     /api/notes/{id}  
DELETE  /api/notes/{id}  

For POST and PUT, use JSON body:

```

{
"title": "Sample Note",
"content": "This is a test note"
}

```


## 🧠 What This Project Demonstrates

This project was built to:

- Understand real backend layering  
- Implement dependency injection correctly  
- Work with EF Core migrations  
- Apply async/await in database operations  
- Separate business logic from controllers  
- Prepare for production-level backend systems  


## 📈 Learning Outcomes

After completing this project, I understand:

- How ASP.NET Core handles HTTP requests  
- How dependency injection works internally  
- Why async/await is important for scalability  
- How EF Core migrations manage schema  
- How to structure a clean backend project  


## 🔮 Possible Improvements

- JWT Authentication  
- Role-based Authorization  
- Global Exception Middleware  
- Logging  
- Pagination  
- Refresh Tokens  
- Production-ready configuration


## 👨‍💻 Author

Built as part of a backend architecture learning journey using ASP.NET Core.
