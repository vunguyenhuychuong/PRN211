using LearningOutComeTask1.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LearningOutComeTask1.DTO
{
    public class CustomerForeigner : Customer
    {
        public string nation { get; set; }

        public double totalBill { get; set; } 

        public CustomerForeigner()
        {
            
        }

        public CustomerForeigner(int customerID, string customerName, string address, float quantity, float unitPrice, string nation) : base(customerID, customerName, address, quantity, unitPrice)
        {
            this.nation = nation;
        }

        public void InputCustomerForeigner()
        {
            base.InputCustomer();
            int count = 0;
            do
            {
                try
                {
                    count = 0;
                    String pattern = "[0-9]";
                    Console.Write("\nInput Nation: ");
                    this.nation = Console.ReadLine();
                    if (Regex.IsMatch(this.nation, pattern))
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please input Characters not number!");
                    count++;
                }
            } while (count != 0);

            this.totalBill = quantity * UnitPrice;

        }

        //public override string ToString()
        //{
        //    return $"CustomerID: {this.customerID}" + " ," +
        //        $"CustomerName :{this.customerName}," + " ," +
        //        $"Address: {this.Address}," + " ," +
        //        $"Quantity: {this.quantity}," + " ," +
        //        $"UnitPrice: {this.UnitPrice}," + " ," +
        //        $"Nation: {this.nation}," + " ," +
        //        $"TotalBill: {this.totalBill}";

        //}
        public void DisplayCustomerAbove()
        {
            Console.WriteLine("CustomerID: " + customerID + "," +
                              "CustomerName: " + customerName + "," +
                              "Address: " + Address + "," +
                              "Quantity: " + quantity + "," +
                              "UnitPrice: " + UnitPrice + "," +
                              "Nationality: " + nation + "," +
                              "TotalBill: " + totalBill);
        }

    }
}
