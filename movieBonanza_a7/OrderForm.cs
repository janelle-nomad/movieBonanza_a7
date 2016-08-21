/**
 * Janelle Heron
 * 3008398820
 * Version Control: 0.08
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using System.Drawing.Imaging; I could've used the image here too
namespace movieBonanza_a7
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
           
        }

        private string title;

        private string category;

        private string cost;

        public string titleVar
        {
            get { return title; }
            set { title = value; }
        }

        public string categoryVar
        {
            get { return category; }
            set { category = value; }
        }

        public string costVar
        {
            get { return cost; }
            set { cost = value; }
        }

        public OrderForm(System.Drawing.Image mImage)
        {
            InitializeComponent();
            MovieSelectedPictureBox.Image = mImage; 
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            SelectionForm newSelectionFormA = new SelectionForm();
            newSelectionFormA.ShowDialog();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            //decimal is more acurate than double, as far as financial programs go
            decimal purchaseMovie = 10.00m;
            decimal salesTax, movieTotal;
           
            decimal subTotal = decimal.Parse(costTextBox.Text);
            salesTax = 0.13m * subTotal;
            movieTotal = salesTax + subTotal;
                
            titleTextbox.Text = title;
            categoryTextBox.Text = category;
            costTextBox.Text = cost;


            //If the order dvd checkbox  is checked perform the logic so that an additionaol charge is given to the user
            if (orderCheckBox.Checked)
            {
                decimal phSubTotal = subTotal + purchaseMovie;
                decimal phSalesTax = 0.13m*phSubTotal;
                decimal phMovieTotal = phSalesTax + phSubTotal;
                subTotal = phSubTotal;
                salesTax = phSalesTax;
                grandtotalTextBox = grandtotalTextBox.ToString("C");
                subtotalTextBox = subTotal.ToString("C");
                

            }
        }
    }
}
