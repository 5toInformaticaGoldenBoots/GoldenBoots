using GoldenBoots.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace GoldenBoots
{
    public partial class Catalogos : Form
    {
        Database db = new Database();

        public Catalogos(string defaultText = "")
        {
            InitializeComponent();
            //Consigue todos los zapatos de la db
            
            this.UpdateSize(null, EventArgs.Empty);
            this.GenerateItems("SELECT * FROM ZAPATOS");
            textBox1.Text = defaultText;
            //this.OnMaximumSizeChanged += UpdateSize;

            //Label test = new Label();
            //test.Location = new Point(0, 0);
            //test.Size = new Size(500, 30);
            //test.Name = $"test";
            //test.BackColor = Color.Transparent;
            //test.ForeColor = Color.Black;

            //foreach (object[] row in shoes)
            //{
            //    test.Text += row[0].ToString() + " ";
            //}
            //this.Controls.Add(test);

            //recorre cada zapato de la lista
            
        }

        public void UpdateSize(object sender, EventArgs args)
        {
            dgvZapatos.Location = new Point(0, 150);
            dgvZapatos.Size = new Size(this.Width, this.Height);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateItems(string query)
        {
            dgvZapatos.Controls.Clear();

            List<object[]> shoes = new();

            try
            {
                shoes = db.Select(query);
            }
            catch { }

            for (int i = 0; i < shoes.Count; i++)
            {
                GroupBox infoShoe = new GroupBox();

                //NO TOCAR ESTA PARTE HASTA EL SIGUIENTE AVISO
                int objectSpace = Convert.ToInt32(100 * (i + 2.25));

                if (i == 0)
                {
                    objectSpace = 100;
                }

                int rowObjectsCantity = 4;

                int divisor = ((i + rowObjectsCantity) / rowObjectsCantity);

                if (divisor >= 2)
                {
                    divisor += 2;
                }

                int objectY = 100 * divisor;
                //NO TOCAR HASTA AQUI, LO DE ABAJO SI

                infoShoe.Location = new Point(objectSpace, objectY);
                infoShoe.Size = new Size(213, 253);
                infoShoe.TabIndex = i;
                infoShoe.TabStop = false;
                infoShoe.BackColor = Color.Black;
                infoShoe.Name = $"infoZap{i}";

                PictureBox img = new PictureBox();
                img.Image = null;
                img.Location = new Point(27, 26);
                img.Name = "za4";
                img.Size = new Size(168, 133);
                img.SizeMode = PictureBoxSizeMode.StretchImage;
                img.TabIndex = 1;
                img.TabStop = false;

                Label precio = new Label();
                precio.AutoSize = true;
                precio.ForeColor = Color.FromArgb(255, 128, 0);
                precio.Location = new Point(137, 176);
                precio.Name = "label11";
                precio.Size = new Size(55, 15);
                precio.TabIndex = 4;
                precio.Text = "RD$3,600";

                Label marca = new Label();
                marca.AutoSize = true;
                marca.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
                marca.ForeColor = Color.White;
                marca.Location = new Point(5, 203);
                marca.Name = "label10";
                marca.Size = new Size(172, 15);
                marca.TabIndex = 3;
                marca.Text = "Zapatillas Tacones Plataforma";

                Label name = new Label();
                name.AutoSize = true;
                name.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
                name.ForeColor = Color.White;
                name.Location = new Point(7, 177);
                name.Name = "label9";
                name.Size = new Size(85, 15);
                name.TabIndex = 2;
                name.Text = "Zapatos Mujer";

                infoShoe.Controls.AddRange([
                    img,
                    precio,
                    marca,
                    name
                ]);

                dgvZapatos.Controls.Add(infoShoe);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.GenerateItems("select * from ZAPATOS where " + comboBox1.Text + " like '%" + textBox1.Text + "%'");
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.conexion);
            //string query = "select * from ZAPATOS where " + comboBox1.Text + " like '%" + textBox1.Text + "%'";
            //SqlDataAdapter ada = new SqlDataAdapter(query, con);

            //con.Open();

            //DataSet data = new DataSet();

            //ada.Fill(data, "ZAPATOS");

            //dataGridView1.DataSource = data;
            //dataGridView1.DataMember = "ZAPATOS";

        }
    }
};