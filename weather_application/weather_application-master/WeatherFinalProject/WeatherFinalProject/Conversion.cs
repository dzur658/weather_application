using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherFinalProject
{
    class Conversion
    {
        public string day;
        public double degree;

        void get_data()
        {
            degree = 40;
        }
        public Conversion()
        {
            get_data();
        }
        public double ret(double short_circut)
        {
            //assume degree will always be given in fahrenheit
            return (short_circut - 32) * 5 / 9;
        }
    }
}
