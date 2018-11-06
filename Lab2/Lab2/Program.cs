// task 2
// Displaying the product of two numbers input from the keyboard.
using System;

public class Multiplication
{
    public static void Main(string[] args)
    {
        int number1;
        int number2;
        int product;

        Console.Write("Enter first interger: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second interger: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        product = number1 * number2;

        Console.WriteLine("Product is {0}", product);
        Console.ReadKey();
    }
}

// task 3
// Adding a single Console.WriteLine statement that outputs Hello World! (new line) From [Your Name]

public class Hello
{
    public static void Main(string[] args )
    {
        Console.WriteLine( "{0}\n{1}", "Hello World!", "From Charlie");
        Console.ReadKey();
    }
}

// task 4
// Adding an output statement that outputs two phrases with a tab in between

    public class Hello2
{
    public static void Main(string[] args )
    {
        Console.WriteLine( "{0}\t{1}", "Hello World!", "From Charlie");
        Console.ReadKey();
    }
}
// task 5
// answering questions 

// a. Main method begins execution of C# console application
// b. an interger is a number without a decimal point and floats and doubles have decimal points
// c. An example of a method from chapter four is the SetName Method
// d. get and set
// e. an object is an instance of a class and we can create only one instance of a class









