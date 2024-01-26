int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

string firstName = "Sam";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets."); // using variables and direct math operations together - Sam sold 77 widgets


Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets."); // Sam sold 14 widgets

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

// literal decimal data 

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}"); // literal decimal data

//increment/decrement operators aka compound assignment operators

int value = 0; // value now 0
value = value + 5; // value now 5
value += 5; // value now 10
Console.WriteLine(value);

// += or addition assignment operator adds and assigns the value on the right side of the operator to the value on the left side of the operator

int valueTwo = 0; // value 0
valueTwo = valueTwo + 1; // value 1
valueTwo++; // value 2 

// ++ operator increments value of the variable by 1


// example
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);


// example 
int value = 1;

Console.WriteLine($"Second: {value++}");
Console.WriteLine(value);


// END CHALLENGE - MY CODE FOR CONVERTING FAHRENHEIT TO CELSIUS

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32) * 5/9m; // m to get decimal value
Console.WriteLine("The temperature is " + celsius + " Celsius.");