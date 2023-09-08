namespace DataTypes;

class Program
{
    static void Main(string[] args)
    {   //declare multiple values at once
        int num3, num4, num5;
        //declaring variable
        int num1;

        //assigning a value to variable
        num1 = 13;

        int num2 = 23;
        long myLongNum = 12345678910;

        int sum = num1 + num2;
        Console.WriteLine("num is " + num1);
        //using concat
        Console.WriteLine("num1: " + num1 + "  num2: " + num2 + " is " + sum);

        //double
        double d1 = 3.1415;
        double d2 = 5.1;
        double dDiv = d1 / d2;
        Console.WriteLine("Double: " + dDiv);


        //float
        float f1 = 3.1415f;
        float f2 = 5.1f;
        float fDiv = f1 / f2;
        Console.WriteLine("fDiv: " + fDiv);

        double diDiv = d1 / num1;
 
        Console.WriteLine("diDiv: " + diDiv);


        //string- String is for class String and string is for variable
        string myName = "Jaclyn";
        string message = "My name is ";

        Console.WriteLine(message + myName);

        //string methods
        string capsMessage = message.ToUpper();

        string lowerMessage = message.ToLower();

        Console.WriteLine("Upper: " + capsMessage + "Lower: " + lowerMessage);
        Console.Read();

        //Value Types: store actual data directly,typically  stored in the stack
        //include float, int, long, double, char, bool, decimal, struct, enum & nullable versions
        //nullable versions declared with a queston mark ?
        //can be stored in heap if part of reference type

        //Reference Types: instead of storing the value in memory directly, stores the memory locationof the actual data
        //stores memory reference and not the data directly includes strings, classes, arrays , etc
        //When copying reference type of a data type t will copy the memory address of the data to have 2 variables
        //pointing to the same data

        Console.WriteLine("HELLO WORLD"); //prints the text and jumps to new line
        Console.Write("HELLO"); //prints the text in the same line
        Console.Write("WORLD");

        Console.Write("Enter a string and press Enter: ");
        string readInput = Console.ReadLine();
        Console.WriteLine("You have Entered{0}", readInput);
        Console.Write("Enter a string and press Enter: ");
        int asciiValue = Console.Read();
        Console.WriteLine("ASCII Value is {0}", asciiValue);
        Console.ReadKey();//blocks program from stopping or finishing

        //variable and method args are camel case and classes and methods are pascal case
        //use Nouns for classes and Verbs for methods

    }
}

