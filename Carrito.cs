using GoldenBoots;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;



namespace GoldenBoots
{

    public partial class Carrito : Form
    {

        private int qone = 1;
        private int qtwo = 1;
        public Carrito()
        {
            InitializeComponent();
            cantityText.Text = Convert.ToString(qone);
            cantityText2.Text = Convert.ToString(qtwo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cantityText.Text = Convert.ToString(++qone);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cantityText.Text = Convert.ToString(--qone);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cantityText2.Text = Convert.ToString(++qtwo);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cantityText2.Text = Convert.ToString(--qtwo);

        }


    }
}
