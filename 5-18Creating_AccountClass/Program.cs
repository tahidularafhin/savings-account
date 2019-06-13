using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_18Creating_AccountClass
{
    class Program  //5-18# Creating Account Class -Classes and Objects( Coding homework) in youtube
    {
        static void Main(string[] args)
        {
            string accNum;
            decimal startBalance, charges, credit, creditLimit;
            string quit = "1";
            while (quit!="0")
            {

            

            Console.WriteLine(" Please Enter Account number");
            accNum = Console.ReadLine();

            Console.WriteLine("Please Enter Starting Balance");
            startBalance = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please Enter all  charges");
            charges = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please Enter credit added to the account");
            credit = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please Enter Starting credit Limit");
            creditLimit = Convert.ToDecimal(Console.ReadLine());

            Account acc = new Account(accNum, startBalance, charges, credit, creditLimit);
            Console.WriteLine("Summary of account#{0}", acc.AccNum);
            if (acc.calculateNewBalance() > acc.CreditLimit)
            {
                Console.WriteLine("You have exceeded your credit Limit !");
            }
            
           
                Console.WriteLine("Your current balance is {0:C}",acc.calculateNewBalance());
                Console.WriteLine("Available is {0:C}",acc.CreditLimit-acc.calculateNewBalance());
                Console.WriteLine("Do you want to continue? Enter 0 to quit");
                quit = Console.ReadLine();
            }

            Console.ReadKey();
                
          
        }
    }
}
