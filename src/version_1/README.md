1. Ticket Types
     Each ticket has a type that can only be one of: Standard, VIP, or IMAX.

Question to consider: How would you represent this?

2. Seat Location
You need a type to represent a seat location:

Row (as a char like 'A', 'B')

Number (as an int)

Question to consider: Should this be a class or a struct? Create it.

3. Ticket Class
Create a Ticket class containing the following fields/properties:

MovieName (public)

Type (public)

Seat (public)

Price (private)

Constructor Requirements:
Handle full initialization when a ticket is created with all information.

Handle partial initialization when a ticket is created with just the movie name (using default values: type Standard, seat A1, price 50).

Rule: Handle both scenarios without repeating your initialization logic.

4. Ticket Class Methods
Add these three methods to your Ticket class:

CalcTotal()

Receives a taxPercent (double).

Calculates and returns the total price after tax.

Rule: The original price must remain unchanged.

ApplyDiscount()

Receives a discountAmount (double).

Checks if the discount is valid (must be > 0 and ≤ Price).

If valid: Deducts it from Price and sets the discountAmount to 0 (consumed).

If invalid: The discount stays unchanged.

PrintTicket()

Prints the full ticket information to the console.