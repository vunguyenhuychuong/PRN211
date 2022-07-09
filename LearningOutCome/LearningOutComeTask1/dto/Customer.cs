    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                    String pattern = @"^[0-9]+\s+([a-Za-Z]+[a-Za-Z]+\s[a-ZA-Z]+)$";
                    Console.Write("\nInput ID: ");
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
                    Console.Write("\nInput Name: ");
                    customerName = Console.ReadLine();
                    if (customerName == null && customerName.Length < 0)
                    {
                        Console.Write("Please Custumer Name is not Empty!");
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);

                }
            }while (count != 0);

            do
            {
                try
                {
                    Console.Write("\nInput Address: ");
                    Address = Console.ReadLine();
                    if (Address == null && Address.Length < 0)
                    {
                        Console.Write("Please Do not let address empty");
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    count++;
                }
            } while (count != 0);

            do
            {
                try
                {
                    Console.Write("\nInput Quantity: ");
                    quantity = float.Parse(Console.ReadLine());
                    if (quantity < 0)
                    {
                        Console.Write("Please Do not let address empty");
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    count++;
                }
            } while (count != 0);

            do
            {
                try
                {
                    Console.Write("\nInput Unit Price: ");
                    UnitPrice = float.Parse(Console.ReadLine());
                    if (quantity < 0)
                    {
                        Console.Write("Please Do not let address empty");
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    count++;
                }
            } while (count != 0);
        }


        public override string ToString()
        {
            //return "CustomerID" + customerID + "CustomerName" + customerName + "Address" + Address
            //    + "Quantity" + quantity + "UnitPrice" + UnitPrice; 
            string obj = $"{customerID}, {customerName}, {Address} , {quantity}, {UnitPrice}";
            return obj;
        }
        //public void display()
        //{
        //    Console.WriteLine($"customerid : " + customerID);
        //    Console.WriteLine($"customername : " + customerName);
        //    Console.WriteLine($"address : " + Address);
        //    Console.WriteLine($"ammount of consumpt : " + quantity);
        //    Console.WriteLine($"price : " + UnitPrice);
        //}

    }
}
