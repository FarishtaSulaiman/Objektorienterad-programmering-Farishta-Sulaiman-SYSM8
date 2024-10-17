using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTack
{
    public class StrenghtWorkout : WorkOut
    {
        public int Repetitions { get; set; }

        public StrenghtWorkout(DateTime date, string type, TimeSpan duration, int caloriesBurned, string notes, int repetitions) : base(date, type, duration, caloriesBurned, notes)
        {
            Repetitions = repetitions;
        }

        public override int CalculateCaloriesBurned()
        {
            // enkel logik för att beräkna kalorier t.ex. 
            return CaloriesBurned + Repetitions * 2;
        }
    }
}
