using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TickTackToe.Interfaces;

namespace TickTackToe
{
    class GameManager: IGameManger
   {
      

        // private members
        private string chosenNummber;
        private string playerOne;
        private string playerTwo;
        private string currentPlayer;
        private string character;
        private int counter;

        private bool PlayerHasWon;

        private UserInterfacecs userInterfacecs = new UserInterfacecs();



        /// <summary>
        /// start the game
        /// </summary>
        public void Init_System()
        {

            Console.Clear();
            userInterfacecs.WelcomeMessage();
            SetPlayersName();
            currentPlayer = playerOne;
            PlayerHasWon = false;

            while (!PlayerHasWon)
            {
                userInterfacecs.Board();
                ChoseNumber();
            }

            if (PlayerHasWon) Init_System();



        }

        /// <summary>
        /// Chose a number
        /// </summary>
        private void ChoseNumber()
        {
 
            Console.Write($"{currentPlayer} Chose a number ");
            chosenNummber = Console.ReadLine();
            SetCharacter();
          

            if (!ContainstLetter(chosenNummber))
            {
            
                  if (IsBetweenAllowdNummer(chosenNummber) && CheckIfNummerChosen(chosenNummber))
                {

                    CheckIfPlayerHasWon();
                    CheckPlayerTurn();
                }
                else
                {
                    userInterfacecs.ErrorMessageNummbers();
                    ChoseNumber();  
                }
            }
            else
            {
                userInterfacecs.ErrorMessageIsLetter();
                ChoseNumber();
            }
        }



        /// <summary>
        /// checks if it contains a letter
        /// </summary>
        /// <param name="number"></param>
        private bool ContainstLetter(string number)
        {
            bool Isletter = false;
            for (int i = 0; i < number.Length; i++)
            {
                char character = number[i];
               Isletter =  char.IsLetter(character);
            }
            return Isletter;
        }


        /// <summary>
        /// checks if the value is between 1 and 10
        /// </summary>
        /// <param name="nummber"></param>
        /// <returns></returns>
        private bool IsBetweenAllowdNummer(string nummber)
        {
            int numberValue;
            bool IsParsed = false;
            
            if(int.TryParse(nummber, out numberValue))
            {
                if (numberValue is > 0 and < 10) return IsParsed = true;
            }
            else 
            {
                return IsParsed = false;
            }

            return IsParsed;
        }


        /// <summary>
        /// Set players names
        /// </summary>
        private void SetPlayersName()
        {
            Console.Write("Name of player one is ");
            playerOne = Console.ReadLine();
            Console.Write("Name of Player two is ");
            playerTwo = Console.ReadLine();
        }

         
        /// <summary>
        /// checks which turn it is
        /// </summary>
        private void CheckPlayerTurn()
        {

            if(currentPlayer == playerOne)
            {
                currentPlayer = playerTwo;
                character = "O";
            } else
            {
                currentPlayer = playerOne;
                character = "X";
            }

        }

        /// <summary>
        /// checks if the number isnt all ready chosen
        /// If it is chosen than it will set a 'X' or 'O'
        /// </summary>
        /// <param name="number"></param>
        private bool CheckIfNummerChosen(string number)
        {
            bool isAlreadyChosen = false;    

            for (int i = 0; i < userInterfacecs.NumbersHolder.GetLength(0); i++)
            {
                for (int j = 0; j < userInterfacecs.NumbersHolder.GetLength(1); j++)
                {
                    if (userInterfacecs.NumbersHolder[i, j] == number)
                    {

                        userInterfacecs.NumbersHolder[i, j] = character;
                        isAlreadyChosen = true;
                  
                    }
                   
                }
            }  

            return isAlreadyChosen;
        }

        
        /// <summary>
        /// Sets the Character symbol for the current player
        /// </summary>
        private void SetCharacter()
        {
            if (currentPlayer == playerOne)
            {
                character = "X";
            }
            else
            {
                character = "O";
            }
        }

        /// <summary>
        /// Will check if th current player has won
        /// </summary>
        private void CheckIfPlayerHasWon()
        {

            counter++;
            #region Verticale Wins
            if (userInterfacecs.NumbersHolder[0,0] == character && userInterfacecs.NumbersHolder[1, 0] == character && userInterfacecs.NumbersHolder[2, 0] == character) RestartGame();
            else if(userInterfacecs.NumbersHolder[0,1] == character && userInterfacecs.NumbersHolder[1, 1] == character && userInterfacecs.NumbersHolder[2, 1] == character) RestartGame();
            else if(userInterfacecs.NumbersHolder[0,2] == character && userInterfacecs.NumbersHolder[1, 2] == character && userInterfacecs.NumbersHolder[2, 2] == character) RestartGame();
            #endregion
            #region Horizontal Wins
            if (userInterfacecs.NumbersHolder[0, 0] == character && userInterfacecs.NumbersHolder[0, 1] == character && userInterfacecs.NumbersHolder[0, 2] == character) RestartGame();
            else if (userInterfacecs.NumbersHolder[1, 0] == character && userInterfacecs.NumbersHolder[1, 1] == character && userInterfacecs.NumbersHolder[1, 2] == character) RestartGame();
            else if (userInterfacecs.NumbersHolder[2, 0] == character && userInterfacecs.NumbersHolder[2, 1] == character && userInterfacecs.NumbersHolder[2, 2] == character) RestartGame();
            #endregion
            #region Diagonal Wins
            if (userInterfacecs.NumbersHolder[0, 0] == character && userInterfacecs.NumbersHolder[1, 1] == character && userInterfacecs.NumbersHolder[2, 2] == character) RestartGame();
            else if (userInterfacecs.NumbersHolder[0, 2] == character && userInterfacecs.NumbersHolder[1, 1] == character && userInterfacecs.NumbersHolder[2, 0] == character) RestartGame();
            #endregion
            #region Check if their is a draw

            if (counter == 9) 
            {
                
                
                ResetNummberValue();
            }
          
            #endregion




        }

        /// <summary>
        /// Will restartd the game or exit it
        /// </summary>
        private void RestartGame()
        {
            userInterfacecs.Board();
            Console.Write($"You Have won {currentPlayer}, now please enther Oke To restart the game ");

            ResetNummberValue();
            if (Console.ReadLine() == "Oke") PlayerHasWon = true;
            else Environment.Exit(0);



        }

        /// <summary>
        /// Will reset the nummberValue
        /// </summary>
        private void ResetNummberValue()
        {
           string[,] vs =
            {
                { "1", "2", "3"},
                { "4", "5", "6"},
                { "7", "8", "9"}
            };

            counter = 0;
            userInterfacecs.NumbersHolder = vs;
        }

    }
}
