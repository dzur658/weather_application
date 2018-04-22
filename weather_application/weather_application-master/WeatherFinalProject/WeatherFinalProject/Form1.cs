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
using HtmlAgilityPack;

namespace WeatherFinalProject
{
    public partial class Form1 : Form
    {
        List<Label> labels = new List<Label>();
        public string get_degree()
        {
            var html = @"https://weather.com/weather/tenday/l/44145:4:US";

            HtmlWeb web = new HtmlWeb();

            HtmlAgilityPack.HtmlDocument htmlDoc = web.Load(html);

            HtmlNode node = htmlDoc.DocumentNode.SelectSingleNode("//div[@id='temps']");

            return Convert.ToString(node.InnerText);
        }
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
            List<Label> days = new List<Label>();
            /*List<days_of_the_week> days_string = new List<days_of_the_week>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };*/
            List<days_of_the_week>days_string = new List<days_of_the_week>();
            days_of_the_week Monday = new days_of_the_week("Monday");
            days_of_the_week Tuesday = new days_of_the_week("Tuesday");
            days_of_the_week Wednesday = new days_of_the_week("Wednesday");
            days_of_the_week Thursday = new days_of_the_week("Thursday");
            days_of_the_week Friday = new days_of_the_week("Friday");
            days_of_the_week Saturday = new days_of_the_week("Saturday");
            days_of_the_week Sunday = new days_of_the_week("Sunday");
            days_string.Add(Monday);
            days_string.Add(Tuesday);
            days_string.Add(Wednesday);
            days_string.Add(Thursday);
            days_string.Add(Friday);
            days_string.Add(Saturday);
            days_string.Add(Sunday);
            bool Mr_Booly = true;
            bool Mr_Booly_two = true;
            Graphics Mr_Graphy = CreateGraphics();
            for (int i = 0; i <= 6; i++) {
                if (Mr_Booly == false)
                {
                    PictureBox pannel = new PictureBox
                    {
                        Name = "pannel" + i,
                        Size = new Size(100, 200),
                        Location = new Point(i * 100 + 50, 150),
                        Text = "text"
                    };
                    Label degrees_uno = new Label
                    {
                        Name = "Label_Degree" + i,
                        Size = new Size(30, 15),
                        Location = new Point(i * 100 + 50 + 40, 180),
                        Text = Convert.ToString(get_degree()) + "°F",
                        BackColor = System.Drawing.Color.Transparent
                    };
                    Label day_uno = new Label
                    {
                        Name = "Label" + i,
                        Size = new Size(65, 15),
                        Location = new Point(i * 100 + 50, 150),
                        Text = days_string[i].ret(),
                        BackColor = System.Drawing.Color.Transparent
                    };
                    //pannel.ImageLocation = @"C:\Users\User1\Documents\weather_pannel.bmp";
                    pannel.ImageLocation = @"C:\Users\dzure\Documents\weather_pannel.bmp";
                    pannels.Add(pannel);
                    labels.Add(degrees_uno);
                    days.Add(day_uno);
                }
                else
                {
                    PictureBox pannel = new PictureBox
                    {
                        Name = "pannel" + i,
                        Size = new Size(100, 200),
                        Location = new Point(50, 150)
                    };
                    Label degrees_uno = new Label
                    {
                        Name = "Label_Degree" + i,
                        Size = new Size(30, 15),
                        Location = new Point(i * 100 + 50 + 40, 180),
                        Text = Convert.ToString(get_degree()) + "°F",
                        BackColor = System.Drawing.Color.Transparent
                    };
                    Label day_uno = new Label
                    {
                        Name = "Label" + i,
                        Size = new Size(65, 15),
                        Location = new Point(i * 100 + 50, 150),
                        Text = days_string[i].ret(),
                        BackColor = System.Drawing.Color.Transparent
                    };
                    //pannel.ImageLocation = @"C:\Users\User1\Documents\weather_pannel.bmp";
                    pannel.ImageLocation = @"C:\Users\dzure\Documents\weather_pannel.bmp";
                    pannels.Add(pannel);
                    labels.Add(degrees_uno);
                    days.Add(day_uno);
                    Mr_Booly = false;
                }
            }
            foreach (PictureBox p in pannels)
            {
                Controls.Add(p);
            }
            foreach (Label n in labels)
            {
                Controls.Add(n);
                n.BringToFront();
            }
            foreach (Label m in days)
            {
                Controls.Add(m);
                m.BringToFront();
            }
            /*Conversion test_two = new Conversion();
            our_test_box.Text = Convert.ToString(test_two.ret());*/
            //^the aforementioned text box no longer exists
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void converter_Click(object sender, EventArgs e)
        {
            Conversion converty = new Conversion();
            foreach (Label n in labels)
            {
                n.Text = Convert.ToString(converty.ret(32)) + "°C";
                this.Update();
            }
        }
    }
}
