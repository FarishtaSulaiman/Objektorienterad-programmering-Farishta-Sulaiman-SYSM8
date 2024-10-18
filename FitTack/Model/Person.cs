using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTack.Model
{
    public abstract class Person // denna klass fungerar som bas för användare 
    {

        // property
        public string UserName { get; set; }
        public string PassWord { get; set; }

        // konstruktor
        public Person(string userName, string passWord)
        {
            UserName = userName;
            PassWord = passWord;

        }

        //  abstrakt metod utan implementering, det är underklasserna som måste implementera den 
        public abstract void SignIn();




    }
}

