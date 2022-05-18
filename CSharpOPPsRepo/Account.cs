using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOPPsRepo
{
    public abstract class Account
    {
        public int userId;
        public abstract void WithDrowal(int drowalAmmount);
        public abstract  void Deposite (int depositeAmmount);
        public abstract void AccountDetails();


    }
}
