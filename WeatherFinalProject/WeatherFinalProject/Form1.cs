using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WeatherFinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WebRequest req = WebRequest.Create("https://weather.com/weather/today/l/USOH1037:1:US");
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            Stream data = res.GetResponseStream();
            StreamReader reader = new StreamReader(data);
            string response = reader.ReadToEnd();

            TextBox.Text = response;
            string test = "hello";

        }
    }
}
