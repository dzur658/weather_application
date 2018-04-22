using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherFinalProject
{
    interface Idata_collector
    {
        double degree { get; set; }
        string day { get; set; }
        void get_data();
    }
}
