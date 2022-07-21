using GuessYourNummer.Errors;
using GuessYourNummer.GameManager;

namespace GuessYourNummer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wizardmanager wizardmanager = new Wizardmanager();
            wizardmanager.Init_Game();
           
        }
    }
}