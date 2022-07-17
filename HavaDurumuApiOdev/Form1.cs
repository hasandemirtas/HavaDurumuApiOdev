using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HavaDurumuApiOdev
{
    public partial class Form1 : Form
    {
        static String[] sehirler = new string[81]
        {
            "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", 
            "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", 
            "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", 
            "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır",
            "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", 
            "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay",
            "Isparta", "İçel (Mersin)", "İstanbul", "İzmir", "Kars",
            "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli",
            "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş",
            "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu",
            "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas",
            "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa",
            "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt",
            "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan",
            "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string sehir in sehirler)
            {
                cbSehirler.Items.Add(sehir);
            }
            cbSehirler.SelectedItem = "Adana";
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            lblHavaDurumu.Text = "Bekleyiniz...";
            GetWeather();
        }

        private void GetWeather()
        {
            string api = "476ac7e8874328c04bd4cba59216539c";
            string baglanti = "http://api.openweathermap.org/data/2.5/weather?q="+cbSehirler.SelectedItem+"&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument Hava = XDocument.Load(baglanti);
            var sicaklik = Hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var durum = Hava.Descendants("weather").ElementAt(0).Attribute("value").Value;
            lblHavaDurumu.Text = cbSehirler.SelectedItem +" şehrinde \n Sıcaklık: " + sicaklik + " ºC \n Durum: "+ durum;
        }
    }
}
