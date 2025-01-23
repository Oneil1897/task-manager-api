# Task Manager API

## Overview
The Task Manager API is a simple RESTful web service built with ASP.NET Core that allows users to manage tasks efficiently. It provides endpoints to create, retrieve, and manage tasks, following clean architecture principles.

## Features
- Create new tasks
- Retrieve all tasks
- Use an in-memory database for simplicity
- Clean architecture with services and repositories

## Project Structure
```
TaskManagerAPI/
├── Controllers/
│   ├── TasksController.cs       # API controller for handling tasks
├── Models/
│   ├── TaskItem.cs              # Task entity/model
├── Services/
│   ├── ITaskService.cs          # Interface for business logic
│   ├── TaskService.cs           # Implementation of business logic
├── Repositories/
│   ├── ITaskRepository.cs       # Repository interface
│   ├── TaskRepository.cs        # Repository implementation
├── Data/
│   ├── AppDbContext.cs          # Entity Framework DB context
├── Program.cs                   # Entry point
├── Startup.cs                   # Application configuration
├── appsettings.json             # Application settings
├── README.md                    # Documentation
├── TaskManagerAPI.csproj         # Project file
```

## Prerequisites
Make sure you have the following installed:
- [.NET SDK 6.0+](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/)
- Postman (for testing API requests)

## Installation

1. Clone the repository:
   ```sh
   git clone https://github.com/your-username/task-manager-api.git
   cd task-manager-api
   ```

2. Install dependencies:
   ```sh
   dotnet restore
   ```

3. Run the application:
   ```sh
   dotnet run
   ```

4. The API will be accessible at:
   ```
   http://localhost:5000
   ```

## API Endpoints

### Create a New Task
- **URL:** `POST /api/tasks`
- **Request Body:**
  ```json
  {
    "title": "Complete API project",
    "description": "Write sample code",
    "isCompleted": false,
    "dueDate": "2025-01-30T12:00:00Z"
  }
  ```
- **Response:**
  ```json
  {
    "id": 1,
    "title": "Complete API project",
    "description": "Write sample code",
    "isCompleted": false,
    "dueDate": "2025-01-30T12:00:00Z"
  }
  ```

### Retrieve All Tasks
- **URL:** `GET /api/tasks`
- **Response:**
  ```json
  [
    {
      "id": 1,
      "title": "Complete API project",
      "description": "Write sample code",
      "isCompleted": false,
      "dueDate": "2025-01-30T12:00:00Z"
    }
  ]
  ```

## Running Tests

To run unit tests, use:
```sh
dotnet test
```

## Deployment

To deploy the application, build and publish it:
```sh
dotnet publish -c Release -o out
```

You can host it on Azure, AWS, or other cloud platforms.

## Contact

For any questions or support, please contact:
- **Name:** Oneil Contractor
- **Email:** oneil.contractor@example.com

