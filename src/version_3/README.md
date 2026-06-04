# Movie Ticket Booking System — Version 3 🎬

This project implements the requirements for **Assignment 03** of the **Route Academy** backend track. The architecture transitions from an isolated single-model design to an enterprise-style approach leveraging **Inheritance**, structural **Composition**, and runtime **Polymorphism**.

---

## 🛠️ Architectural Enhancements

### 1. Object-Oriented Hierarchy (Inheritance & Polymorphism)
The codebase establishes a unified data hierarchy anchored by a base model:
* **`Ticket` (Base Class):** Hosts shared data fields (`MovieName`, `Price`, `TicketId`) and exposes a read-only computed `PriceAfterTax` logic alongside a virtual `ToString()` layout.
* **`StandardTicket` (Child Class):** Tailored for general seating options by tracking explicit `SeatNumber` strings.
* **`VIPTicket` (Child Class):** Extends properties to account for `LoungeAccess` permissions and appends an automatic base `ServiceFee = 50` EGP onto its standard outputs.
* **`IMAXTicket` (Child Class):** Features an interactive `Is3D` flag. When evaluated as true, runtime behaviors polymorphically intercept and inflate the ticket baseline by an additional `30` EGP.

### 2. Structural Composition (`Models/Cinema.cs`)
Demonstrating real-world relationship modeling ("Has-A" patterns), the `Cinema` container incorporates lifecycle composition:
* **`Projector` Integration:** Rather than inheriting projector states, a distinct `Projector` object is managed and instantiated inside the `Cinema` class layout.
* **State Operations:** Exposes explicit orchestration wrappers (`OpenCinema()` and `CloseCinema()`) to cleanly initialize, spin up, or power down the underlying internal hardware components.
* **Unified Array Matrix:** Maintains a safe collection of up to 20 polymorphically accepted instances via a basic base array (`Ticket[]`).

### 3. Polymorphic Methods
* **Overridden `ToString()` Formats:** Each distinct sub-ticket subclass intercepts the standard virtual text footprint, seamlessly appending its specific metadata variants (`LoungeAccess` status, `3D` viewing modes, or seat allocations) into cleaner debugging readouts.
* **Polymorphic Printing:** The core printing method takes the base `Ticket` class pointer, allowing a single iteration sequence to read, process, and display all distinct child configurations seamlessly.