# Car Rental Management System

A complete Windows Forms desktop application built using **C# (.NET Framework)** and **SQL Server**, designed to manage a car rental business. Developed as part of **Object-Oriented Programming (OOP)** and **Database Systems** coursework, it provides secure admin access, dynamic vehicle and customer management, and seamless payment and email integration.

---

## Features

* **Admin Login and Approval**
  Secure sign-in, sign-up, and super admin-based approval

* **Customer Management**
  Add, update, delete, and search customer records

* **Vehicle Management**
  Manage both cars and trucks using inheritance-based class structure

* **Rentals and Returns**
  Rent vehicles to customers with real-time tracking of rental status

* **Payments**
  Process payments using Stripe API (or mark as Cash)

* **Email Integration**
  Uses SendGrid API to send confirmation and approval emails

* **Reports and Records**
  View rental and payment logs in formatted tables

* **Modern UI**
  Built using **Bunifu** and **Guna UI** frameworks for a clean, professional interface

---

## Technologies Used

* **Frontend:** C# (.NET Framework), Windows Forms
* **UI Frameworks:** Bunifu UI, Guna UI
* **Backend:** SQL Server (with stored procedures)
* **APIs:** Stripe (payments), SendGrid (emails)
* **Dev Tools:** Visual Studio, SQL Server Management Studio

---

## Database Tables

* ADMINS
* CUSTOMERS
* VEHICLES
* RENTALS
* PAYMENTS

All logic is implemented using stored procedures for secure, maintainable operations.

---

## Requirements

* Windows OS
* .NET Framework 4.x
* SQL Server installed and configured
* Visual Studio (Recommended for running and debugging)

---

## How to Run

1. Clone the repository
2. Import `.sql` files to your SQL Server database
3. Open the solution in Visual Studio
4. Update `App.config` with your SQL Server connection string
5. Install required UI libraries (Bunifu and Guna UI)
6. Run the project

---

## APIs Used

* **Stripe API** – For payment gateway integration
* **SendGrid API** – For email verification and notifications

> API keys should be added securely (e.g., via `App.config` or environment variables)

---

## Authors

* **Taha Manshoor**

---

## License

This project is developed for academic purposes. You may reuse or modify it for non-commercial or learning use.

---

## GitHub Repository

[View the Repository](https://github.com/Tahadar7/CarRental.git)
