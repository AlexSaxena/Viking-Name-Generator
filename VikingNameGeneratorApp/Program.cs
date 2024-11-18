var nameInput = "";
var genderInput = "";
var titleInput = "";

var nameValidator = new ValidateName();
var genderValidator = new ValidateGenderOptions();
var titleValidator = new ValidateTitle();
var nameGenerator = new VikingNameCombiner();

Console.WriteLine("Hello Viking to be! \nPlease answer these quick questions to get your new Viking name!");

Console.WriteLine("1. What is your name?");
nameInput = Console.ReadLine();

while (!nameValidator.Validate(nameInput))
{
    Console.WriteLine("Let's try again. What is your name?");
    nameInput = Console.ReadLine();
}

Console.WriteLine("2. What is your gender? (M or F)");
genderInput = Console.ReadLine();

while (!genderValidator.Validate(genderInput))
{
    Console.WriteLine("Let's try again. What is your gender? (M or F)");
    genderInput = Console.ReadLine();
}

Console.WriteLine("\n3. Choose your Viking destiny!");
Console.WriteLine("Are you a mighty Warrior, a noble Royalty, or a humble Farmer?");
titleInput = Console.ReadLine();

while (!titleValidator.Validate(titleInput))
{
    Console.WriteLine("Let's try again! Please type Warrior, Royalty, or Farmer:");
    titleInput = Console.ReadLine();
}

string vikingName = nameGenerator.GenerateName(nameInput, genderInput, titleInput);

Console.WriteLine($"\nYour Viking name is: {vikingName}");
