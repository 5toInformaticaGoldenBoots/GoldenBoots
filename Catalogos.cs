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
    public partial class Catalogos : Form
    {
        Database db = new Database();

        public Catalogos()
        {
            InitializeComponent();
            //Consigue todos los zapatos de la db
            List<object[]> shoes = db.Query("SELECT * FROM ZAPATOS");

            Label test = new Label();
            test.Location = new Point(0, 0);
            test.Size = new Size(500, 30);
            test.Name = $"test";
            test.BackColor = Color.Transparent;
            test.ForeColor = Color.Black;
            
            foreach (object[] row in shoes)
            {
                test.Text += row[0].ToString() + " ";
            }
            this.Controls.Add(test);

            //recorre cada zapato de la lista
            for (int i = 0; i < shoes.Count; i++)
            {
                GroupBox infoShoe = new GroupBox();
                infoShoe.Location = new Point(100 * (i+1)*2, 100);
                infoShoe.Size = new Size(150, 150);
                infoShoe.TabIndex = i;
                infoShoe.TabStop = false;
                infoShoe.BackColor = Color.Transparent;
                infoShoe.Name = $"infoZap{i}";

                Label price = new Label();
                price.Location = new Point(50, 50);
                price.Size = new Size(50, 30);
                price.Name = $"textZap{i}";
                price.BackColor = Color.Transparent;
                price.ForeColor = Color.Black;
                price.Text = "$" + shoes[i][2].ToString();

                Label marca = new Label();
                marca.Location = new Point(80, 80);
                marca.Size = new Size(50, 30);
                marca.Name = $"marcaZap{i}";
                marca.BackColor = Color.Transparent;
                marca.ForeColor = Color.Black;
                marca.Text = db.QueryOne($"SELECT NOMBRE FROM MARCA WHERE ID = {shoes[i][4].ToString()}")[0].ToString();

                infoShoe.Controls.AddRange([
                    new PictureBox(), 
                    price,
                    marca
                ]);

                this.Controls.Add(infoShoe);
            }
        }
    }
}
