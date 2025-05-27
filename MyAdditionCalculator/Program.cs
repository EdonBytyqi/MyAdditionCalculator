// See https://aka.ms/new-console-template for more information
// datatype variableName = initial value;
int myNumber = 0;
int myNumber2 = 0;


// Prints out whatever is inside of ();
Console.WriteLine("Enter a whole number");

// takes the user input and stores it
// Variable with the name "userInpunt" and the data type "string"
string userInput = Console.ReadLine();
//myNumber = int.Parse(Console.ReadLine());
myNumber = int.Parse(userInput);

Console.WriteLine("Enter a whole number");
userInput = Console.ReadLine();
myNumber2 = int.Parse(userInput);

//we are adding to strings together and writing them onto the console
int sum = myNumber + myNumber2;
Console.WriteLine("The sum is: " + sum);
Console.ReadKey();
