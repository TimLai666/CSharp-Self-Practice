using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowAndRepay
{
    public class Person
    {
        public string name;
        public int money;
        public Person(string name, int money)
        {
            this.name = name;
            this.money = money;
        }

        public void Borrow(Person lender, int amount)
        {
            if (amount <= lender.money)
            {
                this.money += amount;
                lender.money -= amount;
            }
        }

        public void Repay(Person lender, int amount)
        {
            if (amount <= this.money)
            {
                this.money -= amount;
                lender.money += amount;
            }
        }
    }
}
