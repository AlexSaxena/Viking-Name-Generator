public class ValidateGenderOptions
{
    public bool Validate(string genderInput)
    {
        if (string.IsNullOrWhiteSpace(genderInput))
        {
            Console.WriteLine("Gender cannot be left empty or just whitespace!");
            return false;
        }
        genderInput = genderInput.ToLower();

        if (genderInput == "m" || genderInput == "f")
        {
            return true;
        }

        Console.WriteLine("Invalid gender option. Please enter M or F.");
        return false;
    }
}
