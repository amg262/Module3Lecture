using System;

namespace ConsoleApp1
{
    class Program
    {


        public void LemonadeStandApp()
        {
            int cups = 0, cupsPoured = 0, freeCups = 0;
            double total, tip = 0;
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

            total = cups * PRICE_OF_LEMONADE;
            
            Console.WriteLine($"Your total is {total:C}");
            Console.WriteLine("Thank you! Would you like to provide a tip? y/n>");
            
            //easy
            // string choice = Console.ReadLine();
            
            //more advanced due to converting input to valid so no error
            char yN = Console.ReadLine().ToLower()[0];

            if (yN == 'y')
            {
                Console.WriteLine("Thank you! Please enter tip amount>");
                tip = Convert.ToDouble(Console.ReadLine());
            }
            
            Console.WriteLine("\nPrint Transaction details\n---------------");
            Console.WriteLine($"Total cups sold: {cups}");
            Console.WriteLine($"Total cups poured: {cupsPoured}");
            Console.WriteLine($"Total free cups: {freeCups}");
            Console.WriteLine($"Total cost: {total:C}");
            Console.WriteLine($"Total tip: {tip:C}");
            total += tip;
            Console.WriteLine($"Total money made: {total:C}");
        }


        public void TernaryOperator()
        {
            /*
            * Using ternary operators for if-else replacement
            */
            int score;

            Console.WriteLine("Score>");
            score = Convert.ToInt32(Console.ReadLine());

            // longer way
            string output = score < 60 ? "You fail" : "You pass";
            Console.WriteLine(output);
            
            // skips variable only used once, more efficient
            Console.WriteLine(score < 60 ? "You fail" : "You pass");

        }

        public void SwitchStatement()
        {
            /*
            * switch statement always needs break after each line, even in default
            */
            int option = 0;

            Console.WriteLine("Welcome!\n1.\n2.");

            switch (option) 
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
        
        static void Main(string[] args)
        {
           //  int cups = 0, cupsPoured = 0, freeCups = 0;
           //  double total, tip = 0;
           //  const double PRICE_OF_LEMONADE = 0.99;
           //  
           //  Console.Write("Welcome! How many cups of lemonade would you like to buy?\n>");
           //  cups = Convert.ToInt32(Console.ReadLine());
           //
           //  cupsPoured = cups;
           //  if (cups >= 3)
           //  {
           //      freeCups = cups / 3;
           //      //Console.WriteLine("Thank you! Because of special, you get {0:N} cups!", freeCups);
           //      Console.WriteLine($"Thank you! Because of special, you get {freeCups:N} cups!");
           //      cupsPoured += freeCups;
           //  }
           //
           //  total = cups * PRICE_OF_LEMONADE;
           //  
           //  Console.WriteLine($"Your total is {total:C}");
           //  Console.WriteLine("Thank you! Would you like to provide a tip? y/n>");
           //  
           //  //easy
           // // string choice = Console.ReadLine();
           //  
           //  //more advanced due to converting input to valid so no error
           //  char yN = Console.ReadLine().ToLower()[0];
           //
           //  if (yN == 'y')
           //  {
           //      Console.WriteLine("Thank you! Please enter tip amount>");
           //      tip = Convert.ToDouble(Console.ReadLine());
           //  }
           //  
           //  Console.WriteLine("\nPrint Transaction details\n---------------");
           //  Console.WriteLine($"Total cups sold: {cups}");
           //  Console.WriteLine($"Total cups poured: {cupsPoured}");
           //  Console.WriteLine($"Total free cups: {freeCups}");
           //  Console.WriteLine($"Total cost: {total:C}");
           //  Console.WriteLine($"Total tip: {tip:C}");
           //  total += tip;
           //  Console.WriteLine($"Total money made: {total:C}");

            // /*
            //  * Using ternary operators for if-else replacement
            //  */
            // int score;
            //
            // Console.WriteLine("Score>");
            // score = Convert.ToInt32(Console.ReadLine());
            //
            // // longer way
            // string output = score < 60 ? "You fail" : "You pass";
            // Console.WriteLine(output);
            //
            // // skips variable only used once, more efficient
            // Console.WriteLine(score < 60 ? "You fail" : "You pass");
            //

            // /*
            //  * switch statement always needs break after each line, even in default
            //  */
            // int option = 0;
            //
            // Console.WriteLine("Welcome!\n1.\n2.");
            //
            // switch (option) 
            // {
            //     case 1:
            //         Console.WriteLine("1");
            //         break;
            //     case 2:
            //         Console.WriteLine("2");
            //         break;
            //     default:
            //         Console.WriteLine("Invalid");
            //         break;
            // }

        }
    }
}