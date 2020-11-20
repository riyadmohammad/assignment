using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid__assignment
{
    class Credit : Account
    {

        private int creditLimite = -10000;

        public Credit() { Console.WriteLine("Your Balance : " + balance); }
        public Credit(int b, int d, int w) : base(b, d, w) { }

        public override void dipositAmount()
        {

            balance = (balance+diposit) ;
            Console.WriteLine("Your Balance after Diposit : " + balance);
        }

        public override void withdrowAmount()
        {
            
            

                
                    balance =balance -withdrow ;
                    

                    if (balance >= creditLimite)
                    { Console.WriteLine("Your Balance after withdrow : " + balance); }

                    else { Console.WriteLine(" credite limite is crossed  "); }
           
            
           
        }
    }
}
