public class ValidateTitle
{
    public bool Validate(string titleInput)
    {
        if (string.IsNullOrWhiteSpace(titleInput))
        {
            Console.WriteLine("Title cannot be empty or just whitespace!");
            return false;
        }

        titleInput = titleInput.ToLower();

        if (titleInput == "warrior" || titleInput == "royalty" || titleInput == "farmer")
        {
            return true;
        }

        Console.WriteLine("Invalid title.");
        return false;
    }
}
