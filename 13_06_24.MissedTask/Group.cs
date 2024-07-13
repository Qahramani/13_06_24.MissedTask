namespace _13_06_24.MissedTask;

public class Group
{

    public int StudentLimit { get; set; }
    public string GroupNo { get; set; }
    private Student[] Students;
    public Group(int studentlimit, string groupNo)
    {
        StudentLimit = studentlimit;
        GroupNo = groupNo;
        Students = new Student[0];

    }
    public static bool CheckGroupNo(string groupNo)
    {
        if (char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1])
            && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
        {
            return true;
        }
        return false;
    }
    public void AddStudent(Student student)
    {
        if (Students.Length >= StudentLimit)
        {
            Console.WriteLine($"Group is full. This group cannot have more than {StudentLimit} students.");
            return;
        }
        Array.Resize(ref Students, Students.Length + 1);
        Students[^1] = student;
        Console.WriteLine("Student added successfully");
    }
    public void GetStudentById(int id)
    {
        foreach (var student in Students)
        {
            if (student.Id == id)
            {
                student.StudentInfo();
                return;
            }
        }
        Console.WriteLine("Student is not found");
    }
    public void GetAllStudents()
    {
        foreach (var student in Students)
        {
            student.StudentInfo();
        }
    }

}
