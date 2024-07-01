using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                label_city_country.Text = "Ошибка при выборе города";
            }
            else
            {
                string url = "http://api.openweathermap.org/data/2.5/weather?q=" + comboBox1.SelectedItem + "&appid=2ffceb352ed6d91366a166514c9eee34&units=metric";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string response = reader.ReadToEnd();
                richTextBox1.Text = response;
                WeatherResponse wr = JsonConvert.DeserializeObject<WeatherResponse>(response);
                label_city_country.Text = wr.Name + ", " + wr.Sys.Country;
                label_temp.Text = "Температура " + wr.Main.Temp.ToString() + " ℃";
                label_pressure.Text = "Давление " + wr.Main.Pressure.ToString() + " hPa";
                label_humidity.Text = "Влажность " + wr.Main.Humidity.ToString() + " %";
                label_windspeed.Text = "Скорость ветра " + wr.Wind.Speed.ToString() + " м/c";
                label_visibility.Text = "Видимость " + wr.Visibility.ToString() + " м";
                int winddeg = wr.Wind.deg;
                string wind_destination;
                if (winddeg > 22.5 & winddeg < 67.5)
                {
                    wind_destination = "Северо-восточный";
                }
                else if (winddeg > 67.5 & winddeg < 112.5)
                {
                    wind_destination = "Восточный";
                }
                else if (winddeg > 112.5 & winddeg < 157.5)
                {
                    wind_destination = "Юго-восточный";
                }
                else if (winddeg > 157.5 & winddeg < 202.5)
                {
                    wind_destination = "Южный";
                }
                else if (winddeg > 202.5 & winddeg < 247.5)
                {
                    wind_destination = "Юго-западный";
                }
                else if (winddeg > 247.5 & winddeg < 292.5)
                {
                    wind_destination = "Западный";
                }
                else if (winddeg > 292.5 & winddeg < 337.5)
                {
                    wind_destination = "Северо-западный";
                }
                else
                {
                    wind_destination = "Северный";
                }
                label_winddeg.Text = wind_destination;
            }
        }
    }
}
