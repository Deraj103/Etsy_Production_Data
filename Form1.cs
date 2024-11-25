using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Etsy_Production_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //string name = "";
        //double scale = 0;
        //double filament = 0; //in grams
        //double speed = 0;
        //double timeHrs = 0;
        //double timeMins = 0;
        //double materialCost = 0;
        //double sellPrice = 0;
        //double profit = 0;
        //double profitPerc = 0;

        public static ArrayList productList = new ArrayList();

        //public static Product[] productList =
        //{
        //    new Product( "test", 100, 75, 100, 10, 5, 7.75, 10.75, 3, 28 )
        //};


        private void addButton_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (productList == null)
            {
                var refresh =
    from ArrayList pL in productList
    orderby pL.name
    select new { pL.name };
                foreach (var product in refresh)
                {
                    productListBox.Items.Add(product.name);
                }
            }
        }
    }
}
