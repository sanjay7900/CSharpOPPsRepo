using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOPPsRepo
{
    public class CurrentAccount : Account
    {
        private string name_of_holder;
        private double balance;
        private string accounttype = "Current Account";
        private string address;
        private int age;
        private int account_number;
        private int transcation_count = 0;
        public CurrentAccount(int userid,string name, int accNumber,double bal,string add,int age)
        {
            this.name_of_holder = name;
            this.address = add;
            this.age = age;
            this.balance = bal;
            this.account_number = accNumber; 
            this.userId = userid;
        }



        public override void AccountDetails()
        {
            Console.WriteLine("======================================================");
            Console.WriteLine(" Account UserId = " + this.userId);
            Console.WriteLine(" Account Holder Name = " + this.name_of_holder);
            Console.WriteLine("Account number  = " + this.account_number);

            Console.WriteLine("Account type = " + this.accounttype);
            Console.WriteLine(" Account balance = "+this.balance);  
            Console.WriteLine("Account holder Address = "+this.address);
            Console.WriteLine("======================================================");

        }

        public override void Deposite(int depositeAmmount)
        {
            this.balance += depositeAmmount;

        }

        public override void WithDrowal(int drowalAmmount)
        {
            double sufficient;
            sufficient = this.balance - drowalAmmount;
            
            if (((sufficient > 0 && this.transcation_count < 5) && drowalAmmount <= (50000 * 70)))
            {
                this.balance-= drowalAmmount;
                Console.WriteLine(this.balance);
                this.transcation_count++;
            }
            else if (transcation_count >= 5)
            {
                Console.WriteLine("Number of Transcation can't exceed to 5 !!");
            }
            else if (drowalAmmount > (50000 * 70))
            {
                Console.WriteLine(" your account limit can't Withdorw So much Ammount !!  ");
            }
            else
            {
                Console.WriteLine("Visit tomorrow bay  ...");
            }


            
        }
    }
}
