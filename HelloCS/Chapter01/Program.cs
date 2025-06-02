// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// We can start the application with a debugger attached or not. When starting without it will consume less resources
// F5 -> With a debugger
// CTRL + F5 without a debuffer

string name = typeof(Program).Namespace ?? "<null>";
//Since we're using top level statements, the namespace here will be displayed as null
Console.WriteLine($"Namespace: {name}");