# Day 05 — Advanced C# Practice Problems

This directory contains five hands-on C# practice problems designed to strengthen my understanding of Object-Oriented Programming (OOP), access modifiers, properties, static members, nullable types, and exception handling.

## 🎯 Learning Objectives

- Understand interfaces and abstract classes.
- Practice static methods and class members.
- Apply access modifiers to control data access.
- Use properties and constructors to manage object data.
- Implement inheritance and method overriding.
- Understand nullable value types.
- Handle exceptions using `try-catch`.
- Build small, practical C# console applications.

## 📚 Problem List

### 01. Payment System

**Folder:** `01-Payment-System`

**Concepts:** Interfaces, Polymorphism, Methods

**Description:**
Created a payment system using an `IPayment` interface. Implemented separate payment classes for bKash and card payments, including receipt generation.

**Key Learnings:**
- Define and implement interfaces.
- Implement common methods in different classes.
- Use interface references to work with different payment types.

### 02. Employee Management System

**Folder:** `02-Employee-Management`

**Concepts:** Abstract Classes, Inheritance, Properties, Method Overriding

**Description:**
Built an employee management system with an abstract `Employee` class and concrete `Developer` and `Manager` classes.

**Key Learnings:**
- Define abstract classes and abstract methods.
- Implement abstract methods using `override`.
- Use properties to store employee information.
- Reuse common functionality through inheritance.

### 03. Student Result Calculator

**Folder:** `03-Student-Result-Calculator`

**Concepts:** Static Methods, Conditional Statements, Methods, Arithmetic Operations

**Description:**
Developed a student result calculator that calculates total marks, average marks, and pass/fail status.

**Key Learnings:**
- Create and call static methods.
- Perform arithmetic calculations.
- Use conditional statements to determine results.
- Format numeric output.

### 04. Bank Employee System

**Folder:** `04-Bank-Employee-System`

**Concepts:** Access Modifiers, Properties, Inheritance, Constructors, Method Overriding

**Description:**
Created a bank employee system with an `Employee` base class and a `Manager` derived class. Salary updates are handled through a public method while the salary field remains private.

**Key Learnings:**
- Apply `public` and `private` access modifiers.
- Protect fields through controlled access.
- Use constructors and inheritance.
- Override methods and call base-class functionality.

### 05. Safe Banking System

**Folder:** `05-Safe-Banking-System`

**Concepts:** Nullable Types, Exception Handling, Validation, Methods

**Description:**
Implemented a banking system that supports deposits and withdrawals, validates transaction amounts, and handles errors such as insufficient balance and invalid deposits.

**Key Learnings:**
- Work with nullable types using `double?`.
- Check for `null` before accessing nullable values.
- Throw exceptions for invalid operations.
- Handle exceptions using `try-catch`.
- Protect account balance updates with validation.

## 🛠️ Technologies Used

- **Language:** C#
- **Platform:** .NET
- **Application Type:** Console Applications
- **IDE:** Visual Studio Code
- **Version Control:** Git and GitHub

## ▶️ How to Run a Problem

1. Open a terminal.
2. Navigate to the desired problem directory.
3. Run the application using the .NET CLI.

Example:

```powershell
cd 01-Payment-System
dotnet run
```

Replace `01-Payment-System` with the directory name of any other problem.

## 📂 Directory Structure

```text
Day-05/
├── README.md
├── 01-Payment-System/
│   └── Program.cs
├── 02-Employee-Management/
│   └── Program.cs
├── 03-Student-Result-Calculator/
│   └── Program.cs
├── 04-Bank-Employee-System/
│   └── Program.cs
└── 05-Safe-Banking-System/
    └── Program.cs
```

*Note: Each project may also contain its own `.csproj`, `bin/`, and `obj/` files.*

## 📈 Progress Summary

- [x] Problem 01 — Payment System
- [x] Problem 02 — Employee Management System
- [x] Problem 03 — Student Result Calculator
- [x] Problem 04 — Bank Employee System
- [x] Problem 05 — Safe Banking System

**Status:** Completed — 5/5 Problems

## 💡 Key Takeaways

Through these exercises, I practiced essential C# concepts and applied them to small console applications. These problems helped me improve my understanding of object-oriented programming, code organization, data protection, and basic error handling.

This practice series is part of my ongoing journey to become a stronger software engineer through consistent coding, problem-solving, and GitHub documentation. 
