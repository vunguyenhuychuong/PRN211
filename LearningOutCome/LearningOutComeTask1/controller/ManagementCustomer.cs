using LearningOutComeTask1.dto;
using LearningOutComeTask1.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOutComeTask1.Controller
{
    public class ManagementCustomer
    {

        Customer[] customersList = new Customer[100];
        private CustomerLocal listCustomerLocal;
        private CustomerForeigner? listcustomerForeigner;
        

        private float sumCustomerLocal = 0, sumCustomerForeigner = 0;
        private double Count;
        private double avergradeTotalBill;
        private int count;
        //private float ;


       

        public ManagementCustomer()
        {
            count = 0;
            sumCustomerForeigner = 0;
            sumCustomerLocal = 0;
            avergradeTotalBill = 0;
            for(int i = 0; i < customersList.Length; i++)
            {
                customersList[i] = new Customer();
            }
        }
            

        public void InputCustomerList(byte check)
        {
            if(count > 100)
            {
                Console.WriteLine("Full Memory!!");
            }
            else
            {
                if(check == 1)
                {
                    customersList[count] = new CustomerLocal();
                    listCustomerLocal = new CustomerLocal();
                    
                    listCustomerLocal.InputCustomerLocal();
                    sumCustomerLocal += listCustomerLocal.quantity;

                    customersList[count] = listCustomerLocal;
                    
                }
                else
                {
                    customersList[count] = new CustomerForeigner();
                    listcustomerForeigner = new CustomerForeigner();

                    listcustomerForeigner.InputCustomerForeigner();
                    sumCustomerForeigner += listcustomerForeigner.quantity;

                    customersList[count] = listcustomerForeigner;
                    
                }
                Count++;
                count++;
            }
        }

        public void ShowListLocal()
        {
            foreach (Customer customer in customersList)
            {
                Console.WriteLine(customer.ToString());
                Console.ReadLine();
            }
            if(customersList == null)
            {
                Console.WriteLine("The list is empty!!");
            }
        }

        public void TotalAmountOfConsumption()
       {
            Console.WriteLine("$==============> Total amount of comsumption LocalCustomer: " + sumCustomerLocal);
            Console.WriteLine("$==============> Total amount of consumption ForeignerCustomer: " + sumCustomerForeigner);
            Console.ReadLine();
       }

        public void AveragePriceFromCustomerAbove()
        {
            //double TotalAmount = () ;
            //avergradeTotalBill = TotalAmount;
            Console.WriteLine("The average of total bill for foreginer Customer: " + (avergradeTotalBill/Count));
        }

    }
}
