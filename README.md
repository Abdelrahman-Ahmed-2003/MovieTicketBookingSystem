# MovieTicketBookingSystem
A multi-version Movie Ticket Booking System built in C# and .NET. The project dynamically evolves through each version to demonstrate clean architecture and the progressive implementation of advanced Object-Oriented Programming (OOP) principles.
# Movie Ticket Booking System 🎬

This repository showcases a structured, multi-version console application built as part of the Route Academy backend track. The core objective of this project is to demonstrate the progressive application of Object-Oriented Programming (OOP) principles through an evolving software architecture.

---

## 🏗️ OOP Evolution Plan By Version

### 🔹 Version 1: Encapsulation & Foundational Architecture
Focuses on defining the domain models and strictly protecting data integrity.
* **Encapsulation:** All fields are kept private, exposing data only through clean public properties with custom validation logic.
* **Data Organization:** Features separate folders for `Models`, `Enums`, and `Structs` to separate concerns neatly.

### 🔹 Version 2: Inheritance & Specialized Classes
Expands the domain to handle advanced booking types without repeating code.
* **Inheritance:** Introduces a base `Ticket` class, with specialized classes like `VIPTicket` and `StandardTicket` inheriting common functionality.
* **Code Reusability:** Eliminates code duplication by sharing common traits via parent classes.

### 🔹 Version 3: Polymorphism & Dynamic Behavior
Enables the system to process different ticket types seamlessly at runtime.
* **Polymorphism:** Implements `virtual` and `override` methods for dynamic pricing calculations and discount logic.
* **Interfaces / Abstract Classes:** Introduces abstractions to decouple the booking manager from concrete ticket implementations.

### 🔹 Version 4: Abstraction & Clean Interfaces
Hides complex system workflows behind clean, simple contracts.
* **Abstraction:** Implements service interfaces (e.g., `IBookingService`) so user interactions are completely isolated from internal database or business logic workflows.