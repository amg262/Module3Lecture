﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cups, cupsPoured = 0, freeCups;
            double total, tip;
            const double PRICE_OF_LEMONADE = 0.99;
            
            Console.Write("Welcome! How many cups of lemonade would you like to buy?\n>");
            cups = Convert.ToInt32(Console.ReadLine());

            cupsPoured = cups;
            if (cups >= 3)
            {
                freeCups = cups / 3;
                //Console.WriteLine("Thank you! Because of special, you get {0:N} cups!", freeCups);
                Console.WriteLine($"Thank you! Because of special, you get {freeCups:N} cups!");
                cupsPoured += freeCups;

            }
        }
    }
}