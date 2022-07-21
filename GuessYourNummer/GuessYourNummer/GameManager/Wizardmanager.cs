using GuessYourNummer.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessYourNummer.GameManager
{
    public class Wizardmanager
    {
     
        private Random random = new();
        private Game wizardGame = new();

        /// <summary>
        /// this will start the game
        /// </summary>
        public void Init_Game()
        {
            Introduction();
         

            while (!wizardGame.IsGuesed)
            {
                Console.WriteLine($"is this your guess nummer {wizardGame.GetGuesed()}");
                wizardGame.GuesNummer();
            }


        }
        /// <summary>
        /// Shows the introduction text
        /// </summary>
        private void Introduction()
        {
            Console.WriteLine("Welcome to nummer wizard");
            Console.WriteLine("this is a intractional game where the computer is going to guess your nummer");
            Console.WriteLine("choose a nummer between 0 and 100\n");
            Console.WriteLine("if the given nummer is lower than your chosen nummer than type (l) ");
            Console.WriteLine("if the given nummer is Higher than your chosen nummer than type (h)");
            Console.WriteLine("if the given nummer is right than enther right (r) \n");

        }

       

        

     

    }
}
