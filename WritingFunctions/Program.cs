// When MultiplyTable is called, number and size are arguments.
MultiplyTable(number: 3, size: 5);

// When CalculateTax is called, amount and twoLetterRegionCode are arguments.
decimal tax = CalculateTax(amount: 100, twoLetterRegionCode: "CH");
WriteLine($"The tax is {tax:C}"); // The :C format specifier formats the value as currency.

RunCardinalToOrdinal();

RunFactorial();