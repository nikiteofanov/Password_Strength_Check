
class PasswordStrengthChecker
{
    static void Main(string[] args)
    {
        Console.WriteLine("Password Strength Checker");

        Console.Write("Enter a password: ");
        string password = Console.ReadLine();

        string length = passwordLength(password);
        Console.WriteLine(length);
        string specialCharacters = specialChars(password);
        Console.WriteLine(specialCharacters);
        string upperCase_ = upperCase(password);
        Console.WriteLine(upperCase_);
        string lowerCase_ = lowerCase(password);
        Console.WriteLine(lowerCase_);
        string numbers_ = numbers(password);
        Console.WriteLine(numbers_);
    }

    static string passwordLength(string input)
    {
        if (input.Length >= 8)
            return "The password has more than 8 characters!";
        else
            return "The password is too short! You need at least 8 characters";
    }

    static string specialChars(string input)
    {
        string characters = "!@#$%^&*()_+=[]{};:'\"<>,.?/|\\";
        foreach (char item in input)
        {
            if (characters.Contains(item))
                return "The password contains special characters!";
        }
        return "The password does NOT contain special characters! Try again!";
    }

    static string upperCase(string input)
    {
        foreach (char c in input)
        {
            if (char.IsUpper(c))
                return "The password contains upper case letters!";
        }
        return "The password does NOT contain upper case letters! Try again!";
    }

    static string lowerCase(string input)
    {
        foreach (char c in input)
        {
            if (char.IsLower(c))
                return "The password contins lower case letter!";
        }
        return "The password does not contain lower case letters! Try again!";
    }

    static string numbers(string input)
    {
        foreach (char item in input)
        {
            if (char.IsDigit(item))
                return "The password contains numbers!";
        }
        return "The password does NOT contain numbers! Try again!";
    }

}
