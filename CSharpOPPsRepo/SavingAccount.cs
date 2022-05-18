﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOPPsRepo
{
    public class SavingAccount : Account
    {
        private string name_of_holder;
        private double balance;
        private string accounttype = "Saving Account";
        private string address;
        private int account_number;
        private int age;
        private int transcation_count = 0;
        public SavingAccount(int userid,string name, int accNumber, double bal, string add, int age)
        {
            this.name_of_holder = name;
            this.address = add;
            this.age = age;
            this.balance = bal;
            this.account_number = accNumber;
            this.userId = userid;   
        }
        public override double AccountBalance()
        {
           return this.balance;
        }



        public override void AccountDetails()
        {
            Console.WriteLine("======================================================");

            Console.WriteLine(" Account UserId = " + this.userId);
            Console.WriteLine(" Account Holder Name = " + this.name_of_holder);
            Console.WriteLine("Account type = " + this.accounttype);
            Console.WriteLine(" Account balance = " + this.balance);
            Console.WriteLine("Account holder Address = " + this.address);
            Console.WriteLine(" age = " + this.age);
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
            if (((sufficient > 0 && this.transcation_count <= 5) && drowalAmmount <= (50000 * 70)))
            {
                this.balance -= drowalAmmount;
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
