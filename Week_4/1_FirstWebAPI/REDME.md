# 📦 FirstWebAPI (Week 4 Assessment)

## 📌 Description

This project demonstrates a simple **ASP.NET Core Web API** for Week 4 of the Cognizant .NET Training Program. It implements a `ValuesController` with full CRUD operations and has been tested using Postman.

---

## ✅ Implemented Features

| HTTP Method | Route              | Description          |
| ----------- | ------------------ | -------------------- |
| `GET`       | `/api/values`      | Get all values       |
| `GET`       | `/api/values/{id}` | Get value by ID      |
| `POST`      | `/api/values`      | Add a new value      |
| `PUT`       | `/api/values/{id}` | Update a value by ID |
| `DELETE`    | `/api/values/{id}` | Delete a value by ID |

---

## 🧪 Testing

All endpoints were tested using **Postman**. The following screenshots are included:

- 📥 `GET.png` – Get all values
- ➕ `POST.png` – Add a value
- ✏️ `PUT.png` – Update a value
- ❌ `DELETE.png` – Delete a value

Screenshots are located in the [`Screenshots/`](./Screenshots/) folder.

---

## 🛠 Technologies Used

- .NET 6 (ASP.NET Core Web API)
- C#
- Postman

---

## 📁 Folder Structure

FirstWebAPI/
├── Controllers/
│ └── ValuesController.cs
├── Properties/
│ └── launchSettings.json
├── Outputs/
│ ├── GET.png
│ ├── POST.png
│ ├── PUT.png
│ ├── DELETE.png
├── appsettings.json
├── Program.cs
├── FirstWebAPI.csproj
├── README.md

---

## 👨‍💻 Author

Sarthak Sharma
