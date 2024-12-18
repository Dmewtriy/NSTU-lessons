using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab3
{
    internal class Program
    {
        static void Main()
        {
            Game game = new Game(new Player(), new Player()).LoadGame("2024-12-18_22-57-49");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
    }
}

