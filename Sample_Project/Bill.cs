using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Project
{
    internal class Bill

    {
        private double fixedCost;
        private int initialUnit;
        private int finalUnit;
        private double totalCost;

        public double FixedCost
        {
            get { return fixedCost; }
            set { fixedCost = value; }
        }

        public int InitialUnit
        {
            get { return initialUnit; }
            set { initialUnit = value; }
        }
        public int FinalUnit
        {
            get { return finalUnit; }
            set { finalUnit = value; }
        }
        public double TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }


        public Bill(int initialUnit, int finalUnit)
        {
            //this.fixedCost = fixedCost;
            this.initialUnit = initialUnit;
            this.finalUnit = finalUnit;
            //this.totalCost = totalCost;
        }

        public void CalculateBill()
        {
            int unitDifference = finalUnit - initialUnit;

            if (unitDifference < 0)
            {
                Console.WriteLine("Please enter valid numbers");
                totalCost = -1;
                return;
            }

            switch (unitDifference)
            {
                case <= 60 when unitDifference >= 0:
                    fixedCost = 0.00;
                    totalCost = unitDifference * 7.85 + fixedCost;
                    break;

                case <= 90:
                    fixedCost = 90.00;
                    totalCost = (60 * 7.85 + ((unitDifference - 60) * 10) + fixedCost);
                    break;

                case <= 120:
                    fixedCost = 480.00;
                    totalCost = (60 * 7.85 + 30 * 10 + ((unitDifference - 90) * 27.75));
                    break;

                case <= 180:
                    fixedCost = 480.00;
                    totalCost = (60 * 7.85 + 30 * 10 + 30 * 27.75 + ((unitDifference - 120) * 32) + fixedCost);
                    break;
                default:
                    Console.WriteLine("Check the value you entered again");
                    totalCost = -1;
                    break;


            }
        }

        public void DisplayBill(Users user) { 

            if(totalCost< 0)
            {
                return;
            }

        
            int unitDifference = finalUnit - initialUnit;

            Console.WriteLine("Electricity Bill");
            Console.WriteLine("-----------------\n");
            Console.WriteLine($"Customer Name:{user.firstName} {user.lastName}");
            Console.WriteLine($"Id No: {user.idNo}");
            Console.WriteLine($"Phone Number: {user.phoneNumber}");
            Console.WriteLine($"Initial unit: {initialUnit}");
            Console.WriteLine($"Current unit: {finalUnit}");
            Console.WriteLine($"Number of units used for month: {unitDifference}");
            Console.WriteLine($"Total Cost:{totalCost}");
        }
    }
}
