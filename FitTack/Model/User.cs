using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTack.Model
{

    public class User : Person
    {
        public string Country { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public User(string userName, string passWord, string country, string securityQuestion, string securityAnswer) : base(userName, passWord)
        {

            Country = country;
            SecurityQuestion = securityQuestion;
            SecurityAnswer = securityAnswer;
        }


        // Override inloggningslogik 
        public override void SignIn()
        {

        }

        // implementation av lösenordsåterställning
        public void ResetPassword(string securityAnswer)
        {
           
        }
    }
}
   

       


    
