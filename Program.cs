/* 
 * Programmer: Caydin Snodgrass
 * Date: 3/6/2020
 * Purpose: a short description about the program
 * Class: CITP 180
 * Assignment 6: Chapter 4 - Programming Excercise 5
 */
using System;
using CSAssignment6;
    class Program
    {
    static void Main(string[] args)
    {
        /*Recipt Class*/
        Receipt newReceipt = new Receipt();

        newReceipt.receipt_number = 967418354;
        newReceipt.date_of_purchase = DateTime.Now.ToString("M/d/yyyy");
        newReceipt.customer_number = 00473215;
        newReceipt.customer_name = "Caydin Snodgrass";
        newReceipt.customer_address = "12345 Linden Rd, Linden, MI, 48451";
        newReceipt.customer_phone_number = 8106875267;
        newReceipt.item_number = 055;
        newReceipt.description = "2TB Hard Drive";
        newReceipt.unit_price = 19.99;
        newReceipt.quantity_purchased = 4;

        Console.WriteLine(newReceipt + "\n");
        Console.WriteLine("Press any key to continue...");
        Console.Read();

    }
}