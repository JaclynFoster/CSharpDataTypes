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

        Console.Read();
    }
}

