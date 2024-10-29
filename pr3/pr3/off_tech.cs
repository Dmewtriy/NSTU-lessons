using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3
{
    public class off_tech : IComparable<off_tech>, ICloneable
    {
        private string Firm;
        public string firm
        {
            set
            {
                if (value == "") Firm = "Firm";
                else Firm = value;
            }
            get
            {
                return Firm;
            }
        }
        private int Weight;
        public int weight
        {
            set
            {
                if (value < 1 || value > 20) Weight = 1;
                else Weight = value;
            }
            get { return Weight; }
        }
        private int Price;
        public int price
        {
            set
            {
                if (value < 100 || value > 1000000) Price = 1000;
                else Price = value;
            }
            get
            {
                return Price;
            }
        }
        public off_tech()
        {
            Firm = "";
            Weight = 0;
            Price = 1000;
        }
        public off_tech(string firm, int weight, int price)
        {
            if (weight < 1 || weight > 20) Weight = 0;
            else Weight = weight;

            if (firm == "") Firm = "Firm";
            else Firm = firm;

            if (price < 100 || price > 1000000) Price = 1000;
            else Price = price;
        }
        public virtual void print()
        {
            Console.WriteLine($"Фирма: {Firm} \nВес: {Weight}\nЦена: {Price}");
        }

        public int CompareTo(off_tech o)
        {
            return this.Firm.CompareTo(o.Firm);
        }
        
        

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class off_techComparer : IComparer<off_tech>
    {
        public int Compare(off_tech o1, off_tech o2)
        {
            if (o1.firm.Length > o2.firm.Length)
            {
                return 1;
            }
            else if (o1.firm.Length < o2.firm.Length)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
