using System.Data;
using GoldenBoots;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;



namespace GoldenBoots
{

    public partial class Carrito : Form
    {

        public Carrito()
        {
            InitializeComponent();
        }

        private void ChangeCantity(object sender, EventArgs e)
        {
            Button obj = sender as Button;

            TextBox cantity = this.Controls["cantityText" + obj.Name.Remove(0, 1)] as TextBox;

            DataTable calculator = new();

            cantity.Text = calculator.Compute($"{cantity.Text}{obj.Text}1", null).ToString();
        }

        private void NewTotal(object sender, EventArgs e)
        {
            double[] prices = (new string[] { price1.Text.Remove(0, 4), price2.Text.Remove(0, 4) }).Select(double.Parse).ToArray();
            prices[0] *= int.Parse(cantityText1.Text);
            prices[1] *= int.Parse(cantityText2.Text);
            total.Text = "Total: " + prices.Sum();
        }

        private void bvolver_Click(object sender, EventArgs e)
        {
            RepeatFunctions.OpenForm(this, new Inicio());
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
