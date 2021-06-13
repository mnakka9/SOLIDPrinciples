using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    class OCP
    {
        /*
     A class should be closed for modification and open for extension

      */
    }

    public class AccountOCPNotFollowed
    {
        public decimal Interest { get; set; }
        public decimal Balance { get; set; }
        // members and function declaration
        public decimal CalcInterest(string accType)
        {

            if (accType == "Regular") // savings
            {
                Interest = (Balance * 4) / 100;
                if (Balance < 1000) Interest -= (Balance * 2) / 100;
                if (Balance < 50000) Interest += (Balance * 4) / 100;
            }
            else if (accType == "Salary") // salary savings
            {
                Interest = (Balance * 5) / 100;
            }
            else if (accType == "Corporate") // Corporate
            {
                Interest = (Balance * 3) / 100;
            }
            return Interest;
        }
    }


    public class OCPFollowed
    {
        public void Main()
        {
            IAccount account = new RegularSavingAccount();
            account.Balance = 500;
            Console.WriteLine(account.CalcInterest());

            account = new SalarySavingAccount();
            account.Balance = 5000;
            Console.WriteLine(account.CalcInterest());

            account = new CorporateAccount();
            account.Balance = 5000;
            Console.WriteLine(account.CalcInterest());
        }
    }


    interface IAccount
    {
        // members and function declaration, properties
        decimal Balance { get; set; }
        decimal Interest { get; set; }
        decimal CalcInterest()
        {
            decimal interest = (Balance * this.Interest) / 100;
            return interest;
        }
    }

    //regular savings account
    public class RegularSavingAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal Interest { get; set; } = 4;

        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 4) / 100;
            if (Balance < 1000) Interest -= (Balance * 2) / 100;
            if (Balance < 50000) Interest += (Balance * this.Interest) / 100;

            return Interest;
        }
    }

    //Salary savings account
    public class SalarySavingAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal Interest { get; set; } = 5;
    }

    //Corporate Account
    public class CorporateAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal Interest { get; set; } = 3;
    }
}
