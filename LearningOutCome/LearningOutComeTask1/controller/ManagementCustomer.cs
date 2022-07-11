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
        private double SumTien = 0;
        private int countKh;
        private double dem = 0;




        public ManagementCustomer()
        {
            countKh = 0;
            for(int i = 0; i < customersList.Length; i++)
            {
                customersList[i] = new Customer();
            }
        }
            

        public void InputCustomerList(byte check)
        {
            if(countKh > 100)
            {
                Console.WriteLine("Full Memory!!");
            }
            else
            {
                if(check == 1)
                {
                    customersList[countKh] = new CustomerLocal();
                    listCustomerLocal = new CustomerLocal();
                    
                    listCustomerLocal.InputCustomerLocal();
                    listCustomerLocal.totalBill = listCustomerLocal.TTien();
                    customersList[countKh] = listCustomerLocal;
                    sumCustomerLocal += listCustomerLocal.quantity;                    
                }
                else
                {
                    customersList[countKh] = new CustomerForeigner();
                    listcustomerForeigner = new CustomerForeigner();

                    listcustomerForeigner.InputCustomerForeigner();
                    listcustomerForeigner.totalBill=listcustomerForeigner.TTien();
                    customersList[countKh] = listcustomerForeigner;
                    sumCustomerForeigner += listcustomerForeigner.quantity;
                    SumTien += listcustomerForeigner.totalBill;                  
                }
                dem++;
                countKh++;
            }
        }

        public void showListCustomerAll()
        {
            if(countKh == 0)
            {
                Console.WriteLine("No data");
            }
            else
            {
                for (int i = 0; i < countKh; i++)
                {
                    Console.WriteLine("  Number of the List Bill {0}", i + 1);
                    if (customersList[i].GetType() == typeof(CustomerLocal))
                    {
                        listCustomerLocal = (CustomerLocal)customersList[i];
                        listCustomerLocal.DisplayCustomerLocal();
                    }
                    else
                    {
                        listcustomerForeigner = (CustomerForeigner)customersList[i];
                        listcustomerForeigner.DisplayCustomerAbove();
                    }
                }
                Console.ReadKey();
            }          
        }
        public void TotalAmountOfConsumption()
        {
            Console.WriteLine("$==============> Total amount of comsumption LocalCustomer: " + sumCustomerLocal + "KW");
            Console.WriteLine("$==============> Total amount of consumption ForeignerCustomer: " + sumCustomerForeigner + "KW");
            Console.ReadLine();
        }

        public void AveragePriceFromCustomerAbove()
        {
            if(listcustomerForeigner.customerID != 0)
            {
                Console.WriteLine("The average of total bill for foreginer Customer: " + SumTien/dem);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No data load!");
            }           
        }
    }
}
