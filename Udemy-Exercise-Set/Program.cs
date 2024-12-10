using Udemy_Exercise_Set.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<Courses> courses = new HashSet<Courses>();

        Console.Write("How many students for course A? ");
        int qtStudents = int.Parse(Console.ReadLine());
        string course = "A";
        SetStudents(qtStudents, course, courses);

        Console.WriteLine();
        Console.Write("How many students for course B? ");
        qtStudents = int.Parse(Console.ReadLine());
        course = "B";
        SetStudents(qtStudents, course, courses);

        Console.WriteLine();
        Console.Write("How many students for course C? ");
        qtStudents = int.Parse(Console.ReadLine());
        course = "C";
        SetStudents(qtStudents, course, courses);

        Console.WriteLine();
        Console.WriteLine("Total students: " + courses.Count);
    }

    static public void SetStudents(int qtStudents, string course, HashSet<Courses> courses)
    {
        for (int i = 0; i < qtStudents; i++)
        {
            int students = int.Parse(Console.ReadLine());
            courses.Add(new Courses(students, course));
        }
    }
}