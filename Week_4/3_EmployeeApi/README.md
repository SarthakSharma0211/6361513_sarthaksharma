# EmployeeApi – ASP.NET Core Web API

This is a Web API project created as part of a hands-on assignment for demonstrating:

- Custom model classes with nested structure
- GET and POST API actions
- Custom Authorization and Exception filters
- Swagger integration for testing

---

## ✅ Features Implemented

### 1. **Custom Model Class**

- `Employee` model with nested `Department` and list of `Skill`

### 2. **Controllers**

- `EmployeeController`:
  - `GET /Employee` – Returns list of employees
  - `POST /Employee` – Adds new employee using [FromBody]

### 3. **Authorization Filter**

- `CustomAuthFilter` checks for:
  - Presence of `Authorization` header
  - Contains `Bearer` keyword

### 4. **Exception Filter**

- `CustomExceptionFilter` handles all unhandled exceptions globally
- Logs exception to a local file (`error_log.txt`)
- Returns HTTP 500 with generic error message

### 5. **Swagger Integration**

- Used for testing all endpoints
- `Authorize` support added to test Authorization headers

---

## 🧪 How to Run

1. Clone the repo
2. Navigate to the folder and run:
   ```bash
   dotnet restore
   dotnet build
   dotnet run
   ```

Open Swagger:

Then bash:
http://localhost:5274/swagger

Click "Authorize" and enter:
Bearer token123
