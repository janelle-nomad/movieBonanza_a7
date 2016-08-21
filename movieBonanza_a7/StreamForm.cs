using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Janelle Heron 
 * Version: 0.08 ~ this is a reupload
 */
namespace movieBonanza_a7
{
    public partial class StreamForm : Form

    {
        //grab the title and total bill
        public string title;
        public string movieTotal;
        public string grandTotal;
        private string titleVar { get { return title; } set { title = value; } }
        public string balance { get { return movieTotal; } set { movieTotal = value; } }
        
        public StreamForm()
        {
            InitializeComponent();
        }

        private void StreamForm_Load(object sender, EventArgs e)
        {
            //I missed a calculation here
            //
            movieTotal.Text = "Your Credit card will be charged " + grandTotalTextbox.ToString();

            balanceDueLabel.Text = title + " will begin streaming shortly.";
        }
    }
}
