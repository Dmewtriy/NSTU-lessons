using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Fax : off_tech
    {
        public int ResOfPages { get; }
        public bool Delay_Send { get; }

        public Fax() : base()
        {
            ResOfPages = 100;
            Delay_Send = false;
        }
        public Fax(int ResOfPages, bool Delay_Send, string Firm = "firm", int Weight = 2, int Price = 100) : base(Firm, Weight, Price)
        {
            if (ResOfPages < 100 || ResOfPages > 6000) this.ResOfPages = 100;
            else this.ResOfPages = ResOfPages;

            if (Delay_Send != false && Delay_Send != true)
                this.Delay_Send = false;
            else this.Delay_Send = Delay_Send;
        }
        public override void print()
        {
            base.print();
            Console.Write($"\nРазрешение страницы: {ResOfPages}\nНаличие задержки печати: ");
            if (Delay_Send == true) Console.Write("Есть\n");
            if (Delay_Send == false) Console.Write("Отсутсвует\n");
        }
    }
}
