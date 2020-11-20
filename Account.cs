using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid__assignment
{
    abstract class Account
    {
        protected int balance;
        protected int diposit;
        protected int withdrow;

        public int Balance {

            get { return balance; }
            set { balance = value; }
        
        }
        public int Diposit
        {

            get { return diposit; }
            set {diposit = value; }

        }

        public int Withdrow
        {

            get { return withdrow; }
            set { withdrow = value; }

        }

        public  Account() { }

        public  Account(int a , int b, int c) {

            this.balance = a;
            this.diposit = b;
            this.withdrow = c;

        }

        public abstract void dipositAmount();
        public abstract void withdrowAmount();




    }
}
