/* 
 * Programmer: Caydin Snodgrass
 * Date: 2/9/2020
 * Purpose: a short description about the program
 * Class: CITP 180
 * Assignment: Chapter 3 - Programming Excersize 10
 */
using System;

namespace CSAssignment3
{
    class Program
    {
        public static void Main(string[] args)
        {
            double current_value = 100000;
            double milage_rate = .01003;
            double value_increase = 0.027;
            double exemption = 25000.00;

            double new_value = enter_new_value(current_value, value_increase);
            double tax_value = enter_tax_value(new_value, exemption);
            double tax_owed = enter_tax_owed(tax_value, milage_rate);

            print_results(current_value, milage_rate, value_increase, exemption, new_value, tax_value, tax_owed);

        }
        private static double enter_new_value(double current_value, double value_percentage_increase)
        {
            return current_value * (1 + value_percentage_increase);
        }
        private static double enter_tax_value(double new_value, double exemption)
        {
            return new_value - exemption;
        }
        private static double enter_tax_owed(double tax_value, double tax_rate)
        {
            return tax_value * (tax_rate / 10);
        }
        private static void print_results(double current_value, double milage_rate, double value_increase, double exemption, double new_value, double tax_value, double tax_owed)
        {
            string address;
            const int space = 12;
            Console.WriteLine("Taxes are based on the following");
            Console.WriteLine("Milage Rate: $10.03 (per $1,000 of taxable value).");
            Console.WriteLine("$25,000.00 (exemption): subtracted from taxable values for homeowners.");
            Console.ReadLine();
            Console.WriteLine("-------Tax Calculator---------");
            Console.WriteLine("Enter address: ");
            address = Console.ReadLine();
            Console.WriteLine($"Last year's assessed value: {current_value,space:C}");
            Console.WriteLine($"Current Value:              {new_value,space:C}");
            Console.WriteLine($"Exemption:                  {exemption,space:C}");
            Console.WriteLine($"Taxable value:              {tax_value,space:C}");
            Console.WriteLine($"Mileage rate (per $1000):   {milage_rate,space:C}");
            Console.WriteLine($"Taxes owed:,                {tax_owed,space:C}");

        }
    }
}
