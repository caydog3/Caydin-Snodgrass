/* 
 * Programmer: Caydin Snodgrass
 * Date: 3/6/2020
 * Purpose: a short description about the program
 * Class: CITP 180
 * Assignment 6: Chapter 4 - Programming Excercise 5
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CSAssignment6
{
    class Receipt
    {
        public int receipt_number { get; set; }
        public string date_of_purchase { get; set; } = DateTime.Now.ToString("M/d/yyyy");
        public int customer_number { get; set; }
        public string customer_name { get; set; }
        public string customer_address { get; set; }
        public long customer_phone_number { get; set; }
        public int item_number { get; set; }
        public string description { get; set; }
        public double unit_price { get; set; }
        public int quantity_purchased { get; set; } = 1;

        public double total_purchase(double cost, int quantity)
        {
            return cost * quantity;
        }
        public override string ToString()
        {
            return "**Order Summary** \n" +
                   "Receipt Number: " + receipt_number + "\n" +
                   "Date Of Purchase: " + date_of_purchase + "\n" +
                   "Customer Number: " + customer_number + "\n" +
                   "Customer Name: " + customer_name + "\n" +
                   "Customer Address: " + customer_address + "\n" +
                   "Customer Phone Number: " + String.Format("{0:(###) ###-####}", customer_phone_number) + "\n" +
                   "Item Number: " + item_number + "\n" +
                   "Item Description: " + description + "\n" +
                   "Unit Price: " + string.Format("{0:C2}", unit_price) + "\n" +
                   "Quantity Purchased: " + quantity_purchased + "\n" +
                   "Total Purchase Amount: " + string.Format("{0:C2}", total_purchase(unit_price, quantity_purchased));
        }
    }
}
