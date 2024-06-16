using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    internal class SavingsAccount
    {
        public static double currInterestRate = 0.04;
        public double currBalance;
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }
        public static void SetInterestRate(double newRate) => currInterestRate = newRate;
        
        public static double GetInterestRate() => currInterestRate;
    }
}
