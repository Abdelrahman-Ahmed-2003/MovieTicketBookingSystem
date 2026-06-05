# Movie Ticket Booking System — Version 5 🎬

This project implements the requirements for **Assignment 05** of the **Route Academy** backend development track. The focus of this session is decoupling application logic and enforcing operational contracts using **Custom and Native C# Interfaces**, achieving clean **Interface Polymorphism**, and resolving memory allocation hurdles through **Deep Copying**.

---

## 🛠️ Design Patterns & Principles

### 1. Contract-Driven Architecture (Custom Interfaces)
To establish explicit system capabilities, the architecture introduces two distinct behavioral abstractions:
* **`IPrintable`**: Establishes a uniform blueprint for all objects requiring console outputs (such as tickets and accounting receipts) without hardcoding dependencies on individual class models.
* **`IBookable`**: Enforces life-cycle state tracking across transactional objects. It encapsulates properties for status auditing alongside explicit execution patterns for booking and cancellation behaviors.

### 2. Interface Polymorphism
By utilizing interfaces as method abstractions, the processing engines are fully decoupled from implementation details:
* **Decoupled Utilities (`BookingHelper`)**: Features a localized processing engine that acts upon collections bound to the `IPrintable` contract. This enables unified rendering routines for mixed arrays containing disparate printable entities without the utility ever needing knowledge of their concrete subclass types.

### 3. Object Prototyping & Memory Isolation (`ICloneable`)
To manage independent structural duplicates of existing models, the core data matrix integrates with standard .NET protocols:
* **Deep Copying Implementations**: Rather than processing shallow pointer assignments (which mirror reference addresses across variables), the ticket sub-nodes implement explicit `ICloneable` mapping logic.
* **State Independence**: Instantiating a clone allocates a new, distinct memory sector on the Heap. Modifying context layers or states on a duplicated object leaves the parent reference model completely unchanged.

---

## 📊 Interface Implementation Matrix

| Class Component | `IPrintable` | `IBookable` | `ICloneable` | Behavior Description |
| :--- | :---: | :---: | :---: | :--- |
| **`Ticket` (Base)** |  |  |  | Establishes baseline layout rules and handles base fields. |
| **`StandardTicket`** |  |  |  | Specializes print metrics and clones localized row fields. |
| **`VIPTicket`** |  |  |  | Clones compound parameters and specialized auxiliary data. |
| **`IMAXTicket`** |  |  |  | Intercepts and copies dimensional system conditions. |

---

## 🚀 Key Validation Workflows Tested

* **Contract Isolation**: Demonstrates how an object can safely alter its tracking state via an `IBookable` interface cast while restricting access to other unrelated data layer manipulations.
* **Polymorphic Printing**: Validates sending a mixed array structure directly into a general `IPrintable` tracking handler.
* **Heap Isolation Audit**: Verifies cloning operations by asserting that changing properties on a cloned instance does not overwrite data inside the primary origin model.