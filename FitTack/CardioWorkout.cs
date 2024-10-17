using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTack
{
    public class CardioWorkout : WorkOut // implementerar abstrakta metoden calculatecaloriesburned 
    {

        public int Distance {  get; set; }

        public CardioWorkout(DateTime date, string type, TimeSpan duration, int caloriesBurned, string notes, int distance) : base(date, type, duration, caloriesBurned, notes)
        {
            Distance = distance;
        }

        public override int CalculateCaloriesBurned()
        {
            // enkel logik för att beräkna kalorier t.ex. 
            return CaloriesBurned + Distance * 5;
        }
    }
}
