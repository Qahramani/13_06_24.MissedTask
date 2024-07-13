namespace _13_06_24.MissedTask;

public class User : Account
{
    private static int _id;
    public int Id { get; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public User(string fullname, string email, string password)
    {
        FullName = fullname;
        Email = email;
        Password = password;
        Id = ++_id;
    }


    public override void ShowInfo()
    {
        Console.WriteLine($"Fullname: {FullName}, Email: {Email}, Id: {Id}");
    }
}
