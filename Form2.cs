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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string name = "";
        double scale = 0;
        double filament = 0; //in grams
        double speed = 0;
        double timeHrs = 0;
        double timeMins = 0;
        double materialCost = 0;
        double sellPrice = 0;
        double profit = 0;
        double profitPerc = 0;

        private void addButton_Click(object sender, EventArgs e)
        {
            name = nameRTB.Text;
            scale = double.Parse(scaleRTB.Text);
            filament = double.Parse(filamentRTB.Text);
            speed = double.Parse(speedRTB.Text);
            timeHrs = double.Parse(timeHrsRTB.Text);
            timeMins = double.Parse(timeMinsRTB.Text);
            materialCost = double.Parse(materialCostRTB.Text);
            sellPrice = double.Parse(priceRTB.Text);
            profit = double.Parse(profitRTB.Text);
            profitPerc = double.Parse(profitPercRTB.Text);
            Form1.productList.Add(new Product(name, scale, filament, speed, timeHrs, timeMins, materialCost, sellPrice, profit, profitPerc));
        }
    }
}
