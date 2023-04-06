using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        private ComboBox cmbFromCurrency;
        private ComboBox cmbToCurrency;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            fromCurrency = new ComboBox();
            toCurrency = new ComboBox();

            // Add items to the FromCurrency ComboBox
            fromCurrency.Items.Add("IDR");
            fromCurrency.Items.Add("USD");
            fromCurrency.Items.Add("EUR");
            fromCurrency.Items.Add("GBP");
            fromCurrency.Items.Add("JPY");

            // Add items to the ToCurrency ComboBox
            toCurrency.Items.Add("IDR");
            toCurrency.Items.Add("USD");
            toCurrency.Items.Add("EUR");
            toCurrency.Items.Add("GBP");
            toCurrency.Items.Add("JPY");

            // Set default selected items
            fromCurrency.SelectedIndex = 1;
            toCurrency.SelectedIndex = 2;

            Controls.Add(fromCurrency);
            Controls.Add(toCurrency);
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(textAmount.Text);

            string fromCurrencyCode = fromCurrency.SelectedItem.ToString();
            string toCurrencyCode = toCurrency.SelectedItem.ToString();

            double exchangeRate = GetExchangeRate(fromCurrencyCode, toCurrencyCode);

            double convertedAmount = amount * exchangeRate;

            labelResult.Text = string.Format("{0:F2} {1} = {2:F2} {3}", amount, fromCurrencyCode, convertedAmount, toCurrencyCode);
        }

        private double GetExchangeRate(string fromCurrencyCode, string toCurrencyCode)
        {
            switch (fromCurrencyCode + toCurrencyCode)
            {
                case "USDGBP":
                    return 0.72;
                case "GBPUSD":
                    return 1.39;
                case "USDEUR":
                    return 0.83;
                case "EURUSD":
                    return 1.21;
                case "GBPJPY":
                    return 152.11;
                case "JPYGBP":
                    return 0.01;
                default:
                    throw new Exception("Invalid currency pair.");
            }
        }
    }
}