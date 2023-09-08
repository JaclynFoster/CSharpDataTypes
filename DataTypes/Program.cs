namespace DataTypes;

class Program

{
    //constants as fields are immutable and cannot change throughout the program
    const double pi = 3.14159265;
    const int weeks = 52;
    const int months = 12;
    const string birthday = "February";

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
       

        //variable and method args are camel case and classes and methods are pascal case
        //use Nouns for classes and Verbs for methods

        //Explicit Conversion:
        double myDouble = 13.37;
        int myInt;
        //cast double to int
        myInt = (int)myDouble;
        Console.WriteLine(myInt);
        Console.Read();

        //Implicit Conversion:
        int anyNum = 3456789;
        int bigNum = anyNum;

        float myFloat = 13.57f;
        double myNewDouble = myFloat;

        //Type Conversion:
        string myString = myDouble.ToString(); //"13.37"
  
        string myFloatString = myFloat.ToString();
        Console.WriteLine(myFloatString);
        Console.Read();

        bool sunIsShining = true;
        string boolString = sunIsShining.ToString();
        Console.WriteLine(boolString);
        Console.Read();

        //Parse string into an int
        string myNumString = "12";
        string mySecondString = "22";
        int myNumInt = Int32.Parse(myNumString);
        int myNumSecondString = Int32.Parse(mySecondString);
        int intResult = myNumInt + myNumSecondString;
        string result = myNumString + mySecondString;
        Console.WriteLine(intResult);
        Console.Read();

        string stringForFloat = "0.85"; // datatype should be float
        string stringForInt = "12345"; // datatype should be int
        float floatString = float.Parse(stringForFloat);
        int intString = Int32.Parse(stringForInt);
        Console.WriteLine("Parsed Float: " + floatString + "Parsed Int: " + intString);
        Console.Read();

        //String Manipulation:

        int myAge = 34;
        string myFirstName = "Jaclyn";
        string myJob = "Developer";

        //1. String Concatenation:
        Console.WriteLine("Hello my name is " + myFirstName + " and I am " + myAge + " years old.");
        //2. String Formatting: Uses the Index
        Console.WriteLine("Hello my name is {0}, and I am {1} years old. I am a {2}.", myFirstName, myAge, myJob);
        //3. String Interpolation:
        Console.WriteLine($"Hello my name is {myFirstName} and I am {myAge} years old.");
        //4. Verbatim Strings: Use @ and tells compiler to take string literally ignoring spacing & escape characters like /n
        //useful for paths on your machine liek C:\Users\Admin 
        Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt
        ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut
        aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu
        fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit
        anim id est laborum.");


        //String Methods:
        //SubString(int32) - used to get the substring from the string starting from the specified index;
        //ToLower() - To Lowercase
        //ToUpper() - To Uppercase
        //Trim() - trim whitespace
        //indexOf(string) - get first occurrence of of the string
        //IsNullOrWhiteSpace()

        //String.Format: Used to insert the object or variable name inside any string
        //We can replace the value in the specified format
        //var nameExample = "Chris";
        //String.Format("My name is {0}", nameExample);

        //Var Keyword:implicitly typed local variables
        var varNumber = 0;
        var text = "text";
        var isTrue = true;
        Console.ReadKey();//blocks program from stopping or finishing
    }

}

