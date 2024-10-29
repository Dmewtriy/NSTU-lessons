using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public enum tech_of_print
    {
        Laser = 1, Light, Jet, Undefined
    };
    public class Printer : off_tech
    {
        public int Speed { get; }
        public tech_of_print Tech { get; }
        public Printer() : base()
        {
            Speed = 2;
            Tech = tech_of_print.Undefined;
        }
        public Printer(int speed, tech_of_print tech, string firm = "firm", int weight = 2, int price = 1000) : base(firm, weight, price)
        {
            if (speed < 1 || speed > 10) Speed = 2;
            else Speed = speed;

            if (tech != tech_of_print.Light && tech != tech_of_print.Laser && tech != tech_of_print.Jet)
                Tech = tech_of_print.Undefined;
            else Tech = tech;
        }
        public override void print()
        {
            base.print();
            Console.Write($"\nСкорость печати: {Speed}\nТехнология печати: ");
            if (Tech == tech_of_print.Light) Console.Write("Light\n");
            if (Tech == tech_of_print.Laser) Console.Write("Laser\n");
            if (Tech == tech_of_print.Jet) Console.Write("Jet\n");
            if (Tech == tech_of_print.Undefined) Console.Write("Undefined\n");
        }
    }
}
