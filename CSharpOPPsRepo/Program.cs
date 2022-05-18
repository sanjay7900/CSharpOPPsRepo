using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOPPsRepo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CurrentAccount user1 = new CurrentAccount(1011,"sanjay Singh", 100204, 20000, "Noida", 21);
            user1.WithDrowal(5);
            Console.WriteLine(" balance = "+user1.AccountBalance());
            user1.WithDrowal(5);
            user1.WithDrowal(5);
            user1.WithDrowal(5);
            user1.WithDrowal(5);
            user1.WithDrowal(5);
            // user1.WithDrowal(5);
            user1.Deposite(25);
            user1.AccountDetails();

            SavingAccount user2 = new SavingAccount(1002, "Ganeshan", 20403505, 350000, "Andra Pradesh", 27);
            user2.AccountDetails();
            user2.WithDrowal(21000);

            user2.Deposite(12000);
            user2.AccountDetails();

            // Stroing the data in the data Structure...
            List<Account> AccountList = new List<Account>();

            AccountList.Add(user1);
            AccountList.Add(user2);
            foreach (var result in AccountList) { 
                result.AccountDetails();
                Console.WriteLine(result.userId);
               }
            //=====================



            Console.ReadKey();

           
        }
    }
}
