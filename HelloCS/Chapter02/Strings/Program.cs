// Char uses a single quote ''
char letter = 'A';
char digit = '1';
char symbol = '$';
char userChouse = GetChar(value);

// Strings
// While strings uses double quotes ""
string firstName = "Bob";
string lastName = "Smith";
string phoneNumber = "67999999999";

// Assign string returned from a class constructor
string horizontalLine = new('_', 2);

// and so on

// When we're working with file paths, we need to pay attention with the types:
// string filePath = "C:\televisions\sony\bravia.txt"; this will not compile, while:
// Verbatim string will disable escape characters to that a backlash is a backlash
string filePath = @"C:\televisions\sony\bravia.txt"; // will. We just need to use @ symbol when using filepaths

// in c# 11+ we can have raw string literals, example:
// Interpolated string will enable embedded formatted variables
string xml = """
     <person age="50">
        <first_name>Mark</first_name>
     </person>
     """;

// This way we can maintain XML, HTML or JSON formated. Take notice in the spacing

/*
 
string xml = """
123456<person age="50">
        <first_name>Mark</first_name>
123456</person>
123456"""; when the compiler sees this spacing, it will remove it from all lines, and the output will be  
 

<person age="50">
    <first_name>Mark</first_name>
</person>

*/

//We can also deal with string interpolation, as follwos with the JSON example

var person = new { FirstName = "Aline", Age = 56 };

string json = $$"""
                {
                "first_name": "{{person.FirstName}}",
                "age": {{person.Age}},
                "calculation":"{{{1 + 2}}}"
                }
                """;

Console.WriteLine(json);
