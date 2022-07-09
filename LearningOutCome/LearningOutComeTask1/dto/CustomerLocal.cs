using LearningOutComeTask1.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LearningOutComeTask1.DTO
{

    public class CustomerLocal : Customer
    {

        public string typeCustomer { get; set; }

        public float quota { get; set; }

        public double totalBill { get; set; }

        public CustomerLocal()
        {

        }

        public CustomerLocal(int customerID, string customerName, string address, float quantity, float unitPrice, string type, float quota) : base(customerID, customerName, address, quantity, unitPrice)
        {
            this.typeCustomer = type;
            this.quota = quota;
        }

        public void InputCustomerLocal()
        {
            
            int count = 0;
            base.InputCustomer();
            do
            {
                try
                {
                    count = 0;
                    String pattern = "[0-9]";
                    Console.Write($"\nInput Type (Bussiness, Saler, Teacher,Employee): ");
                    this.typeCustomer = Console.ReadLine();
                    String typeCutomer = this.typeCustomer;
                    if (Regex.IsMatch(typeCutomer, pattern))
                    {
                        throw new Exception();
                    }
                   
                }
                catch(Exception ex)
                {   
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dont type a number");
                    count++;
                }
                Console.ResetColor();
            }while(count != 0);

            do
            {
                try
                {
                    count = 0;
                    String pattern = "[0-9]";
                    Console.Write("$\nInput Quota: ");
                    this.quota = float.Parse(Console.ReadLine());
                    if (this.quota.Equals(pattern))
                    {
                        throw new Exception();
                    }            
                }
                catch (Exception)
                {   
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please input number ,not character!!");
                    count++;
                }
                Console.ResetColor();
            } while (count != 0);

            if(quantity <= quota)
            {
                this.totalBill = quantity * UnitPrice;
            }
            else
            {
                this.totalBill = quantity * UnitPrice * quota * (quantity + quota) + UnitPrice * 2.5;
            }
        }

        public override string ToString()
        {
            base.ToString();
            string obj = $"CustomerID: {this.customerID}" + " ," +
                $"CustomerName :{this.customerName}," + " ," +
                $"Address: {this.Address}," + " ," +
                $"Quantity: {this.quantity}," + " ," +
                $"UnitPrice: {this.UnitPrice}," + " ," +
                $"TypeCustomer: {this.typeCustomer}," + " ,"  +
                $"Quota: {this.quota}," + " ," +
                $"TotalBill: {this.totalBill}]";
            return obj;
        }
    }
}
