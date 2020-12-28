using System;
using System.Collections.Generic;
using System.Text;

namespace ObectPractice
{
    public class Money
    {
        private int count;
        private int cost;

        public int Cost { get; set; }
        public int Count { get; set; }

        public int SumOfMoney
        {
            get
            {
                return cost * count;
            }
        }
        public Money(int count, int cost)
        {
            this.cost = cost;
            this.count = count;
        }

        public void About()
        {
            Console.Write("Cost = ");
            Console.WriteLine(cost);
            Console.Write("Count = ");
            Console.WriteLine(count);
        }

        public bool IsEnoughtToBuy(int needMoney)
        {
            if (needMoney > cost)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int CountOfItemsEnoight(int costOfItem)
        {
            return cost / costOfItem;
        }


    }
}
