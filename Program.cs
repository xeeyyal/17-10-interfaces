using TASK.UNI._16.Models;

namespace TASK.UNI._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            while (true)
            {
                Console.WriteLine("Menyu:");
                Console.WriteLine("1. Sür");
                Console.WriteLine("2. Zapravkaya gir");
                Console.WriteLine("3. Benzini göstər");
                Console.WriteLine("4. Getdiyimiz yolu göstər");
                Console.Write("Seçiminizi edin (1-4): ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Sehv daxil etmisiniz.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Neçə km sürmek isteyirsiniz?: ");
                        if (double.TryParse(Console.ReadLine(), out double distance))
                        {
                            bool success = myCar.Drive(distance);
                            if (success)
                            {
                                Console.WriteLine($"Qalan benzin: {myCar.Fuel:F2} litr");
                                Console.WriteLine($"Getdiyiniz yol: {myCar.MileAge:F2} km");
                            }
                            else
                            {
                                Console.WriteLine("Bu yolu getmək mümkün deyil.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Səhv daxil etmisiniz.");
                        }
                        break;

                    case 2:
                        Console.Write("Neçə litr benzin doldurmaq istəyirsiniz?: ");
                        if (double.TryParse(Console.ReadLine(), out double refuelAmount))
                        {
                            bool success = myCar.Refuel(refuelAmount);
                            if (success)
                            {
                                Console.WriteLine("Benzin uğurla dolduruldu.");
                            }
                            else
                            {
                                Console.WriteLine("Səhv daxil etmisiniz.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Səhv daxil etmisiniz.");
                        }
                        break;

                    case 3:
                        Colored.WriteLine($"Car Model: BMW F30", ConsoleColor.Yellow);
                        Colored.WriteLine($"Benzin miqdarı: {myCar.Fuel:F2} litr", ConsoleColor.Yellow);
                        break;

                    case 4:
                        Colored.WriteLine($"Car Model: BMW F30", ConsoleColor.Green);
                        Colored.WriteLine($"Getdiyiniz yol: {myCar.MileAge:F2} km", ConsoleColor.Green);
                        break;

                    default:
                        Console.WriteLine("Səhv seçim.");
                        break;
                }
            }
        }
    }
}