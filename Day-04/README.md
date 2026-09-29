# Day 04 — C# OOP Practice

This folder contains C# practice problems focused on **Object-Oriented Programming (OOP)** concepts.

The problems are designed to strengthen practical understanding of **Class & Object, Constructor, Methods, Encapsulation, Inheritance, Abstraction, Interface, and Polymorphism**.

---

## 📚 Topics Covered

* Class & Object
* Properties
* Constructor
* Methods
* Encapsulation
* Inheritance
* Polymorphism
* Abstraction
* Interface
* Runtime Polymorphism

---

## 📂 Problems

| #  | Problem                    | Main Concepts                                     |
| -- | -------------------------- | ------------------------------------------------- |
| 01 | Student Class & Object     | Class, Object, Properties, Method                 |
| 02 | Employee Salary Calculator | Constructor, Methods, Object                      |
| 03 | Bank Account               | Encapsulation, Private Property, Methods          |
| 04 | Vehicle Polymorphism       | Inheritance, Virtual, Override, Polymorphism      |
| 05 | Payment System             | Abstraction, Interface, Inheritance, Polymorphism |

---

## 📝 Problem Details

### 01 — Student Class & Object

Created a `Student` class with properties for:

* Name
* Age
* Department
* CGPA

Created multiple student objects and displayed their information using a class method.

**Concepts:**
`Class`, `Object`, `Properties`, `Method`

---

### 02 — Employee Salary Calculator

Created an `Employee` class with:

* Name
* Position
* Monthly Salary

Used a constructor to initialize employee information and a method to calculate the annual salary.

**Concepts:**
`Constructor`, `Properties`, `Methods`, `Object`

---

### 03 — Bank Account

Created a `BankAccount` class to demonstrate encapsulation.

The account balance is kept private and can only be modified through controlled methods:

* `Deposit()`
* `Withdraw()`
* `GetBalance()`

The program also validates deposit and withdrawal amounts.

**Concepts:**
`Encapsulation`, `Private Property`, `Methods`, `Data Protection`

---

### 04 — Vehicle Polymorphism

Created a base `Vehicle` class and derived classes:

* `Car`
* `Bike`
* `Bus`

The `Start()` method is overridden in each child class.

A `Vehicle` reference is used to hold different child objects, demonstrating runtime polymorphism.

**Concepts:**
`Inheritance`, `Virtual`, `Override`, `Runtime Polymorphism`

---

### 05 — Payment System

Created an abstract `Payment` class and an `IReceipt` interface.

Implemented different payment types:

* `BkashPayment`
* `CardPayment`
* `CashPayment`

Each payment class provides its own implementation of `Pay()` and `GenerateReceipt()`.

**Concepts:**
`Abstraction`, `Interface`, `Inheritance`, `Runtime Polymorphism`

---

## 🛠️ Technologies

* C#
* .NET
* Object-Oriented Programming
* Visual Studio Code
* Git & GitHub

---

## ▶️ How to Run

Navigate to any problem folder and run:

```powershell
dotnet run
```

Example:

```powershell
cd Day-04\01-Student-Class-Object
dotnet run
```

---

## 🎯 Learning Objectives

Through these problems, I practiced:

* Creating classes and objects
* Using properties
* Creating and using constructors
* Writing class methods
* Protecting data using encapsulation
* Reusing code through inheritance
* Overriding methods
* Understanding runtime polymorphism
* Designing abstract classes
* Implementing interfaces
* Combining multiple OOP concepts in practical programs

---

## ✅ Completion Checklist

* [x] Student Class & Object
* [x] Employee Salary Calculator
* [x] Bank Account
* [x] Vehicle Polymorphism
* [x] Payment System
* [x] Practiced OOP concepts
* [x] Tested programs using `dotnet run`
* [x] Reviewed code and output

---

## 📌 Key Takeaway

Day 04 practice helped me move from learning individual OOP concepts to applying them in practical C# programs.

The main focus was understanding how **classes, objects, encapsulation, inheritance, abstraction, interfaces, and polymorphism** work together in real-world programming.

**Day 04 Practice — Completed ✅**