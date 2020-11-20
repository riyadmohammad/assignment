using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid__assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter your Balance type : 1 for Current , 2 for Savings , 3 for Credite  : " );

            int a = Int32.Parse(Console.ReadLine()); 

            if(a== 1){

                Current c = new Current();
                Console.Write(" Enter Diposit amount  : ");
                c.Diposit = Int32.Parse(Console.ReadLine());
                c.dipositAmount();
                Console.Write(" Enter Withdrow amount  : ");
                c.Withdrow = Int32.Parse(Console.ReadLine());
                c.withdrowAmount();


            }
            else if(a==2)
                 {

                     Savings s = new Savings();
                     Console.Write(" Enter Diposit amopunt  : ");
                      s.Diposit = Int32.Parse(Console.ReadLine());
                      s.dipositAmount();
                      Console.Write(" Enter withdrow amopunt  : ");
                      s.Withdrow = Int32.Parse(Console.ReadLine());
                      s.withdrowAmount();


            }
            else if (a == 3)
            {

                Credit cra = new Credit();
                Console.Write(" Enter Diposit amopunt  : ");
                cra.Diposit = Int32.Parse(Console.ReadLine());
                cra.dipositAmount();
                Console.Write(" Enter Withdrow amopunt  : ");
                cra.Withdrow = Int32.Parse(Console.ReadLine());
                cra.withdrowAmount();


            }
            else { Console.WriteLine(" account type dose not match "); }



            
            
            

            

           
            

        }
    }
}
