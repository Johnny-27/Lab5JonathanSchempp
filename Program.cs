//Lab 5: Functions and Methods//

//Void//

void SoullessCat ()
{
Console.WriteLine ("   ^__/,|   ");
Console.WriteLine ("   |o o  |   ");
Console.WriteLine ("   ( T   )   ");
Console.WriteLine ("  .^`^--'^.   ");
Console.WriteLine ("  `.  ;   .'   ");
Console.WriteLine ("   | | |  | |   ");
Console.WriteLine ("   ((_((  ))_))   ");
Console.ReadKey ();
Menu ();
} 

//User input return
void ReturnInput ()
{
    Console.WriteLine ("User, please enter something, anything, please");
    string input = Console.ReadLine();
    Console.WriteLine($"you entered {input}");
    Console.ReadKey();
    Menu ();
}

//Input Addition
void AddInput ()
{
    Console.WriteLine ("User, please enter 2 numbers to add together. Number 1:");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine ("Number 2:");
    int num2 = int.Parse(Console.ReadLine());
    int total = num1 + num2;
    Console.WriteLine($"The total of your numbers is {total}");
    Console.ReadKey();
    Menu ();
}

//Input Subtraction
void SubtractInput ()
{
    Console.WriteLine ("User, please enter 2 numbers to subtract. Number 1:");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine ("Number 2:");
    int num2 = int.Parse(Console.ReadLine());
    int difference = num1 - num2;
    Console.WriteLine($"The difference of your numbers is {difference}");
    Console.ReadKey();
    Menu ();
}

//Input Multiplication
void MultiplyInput ()
{
    Console.WriteLine ("User, please enter 2 numbers to multiply together. Number 1:");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine ("Number 2:");
    int num2 = int.Parse(Console.ReadLine());
    int product = num1 * num2;
    Console.WriteLine($"The product of your numbers is {product}");
    Console.ReadKey();
    Menu ();
}

//Input Division
void DivideInput ()
{
    Console.WriteLine ("User, please enter 2 numbers to add together. Number 1:");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine ("Number 2:");
    int num2 = int.Parse(Console.ReadLine());
    int quotient = num1 / num2;
    Console.WriteLine($"The quotient of your numbers is {quotient}");
    Console.ReadKey();
    Menu ();
}

//Menu()
void Menu ()
{
    Console.WriteLine ("Please select one of the following options");
    Console.WriteLine ("1: See a judgy cat with soulless eyes");
    Console.WriteLine ("2: Have me tell you what you literally just wrote in case you forgot");
    Console.WriteLine ("3: Add two numbers together");
    Console.WriteLine ("4: Subtract two numbers");
    Console.WriteLine ("5: Multiply two numbers");
    Console.WriteLine ("6: Divide two numbers");
    Console.WriteLine ("7: Exit");
    string Choice = Console.ReadLine ();
    if (Choice == "1") SoullessCat();
    if (Choice == "2") ReturnInput ();
    if (Choice == "3") AddInput ();
    if (Choice == "4") SubtractInput ();
    if (Choice == "5") MultiplyInput ();
    if (Choice == "6") DivideInput ();
    if (Choice == "7") 
    {
        System.Environment.Exit (0);
    }
    else 
    {
        Menu ();
    }
}
Menu ();