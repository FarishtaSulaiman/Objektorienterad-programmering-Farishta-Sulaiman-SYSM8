using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTack
{
    public class User : Person

    {

        // property 
        public string Country { get; set; }

        public string SecurityQuestion { get; set; }

        public string SecurityAnswer { get; set; }


        // konstruktor 

        public User(string UserName, string PassWord, string Country, string SecurityQuestion, string SecurityAnswer) : base(UserName, PassWord)
        {

            this.Country = Country;
            this.SecurityQuestion = SecurityQuestion;
            this.SecurityAnswer = SecurityAnswer;
        }

       public override void SignIn()
        {
            // logik för inlogg 
        }




        public void ResetPassword(string SecurityAnswer)
        {
            if (this.SecurityAnswer == SecurityAnswer)
            {
                // logik för återställande av lösenord
            }
        }
    }
    
}
