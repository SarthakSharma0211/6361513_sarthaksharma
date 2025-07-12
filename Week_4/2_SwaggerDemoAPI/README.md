This project demonstrates the following Web API concepts using ASP.NET Core and Swagger:

## ✅ Features Implemented

- Web API project using .NET Core
- Swagger integrated via Swashbuckle
- Custom metadata for API title, contact, license
- API controller: `EmployeeController`
  - `GET` method with `[ProducesResponseType]`
  - `POST` method using `[FromBody]`
  - Custom routing using `[Route("api/emp")]`
  - Multiple `GET` methods with `[ActionName]`
- Tested using Swagger UI and Postman

## 📁 Output Screenshots

See the `/output` folder for task-wise screenshots as proof of execution.

## 🛠️ Technologies

- ASP.NET Core
- Swagger (Swashbuckle)
- Visual Studio Code
- Postman

## 🚀 How to Run

```bash
dotnet run --launch-profile SwaggerDemoAPI

Then Visit:
https://localhost:5001/swagger

```
