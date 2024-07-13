namespace _13_06_24.MissedTask;

public class Student
{
    private static int _id;
    public int Id { get; }
    public string FullName { get; set; }
    public int Point { get; set; }
    public Student(string fullname, int point)
    {
        FullName = fullname;
        Point = point;
        Id = ++_id;
    }
    public void StudentInfo()
    {
        Console.WriteLine($"Fullname: {FullName}, Point: {Point}, Id: {Id}");
    }
}
