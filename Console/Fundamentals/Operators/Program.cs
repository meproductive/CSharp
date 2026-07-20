/*  
    
    OPERATORS
    ------------------------------------------------------------------------------------------------------

    1. Arithmetic operators (+, -, *, /, %)

    int num1 = 2;
    int num2 = 8;

    int addition = num2 + num1;
    int subtraction = num2 - num1;
    int division = num2 / num1;
    int multiplication = num1 * num2;

    
    Console.WriteLine("output: " + addition); // output is 10
    Console.WriteLine($"output: {subtraction}"); // output is 6
    Console.WriteLine("output: {0} output: {1}", division, multiplication); // first output is 4, second output is 16
    Console.WriteLine("output: " + (num2 % num1)); // output is 0

    ------------------------------------------------------------------------------------------------------

    2. Assignment Operator (=)

    int number = 10;
    string name = "John";
    bool isActive = true;

    Console.WriteLine($"number: {number} name: {name} isActive: {isActive}");

    ------------------------------------------------------------------------------------------------------

    3. Compound Assignment Operators (+=, -=, *=, /=)

    int i = 10;
    
    i += 3; // i = i + 3; // output is 13
    i -= 3; // i = i - 3; // output is 10
    i *= 3; // i = i * 3; // output is 30
    i /= 3; // i = i / 3; // output is 3
    
    ------------------------------------------------------------------------------------------------------
    
    4. Increment and Decrement Operators (++, --)

    ------------------------------------------------------------------------------------------------------

    When increment and decrement operators are used as standalone statements, their returned values are not used, so pre and post versions produce the same result.

    Post-increment (x++) returns the old value and then increments the variable.
    Pre-increment (++x) increases the variable first, then returns the new value.

    int post = 12;

    Console.WriteLine(post++); // 12
    Console.WriteLine(post); // 13

    int pre = 60;

    Console.WriteLine(++pre); // 61
    Console.WriteLine(pre); // 61

    ------------------------------------------------------------------------------------------------------

    The difference can be observed when the returned value is used in:

    - Assignments
    - Method arguments
    - Output statements
    - Comparisons
    - Arithmetic expressions
    
    The difference becomes visible when the returned value of the expression is used by another operation.

    int ex = 5;
    
    int e = ex++; // assignment
    Console.WriteLine(ex++) // method argument
    if (ex++ > 5) // comparison
    int x = ex++ + 5; // arithmetic expression
 
    ------------------------------------------------------------------------------------------------------

    int postIncrease = 5;
    int postDecrease = 5;
    
    postIncrease++; // use current value, then increase by 1 - Post-increment
    postDecrease--; // use current value, then decrease by 1 - Post-increment

    Console.WriteLine($"post increase: {postIncrease} post decrease: {postDecrease}");

    int preIncrease = 50;
    int preDecrease = 50;

    ++preIncrease; // increase by 1 first, then use new value - Pre-increment
    --preDecrease; // decrease by 1 first, then use new value - Pre-increment

    Console.WriteLine($"pre increase: {preIncrease} pre decrease: {preDecrease}");

    ------------------------------------------------------------------------------------------------------
    
    int a = 20;
    int b = a++;
    Console.WriteLine($"a: {a} b: {b} - Post-increment"); // a: 21 b: 20
    // the current value of 'a' is assigned to 'b' first, then 'a' is increased by 1.
    

    int c = 30;
    int d = ++c;
    Console.WriteLine($"c: {c} d: {d} - Pre-increment"); // c: 31 d: 31
    // 'c' is increased by 1 first, then the new value of 'c' is assigned to 'd'.

    ------------------------------------------------------------------------------------------------------

    5. Comparison Operators (>, <, >=, <=, ==, !=)

    int age = 20;
    
    Console.WriteLine(age == 20); // True
    Console.WriteLine(age != 20); // False
    Console.WriteLine(age > 20); // False
    Console.WriteLine(age >= 20); // True
    Console.WriteLine(age < 20); // False
    Console.WriteLine(age <= 20); // True

    ------------------------------------------------------------------------------------------------------

    6. Logical Operators (&&(AND), ||(OR), !(NOT))

    bool isActive = true;
    bool isRun = false;
    
    Console.WriteLine(isActive && isRun);
    Console.WriteLine(isActive || isRun);
    Console.WriteLine(!isActive); // False

    1. && AND

    condition 1     condition 2     result
        0               0              0
        1               0              0
        0               1              0
        1               1              1

    2. || OR

    condition 1     condition 2     result
        0               0              0
        1               0              1
        0               1              1
        1               1              1

    3. ! NOT
    
    bool isTrue = true;
    bool isFalse = false;
    
    Console.WriteLine(isTrue); // True
    Console.WriteLine(!isTrue); // False
    Console.WriteLine(isFalse); // False
    Console.WriteLine(!isFalse); // True;
    
    ------------------------------------------------------------------------------------------------------

    7. Ternary Operator (?(IF), :(ELSE))
    
    int balance = 50000000; // 50m
    
    string result = balance >= 100000000 //100m
        ? "rich" // if balance is equal or bigger than 100m then rich
        : "poor"; // else poor

    Console.WriteLine(result);

    ------------------------------------------------------------------------------------------------------

    8. Null-Coalescing and Null-Coalescing Assignment Operators (??, ??=)

    string? name_ = null;

    string username = name_ ?? "Guest";

    Console.WriteLine(username) // output is "Guest"

    string? _name = null;
    
    _name ??= "Guest"

    Console.WriteLine(_name); // output is "Guest"

 */