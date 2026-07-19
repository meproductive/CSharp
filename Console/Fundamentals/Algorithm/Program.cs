/*
    ALGORITHM
    ------------------------------------------------------------------------------------------------------
    
    What is an Algorithm?
    ------------------------------------------------------------------------------------------------------
    
    An algorithm is basically a set of steps followed to solve problems, complete tasks or achieve a specific goal. 
    Algorithms are implemented in programming languages to solve problems efficiently and systematically.
    
    Algorithms are not limited to programming. An algorithm can be used in everyday life situations, such as daily routine, completing a task etc.
    
    Algorithms are implemented in software used on our phones, computers and other devices. They are all powered by software.
    Software is written in different programming languages, each providing tools to solve problems efficiently.
    
    Imagine you are fixing a water pipe. Would you use a hammer or a pipe wrench? Perhaps not a hammer, 
    because it is not the right one for the job. A pipe wrench is designed for that task and allows you to work more efficiently. 
    Programming languages are similar. Each has its own strengths that make it better suited for certain types of problems.
    
    A good algorithm should be:
    
    - Well-defined: Each step should be clear, precise, and easy to understand.
    
    - Finite: It should have a clear beginning and end. Every possible execution path should eventually terminate.
    
    - Efficient: It should solve the problem without performing unnecessary operations or using excessive resources.

    - Correct: It should produce the expected result for every valid input.
    
    ------------------------------------------------------------------------------------------------------
    
    The Role of Algorithms in Daily Life and Programming:
    ------------------------------------------------------------------------------------------------------
    
    The role of algorithms in our daily life is to help us complete tasks, solve problems, make decisions 
    and achieve goals in a structured and efficient way.
    
    The role of algorithms in programming is similar. Algorithms help us to solve problems, organize program logic, 
    improve efficiency, and make software easier to maintain.
    
    ------------------------------------------------------------------------------------------------------
    
    Why is the Design of an Algorithm Important? 
    ------------------------------------------------------------------------------------------------------
    
    The way you design an algorithm can have a significant impact on how efficiently a problem is solved.
    
    Imagine you are looking for the Permutations chapter in a mathematics textbook.
    
    One approach is to turn pages one by one. You will most likely find the chapter, but it may take a long time.
    
    Another approach is to turn two pages at a time. This is faster, but there is a chance that you will 
    skip the page you are looking for.
    
    A better approach is to use the table of contents. It tells you approximately where the chapter is, 
    allowing you to go directly to the section with far fewer page turns. This is similar to using a search filter on a website. 
    It helps you narrow down the results instead of checking everything one by one.
    
    This example shows that different algorithms can solve the same problem, but some are much more efficient than others. 
    Choosing the right algorithm is often just as important as writing code itself.
    
    ------------------------------------------------------------------------------------------------------
    
    Daily Life Algorithm Example:
    ------------------------------------------------------------------------------------------------------
    
    1 - Start
    
    2 - Choose a tool
        - Hammer
        - Pipe wrench
    
    3 - Fix the water pipe
        - Can you fix it with the chosen tool?
        - Yes -> go to step 4
        - No -> go to step 2
    
    4 - Clean up
    
    5 - Put tools back
    
    6 - End
    
    ------------------------------------------------------------------------------------------------------
    
    Programming Algorithm Example:
    ------------------------------------------------------------------------------------------------------
    
    Task:
    We want to write a program that prints all even numbers from 0 through 100.
    
    Solution:
    We need to iterate from 0 through 100 and determine whether the number is even. If a number is divisible by 2, print it.
    
    Algorithm:
    - Start from 0
    - Continue up to and including 100
    - Check if the number is divisible by 2
    - If true, print the number
    
    ------------------------------------------------------------------------------------------------------
    Pseudocode:
    ------------------------------------------------------------------------------------------------------
    
    START
    
    FOR number = 0 to 100
        IF number MOD 2 == 0 THEN
            PRINT number
        END IF
    END FOR
    
    END
    
    ------------------------------------------------------------------------------------------------------
    C# Code:
    ------------------------------------------------------------------------------------------------------
    
    for (int i = 0; i <= 100; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
    
    ------------------------------------------------------------------------------------------------------
    
    Implementing a Real-World Algorithm in a Programming Language:
    ------------------------------------------------------------------------------------------------------
    
    Algorithm:
    ------------------------------------------------------------------------------------------------------
    1 - Ask the user to enter their age.
    
    2 - Check whether the input is a valid integer.
        - If it is valid, continue.
        - If it is invalid, print "Invalid input" and terminate the program.
    
    3 - Check whether the age is within a valid range of 0 to 120.
        - If it is valid, continue.
        - If it is invalid, print "Invalid age" and terminate the program.
    
    4 - Check whether the age is greater than or equal to 18.
        - If yes, print "Adult".
        - If no, print "Minor".
    
    ------------------------------------------------------------------------------------------------------            
    Basic C# code:
    ------------------------------------------------------------------------------------------------------
    
    NOTE: The following C# code performs the age check without implementing the input validation steps described in Steps 2 and 3. 
    It assumes the user will always enter a valid whole number. Convert.ToInt32 will throw an unhandled exception and 
    terminate the program if the input is empty, non-numeric, contains a floating-point input such as "20.5" or is outside the range supported by the int data type.

    ------------------------------------------------------------------------------------------------------
    
    Console.Write("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    
    if (age >= 18)
    {
        Console.WriteLine("Adult");
    }
    else
    {
        Console.WriteLine("Minor");
    }
    
    ------------------------------------------------------------------------------------------------------
    
    Input validation example:
    ------------------------------------------------------------------------------------------------------
    
    NOTE: The following C# code implements all the steps of the algorithm. It uses int.TryParse instead of Convert.ToInt32. 
    The int.TryParse method does not throw an exception when the input is invalid. Instead, it returns false. 
    The program also checks whether the entered age is within a reasonable range.

    ------------------------------------------------------------------------------------------------------ 

    Console.Write("Enter your age: ");
    
    if (int.TryParse(Console.ReadLine(), out int age))
    {
        if (age < 0 || age > 120)
        {
            Console.WriteLine("Invalid age!");
        }
        else if (age >= 18)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Minor");
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
    
    - Valid input: Only whole numbers within the range of 0 to 120 are accepted.

    - Invalid input:
        character input -> 'a'
        empty input -> ""
        text input -> "twenty", "twenty5", "5twenty"
        floating-types -> float, double, decimal - 20.5
        negative numbers -> -20
        age outside the accepted range -> 121
     
    ------------------------------------------------------------------------------------------------------
    
    Big-O - Efficiency: Time and Space Complexity
    ------------------------------------------------------------------------------------------------------

    As mentioned above a good algorithm should be efficient, and some algorithms solve the same problem faster than others (the textbook page-turning example). 
    But "faster" needs a way to be measured. This is what time complexity and space complexity are for.

    - Time complexity describes how the number of operations an algorithm performs grows as the input size grows.
    - Space complexity describes how much extra memory an algorithm needs as the input size grows.

    Both are usually expressed with Big-O notation, which describes the growth rate rather than an exact number of steps. A few common examples:

    - O(1)      constant time       - checking if a number is even(i % 2 == 0) does the same amount of work
                                      no matter how big the number is.
    - O(n)      linear time         - turning pages one by one in the textbook example; work grows in direct
                                      proportion to input size.
    - O(log n)  logarithmic time    - using the table of contents (binary search) approach; each step 
                                      eliminates a large portion of the remaining work.
    
    This is why the "table of contents (binary search)" approach from earlier isn't just a nicer way to search, it belongs to more efficient, 
    slower growing complexity class than page-by-page (linear search). Big-O notation is covered in more depth in dedicated algorithm, 
    data-structures material, but keeping it in mind while designing an algorithm helps you reason about efficiency instead of guessing at it.
    
    ------------------------------------------------------------------------------------------------------
*/