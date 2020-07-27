using System;
using System.Collections.Generic;
using TaxPayment.Entities;

namespace TaxPayment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<TaxPayer> payers = new List<TaxPayer>();
            double total = 0;

            for (int i = 1;i<=n ;i++) {
                Console.WriteLine("Tax payer #{0} data:", i);
                Console.Write("Individual or company (i/c)? ");
                char op = Convert.ToChar(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double income = Convert.ToDouble(Console.ReadLine());

                if (op == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double costHealth = Convert.ToDouble(Console.ReadLine());
                    payers.Add(new Individual(name, income, costHealth));
                }
                else if (op == 'c') {
                    Console.Write("Number of employees: ");
                    int nEmployees = Convert.ToInt32(Console.ReadLine());
                    payers.Add(new Company(name, income, nEmployees));
                }          
            }


            Console.WriteLine("\nTAXES PAIND:");
            foreach (TaxPayer payer in payers) {
                Console.WriteLine(payer.Name + ": $ " + payer.Tax().ToString("F2"));
                total += payer.Tax();
            }
            Console.WriteLine("\nTOTAL TAXES: $ " + total.ToString("F2"));
        }
    }
}
