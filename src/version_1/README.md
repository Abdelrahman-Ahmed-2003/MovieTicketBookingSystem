---

## 📂 Version 1: Technical Implementation Details

This section documents the specific requirements, architectural decisions, and object encapsulation patterns implemented in `Version_01` (`MovieBookingV1`).

### 1. Ticket Types (`Enums`)
To represent the fixed set of ticket options securely and prevent invalid string inputs, we utilize a strongly-typed enumeration:
* **Standard**: Default tier.
* **VIP**: Premium tier.
* **IMAX**: High-definition theater tier.

> **Design Decision:** An `Enum` is used here instead of raw strings to ensure type safety, prevent runtime spelling errors, and make the codebase highly maintainable as new tiers expand.

---

### 2. Seat Location (`Structs`)
Represents the exact physical location of a theater seat using a coordinate mapping:
* **Row**: Represented as a `char` (e.g., `'A'`, `'B'`).
* **Number**: Represented as an `int` (e.g., `1`, `12`).

> **Design Decision:** This type is created as a **`struct`** rather than a class. Because a seat location is small, lightweight, immutable in nature, and acts simply as a cohesive value containing two primitive types, a value type (`struct`) is significantly more memory-efficient than a reference type (`class`).

---

### 3. Ticket Class (`Classes`)
The core domain model responsible for encapsulating complete movie ticket states.

#### Properties & Fields
* `MovieName` (public string)
* `Type` (public TicketType Enum)
* `Seat` (public SeatLocation struct)
* `Price` (**private** double) — *Strictly encapsulated to protect financial data from external unauthorized modification.*

#### Constructor Requirements (DRY Principle)
To initialize tickets safely without code duplication, the class implements **Constructor Chaining**:
1. **Full Initialization Constructor**: Accepts all values (`MovieName`, `Type`, `Seat`, `Price`) to build custom configurations.
2. **Partial Initialization Constructor**: Accepts *only* the `MovieName`. Using the `: this(...)` syntax, it forwards the call to the full constructor with strict default values:
   * **Type:** `Standard`
   * **Seat:** `A1`
   * **Price:** `50`

---

### 4. Behavioral Business Logic (Methods)

The `Ticket` class encapsulates its own behavioral logic using three highly testable methods:

#### 🔹 `CalcTotal(double taxPercent)`
* **Behavior:** Receives a percentage value, calculates the absolute tax amount, and returns the net total price.
* **Rule Applied:** Implements pure data calculation. The original internal `Price` of the ticket remains completely unchanged.

#### 🔹 `ApplyDiscount(ref double discountAmount)`
* **Behavior:** Processes a potential discount modification by reference.
* **Validation Check:** Verifies if the incoming discount is valid (must be greater than `0` and less than or equal to the current `Price`).
* **Rule Applied:** If valid, the discount is deducted from the internal `Price` and the outer parameter is set to `0` (fully consumed). If invalid, the operations fail silently and the discount token remains entirely unchanged.

#### 🔹 `PrintTicket()`
* **Behavior:** Formats and outputs the complete structured data properties cleanly to the Console window for direct user visibility.