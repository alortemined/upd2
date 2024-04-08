using System;

class Student
{
    private string lastName;
    private DateTime dateOfBirth;
    private string groupNumber;
    private int[] grades;

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public DateTime DateOfBirth
    {
        get { return dateOfBirth; }
        set { dateOfBirth = value; }
    }

    public string GroupNumber
    {
        get { return groupNumber; }
        set { groupNumber = value; }
    }

    public int[] Grades
    {
        get { return grades; }
        set { grades = value; }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Last Name: {lastName}");
        Console.WriteLine($"Date of Birth: {dateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Group Number: {groupNumber}");
        Console.WriteLine("Grades: ");
        for (int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine($"Grade {i + 1}: {grades[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        student.LastName = "Халитов";
        student.DateOfBirth = new DateTime(2006, 10, 2);
        student.GroupNumber = "Группа 624";
        student.Grades = new int[] { 5, 4, 3, 5, 4 };

        student.DisplayInfo();

        Console.WriteLine("\nEnter new Last Name: ");
        student.LastName = Console.ReadLine();
        Console.WriteLine("Enter new Date of Birth (yyyy-mm-dd): ");
        student.DateOfBirth = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter new Group Number: ");
        student.GroupNumber = Console.ReadLine();

        student.DisplayInfo();

        Console.ReadLine();
    }
}