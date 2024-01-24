var name = "Bob";
int num = 3;
var num_2 = 34.4; 


Console.Write("Hello, " + name + "! You have " + num + " messages in your inbox. The temperature is " + num_2 + " celsius."); // using variables to print full message

// 

Console.WriteLine(34.40M); // using M or m will denote decimal type 

Console.WriteLine("Hello\nWorld!"); // using \n will start a new line, in this case before the word "World!"

Console.WriteLine("Hello \"World\"!") // using \\ allows you to insert quotation marks into the string without the compiler thinking you are trying to end the string

Console.WriteLine("c:\\source\\repos"); // using two \\ instead of one \ for things like file paths, since C# reserves backslash for escape

Console.WriteLine("Hello\tWorld!") // using \t will insert a tab character 

// **microsoft example below

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// **END

Console.WriteLine(@" Hello my name is 
        Sam"); // using @, verbatim string literal
                // use this when you want to keep whitespace, characters, etc. the same way that it is typed up in the code


// **microsoft example below for when you want to use other characters, such as japanese letter characters

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices"); 
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // this will print "Hello" in japanese, using the character number designation of Unicode (UTF-16) and \u escape sequence

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

// **END


// how to concatenate multiple variables
string firstName = "Sam";
string greeting = "Hey there";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message); // this will print "Hey there Sam!"


// how to interpolate multiple variables 
string firstName = "Sam";
string greeting = "Hey there";

string message = $"{greeting} {firstName}";

Console.WriteLine(message); // will print "Hey there Sam"

// more string interpolation - microsoft example 
int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);

// avoiding intermediate variables - microsoft example
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

// interpolation and verbatim string literals - microsoft example
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

//  self-project -- to print given output that they asked for - my code down below
string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine("View English output:");
Console.WriteLine($@"c:\Exercise\{projectName}\data.txt");
Console.WriteLine();
Console.WriteLine(russianMessage + ":");
Console.WriteLine($@"c:\Exercise\{projectName}\ru-RU\data.txt");

