using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTack
{
    public abstract class WorkOut // bas för olika typer av träningspass 
    {
        public DateTime Date {  get; set; }
        public string Type { get; set; }
        public TimeSpan Duration { get; set; }
        public int CaloriesBurned { get; set; }
        public string Notes { get; set; }

        public WorkOut(DateTime date, string type, TimeSpan duration, int caloriesburned, string notes)
        {
            Date = date;
            Type = type;
            Duration = duration;
            CaloriesBurned = caloriesburned;
            Notes = notes;

        }

        public abstract int CalculateCaloriesBurned();
    }
}
