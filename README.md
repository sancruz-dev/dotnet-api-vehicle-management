# Vehicle Management System API

[![.NET](https://img.shields.io/badge/.NET-6.0-blue.svg)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Entity Framework](https://img.shields.io/badge/Entity%20Framework-512BD4?style=flat&logo=.net&logoColor=white)](https://docs.microsoft.com/en-us/ef/)
[![MySQL](https://img.shields.io/badge/MySQL-4479A1?style=flat&logo=mysql&logoColor=white)](https://www.mysql.com/)
[![JWT](https://img.shields.io/badge/JWT-000000?style=flat&logo=json-web-tokens&logoColor=white)](https://jwt.io/)
[![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=flat&logo=swagger&logoColor=black)](https://swagger.io/)
[![MSTest](https://img.shields.io/badge/MSTest-68217A?style=flat&logo=microsoft&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest)
[![Clean Architecture](https://img.shields.io/badge/Clean%20Architecture-00599C?style=flat&logo=architecture&logoColor=white)](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![API](https://img.shields.io/badge/API-REST-orange.svg)](https://restfulapi.net/)

A comprehensive RESTful API built with .NET that demonstrates modern software development practices including Clean Architecture, Entity Framework, JWT authentication, and comprehensive testing.

## 🚀 Features

- **Vehicle CRUD Operations**: Complete Create, Read, Update, Delete functionality for vehicle management
- **User Authentication & Authorization**: JWT-based authentication with role-based access control
- **Admin Management**: Dedicated endpoints for administrator operations
- **Data Validation**: Robust server-side validation with custom validation rules
- **API Documentation**: Interactive Swagger/OpenAPI documentation
- **Memory Caching**: Optimized performance with in-memory caching strategies
- **Comprehensive Testing**: Unit tests with MSTest framework ensuring code reliability

## 🏗️ Architecture & Design Patterns

This project follows **Clean Architecture** principles with clear separation of concerns:

```
├── Domain Layer (Entities, Interfaces)
├── Application Layer (Use Cases, DTOs, Validators)
├── Infrastructure Layer (Data Access, External Services)
└── Presentation Layer (Controllers, Middleware)
```

### Key Architectural Decisions:
- **Clean Code**: Following SOLID principles and clean coding practices
- **Repository Pattern**: Abstraction layer for data access operations
- **Dependency Injection**: Loose coupling between components
- **Entity Framework Core**: Code-first approach with migrations
- **JWT Authentication**: Stateless authentication mechanism

## 🛠️ Technologies & Tools

### Backend Framework
- **.NET 6+**: Modern cross-platform framework
- **ASP.NET Core Web API**: RESTful API development
- **Entity Framework Core**: Object-relational mapping (ORM)

### Database
- **MySQL**: Relational database management
- **MySQL CLI**: Database operations and management

### Authentication & Security
- **JWT (JSON Web Tokens)**: Secure authentication
- **Role-based Authorization**: Admin and user access levels
- **Password Hashing**: Secure password storage

### Testing
- **MSTest**: Unit testing framework
- **Test-Driven Development**: Ensuring code reliability and maintainability

### Documentation & Tools
- **Swagger/OpenAPI**: Interactive API documentation
- **Postman Collections**: API testing and validation

## 📋 API Endpoints

### Authentication
```http
POST /api/auth/login          # User authentication
POST /api/auth/register       # User registration
```

### Vehicle Management
```http
GET    /api/vehicles          # Get all vehicles
GET    /api/vehicles/{id}     # Get vehicle by ID
POST   /api/vehicles          # Create new vehicle
PUT    /api/vehicles/{id}     # Update vehicle
DELETE /api/vehicles/{id}     # Delete vehicle
```

### Administration
```http
GET    /api/admin/users       # Get all users (Admin only)
POST   /api/admin/seed        # Seed default administrator
PUT    /api/admin/users/{id}  # Update user (Admin only)
```

## 🔧 Getting Started

### Prerequisites
- .NET 6+ SDK
- MySQL Server
- MySQL CLI tools

### Installation

1. **Clone the repository**
```bash
git clone [repository-url]
cd vehicle-management-api
```

2. **Configure Database Connection**
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=VehicleDB;Uid=your_username;Pwd=your_password;"
  }
}
```

3. **Apply Database Migrations**
```bash
dotnet ef database update
```

4. **Seed Administrator Account**
```bash
dotnet run --seed-admin
```

5. **Run the Application**
```bash
dotnet run
```

6. **Access Swagger Documentation**
Navigate to `https://localhost:5001/swagger`

## 🧪 Testing

Run the comprehensive test suite:

```bash
dotnet test
```

### Test Coverage
- **Unit Tests**: Core business logic validation
- **Integration Tests**: API endpoint testing
- **Persistence Tests**: Database operations verification
- **Authentication Tests**: JWT and authorization testing

## 🔒 Security Features

- **JWT Authentication**: Secure token-based authentication
- **Password Security**: BCrypt password hashing
- **Role-based Access Control**: Different permission levels
- **Input Validation**: Protection against malicious inputs
- **HTTPS Enforcement**: Secure data transmission

## 📊 Performance Optimizations

- **In-Memory Caching**: Frequently accessed data caching
- **Efficient Queries**: Optimized Entity Framework queries
- **Asynchronous Operations**: Non-blocking I/O operations
- **Connection Pooling**: Database connection optimization

## 🏆 Best Practices Implemented

- **Clean Architecture**: Maintainable and testable code structure
- **SOLID Principles**: Object-oriented design principles
- **Repository Pattern**: Data access abstraction
- **Dependency Injection**: Loose coupling and testability
- **Configuration Management**: Environment-specific settings
- **Error Handling**: Centralized exception management

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

---

**Built with ❤️ using .NET, Entity Framework, and Clean Architecture principles**