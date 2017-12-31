using System;
using TeachQuinHowToQuin;

namespace TeachQuinStuff
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Quin mainQuin = new Quin();
            mainQuin.Talk();
            BuyArt(mainQuin);
        }

        private static void BuyArt(Quin someKindOfQuin)
        {
            bool quinHasAgreedToMakeArt = false;
            int moneyOfferedToQuin = 1500;

            while(!quinHasAgreedToMakeArt)
            {
                Console.WriteLine("What art would you like from Quin?");
                string artIWantFromQuin = Console.ReadLine();
                if (someKindOfQuin.AskForArt(artIWantFromQuin, moneyOfferedToQuin))
                {
                    Console.WriteLine("Sweet, Quin said yes!");
                    CustomerIsSatisfied();
                    quinHasAgreedToMakeArt = true;
                }
                else
                {
                    moneyOfferedToQuin += 250;
                    Console.WriteLine("Oh, Quin said no.");
                }
            }
        }

        private static void CustomerIsSatisfied()
        {
            Console.WriteLine("Customer: Sweet, I'm a happy customer.");
        }
    }
}