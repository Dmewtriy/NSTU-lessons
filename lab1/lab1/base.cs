using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class off_tech
    {
        private string firm;
        public string Firm
        {
            set
            {
                if (value == "") firm = "firm";
                else firm = value;
            }
            get 
            {
                return firm;
            }
        }
        private int weight;
        public int Weight
        {
            set
            {
                if (value < 1 || value > 20) weight = 1;
                else weight = value;
            }
            get { return weight; }
        }
        private int price;
        public int Price
        {
            set
            {
                if (value < 100 || value > 1000000) price = 1000;
                else price = value;
            }
            get 
            {
                return price;
            }
        }
        public off_tech()
        {
            firm = "firm";
            weight = 2;
            price = 1000;
        }
        public off_tech(string firm, int weight, int price)
        {
            if (weight < 1 || weight > 20) Weight = 2;
            else Weight = weight;

            if (firm == "") Firm = "firm";
            else Firm = firm;

            if (price < 100 || price > 1000000) Price = 1000;
            else Price = price;
        }
        public virtual void print()
        {
            Console.WriteLine($"\n\nФирма: {Firm} \nВес: {Weight}\nЦена: {Price}");
        }
    }
}
