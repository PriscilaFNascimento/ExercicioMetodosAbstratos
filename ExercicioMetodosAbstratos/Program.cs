using System;
using System.Collections.Generic;
using ExercicioMetodosAbstratos.Entities;

namespace ExercicioMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating the list of payers
            List<Payers> list = new List<Payers>();

            Console.Write("Insert the number of payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine());

                if(type == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());

                    //Creating a new individual
                    Individual individual = new Individual(name, annualIncome, healthExpenditures);
                    //Adding the individual to the list of payers
                    list.Add(individual);
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    //Creating a new company
                    Company company = new Company(name, annualIncome, numberOfEmployees);
                    //Adding the company to the list of payers
                    list.Add(company);
                } 
            }

            //Variable that stores the sum of all payers' taxes
            double sum = 0.0;

            //Writing each tax payed
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Payers payers in list)
            {
                double tax = payers.Taxes();
                Console.WriteLine(payers.Name + ": $" + tax.ToString("F2"));
                //Adding the tax to sum
                sum += tax;
            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: $" + sum.ToString("F2"));
        }
    }
}
