using System;

namespace my_first_app
{
    class Program
    {
        static void Main(string[] args)
        {

            // Number 1

sbyte @sbyte = 97;
sbyte @sbyte1 = 52;
sbyte @sbyte2 = 112;
sbyte @sbyte3 = -44;
sbyte @sbyte4 = -115;

byte @byte = 224;
byte @byte1 = 130;

short @short = -10000;
short @short1 = 20000;
short @short2 = 1990;

ushort @ushort = 52130;
ushort @ushort1 = 224;
ushort @ushort2 = 1990;
ushort @ushort3 = 112;
ushort @ushort4 = 52;
ushort @ushort5 = 97;

int @int = 52;
int @int1 = 130;
int @int2 = 97;
int @int3 = 112;
int @int4 = 224;
int @int5 = 1990;
int @int6 = 20000;
int @int7 = -10000;
int @int8 = -115;
int @int9 = 4825932;
int @int10 = 970700000;
int @int11 = -1000000;

uint @uint = 52;
uint @uint1 = 130;
uint @uint2 = 97;
uint @uint3 = 112;
uint @uint4= 224;
uint @uint5 = 1990;
uint @uint6 = 20000;
uint @uint7 = 4825932;
uint @uint8 = 970700000;


long @long = 123456789123456789;
long @long1 = 52;
long @long2 = 130;
long @long3 = 97;
long @long4 = 112;
long @long5 = 224;
long @long6 = 1990;
long @long7 = 20000;
long @long8 = -10000;
long @long9 = -115;
long @long10 = 4825932;
long @long11 = 970700000;
long @long12 = -1000000;

ulong @ulong = 123456789123456789;
ulong @ulong1 = 52;
ulong @ulong2 = 130;
ulong @ulong3 = 97;
ulong @ulong4 = 112;
ulong @ulong5 = 224;
ulong @ulong6 = 1990;
ulong @ulong7 = 20000;
ulong @ulong8 = 4825932;
ulong @ulong9 = 970700000;

Console.WriteLine("Sbyte Minimun: " + SByte.MinValue  + " Sbyte Maximum: " + SByte.MaxValue);
Console.WriteLine("Byte Minimun: " + Byte.MinValue  + " Byte Maximum: " + Byte.MaxValue);
Console.WriteLine("Short Minimun: " + short.MinValue  + " Short Maximum: " + short.MaxValue);
Console.WriteLine("UShort Minimun: " + ushort.MinValue  + " Ushort Maximum: " + ushort.MaxValue);
Console.WriteLine("Int Minimun: " + Int32.MinValue  + " Int Maximum: " + Int32.MaxValue);

Console.WriteLine("UInt Minimun: " + uint.MinValue  + " UInt Maximum: " + uint.MaxValue);
Console.WriteLine("Long Minimun: " + Int64.MinValue  + " Long Maximum: " + Int64.MaxValue);
Console.WriteLine("Ulong Minimun: " + ulong.MinValue  + " Ulong Maximum: " + ulong.MaxValue);



//Number 2

float @float = 5;

double @double = -5.01;
double @double1 = 5;
double @double2 = 34.567839023;
double @double3 = 12.345;
double @double4 = 8923.1234857;
double @double5 = 3456.091124875956542151256683467;

decimal @decimal1 = 5;

Console.WriteLine("Float Minimum: " + float.MinValue + " Float Maximum: " + float.MaxValue);
Console.WriteLine("Double Minimum: " + Double.MinValue + " Double Maximum: " + Double.MaxValue);
Console.WriteLine("Decimal Minimum: " + Decimal.MinValue + " Decimal Maximum: " + Decimal.MaxValue);

  

    

   // calculator
   
   Console.WhiteLine("Console bassed calculator\n");
Console.WriteLine("========================");

bool continueCalculating = true;

while (continueCalculating)
{
  Console.WriteLine("Enter your first number: ");
  string? firstInput = Console.ReadLine();
  if (firstInput == null)
  {
    Console.WriteLine("First input cannot be null.");
    return;
  }
  double number1 = double.Parse(firstInput);

  Console.WriteLine("Enter the second number: ");
  string? secondInput = Console.ReadLine();
  if (secondInput == null)
  {
    Console.WriteLine("Second input cannot be null.");
    return;
  }
  double number2 = double.Parse(secondInput);

  Console.WriteLine("Choose an operation (multiply, divide, subtract, add, exponent, modulo) ");
  string? operation = Console.ReadLine().ToLower();

  switch (operation)
  {
    case "multiply":
      Console.WriteLine($"Result: {Math.Round(number1 * number2, 2)}");
      break;
    case "divide":
      if (number2 != 0)
        Console.WriteLine($"Result: {Math.Round(number1 / number2, 2)}");
      else
        Console.WriteLine("Error: Division by zero is not allowed.");
      break;
    case "subtract":
      Console.WriteLine($"Result: {Math.Round(number1 - number2, 2)}");
      break;
    case "add":
      Console.WriteLine($"Result: {Math.Round(number1 + number2, 2)}");
      break;
    case "exponent":
      Console.WriteLine($"Result: {Math.Round(Math.Pow(number1, number2), 2)}");
      break;
    case "modulo":
      if (number2 != 0)
      {
        Console.WriteLine($"Result: {number1 % number2}");
      }
      else
      {
        Console.WriteLine("Error: Modulo by zero is not allowed.");
      }
      break;
    default:
      Console.WriteLine("Error: Unsupported operator. Please use 'multiply', 'divide', 'subtract', or 'add'.");
      break;
  }
  Console.WriteLine("Would you like to perform another calculation? (yes to continue, no to exit): ");
  string? response = Console.ReadLine()?.Trim().ToLower();

  if (response != "yes")
  {
    Console.WriteLine("Thank you for using the calculator. Goodbye!");
    break;
    string firstNameGivenByMyFather = "Adekunle";
            string lastName = "Rabiu";
            string fullName = firstNameGivenByMyFather + " " + lastName;

            /////////////////////////// ////////  TYPE CASTING OR CONVERSION/////////////////////////////////////////
            string i = 6.ToString(); // This is explicit casting because value type have to be casted authomatically to string
            object j = i;  // This implicit casting becasue it cast authomatically (1.e does not required manual casting)
            Console.WriteLine(fullName, i);
            int k  = 5;
            long l = k; // This is implicit casting
            double n = 2.5;
            l = (long)n; // This is explicit casting 
            l = Convert.ToInt64(n); // This is the other was of doing explicit casting
            

            //TYPE OF CASTING 
             //implicit conversion;
             //explicit conversion;
            //conversion to or from string;

            // Implicit Type Conversion – Examples
            int myInt = 5;
            Console.WriteLine(myInt); // 5
            long myLong = myInt;
            Console.WriteLine(myLong); // 5
            Console.WriteLine(myLong + myInt); // 10


            // Explicit Type Conversion – Example
            double myDouble = 5.1d;
            Console.WriteLine(myDouble); // 5.1
            long myLong1 = (long)myDouble;
            Console.WriteLine(myLong1); // 5
            myDouble = 5e9d; // 5 * 10^9
            Console.WriteLine(myDouble); // 5000000000
            int myInt1 = (int)myDouble;
            Console.WriteLine(myInt1); // -2147483648
            Console.WriteLine(int.MinValue); // -2147483648
            long myLong2 = long.MaxValue;
            int myInt2 = (int)myLong2;
            Console.WriteLine(myLong2); // 9223372036854775807
            Console.WriteLine(myInt2); // -1

            float heightInMeters = 1.74f; // Explicit conversion
            double maxHeight = heightInMeters; // Implicit
            double minHeight = (double)heightInMeters; // Explicit
            float actualHeight = (float)maxHeight; // Explicit
            //float maxHeightFloat = maxHeight; // Compilation error!

            int a = 5;
            int b = 7;
            string sum = "Sum = " + (a + b);
            Console.WriteLine(sum);
            String incorrect = "Sum = " + a + b;
            Console.WriteLine(incorrect);
            Console.WriteLine(
            "Perimeter = " + 2 * (a + b) + ". Area = " + (a * b) + ".");



            // EXPRESSION
            int r = (150-20) / 2 + 5;
            // Expression for calculating the surface of the circle
            double surface = Math.PI * r * r; // Pi r^2
            // Expression for calculating the perimeter of the circle
            double perimeter = 2 * Math.PI * r; // 2 Pi r
            Console.WriteLine("Radius = " + r);
            Console.WriteLine("Area of a circle = " + surface);
            Console.WriteLine("Perimeter Of a circle = " + perimeter);

            int a1 = 5;
            int b1 = ++a1;
            Console.WriteLine(a1); // 6
            Console.WriteLine(b1); // 6

            int num = 1;
            double denum = 0; // The value is 0.0 (real number)
            int zeroInt = (int) denum; // The value is 0 (integer number)
            Console.WriteLine(num / denum); // Infinity
            Console.WriteLine(denum / denum); // NaN
            Console.WriteLine(zeroInt / zeroInt); // DivideByZeroException

            double incorrect1 = (double)((1 + 2) / 4);
            Console.WriteLine(incorrect1); // 0

            double correct = ((double)(1 + 2)) / 4;
            Console.WriteLine(correct); // 0.75
            Console.WriteLine("2 + 3 = " + 2 + 3); // 2 + 3 = 23
            Console.WriteLine("2 + 3 = " + (2 + 3)); // 2 + 3 = 5




  }
} }
    }
}
