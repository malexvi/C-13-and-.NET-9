// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// We can start the application with a debugger attached or not. When starting without it will consume less resources
// F5 -> With a debugger
// CTRL + F5 without a debuffer

string name = typeof(Program).Namespace ?? "<null>";
//Since we're using top level statements, the namespace here will be displayed as null
Console.WriteLine($"Namespace: {name}");

int z;

Console.WriteLine("Value is {0}",1.0);

for  (z = 0; z < 10;z++)
{
    Console.WriteLine("Value of z ");
}

#region Three variables that store the number 2 million.

int decimalNotation= 2_000_000;
int binaryNotation = 0B_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x001E_8480;

#endregion

 