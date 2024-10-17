using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTack
{
    public class User : Person // lägger till ytterliggare egenskaper och metoder

    {

        // property 
        public string Country { get; set; }

        public string SecurityQuestion { get; set; }

        public string SecurityAnswer { get; set; }


        // konstruktor 

        public User(string userName, string passWord, string country, string securityQuestion, string securityAnswer) : base(userName, passWord)
        {

            this.Country = country;
            this.SecurityQuestion = securityQuestion;
            this.SecurityAnswer = securityAnswer;
        }

        public override void SignIn()
        {
            // logik för inlogg 
            {
                if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(PassWord))
                {
                    Console.WriteLine("Användarnamn eller lösenord får inte vara tomma.");
                    return;
                }

            }
        }

        private void ResetPassword(string securityAnswer)
        {
            if (SecurityAnswer == SecurityAnswer)
            {
                Console.WriteLine("Lösenord återställs. Ange ett nytt lösenord.");
                //OBS! måste lägga till logik sen för att uppdatera lösenord 
            }
            else
            {
                Console.WriteLine("Fel svar på säkerhetsfrågan. Återställning misslyckades.");
            }
        }



    }
}