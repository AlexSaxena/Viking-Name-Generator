public class ValidateName
{
    public bool Validate(string userInput)
    {
        if (string.IsNullOrWhiteSpace(userInput))
        {
            Console.WriteLine("Name cannot be empty or just whitespace!");
            return false;
        }

        if (!IsAlphaOnly(userInput))
        {
            Console.WriteLine("Name cannot contain special characters!");
            return false;
        }

        return true;
    }
    private bool IsAlphaOnly(string input)
    {
        foreach (char c in input)
        {
            if (!char.IsLetter(c) && c != ' ')
            {
                return false;
            }
        }
        return true;
    }
}