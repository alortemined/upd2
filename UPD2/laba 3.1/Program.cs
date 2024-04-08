using System;

class Program
{
    static void Main()
    {
        Worker zxcsemen = new Worker();
        zxcsemen.Name = "Semen";
        zxcsemen.Surname = "Khalitov";
        zxcsemen.Rate = 500.90;
        zxcsemen.Days = 10;
        zxcsemen.GetSalary();
    }
}

class Worker
{
    public string Name;
    public string Surname;
    public double Rate;
    public int Days;

    public void GetSalary()
    {
        Console.WriteLine(Days * Rate);
    }
}