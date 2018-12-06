//     Task 2
//     In a single-selection statement if the number is true then the command gets executed,
//     but if it is false than the command is ignored and next line of code gets executed.
//     In a while repetition statement as long as the statement is true, the loop will execute until the condition becomes false.
//     The main difference between the single-selection and the while repetition statement is that the single-selection statement 
//     only does what its told to do if the condition is true,  in a while repetition statement the line of code gets executed over 
//     and over until the condition becomes false, then it terminates. The main similarity is that the both evaluate to true or false.
using System;

//task 3
public class Program1
{
    
        static void Main(string[] args)
        {
            int speedLimit;
            int speed;

            speedLimit = 35;
            speed = 42;

            if (speed > speedLimit)
                Console.WriteLine("SLOW NOW");
            Console.ReadLine();

        }
    
}

// task 4

public class program2
{

    static void Main(string[] args)
    {
        int isTrue = 10;

        if ( isTrue >= 50 )
            Console.WriteLine("It is True!");
        else
        Console.WriteLine("It is False!");
        Console.ReadLine();


    }
}

// task 5

    public class program3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        double Celsius = (fahrenheit - 32d) * 5d / 9d;
        Console.WriteLine("Temperature in Celsius is {0}: ", Celsius);
        Console.ReadLine();

        if (fahrenheit >= 90)
            Console.WriteLine("It is hot");
        if (fahrenheit <= 40)
            Console.WriteLine("It is cold");
        Console.ReadLine();

    }
}

// Task 6

    public class program4
{
    static void Main(string[] args)
    {
        int a = 1;
        while (a<11)
        {
            Console.Write("Value: ");
            Console.WriteLine(a); a++;
            Console.ReadLine();
        }
    }
}

//Task 7

    public class program5
{
    static void Main(string[] args)
    {
        int a = 60;
        while (a >= 20)
        {
            Console.WriteLine("Value: ");
            Console.WriteLine(a); a-= 5;
            Console.ReadLine(); 

        }


    }
}

//Task 8

    public class program6
{
    static void Main(string[] args)
    {
        int a = 10;
        while (a <= 20)
        {
            Console.Write("Value: ");
            Console.WriteLine(a); a++;
            Console.ReadLine();
        }
    }
}

