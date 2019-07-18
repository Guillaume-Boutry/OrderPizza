using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  throw new System.NotImplementedException();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NewOrder newOrder = new NewOrder();
            newOrder.Tag = this;
            newOrder.Show(this);
            Hide();
        }
        private void Check_Click(object sender, EventArgs e)
        {
            NewOrder newOrder= new NewOrder();
            newOrder.Show();
            Hide();
        }
        
    }
}