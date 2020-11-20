using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid__assignment
{
    class Current: Account
    {

        public Current() { Console.WriteLine("Your Balance : " + balance); }
        public  Current (int b, int d , int w ):base(b,d,w){

            Console.WriteLine("Your Balance : " + balance);
        
        }

        

        public override void dipositAmount()
        {

            balance = balance + diposit;
            Console.WriteLine("Your Balance after Diposit : " + balance);
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
