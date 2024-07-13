namespace _13_06_24.MissedTask;

public abstract class Account
{
    public static bool PasswordChecker(string password)
    {
        if (password.Length < 8)
            return false;

        bool IsDigit = false;
        bool IsUpper = false;
        bool IsLower = false;

        for (int i = 0; i < password.Length; i++)
        {
            if (char.IsDigit(password[i]))
                IsDigit = true;
            else if (char.IsUpper(password[i]))
                IsUpper = true;
            else if (char.IsLower(password[i]))
                IsLower = true;

            if (IsDigit && IsUpper && IsLower)
                return true;
        }
        return false;
    }
    public abstract void ShowInfo();
}
