using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenBoots
{
    public partial class TarjetaCredito : Form
    {
        private const char V = '●';

        public TarjetaCredito()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TarjetaCredito_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string numero = NumeroTarjeta.Text.Replace(" ", " "); //Obtenemos el numero de tarjeta sin los espacios 

            //LImitamos el numero de caracteres a 16
            if (numero.Length > 16)
            {
                numero = numero.Substring(0, 16);

            }


            //Formateamos el numero con espacios cada 4 digitos
            string formato = "";
            for (int i = 0; i < numero.Length; i++)
            {

                if (i > 0 && i % 19 == 0)
                {
                    formato += " ";
                }
                formato += numero[i];

            }

            //Actualizamos el texBox con el nùmero formateado 
            NumeroTarjeta.Text = formato;

            // Colocar el curso al final del texto
            NumeroTarjeta.SelectionStart = NumeroTarjeta.Text.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mostrar mensaje
            MessageBox.Show("¡Tu compra ha sido realizada con éxito ", "Tu compra", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar todos los TextBox
            foreach (Control control in this.Controls)
            {
                if (control is TextBox obj)
                {
                    obj.Clear();
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.PasswordChar = '●';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
