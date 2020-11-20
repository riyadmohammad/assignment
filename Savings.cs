using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid__assignment
{
    class Savings: Account
    {
        protected int fixAmount = 10000;

        public Savings() { Console.WriteLine("Your Balance : " + balance); }
        public Savings(int b, int d, int w) : base(b, d, w) { Console.WriteLine("Your Balance : " + balance); }

        public override void dipositAmount()
        {
            if (diposit == fixAmount)
            {

                balance = balance + diposit;
                Console.WriteLine("Your Balance after Diposit : " + balance);
            }
            else { Console.WriteLine("You can deposit only 10000 BDT"); }

            
        }

        public override void withdrowAmount()
        {
            if (withdrow < balance)
            {
                balance = balance - withdrow;
                Console.WriteLine("Your Balance after withdrow : " + balance);
            }
            else { Console.WriteLine("Insaficient Balance. Your Balance is: " + balance); }
           
        }
    }
}
