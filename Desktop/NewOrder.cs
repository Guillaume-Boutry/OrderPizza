using System;
using System.Windows.Forms;

namespace Desktop
{
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
           // throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            Pizza pizza = new Pizza();
            pizza.Tag = this; 
            pizza.Show(this);
            Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            Dessert dessert = new Dessert();
            dessert.Tag = this; 
            dessert.Show(this);
            Hide();
        }
        /*private void Check_Click()
        {
            Dessert dessert = new Dessert();
            dessert.Show();
            Hide();
        }
        */

        private void button2_Click(object sender, EventArgs e)
        {
            Drinks drinks = new Drinks();
            drinks.Tag = this; 
            drinks.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Sides sides = new Sides();
           sides.Tag = this; 
           sides.Show();
           Hide();
        }
    }
}