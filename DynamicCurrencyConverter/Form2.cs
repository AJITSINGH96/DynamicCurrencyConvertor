using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicCurrencyConverter
{
    public partial class Form1 :Form
    {
        private Dictionary<string, double> _currency = new Dictionary<string, double>();
        public Form1()
        {
            InitializeComponent();
            //var currencies = GetCurrency();
            //dynamic responseobj = JsonConvert.DeserializeObject(currencies);
            //foreach (var item in responseobj.data)
            //{
            //    SourceCombo.Items.Add(item.First.code.ToString());
            //    DestinationCombo.Items.Add(item.First.code.ToString());
            //    _currency.Add(item.First.code.ToString(), item.First.value.Value);
            //    MostPrefferedCheckList.Items.Add(item.First.code.ToString());
            MostPrefferedCheckList.Items.Add("A");
            MostPrefferedCheckList.Items.Add("B");
            MostPrefferedCheckList.Items.Add("C");
            MostPrefferedCheckList.Visible = false;
            PrefferedListOkayButton.Visible = false;
            PrefferedListCancelButton.Visible = false;
            MostPrefferedClearButton.Visible = false;
            //}
        }
        private string GetCurrency()
        {
            var client = new RestClient("https://api.currencyapi.com/v3/latest?base_currency=INR");

            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("apikey", "cur_live_FN3RgIY9NsqcwTZygJElD6ZVyM3RtZXqmrRGMUwh");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return response.Content;
        }

      
        private void Finalvalue_Click(object sender, EventArgs e)
        {
            var selectedSourceCurrency = SourceCombo.SelectedItem.ToString();
            var selectedDestCurrency = DestinationCombo.SelectedItem.ToString();
            var amountentered = double.Parse(amount.Text);
            var sourceCurrentExchangeRate = _currency.First(c => c.Key == selectedSourceCurrency).Value;
            var destinationCurrentExchangeRate = _currency.First(c => c.Key == selectedDestCurrency).Value;
            var calculatedamount = (amountentered * sourceCurrentExchangeRate) * destinationCurrentExchangeRate;
            FinalAmount.Text = $"Result:{calculatedamount}{_currency.First(c => c.Key == selectedSourceCurrency).Key}";
        }

   

        private void Form1_Load(object sender, EventArgs e)
        {
            SourceLabel.Parent = pictureBox1;
            SourceLabel.BackColor = Color.Transparent;

            DestinationLabel.Parent = pictureBox1;
            DestinationLabel.BackColor = Color.Transparent;

            AmountLabel.Parent = pictureBox1;
            AmountLabel.BackColor = Color.Transparent;


            Finalvalue.Parent = pictureBox1;
            Finalvalue.BackColor = Color.Transparent;

            mainframetext.Parent = pictureBox1;

            //PrefferedListOkayButton.Parent = pictureBox1;
            PrefferedListOkayButton.BackColor = Color.Transparent;
            //MostPrefferedClearButton.Parent = pictureBox1;
            MostPrefferedClearButton.BackColor = Color.Transparent;
           // PrefferedListCancelButton.Parent = pictureBox1;
            PrefferedListCancelButton.BackColor = Color.Transparent;


            //mainframetext.BackColor = Color.Transparent;

            //dateTimePicker1.Parent = pictureBox1;
            //dateTimePicker1.BackColor = Color.Transparent;

            //dateTimePicker2.Parent = pictureBox1;
            //dateTimePicker2.BackColor = Color.Transparent;

            //FinalAmount.Parent = pictureBox1;
            //FinalAmount.BackColor = Color.Transparent;

            //SourceCombo.Parent = pictureBox1;
            //SourceCombo.BackColor = Color.Transparent;

            ////DestinationCombo.Parent = pictureBox1;
            //DestinationCombo.BackColor = Color.Transparent;
        }

      

        private void MostPrefferedList_Click(object sender, EventArgs e)
        {
            MostPrefferedCheckList.Visible = !MostPrefferedCheckList.Visible;
            PrefferedListOkayButton.Visible = !PrefferedListOkayButton.Visible;
            PrefferedListCancelButton.Visible = !PrefferedListCancelButton.Visible;
            MostPrefferedClearButton.Visible= !MostPrefferedClearButton.Visible;
        }
        

        private void PrefferedListOkayButton_Click(object sender, EventArgs e)
        {
            if (MostPrefferedCheckList.CheckedItems.Count > 0)
            {
                // Retrieve the selected items from the CheckedListBox
                var selectedItems = MostPrefferedCheckList.CheckedItems.Cast<string>().ToList();

                // Display the selected items
                MessageBox.Show("Selected items: " + string.Join(", ", selectedItems));
            }
            else
            {
                // No items are selected
                MessageBox.Show("No items selected.");
            }
        }

        private void PrefferedListCancelButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MostPrefferedCheckList.Items.Count; i++)
            {
                MostPrefferedCheckList.SetItemChecked(i, false);
            }
            MostPrefferedCheckList.Visible = !MostPrefferedCheckList.Visible;
            PrefferedListOkayButton.Visible = !PrefferedListOkayButton.Visible;
            PrefferedListCancelButton.Visible = !PrefferedListCancelButton.Visible;
            MostPrefferedClearButton.Visible=!MostPrefferedClearButton.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MostPrefferedCheckList.Items.Count; i++)
            {
                MostPrefferedCheckList.SetItemChecked(i, false);
            }
        }
       
    }
    
}
