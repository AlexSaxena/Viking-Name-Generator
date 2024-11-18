public class VikingNameCombiner
{
    public string GenerateName(string name, string gender, string title)
    {
        string suffix = gender.ToLower() == "m" ? "son" : "dottir";

        string prefix = GetPrefixForTitle(title.ToLower());

        return $"{prefix} {name}{suffix}";
    }

    private string GetPrefixForTitle(string title)
    {
        switch (title)
        {
            case "royalty":
                return "Jarl";
            case "warrior":
                return new Random().Next(0, 2) == 0 ? "Shieldbearer" : "Berserker";
            case "farmer":
                return new Random().Next(0, 2) == 0 ? "Bondi" : "Thane";
            default:
                return "";
        }
    }
}
