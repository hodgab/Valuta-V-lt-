using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form_ablak : Form
    {
        public static double arfolyamkereses(String errol, String erre)
        {

            /*
             * FONTOS: Én a 110.0.5481.77-es chromedrivert használtam,
             * a projekt mappán belül a /bin/Debug helyen található ha hibát dob
             * valószínű a verzió eltérésből származik.
             */

            // A Chromedriver parancssorának eltüntetése
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;

            ChromeOptions beallitas = new ChromeOptions();  
            beallitas.AddArgument("headless");  // headless mód = nem jelenik meg a böngésző GUI-ja
            IWebDriver driver = new ChromeDriver(driverService, beallitas); // webdriver
            // ----- webdriver navigálása majd a valuta árfolyam kinyerése a HTML kódból -----
            driver.Navigate().GoToUrl("https://www.google.com");
            var keresoMezo = driver.FindElement(By.XPath("//input[@name='q']"));
            driver.FindElement(By.XPath("//button[@id='L2AGLb']")).Click();
            String kereses = errol + " to " + erre;
            keresoMezo.SendKeys(kereses);
            keresoMezo.Submit();
            var szorzoElem = driver.FindElement(By.XPath("//span[@class='DFlfde SwHCTb']")).Text;
            double szorzo = Convert.ToDouble(szorzoElem);

            // --x-- webdriver navigálása majd a valuta árfolyam kinyerése a HTML kódból --x--

            // webdriver bezárása
            driver.Close();
            

            return szorzo;
        }
        public form_ablak()
        {
            InitializeComponent();
            
        }

        private void btn_atvalt_Click(object sender, EventArgs e)
        {
            // A Comboboxok értékei (EUR, HUF, GBP...stb)
            String errol = cbx_errol.SelectedItem.ToString();
            String erre = cbx_erre.SelectedItem.ToString();
            double szorzo;
            if(errol == erre)
            {
                szorzo = 1; // Ha például HUF-ot akarunk HUF-ra nyilván 1 lesz a szorzó
            }
            else
            {
                szorzo = arfolyamkereses(errol, erre); // Egyébként függvény hívás -> google keresés(Selenium)
            }
            
            // Végeredmény kiszámolása
            double mennyiseg = Convert.ToDouble(txt_mennyiseg.Text);
            double atvaltott = szorzo * mennyiseg;

            // Label megjelenítése az ablakon
            lbl_atvaltott.Text = "Átváltott mennyiség: " + Math.Round(atvaltott, 2) +" "+ erre;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
