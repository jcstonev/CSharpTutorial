using System;
namespace TeachQuinHowToQuin
{
    public class Quin
    {
        public void Talk()
        {
            Console.WriteLine("Hello World, I Quin\nQuin Do Art\nQuin Like Women");
        }

        public bool AskForArt(string art)
        {
            Console.WriteLine("No money was offered!!!!!!!!!");
            if(art == "Painting" || art == "painting")
            {
                Console.WriteLine("Quin: Yeah I can make that.");
                return true;
            }
            else
            {
                Console.WriteLine("Quin: No thanks. Not my style.");
                return false;
            }
        }

        public bool AskForArt(string art, int moneyOffered)
        {
            Console.WriteLine("Quin was offered " + moneyOffered + " dollars");
            bool isAPainting = (art == "Painting" || art == "painting");
            bool offeredEnoughMoney = (moneyOffered >= 2000);
            if (isAPainting && offeredEnoughMoney)
            {
                Console.WriteLine("Quin: Yeah I can make that.");
                return true;
            }
            else
            {
                Console.WriteLine("Quin: No thanks. Not my style.");
                return false;
            }
        }
    }
}