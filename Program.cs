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

            Console.WriteLine("Hello World!");
        }
    }
}
