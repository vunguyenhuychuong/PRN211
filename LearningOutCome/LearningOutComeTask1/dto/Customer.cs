using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LearningOutComeTask1.dto
{
    public class Customer
    {
        public int customerID { get; set; }

        public string customerName { get; set; }

        public string Address { get; set; }

        public float quantity { get; set; }

        public float UnitPrice { get; set; }

        public Customer()
        {
            customerID = 0;
            customerName = "";
            Address = "";
            quantity = 0;
            UnitPrice = 0;
        }

        public Customer(int customerID, string customerName, string address, float quantity, float unitPrice)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.Address = address;
            this.quantity = quantity;
            this.UnitPrice = unitPrice;
        }

        public void InputCustomer()
        {
            int count = 0;
            do
            {
                try
                {
                    count = 0;
                    String pattern = "^[A-Z._%+-]+@[A-Z.-]+\\.A[A-Z]{}$";
                    Console.Write("\nInput CustomerID: ");
                    this.customerID = int.Parse(Console.ReadLine());
                    if (this.customerID.Equals(pattern))
                    {
                        throw new Exception();
                    }
                    
                }
                catch (Exception)
                {
                    Console.Write("Please input number !!");
                    count++;
                }
            } while (count != 0);

            do
            {
                try
                {
                    count = 0;
                    String pattern = "[0-9]";
                    Console.Write("$\nInput CustomerName: ");
                    this.customerName = Console.ReadLine();
                    if (Regex.IsMatch(this.customerName, pattern))
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please input number ");
                    count++;
                }
                Console.ResetColor();
            }while (count != 0);

            do
            {
                try
                {
                    count = 0;
                    String pattern = "[0-9]";
                    Console.Write("$\nInput Address: ");
                    Address = Console.ReadLine();
                    if (Regex.IsMatch(this.Address, pattern))
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Please input String not number");
                    count++;
                }
                Console.ResetColor();
            } while (count != 0);

            do
            {
                try
                {
                    count = 0;
                    String pattern = "^[A-Z._%+-]+@[A-Z.-]+\\.A[A-Z]{}$";
                    Console.Write("$\nInput Quantity: ");
                    quantity = float.Parse(Console.ReadLine());
                    if (this.quantity.Equals(pattern))
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Please input number not character!!");
                    count++;
                }
                Console.ResetColor();
            } while (count != 0);

            do
            {
                try
                {
                    count = 0;
                    String pattern = "^[A-Z._%+-]+@[A-Z.-]+\\.A[A-Z]{}$";
                    Console.Write("$\nInput Unit Price: ");
                    UnitPrice = float.Parse(Console.ReadLine());
                    if (this.UnitPrice.Equals(pattern))
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Please input number not character!!");
                    count++;
                }
                Console.ResetColor();
            } while (count != 0);
        }
    }
}
