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

            //TextBox.Text = response;
            string test = "hello";

            int x_value = 0;
            int y_value = 0;
            /*while (i <= 7)
            {
                PictureBox display_pannel = new PictureBox();
                display_pannel.Width = 100;
                display_pannel.Height = 100;

                //change file path for bmp image on hyland VMs
                Bitmap image = new Bitmap(@"C:\Users\dzure\Documents\weather_pannel.bmp");
                display_pannel.Dock = DockStyle.Fill;
                display_pannel.Image = (Image)image;

                //display_pannel.Location = new Point(x_value, y_value);
                x_value += 50;
                y_value += 50;
                i++;
                display_pannel.Left += 50;
                display_pannel.Top += 50;
                Controls.Add(display_pannel);
                display_pannel.BringToFront();
            }*/
            List<PictureBox> pannels = new List<PictureBox>();

            bool Mr_Booly = true;
            for (int i = 0; i <= 7; i++) {
                if (Mr_Booly == false)
                {
                    PictureBox pannel = new PictureBox
                    {
                        Name = "pannel" + i,
                        Size = new Size(100, 200),
                        Location = new Point(i * 100 + 50, 150)
                    };
                    pannel.ImageLocation = @"C:\Users\dzure\Documents\weather_pannel.bmp";
                    pannels.Add(pannel);
                }
                else
                {
                    PictureBox pannel = new PictureBox
                    {
                        Name = "pannel" + i,
                        Size = new Size(100, 200),
                        Location = new Point(50, 150)
                    };
                    pannel.ImageLocation = @"C:\Users\dzure\Documents\weather_pannel.bmp";
                    pannels.Add(pannel);
                    Mr_Booly = false;
                }
            }
            foreach (PictureBox p in pannels)
            {
                Controls.Add(p);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
