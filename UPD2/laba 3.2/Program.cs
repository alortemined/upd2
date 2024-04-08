using System;

class Program
{
    static void Main()
    {
        Worker zxcsemen = new Worker();
        Console.WriteLine($"Имя: {zxcsemen.GetName()} \nФамилия: {zxcsemen.GetSurname()} \nСтавка: {zxcsemen.GetRate()} \nОтработанные дни: {zxcsemen.GetDays()}");
        zxcsemen.GetSalary();
    }
}

class Worker
{
    private string name = "Semen";
    private string surname = "Kkalitov";
    private double rate = 8.3;
    private int days = 15;

    public string GetName()
    {
        return name;
    }

    public string GetSurname()
    {
        return surname;
    }

    public double GetRate()
    {
        return rate;
    }

    public int GetDays()
    {
        return days;
    }

    public void GetSalary()
    {
        Console.WriteLine($"Зарплата: {days * rate}");
    }
}