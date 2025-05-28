// See https://aka.ms/new-console-template for more information
// datatype variableName = initial value;
double myNumber1 = 0;
double myNumber2 = 0;


// Prints out whatever is inside of ();
Console.WriteLine("Enter a number");

// takes the user input and stores it
// Variable with the name "userInpunt" and the data type "string"
string userInput = Console.ReadLine();
//myNumber = int.Parse(Console.ReadLine());
myNumber1 = double.Parse(userInput);

Console.WriteLine("Enter a number");
userInput = Console.ReadLine();
myNumber2 = double.Parse(userInput);

//we are adding to strings together and writing them onto the console
double sum = myNumber1 + myNumber2;
Console.WriteLine($"The sum is: {sum}");
Console.ReadKey();
