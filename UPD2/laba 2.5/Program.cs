using System;

class Program
{
    static void Main()
    {
        Client senya = new Client();
        Client fedya = new Client("Федя");
        Client syoma = new Client("Сёма", 17);
        Console.WriteLine($"Имя: {senya.Name}, возраст: {senya.Age}");
        Console.WriteLine($"Имя: {fedya.Name}, возраст: {fedya.Age}");
        Console.WriteLine($"Имя: {syoma.Name}, возраст: {syoma.Age}");
    }
}

class Client
{
    private string name;
    private int age;

    public string Name
    {
        get
        {
            return name;
            
        }
        set
        {
            name = value;
            
        }
    }

    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            age = value;
        }
    }

    public Client() : this("Не указанно")
    {
        
    }

    public Client(string name) : this(name, 18)
    {
        
    }

    public Client(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

  
    ~Client()
    {
        Console.WriteLine($"{name} has deleted");
    }
}