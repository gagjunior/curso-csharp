using System.Globalization;
using System.Collections.Generic;
using AbstractMethods.Entities;

namespace AbstractMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int numberOfPayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures);
                }
                else
                {
                    Console.Write("Number of employees: ");

                }
            }
        }
    }
}
