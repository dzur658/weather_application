using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherFinalProject
{
    class days_of_the_week
    {
        public string day;

        public days_of_the_week(string day_two)
        {
            if((day_two == "Monday") || (day_two == "Tuesday") || (day_two == "Wednesday") || (day_two == "Thursday") || (day_two == "Friday") || (day_two == "Saturday") || (day_two == "Sunday"))
            {
                this.day = day_two;
            }
            else
            {
                this.day = "ERROR";
            }
        }
        public string ret()
        {
            return day;
        }
    }
}
