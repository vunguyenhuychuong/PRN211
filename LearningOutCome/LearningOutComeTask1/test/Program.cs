using LearningOutComeTask1.Controller;
using System;


namespace LearningOutComeTask1.Test
{
    public class Progam
    {   

        public static void Main(string[] args)
        {
            int count = 0;
            int choice = 0;
            ManagementCustomer List = new ManagementCustomer();
            do
            {
                Console.Clear();
                Console.WriteLine("$|=======================*********MENU********=====================|");
                Console.WriteLine("$|   1) Input Information Bill for Local(VietNam) customers"         );
                Console.WriteLine("$|   2) Input Information Bill for Foreginer(Above) customers"       );
                Console.WriteLine("$|   3) Export a list Bill"                                          );
                Console.WriteLine("$|   4) Calculate the total ammount of KW for type of customer"      );
                Console.WriteLine("$|   5) Calculate the Average of total bill for Foreigner Customer"  );
                Console.WriteLine("$|   0) Exit the program"                                            );
                Console.WriteLine("$|=======================********************======================|");

                do
                {
                    try
                    {
                        count = 0;
                        String pattern = "[a-z]+";
                        Console.Write("     Select your choice:     ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice.Equals(pattern))
                        {
                            throw new Exception();
                        }
                    }catch(Exception e)
                    {
                        Console.WriteLine("Please dont type character");
                        count++;
                    }
                } while (count != 0);
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        int choice1;
                        do
                        {
                            Console.WriteLine("Input the local customer");
                            Console.WriteLine("1. Add the customer");
                            Console.WriteLine("2. Exit");
                            choice1 = Convert.ToInt32(Console.ReadLine());
                            switch (choice1)
                            {
                                case 1:
                                    List.InputCustomerList(1);
                                    break;
                            }
                        } while (choice1 == 1);
                        break;
                    case 2:
                        Console.Clear();
                        int choice2;
                        do
                        {
                            Console.WriteLine("Input the foreigner customer");
                            Console.WriteLine("1. Add the foreignerCustomer");
                            Console.WriteLine("2. Exit");
                            choice2 = Convert.ToInt32(Console.ReadLine());
                            switch (choice2)
                            {
                                case 1:
                                    List.InputCustomerList(2);
                                    break;
                            }
                        } while (choice2 == 1);
                        break;
                    case 3:
                        Console.Clear();
                        int choice3;
                        do
                        {
                            Console.WriteLine("Input the local customer");
                            Console.WriteLine("1. Show List Bills of Customer ");
                            Console.WriteLine("2. Exit");
                            choice3= Convert.ToInt32(Console.ReadLine());
                            switch (choice3)
                            {
                                case 1:
                                    List.ShowListLocal();
                                    break;
                            }
                        } while (choice3 == 1);
                        break;
                    case 4:
                        Console.Clear();
                        int choice4;
                        do
                        {
                            Console.WriteLine("Input the local customer");
                            Console.WriteLine("1. Show Sum of KW consumption base on customer typically");
                            Console.WriteLine("2. Exit");
                            choice4 = Convert.ToInt32(Console.ReadLine());
                            switch (choice4)
                            {
                                case 1:
                                    List.TotalAmountOfConsumption();
                                    break;
                            }
                        } while (choice4 == 1);
                        break;
                    case 5:
                        int choice5;
                        do
                        {
                            Console.WriteLine("Input the local customer");
                            Console.WriteLine("1. Average costs of customer from Above ");
                            Console.WriteLine("2. Exit");
                            choice5 = Convert.ToInt32(Console.ReadLine());
                            switch (choice5)
                            {
                                case 1:
                                    List.AveragePriceFromCustomerAbove();
                                    break;
                            }
                        } while (choice5 == 1);
                        Console.Clear();
                        break;
                }
            } while (choice != 5);
        }    
    }
}
