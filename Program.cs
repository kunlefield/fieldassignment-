using System;

namespace my_first_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" my name and id ");
            Console.WriteLine("Hello World!");


 

//Console.WriteLine(Fib(5));

 

float num1 = 12f; // output 12.0

 double num2 = 345; // 345.0

double num3 = 345d; // 345.0

decimal num4 = 56767m; // 56767.0

// Console.WriteLine(num1 + num2);

 

long num5 = 78963986982898991;

bool check = false;

bool check1 = true;

char character1 = 'a';

long num6 = 23564;

int num7 = Convert.ToInt32(Int32.MaxValue);

 

string name = "Mr Kunle";

int age = 30;

string country = "Nigeria";

string course = "Education";

string school = "LASU";

int companies = 3;

Console.WriteLine("My name is " + name + "," + "i am " +

     age + " years old" + " from " + country + " i studied " + course

     + " from " + school + " and i am currently working with " + companies

     + " companies");

 

int a = 1;

int b = 2;

// Which one is greater?

bool greaterAB = (a > b); // False

// Is 'a' equal to 1?

bool equalA1 = (a == 1); // True

// Print the results on the console

if (greaterAB)

{

     Console.WriteLine("A > B");  // greaterAB must be true to print this

}

else

{

     Console.WriteLine("A <= B"); // First

}

Console.WriteLine("greaterAB = " + greaterAB); // Second

Console.WriteLine("equalA1 = " + equalA1); // Third

 

 

// Declare a variable

char ch = '}';

// Print the results on the console

Console.WriteLine(

"The code of '" + ch + "' is: " + (int)ch);

ch = 'b';

Console.WriteLine(

"The code of '" + ch + "' is: " + (int)ch);

ch = 'A';

Console.WriteLine(

"The code of '" + ch + "' is: " + (int)ch);

 

object container1 = 5;

object container2 = "Five";

// Print the results on the console

Console.WriteLine("The value of container1 is: " + container1);

Console.WriteLine("The value of container2 is: " + container2);

 

bool check2 = false;

Console.WriteLine(Convert.ToInt32(check2));

string information = " Debit Alert\n\n Account Name\u003A \'Adebayo\' \\ \"Abdullahi\"  \n\n Account Number\u003A 1234***882\n\n Bank\u003A UBA \t\t Bank\n\n Amount\u003A #500\n\n Balance\u003A #1500";

Console.WriteLine(information);

 Console.WriteLine(" " +"\u04A7");

 Console.WriteLine(" " + "\u003A");

 

string path = "C:\\Windows\\Notepad.exe";

Console.WriteLine(path);

string verbatim = @"The \ is not escaped as \\.I am at a new line.";

// Console.WriteLine(verbat
// sbyte, byte, short, ushort, int, uint, long
// and ulong in order to assign them the following values: 52,130; -115;
// 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000;
// 1990; 123456789123456789.

 // Declare variable
 int num11 = 52;
 int num22 = 97;
 int num33 = 112;
 int num44 = 130;
 
Console.WriteLine($"{num11 + num22 + num33 + num44}");
 
 
 
int x = 'b';

  //Console.WriteLine(Fib(5));

            float num1 = 12f; // output 12.0 
            double num2 = 345; // 345.0
            double num3 = 345d; // 345.0
            decimal num4 = 56767m; // 56767.0
           // Console.WriteLine(num1 + num2);

            long num5 = 78963986982898991;
            bool check = false;
            bool check1 = true;
            char character1 = 'a';
            long num6 = 23564;
            int num7 = Convert.ToInt32(Int32.MaxValue);

            string name = "Mr Kunle";
            int age = 30;
            string country = "Nigeria";
            string course = "Education";
            string school = "LASU";
            int companies = 3;
            Console.WriteLine("My name is " + name + "," + "i am " + 
                age + " years old" + " from " + country + " i studied " + course
                + " from " + school + " and i am currently working with " + companies
                + " companies");

            int a = 1;
            int b = 2;
            // Which one is greater?
            bool greaterAB = (a > b); // False
            // Is 'a' equal to 1?
            bool equalA1 = (a == 1); // True
            // Print the results on the console
            if (greaterAB)
            {
                Console.WriteLine("A > B");  // greaterAB must be true to print this
            }
            else
            {
                Console.WriteLine("A <= B"); // First
            }
            Console.WriteLine("greaterAB = " + greaterAB); // Second
            Console.WriteLine("equalA1 = " + equalA1); // Third


            // Declare a variable
            char ch = '}';
            // Print the results on the console
            Console.WriteLine(
            "The code of '" + ch + "' is: " + (int)ch);
            ch = 'b';
            Console.WriteLine(
            "The code of '" + ch + "' is: " + (int)ch);
            ch = 'A';
            Console.WriteLine(
            "The code of '" + ch + "' is: " + (int)ch);

            object container1 = 5;
            object container2 = "Five";
            // Print the results on the console
            Console.WriteLine("The value of container1 is: " + container1);
            Console.WriteLine("The value of container2 is: " + container2);

            bool check2 = false;
            Console.WriteLine(Convert.ToInt32(check2));
            string information = " Debit Alert\n\n Account Name\u003A \'Adebayo\' \\ \"Abdullahi\"  \n\n Account Number\u003A 1234***882\n\n Bank\u003A UBA \t\t Bank\n\n Amount\u003A #500\n\n Balance\u003A #1500";
            Console.WriteLine(information); 
            Console.WriteLine(" " +"\u04A7"); 
            Console.WriteLine(" " + "\u003A"); 
            
            // Declare variable
            int i = 5;
            int j = 6;
            bool numberCheck = i < j;
            int addition = i + j; // Operarnd with addition
            int subtraction = i - j;
            int multiplication = i * j;
            int division = i / j;
            int getMoudle = 12 % 2;
            double realDivision = (double)i / (double)j;
            Console.WriteLine("Addition " + addition); // This is when the variables are added in another variable
            Console.WriteLine("Sutraction " + subtraction);
            Console.WriteLine("Multiplication " + multiplication);
            Console.WriteLine("Divition " + division);
            Console.WriteLine("RealDivisionValue " + realDivision);
            Console.WriteLine(numberCheck);
            Console.WriteLine((i + j) > (i - j));
            Console.WriteLine("Get Mouble " + getMoudle);
            if(getMoudle == 0)
            {
                Console.WriteLine("Check For even Even");
            }
            else
            {
                Console.WriteLine("Check For even Odd");
            }

            Console.WriteLine("Check For even " + (getMoudle == 0 ? "Even": "Odd"));

            
        int k = 5;
        int l = 4;
        Console.WriteLine(k + l); // 9
        Console.WriteLine(k + (l++)); // 9
        Console.WriteLine(k + l); // 10
        Console.WriteLine(k + (++l)); // 11
        Console.WriteLine(k + l); // 11
        Console.WriteLine(14 / k); // 2
        Console.WriteLine(14 % k); // 4
            //Console.WriteLine(k++);

            //Console.WriteLine(i + j); // This is when we called the variable staright in our console without storing it in another variable

            int x = 'a';
            x = 5;

            int? number_one = 5;
            int? ni = number_one;
            number_one = ni;

            
     // Declare a variable
               int  o = 18;
               int  p = 12;
               int  q =  4;
               
               
               Console.Whiteline("Addition" + o +  "addition" + p + "addtion" + q);

                
// / Number 1

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
// This is to compare correctly two real number to accuracy
int number c = 0.000001;
int numcer d = 0.000002;
//which one is greater (c > d);




// Number 3
intnum1 = 256;
intnumberInDec = 256;
intnumberInHex =
Console.Whiteline("NumberBase=256");
}
}
}
 










          

























