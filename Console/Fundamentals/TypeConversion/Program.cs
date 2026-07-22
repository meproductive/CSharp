/*

   TYPE CONVERSION(CASTING)
   ------------------------------------------------------------------------------------------------------
   What is Type Conversion(Casting)? Type Conversion is the process of converting a value from one data type to another. For example, we can convert an int type to long or convert text into a numeric value.

   ------------------------------------------------------------------------------------------------------
   1. Implicit Conversion

   Implicit conversion (automatic conversion) is performed automatically by the C# compiler and the compiler guarentees that conversion is safe. However, some implicit conversions may result in a loss of precision, as shown in the example below.

   For instance: 

   int x = 123456789;
   float y = x;
   Console.WriteLine(y); // output is 123456790, precision loss occurs because float has ~7 digits precision.

   int num = 50;
   double num2 = num; // output is 50, implicitly converted

   int num3 = 10;
   long num4 = num3; // output is 10, implicitly converted

   Console.WriteLine($"{num2} {num4}");

   ------------------------------------------------------------------------------------------------------

   An implicit conversion occurs when a value is assigned from a type with a smaller range to a type with a larger range.

   Implicit conversions are available between compatible signed types and compatible unsigned types.

   Common implicit conversions for signed numeric types:
   sbyte -> short -> int -> long -> float -> double -> decimal

   Common implicit conversions for unsigned numeric types:
   Unsigned types: byte -> ushort -> uint -> ulong

   This is a conceptual progression starting from the byte to demonstrate how numeric types can widen step by step. It does not represent direct implicit conversions between every adjacent type in the sequence.
   byte -> short -> ushort -> int -> uint -> long -> ulong -> float -> double -> decimal

   Note: This does not mean that every data type can be implicitly converted to the next data type in the list. This list shows common widening conversions from smaller numeric data types, as shown in the example below.

   // Valid examples

   byte b = 10;

   short s = b;
   ushort us = b;
   int i = b;
   uint ui = b;
   long l = b;
   ulong ul = b;
   float f = b;
   double d = b;
   decimal dec = b;   
   Console.WriteLine(dec); // output is 10

   byte b2 = 10;
   ushort us4 = b2;
   Console.WriteLine($" implicitly converted: {us4}"); // output is 10

   // Invalid examples

   short s2 = 10;
   ushort us2 = s2; // invalid cannot implicitly convert type short to ushort

   // Valid but explicit casting required
   short s3 = 10;
   ushort us3 = (ushort)s3; // explicit conversion required

   Console.WriteLine($" explicitly converted: {us3}");

   ------------------------------------------------------------------------------------------------------

   Floating-point types support implicit conversion from smaller numeric types:
       float -> double (float can be implicitly converted to double, but double cannot be implicitly converted to float because double has a larger range.) 
       Integral types(byte, short, int, etc) -> float or double

   float num5 = 3.14f;
   double num6 = num5; // output is 3.14, implicitly converted
   Console.WriteLine(6);

   double num7 = 53.15;
   float num8 = num7;
   Console.WriteLine(num8); // invalid: cannot implicitly convert double type to float

   Numeric types cannot be implicitly converted char. Also char types cannot be implicitly converted to numeric types.        

   // Invalid Example

   int number = 3;

   char letter = number; // Compile-time error: numeric types cannot be implicitly convert to char.

   ------------------------------------------------------------------------------------------------------

   2. Explicit Conversion

   double num3 = 12.3;
   int num4 = (int)num3;

   Console.WriteLine(num4); // output is 12 (truncated)

   ------------------------------------------------------------------------------------------------------

   3. Boxing / Unboxing

   Boxing converts a value type reference into a reference type (object).
   Unboxing extracts the value type from a boxed object.

   // Boxing

   int number = 10;

   object boxing = number;

   Console.WriteLine(boxing);

   // Unboxing

   int unboxing = int(boxing);

   Console.WriteLine(unboxing);


   ------------------------------------------------------------------------------------------------------
   4. ToString Method

   int num3 = 5;
   string numToText = num3.ToString();

   Console.WriteLine(numToText);

   ------------------------------------------------------------------------------------------------------

   5. Parse Method

   string textNum = "10"; // string value must contain a valid number
   int num = int.Parse(textNum);

   Console.WriteLine(num);

   ------------------------------------------------------------------------------------------------------

   6. TryParse

   string textNum1 = "5";

   bool isSuccess = int.TryParse(textNum1, out int num8);

   Console.WriteLine(isSuccess); // True
   Console.WriteLine(num8); // output is 5

   ------------------------------------------------------------------------------------------------------

   7. Convert Class

   string textNum2 = "15";

   int num9 = Convert.ToInt32(textNum2); // returns 0 if the value is null

   Console.WriteLine(num9); // output is 15


*/
int itemCount = 42;
long widened = itemCount; // Implicit conversion.

double average = 19.75;
int truncated = (int)average; // Explicit cast.

Console.WriteLine($"widened: {widened}, truncated: {truncated}");