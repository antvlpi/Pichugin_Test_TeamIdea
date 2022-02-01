using System;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Pichugin_Test_TeamIdea
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            label_Date.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        public double ConvertCurrency(double currentCurrency, XmlDocument xmlDoc, string currencyValue)
        {
            double nominal = 0;
            double value = 0;

            foreach (XmlElement currencyXMLElem in xmlDoc.DocumentElement)
            {
                if (currencyXMLElem.GetAttribute("ID") == currencyValue)
                {
                    foreach (XmlNode nominalXMLElem in currencyXMLElem.GetElementsByTagName("Nominal"))
                    {
                        nominal = Convert.ToDouble(nominalXMLElem.InnerText);
                    }

                    foreach (XmlNode valueXMLElem in currencyXMLElem.GetElementsByTagName("Value"))
                    {
                        value = Convert.ToDouble(valueXMLElem.InnerText);
                    }
                }
            }

            // Т.к. всего 2 валюты для конвертации, можно исспользовать тернарный оператор
            return currencyValue == "R01135" ? Math.Round(currentCurrency * value / nominal, 2) : Math.Round(currentCurrency / value * nominal, 2);
        }

        async Task<string> DownloadXMLText()
        {
            using (WebClient cbrWC = new WebClient())
            {
                return await Task.Run(() => cbrWC.DownloadString("http://www.cbr.ru/scripts/XML_daily.asp"));
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Если точка в поле ввода, меняем на запятую для double
            if (textBox_CurrencyHUFQuantity.Text.Contains('.'))
            {
                textBox_CurrencyHUFQuantity.Text = textBox_CurrencyHUFQuantity.Text.Replace('.', ',');
            }

            // Если нет символа, добавляем дробную часть денег
            if (!textBox_CurrencyHUFQuantity.Text.Contains(','))
            {
                textBox_CurrencyHUFQuantity.Text = textBox_CurrencyHUFQuantity.Text + ",00";
            }
            else
            {
                textBox_CurrencyHUFQuantity.Text = textBox_CurrencyHUFQuantity.Text + "00";
            }

            // Подключаемся на сайт и выкачиваем данные
            string downloadedString = await DownloadXMLText();

            // Текстовые данные в XML
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(downloadedString);

            // Получаем рубль из форинта
            double currencyHUF = Convert.ToDouble(textBox_CurrencyHUFQuantity.Text);
            textBox_CurrencyRUBQuantity.Text = Convert.ToString(ConvertCurrency(currencyHUF, xmlDoc, "R01135"));

            // Получаем крону из рубля
            double currencyRUB = Convert.ToDouble(textBox_CurrencyRUBQuantity.Text);
            textBox_CurrencyNOKQuantity.Text = Convert.ToString(ConvertCurrency(currencyRUB, xmlDoc, "R01535"));
        }

        private void textBox_CurrencyHUFQuantity_TextChanged(object sender, EventArgs e)
        {
            Regex regexRub = new Regex(@"^\d*$|^\d*\.$|^\d*\.\d{1,2}$|^\d*\,$|^\d*\,\d{1,2}$"); // Ввод денежного формата числа можно через . или ,

            if (!regexRub.IsMatch(textBox_CurrencyHUFQuantity.Text))
            {
                textBox_CurrencyHUFQuantity.Text = textBox_CurrencyHUFQuantity.Text.Substring(0, textBox_CurrencyHUFQuantity.Text.Length - 1); // После того, как вышли за пределы маски, удаляем введеные числа
                textBox_CurrencyHUFQuantity.SelectionStart = textBox_CurrencyHUFQuantity.Text.Length; // Каретка справа после завершения строки
            }
        }

        private void textBox_CurrencyHUFQuantity_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char inputChar = e.KeyChar;

            if (!Char.IsDigit(inputChar) && inputChar != '.' && inputChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
