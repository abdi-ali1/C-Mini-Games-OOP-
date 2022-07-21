using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToe
{
    class UserInterfacecs
    {

        // Members
        private string[,] numbersHolder =
        {
            { "1", "2", "3"},
            { "4", "5", "6"},
            { "7", "8", "9"}
        };

        // public properties
        public string[,] NumbersHolder
        {
            get
            {
                return numbersHolder;
            }
            set
            {
                numbersHolder = value;
            }
        }

       
        public void Board()
        {

         
            Console.Clear();
       
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", NumbersHolder[0, 0], NumbersHolder[0, 1], NumbersHolder[0, 2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", NumbersHolder[1, 0], NumbersHolder[1, 1], NumbersHolder[1, 2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", NumbersHolder[2, 0], NumbersHolder[2, 1], NumbersHolder[2, 2]);
            Console.WriteLine("     |     |      ");
        }

      
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to ticktackToe\n");
          
        }

       
        public void ErrorMessageIsLetter()
        {
            Console.WriteLine("Please enther a number");
        }

      
        public void ErrorMessageNummbers()
        {
            Console.WriteLine("Please enther a value between 1 and 10 or your nummber is already chosen");
        }


       
    }
}
