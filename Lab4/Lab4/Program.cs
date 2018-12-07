//  Task 2 - The four basic elements of the counter-controlled repetition are: the control variable (or loop counter),
//           the initial value, the increment, and the loop-continuation condition.
//           The initial value is the starting point of the control variable, the increment or deecrement causes an
//           increase or decrease in the control variable every time it loops, and the loop-continuation condition determines if
//           the code should continue looping or not.

// Task 3 - The "for" and "while" statements are amlost the same. They both produce the same outcome. The only difference 
//          is that a "for" statement is more condensed and formatted diferently than a "while" statement.

// Task 4 - A situation in which it would be more appropriate to use a "do...while" statement would be 
//          in a program that was made to check if a user's input was odd or even. For example, If the user inputs
//          an even number, a message is shown to inform the user that the input is inccorect. The program will continue
//          to show this message until the user inputs an odd number.

// Task 5
using System; 

public class program1
{
    static void Main(string[] args)
    {
        for (int i = 1; i < 101; i++)
        {
            Console.WriteLine(i);
            {
                if ((i % 2) == 0)
                { Console.WriteLine("Number is even"); }
                else if ((i % 2) != 0)
                {
                    Console.WriteLine("Number is odd");
                    Console.ReadLine();
                }
            }
        }
    }
}

// Task 6
public class program2
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a temperature: ");

        int temp = Convert.ToInt32(Console.ReadLine());

        if (temp >= 90) { Console.WriteLine("fish"); }

        else if (temp >= 80) { Console.WriteLine("Lion"); }

        else if (temp >= 70) { Console.WriteLine("Turtle"); }

        else if (temp >= 60) { Console.WriteLine("Deer"); }

        else if (temp >= 50) { Console.WriteLine("Reindeer"); }

        else if (temp >= 40) { Console.WriteLine("Moose"); }

        else if (temp >= 20) { Console.WriteLine("Penguin"); }

        else if (temp >= 10) { Console.WriteLine("Polar Bear"); }

        else { Console.WriteLine("Bug"); }
        Console.ReadLine();


    }
}

// Task 7
// the incorrect code had "int i = 10" and "while (i < 21)" also the incorrect code did not put "i++;" in it
// The correct code that displays 10-20 is:

public class program3
{
    static void Main(string[] args)
    {
        int i = 9;
        while (i < 20)
        {
            i++;
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}

// Task 8
// The incorrect code did not put brace brackets around the middle portion of the code
// The correct code to display every from number 0-100 seperated by a line with asterisks on it is:
    public class program4
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 101; i++)
        {
            Console.WriteLine(i);
            Console.WriteLine("********");
            Console.ReadLine();
        }
    }
}