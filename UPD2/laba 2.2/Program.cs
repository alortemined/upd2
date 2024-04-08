using System;

class Program
{
    static void Main()
    {
        Train tovarniy = new Train();
        Train electricka = new Train();
        Train skorostnoy = new Train();

        tovarniy.TrainNumber = 624;
        tovarniy.NameOfDestination = "Москва";
        tovarniy.DepartureTime = new Train.TrainTime(15, 40, 00);

        electricka.TrainNumber = 901;
        electricka.NameOfDestination = "Владивосток";
        electricka.DepartureTime = new Train.TrainTime(16, 00, 00);

        skorostnoy.TrainNumber = 762;
        skorostnoy.NameOfDestination = "Хабаровск";
        skorostnoy.DepartureTime = new Train.TrainTime(11, 20, 00);


        Console.WriteLine("Введите номер поезда (624, 901, 762): ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 624:
                tovarniy.PrintTrain();
                break;
            case 901:
                electricka.PrintTrain();
                break;
            case 762:
                skorostnoy.PrintTrain();
                break;
            default:
                Console.WriteLine("Неверно набран номер поезда");
                break;
        }
    }
}

class Train
{
    public string NameOfDestination;
    public TrainTime DepartureTime = new TrainTime(15, 12, 2);
    public int TrainNumber;

    public void PrintTrain()
    {
        Console.WriteLine($"название пункта назначения: {NameOfDestination} \nномер поезда: {TrainNumber} \nвремя отправления: {DepartureTime} \n");
    }

    public class TrainTime
    {
        public int Hours;
        public int Minutes;
        public int Seconds;

        public TrainTime(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }
    }
}