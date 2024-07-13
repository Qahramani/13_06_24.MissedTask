namespace _13_06_24.MissedTask;

public class Program
{
    static void Main(string[] args)
    {
    restartUserCreation:
        Console.WriteLine("----- Create User -----");
        Console.Write("Fullname: ");
        string username = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();
        if (!Account.PasswordChecker(password))
        {
            Console.WriteLine("Password should contain at least 1 upper ands 1 lower letters, 1 digit and length >=8");
            goto restartUserCreation;
        }

        User user = new(username, email, password);
        Console.WriteLine("User created successfully");

    restartMenu:
        Console.WriteLine("----- Menu -----");
        Console.Write("[1] Show user info\n" +
            "[2] Create new group\n" +
            ">>> ");
        string option = Console.ReadLine();

        Group group = new Group(0, "");
        switch (option)
        {
            case "1":
                user.ShowInfo();
                goto restartMenu;
            case "2":
            restartCreation:
                Console.WriteLine("----- Group Creatiion -----");
                Console.Write("GroupNo: ");
                string groupNo = Console.ReadLine();
                if (!Group.CheckGroupNo(groupNo))
                {
                    Console.WriteLine("it should be two upper letters and three digits (example BP303)");
                    goto restartCreation;
                }
                Console.Write("Student limit: ");
                int studentlimit = int.Parse(Console.ReadLine());
                if (studentlimit < 5 || studentlimit > 18)
                {
                    Console.WriteLine("Studentlimit shoul be between 5 and 18");
                    goto restartCreation;
                }
                group = new(studentlimit, groupNo);
                break;
            default:
                Console.WriteLine("Invalid input");
                goto restartMenu;
        }

    restartGroupMenu:
        Console.WriteLine($"---- Group Menu ({group.GroupNo}) -----");

        Console.Write("[1] Show all students\n" +
            "[2] Get student by Id\n" +
            "[3] Add student\n" +
            "[0] Quit\n" +
            ">>> ");
        option = Console.ReadLine();
        switch (option)
        {
            case "1":
                Console.WriteLine("--- Students List ---");
                group.GetAllStudents();
                goto restartGroupMenu;
            case "2":
                Console.Write("Id: ");
                int idGet = int.Parse(Console.ReadLine());
                group.GetStudentById(idGet);
                goto restartGroupMenu;
            case "3":
            restartStudentCreationMenu:
                Console.WriteLine("--- Student Creation ---");
                Console.Write("Fullname: ");
                string studentname = Console.ReadLine();
                Console.Write("Point: ");
                int point = int.Parse(Console.ReadLine());

                if (point < 0 || point > 100)
                {
                    Console.WriteLine("Invalid input for point");
                    goto restartStudentCreationMenu;
                }

                Student student = new(studentname, point);
                group.AddStudent(student);
                goto restartGroupMenu;
            case "0":
                break;
            default:
                Console.WriteLine("Invalid input");
                goto restartGroupMenu;
        }

    }
}
