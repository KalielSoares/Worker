using Worker.Entities;
using Worker.Entities.Enums;

namespace Worker;

class Program
{
    static void Main(string[] args)
    {

        
        Console.Write("Enter departament's name: ");
        Departament deptName = new Departament(Console.ReadLine());
        Console.WriteLine("Enter worker data: ");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Level (Junior/MidLevel/Senior): ");
        WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
        Console.Write("Base Salary: ");
        double salary = double.Parse(Console.ReadLine());
        
        Workers workers = new Workers(name, level, salary, deptName);
        
        Console.Write("How many contracts to this worker: ");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Enter #{i} contract data: ");
            Console.Write("Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Value per hours: ");
            double value = double.Parse(Console.ReadLine());
            Console.Write("Duration (hours): ");
            int hours = int.Parse(Console.ReadLine());

            HourContract contract = new HourContract(date, value,hours);
            workers.addContract(contract);
        }
        
        Console.WriteLine();

        Console.Write("Enter month and year to calculate income (MM/YYYY): ");
        string YearandMonth = Console.ReadLine();
        int month = int.Parse(YearandMonth.Substring(0, 2));
        int year = int.Parse(YearandMonth.Substring(3));
        
        Console.WriteLine($"Name : {workers.Name})");
        Console.WriteLine($"Departament: {workers.Departament.Name}");
        Console.WriteLine($"Income for {YearandMonth}: {workers.Income(month,year)}");
    }
}

