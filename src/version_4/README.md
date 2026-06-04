# Movie Ticket Booking System — Version 4 🎬

This project implements the requirements for **Assignment 04** of the **Route Academy** backend track. The architecture focuses on the core pillars of Object-Oriented Programming (OOP), specifically demonstrating **Method Overloading (Compile-Time Polymorphism)** and **Method Overriding (Runtime Polymorphism)**.

---

## 🛠️ Architectural Enhancements

### 1. Method Overloading (Compile-Time Polymorphism)
To safely alter internal object state, the base `Ticket` class implements method overloading by exposing two versions of the `SetPrice` method. The compiler decides which method to run based on the arguments passed:
* **`SetPrice(decimal directPrice)`**: Validates and updates the price directly.
* **`SetPrice(decimal basePrice, decimal multiplier)`**: Calculates the final amount dynamically (`base × multiplier`) before assigning it to the protected internal state.

### 2. Method Overriding & Virtual Members (Runtime Polymorphism)
Instead of forcing manual type-checking loops inside the user interface, printing actions leverage virtual dispatches:
* **`virtual void PrintTicket()` (Base Class)**: Formats and outputs the global metadata values shared by all variants (`TicketId`, `MovieName`, `Price`, and `PriceAfterTax`).
* **Specific Subclass Interceptions (`override`)**: 
  * `StandardTicket` appends the explicit `SeatNumber` layout.
  * `VIPTicket` outputs `LoungeAccess` permissions and the appended `ServiceFee`.
  * `IMAXTicket` appends the active `3D Viewing Mode` status.

### 3. Polymorphic Core Matrix (`Cinema.cs` & `Program.cs`)
* **Unified Array Traversal**: The `Cinema.PrintAllTickets()` method loops through a standard `Ticket[]` collection. Because of inheritance and method overriding, calling `.PrintTicket()` automatically jumps to the correct child class logic at runtime.
* **Decoupled Processing Helper**: Built a static `ProcessTicket(Ticket t)` worker function inside `Program.cs`. It accepts the base `Ticket` pointer, meaning it can safely process any existing or future ticket child type without requiring code modifications.

---