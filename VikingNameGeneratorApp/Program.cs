var userInputName = "";

Console.WriteLine("Hello Viking to be! \nPlease answer these quick questions to get your new Viking name!");
Console.WriteLine("1. What is your name?");
userInputName = Console.ReadLine();

var nameValidator = new ValidateName();

while (!nameValidator.Validate(userInputName))
{
    Console.WriteLine("Let's try again. What is your name?");
    userInputName = Console.ReadLine();
}

Console.WriteLine($"You wrote: {userInputName}");
