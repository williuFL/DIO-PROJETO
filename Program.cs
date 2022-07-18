using static System.Console;
using System;
using RPG.src.entities;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", "LV 42,", "HP. 469 de 749," , "MP. 72 de 72," , "Knight" );
            Wizard wizard = new Wizard("Jennica", "LV. 42,", "HP. 325 de 601, ", "MP. 474 de 482,", "White Wizard");
            Wizard topapa = new Wizard("Topapa", "LV. 42," , "HP. 106 de 385," , "MP. 611 de 641," , "Black Wizard");
            Knight wedee = new Knight("Wedee", "LV. 42," , "HP. 292 de 574," , "MP. 89 de 89," , "Ninja");

            WriteLine(arus);
            WriteLine(wizard);
            WriteLine(wedee);
            WriteLine(topapa);
            Thread.Sleep(4000);
            Clear();
            WriteLine("Oh não, o BOSS apareceu, e agora?");
            ReadKey();
            Clear();
            WriteLine("BOSS, LV. 500, HP. 1000, MP. 1000 de 1000, DEVIL");
            ReadKey();
            Clear();
            Thread.Sleep(1000);
            WriteLine(arus.AttackD(10));
            Thread.Sleep(1000);
            WriteLine(wizard.Attack(7));
            Thread.Sleep(1000);
            WriteLine(topapa.Attack(5));
            Thread.Sleep(1000);
            WriteLine(wedee.Attack());
            Thread.Sleep(1000);
            ReadKey();
            Clear();
            WriteLine("O BOSS foi derrotado com sucesso. ");
        }
    }
}