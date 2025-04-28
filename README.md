```markdown
# 🛒 SkiNet

A modular e-commerce web application built with **ASP.NET Core** (Backend) and **Angular** (Frontend).  
It follows a **clean architecture** approach with separate API, Core, and Infrastructure layers.

---

## ✨ Features

- ASP.NET Core Web API (Backend)
- Angular Frontend (Planned)
- Entity Framework Core with Migrations
- Clean and Modular Project Structure
- Basic E-commerce functionality:
  - Product Catalog
  - Shopping Basket
  - Orders System
- Authentication with JWT (Planned)

---

## 📁 Project Structure

```
skinet/
├── API/                # ASP.NET Core Web API controllers and startup
├── Core/               # Domain models and interfaces
├── Infrastructure/     # Data access and external service implementations
├── skinet.sln          # Visual Studio solution file
```

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/) and Angular CLI (for frontend)
- SQL Server (LocalDB or Full)

### Clone the Repository

```bash
git clone https://github.com/Max-creates/skinet.git
cd skinet
```

### Setup Backend (API)

1. Open `skinet.sln` with Visual Studio.
2. Set `API` project as startup project.
3. Apply Migrations (if necessary):
   ```bash
   cd Infrastructure/Data
   dotnet ef database update
   ```
4. Run the project (it will start the API).

### Setup Frontend (Coming Soon)

Frontend based on Angular is planned but not included yet.

---

## 🛠️ TODO List

- [x] Setup ASP.NET Core backend structure
- [ ] Implement Catalog API endpoints
- [ ] Create Angular frontend project
- [ ] Connect frontend to backend API
- [ ] Implement JWT Authentication
- [ ] Implement Shopping Basket logic
- [ ] Implement Order placement and history
- [ ] Admin panel for product management
- [ ] Add Unit and Integration tests
- [ ] Add CI/CD pipeline for automatic deployment

---

## 🧪 Technologies Used

- C# / ASP.NET Core 8
- Angular (Planned)
- Entity Framework Core
- SQL Server
- AutoMapper
- Repository Pattern
- Unit of Work Pattern
- JWT Authentication (Planned)

```
