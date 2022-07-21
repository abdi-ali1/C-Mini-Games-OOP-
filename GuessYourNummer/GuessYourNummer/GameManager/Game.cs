using GuessYourNummer.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessYourNummer.GameManager
{
    public class Game
    {
        private int MaxNummer = 101;
        private int MinNummer = 0;
        private int guess;
        private Random random = new();
        private Error error = new();

        private bool isGuesed;

        public bool IsGuesed
        {
            get { return isGuesed; }
            
        }




        public Game()
        {
            guess = random.Next(0, 101);
        }


        /// <summary>
        /// sets the nummer
        /// </summary>
        public void GuesNummer()
        {
            switch (Console.ReadLine().ToLower())
            {
                case "l":
                    MaxNummer = guess;
                    NextGuest();
                    break;
                case "h":
                    MinNummer = guess;
                    NextGuest();
                    break;
                case "r":
                    isGuesed = true;
                    break;
                default:
                    error.ErrorBoxCharacter();
                    break;
            }
        }

        /// <summary>
        /// guesses the next guess
        /// </summary>
        private void NextGuest()
        {
            guess = (MaxNummer + MinNummer) / 2;
            Console.WriteLine($"is this your nummer: {guess}");
        }

        /// <summary>
        /// return true value
        /// </summary>
        /// <returns></returns>
        public int GetGuesed()
        {
            return guess;
        }

  
    }

      
    }

