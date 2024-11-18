var nameInput = "";
var genderInput = "";

var nameValidator = new ValidateName();
var genderValidator = new ValidateGenderOptions();

Console.WriteLine("Hello Viking to be! \nPlease answer these quick questions to get your new Viking name!");
Console.WriteLine("1. What is your name?");
nameInput = Console.ReadLine();

while (!nameValidator.Validate(nameInput))
{
    Console.WriteLine("Let's try again. What is your name?");
    nameInput = Console.ReadLine();
}

Console.WriteLine("2. What is your gender? (M/F/Random)");
genderInput = Console.ReadLine();


while (!genderValidator.Validate(genderInput))
{
    Console.WriteLine("Let's try again. What is your gender? (M/F/Random)");
    genderInput = Console.ReadLine();
}

Console.WriteLine($"You wrote: {nameInput} & You selected: {genderInput}");
