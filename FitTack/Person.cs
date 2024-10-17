using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTack
{
    public abstract class Person
    {

        // property
        public string UserName { get; set; }
        public string PassWord { get; set; }

        // konstruktor
        public Person(string UserName, string PassWord)
        {
            this.UserName = UserName;
            this.PassWord = PassWord;

        }

        // metod 
        public abstract string SignIn();

    }
}

