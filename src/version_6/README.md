# Movie Ticket Booking System — Version 6 🎬

This project implements the requirements for **Assignment 06** of the **Route Academy** backend track. The architecture focuses on design restriction via **Abstract Base Classes**, class splitting architecture using **Partial Classes**, and code maintainability through **C# Extension Methods**.

---

## 🛠️ Design Patterns & Principles

### 1. Architectural Prevention (Abstract Classes)
* **No Plain Tickets**: The base `Ticket` class is now marked as `abstract`. This prevents developers from calling `new Ticket()` directly in `Program.cs`. Every ticket must belong to an explicit category (`Standard`, `VIP`, or `IMAX`).
* **Deferred Logic**: The class uses a mix of concrete methods (for shared behaviors like booking/cancelling) and abstract methods to force every child type to provide its own calculations (such as final pricing variants) at design level.

### 2. Domain Splitting (Partial Classes)
To keep code readable and prevent a single class from growing too massive, the `Cinema` class is split across multiple files using the `partial` keyword. Both files contribute to a single class definition behind the scenes:
* **`Cinema.Tickets.cs`**: Manages underlying operational data arrays, slot allocation, and ticket validation logic.
* **`Cinema.Reporting.cs`**: Handles analytics, ticket inventory print rendering, and financial metrics.

### 3. Non-Invasive Enhancements (Extension Methods)
To add utility tools to existing classes without changing their core source code, the system utilizes static extension methods:
* **Natural Invocations**: Exposes tools like a formatted receipt generator or a revenue summation engine. These feel like native methods attached directly to the objects (e.g., `ticket.GetReceipt()`) even though they live in a separate utility directory.

---

## 📊 Class Architecture Layout

| Feature Type | Target Class | Mechanism | Structural Benefit |
| :--- | :--- | :--- | :--- |
| **Design Enforcement** | `Ticket` | `abstract` | Eliminates incomplete initialization instances. |
| **Code Separation** | `Cinema` | `partial` | Enhanges maintainability by isolating data mutations from reporting. |
| **API Enrichment** | `Ticket[]` | `static extension` | Appends advanced calculations without bloating model logic. |

---

## 🚀 Key Validation Workflows Tested

* **Instantiation Protection**: Confirms that trying to directly instantiate the base `Ticket` class fails at compile time.
* **Partial Synchronization**: Verifies that fields initialized in one partial class file are seamlessly accessible by methods inside the secondary partial class file.
* **Fluent Extensions**: Validates that extension utilities process collections naturally, allowing calculations like total revenue directly off an array pointer.