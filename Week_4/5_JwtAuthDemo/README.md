# Web API Hands-On Assignment – JWT Authentication & Authorization

## 📌 Objective

This project demonstrates:

- Enabling **CORS** in a .NET Web API project
- Implementing **JWT (JSON Web Token)**-based authentication
- Using **Bearer tokens** for securing endpoints
- Performing **role-based authorization** using `[Authorize(Roles = "...")]`
- Validating **token expiration** and **access control**

---

## ⚙️ Tech Stack

- .NET 6 Web API
- JWT Authentication (`System.IdentityModel.Tokens.Jwt`)
- Role-based Authorization
- Postman (for testing API endpoints)

---

## 🚀 How It Works

### 🔑 `/Auth` Endpoint

- Generates a JWT token with:
  - Role: `Admin`
  - UserId: `1`
  - Expiry: 2 minutes

### 🔒 `/Employee` Endpoint

- Secured using `[Authorize(Roles = "Admin")]`
- Requires:
  - Valid JWT token in the **Authorization header**
  - Correct role to access

---

## 🧪 Test Cases (Postman)

| #   | Test Case Description                   | Expected Result       |
| --- | --------------------------------------- | --------------------- |
| 1   | Access `/Auth` to get token             | 200 OK (JWT returned) |
| 2   | Access `/Employee` without token        | 401 Unauthorized      |
| 3   | Access `/Employee` with valid token     | 200 OK                |
| 4   | Access `/Employee` with invalid token   | 401 Unauthorized      |
| 5   | Token has `POC` role instead of `Admin` | 403 Forbidden         |

---

## 📸 Output Screenshots

Screenshots are provided in the `OutputScreenshots/` folder:

- `1_JWT_Token_Generated.png`
- `2_Employee_Unauthorized_NoToken.png`
- `3_Employee_Authorized_WithToken.png`
- `4_Invalid_Token_Unauthorized.png`
- `5_Role_Access_Denied.png`

---

## ✅ Final Notes

- All tests were performed using **Postman**
- JWT signing key: `mysuperdupersecretkeyforjwttokenauth1234`
- Token scheme: `Bearer`
- Framework: `.NET 6`

---
