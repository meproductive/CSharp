/*

    VARIABLES
    ------------------------------------------------------------------------------------------------------
    
    Variables are case-sensitive in C#. This means "myVariable" and "MyVariable" are treated as different identifiers.
    If you define a variable as "myVariable" and try to access it as "MyVariable", it will result in a compile-time error.
    
    A variable can hold a single value at a time, and it must be declared before use.
    
    ------------------------------------------------------------------------------------------------------
    
    Naming Rules:
    
    Rule 1 - Variable names cannot start with a number.
    
    Rule 2 - Variable names cannot contain special characters (except underscore "_").
    
    Rule 3 - Spaces are not allowed in variable names.

    Rule 4 - Reserved keywords cannot be used as variable names unless they are prefixed with "@" (not recommended to use unless it is strictly necessary).
    
    Usage Examples:    
    ------------------------------------------------------------------------------------------------------
    
    Valid examples: num1, _num, num_, hello_world
    
    Invalid examples: 1num, !num, num!, hello!world, hello world
    
    ------------------------------------------------------------------------------------------------------
    
    Data Types in C#
    
    1. Integer Types
    
    Type            Size        Range
    
    ------------------------------------------------------------------------------------------------------
    
    sbyte           1 byte      -128 -> 127
    
    byte            1 byte      0 -> 255
    
    short           2 bytes      -32,768 -> 32,767
    
    ushort          2 bytes      0 -> 65,535
    
    int             4 bytes      -2,147,483,648 -> 2,147,483,647
    
    uint            4 bytes      0 -> 4,294,967,295
    
    long            8 bytes      -9,223,372,036,854,775,808 -> 9,223,372,036,854,775,807
    
    ulong           8 bytes      0 -> 18,446,744,073,709,551,615
    
    Note:
    - "u" in ushort, uint, ulong and uint stands for "unsigned"
    
    ------------------------------------------------------------------------------------------------------
    nint / nuint (Native Integer Types) - These types are platform dependent.
    ------------------------------------------------------------------------------------------------------
    
    - On a 32-bit system:
    
    nint            4 bytes      -2,147,483,648 -> 2,147,483,647
    
    nuint           4 bytes      0 -> 4,294,967,295
    
    - On a 64-bit system:
    
    nint            8 bytes      -9,223,372,036,854,775,808 -> 9,223,372,036,854,775,807
    
    nuint           8 bytes      0 -> 18,446,744,073,709,551,615
    
    Note:
    - nint is the native signed integer type.
    - nuint is the native unsigned integer type.
    
    ------------------------------------------------------------------------------------------------------
    
    2. Floating Point Types
    
    Type            Size        Precision           Common Usage                            Suffix
    
    ------------------------------------------------------------------------------------------------------
    
    float           4 bytes     ~7 digits           General floating-point values           f or F
    
    double          8 bytes     ~15-16 digits       Most common floating-point type         d or D(optional)
    
    decimal         16 bytes    ~28-29 digits       Financial and monetary values           m or M
    
    ------------------------------------------------------------------------------------------------------
    
    3. Text Types
    
    Type            Size                                    Range
    
    ------------------------------------------------------------------------------------------------------
    
    string          String is a reference type.             Sequence of characters
                    Its size depends on the content         
                    length and runtime overhead.              
                    
    
    char            2 byte                                  Single character
    
    ------------------------------------------------------------------------------------------------------
    
    4. Boolean Type
    
    Type            Size                            Values              Default Value
    
    ------------------------------------------------------------------------------------------------------
    
    bool            1 byte (Logical size)           true / false        false
                    (CLR implementation may
                    vary internally)
    ------------------------------------------------------------------------------------------------------

*/


#region Default values
/*
    Fields and array elements are automatically initialized to their default values. Local variables are not
    automatically initialized and must be assigned before use.
    
    int -> 0
    float -> 0f
    double -> 0d
    decimal -> 0m
    char -> '\0'
    bool -> false
    string -> null
 
 */

#endregion

#region Naming Conventions - camelCase, PascalCase

/*
 
    - Local Variables
    camelCase -> userAge, firstName, isActive, productPrice
    
    - Classes
    PascalCase -> ClassesStudent, EmployeeManager
    
    - Properties
    PascalCase -> PostalCode, SecondName, TotalPrice
    
    - Methods
    PascalCase -> CalculateArea(), GetName()
    
    - Constants 
    PascalCase -> Pi
       
*/

#endregion

#region Variable examples

string language = "English";
//string language = "English"; // CANNOT redeclare in the same scope

string Language = "English"; //*Initial letter is uppercase thus it is treated as different identifier

int age = 25;
float price = 19.99f;
char letter = 'A';
bool isCorrect = true;
string name = "John";

// Constant
const double Pi = 3.14;

// Pi = 3; // Cannot reassign to a constant

Console.WriteLine(Pi);

#endregion

#region Assignment vs Declaration

int i; // declaration

i = 1; // assignment

int j = 2;  // declaration + assignment

string identity = "someone"; // declaration + assignment

identity = "second someone"; // reassignment

Console.WriteLine(identity); // output is second someone

#endregion

#region Multiple Declaration

int x = 1, y = 2, z = 3;

int l, n, v;

l = 1; n = 2; v = 3;

#endregion

#region Behavior Examples 

float num = 12.5f;
float num2 = 1.2345678f;

float f = 27.5f; // float requires suffix 'f' 

double d = 27.5; // double is default floating-point type

decimal m = 27.5m;  // decimal requires suffix 'm'

double num3 = 12.5; // valid
double num4 = 12.5d; // valid

float precisionLoss = 1.0f / 3.0f;
Console.WriteLine(precisionLoss); // output is 0.33333334 - Precision loss

float maxFloatRange = float.MaxValue * 2;
Console.WriteLine(maxFloatRange); // output is Infinity due to overflow

decimal balance = 0.1m + 0.2m;
Console.WriteLine(balance); // output is 0.3 - Stable precision

int maxIntRange = int.MaxValue;
maxIntRange = maxIntRange + 1; // overflow, in unchecked context the value wraps around to int.MinValue
Console.WriteLine(maxIntRange);

#endregion

#region Escape Characters

// \a -> alert, bell
// \b -> backspace
// \f -> form feed
// \n -> new line
// \r -> carriage return
// \t -> horizontal tab
// \v -> vertical tab
// \' -> single quote
// \" -> double quote
// \\ -> backslash

Console.Write("This is C#\nprogramming\n");
Console.WriteLine("This is C#\tprogramming");

#endregion

#region Variable Scope

{
    int a = 1; // a variable declared inside the scope cannot be accessed outside of the scope
}
// Console.WriteLine(a); // invalid - the name 'a' doesn't exist in the current context

//{ // uncomment it to see and check the variable below in the another scope
int b = 1; // a variable declared before the scope can be accessed inside and outside of the scope
{
    Console.WriteLine(b); // valid
}
Console.WriteLine(b); // valid
//} // uncomment it to see and check the variable below in the another scope

{

    {
        //int b = 1; // first only uncomment this variable, before curly braces above, and you'll see 'b' is invalid then uncomment curly braces to see, check below why this is invalid:

        // A VARIABLE CANNOT BE REDECLARED INSIDE A NESTED SCOPE, IF IT ALREADY EXISTS IN AN OUTER LOCAL SCOPE.
    }

}

{
    int a = 1;

    {
        Console.WriteLine(a);
        int c = 1;
    }
    //Console.WriteLine(a + c); // 'a' is valid, declared above outside of the scope but 'c' is declared inside the scope and cannot be accessed outside thus invalid - the name 'c' doesn't exist in the current context
}

#endregion

#region var Keyword

// the compiler automatically determines the type based on the assigned value

var number = 10;
var text = "Hello";

// number = "Hello"; // reassignment is invalid because compile-time type is int

Console.WriteLine(number.GetType()); // System.Int32
Console.WriteLine(text.GetType()); // System.String

// var requires initialization
// var value; - invalid
// var value = null - invalid

#endregion