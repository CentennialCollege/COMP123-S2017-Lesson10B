﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 11, 2017
 * Description: Demo for Lesson 10
 * Version: 0.9 - Implemented the SuperVillain > and < overloaded operator methods
 */

namespace COMP123_S2017_Lesson10B
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("SuperHero Dude", 20);
            superHero.AddPower("Spider Climbing", 50);
            superHero.AddPower("Webcasting", 40);
            Console.WriteLine(superHero.ToString());
            Console.WriteLine();
            Console.WriteLine("Karma: " + superHero.Karma);
            Console.WriteLine();

            SuperVillain superVillain = new SuperVillain("SuperVillain Dude", 20);
            superVillain.AddPower("Shadow Casting", 50);
            superVillain.AddPower("Mind Control", 40);
            superVillain.AddPower("Combat Senses", 30);
            Console.WriteLine(superVillain.ToString());
            Console.WriteLine();
            Console.WriteLine("Malice: " + superVillain.Malice);

            AntiHero batman = new AntiHero("Batman", 20, 20);
            batman.AddPower("Super Intelligence", 50);
            Console.WriteLine(batman.ToString());
            Console.WriteLine();
            Console.WriteLine("Karma: " + batman.Karma);
            Console.WriteLine("Malice: " + batman.Malice);
            
            


            if (superVillain.GetPower("Shadow Casting") > 
                superVillain.GetPower("Combat Senses"))
            {
                Console.WriteLine("Shadow Casting is more powerful than Combat Senses");
            }

            if (superVillain.GetPower("Combat Senses") >
                superVillain.GetPower("Mind Control"))
            {
                Console.WriteLine("Combat Senses is more powerful than Mind Control");
            }
            else
            {
                Console.WriteLine("Combat Senses is weaker than Mind Control");
            }




        }
    }
}

