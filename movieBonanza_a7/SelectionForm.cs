using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movieBonanza_a7
{
    public partial class SelectionForm : Form
    {
        //Decimal is way better than double when it comes to finances
        decimal[] downloadCost = new decimal[]
        { 1.99m, 1.99m, 2.99m, 2.99m, 2.99m, 1.99m, 0.99m, 4.99m  };

        //holds movies
        string[] movie = new string[] { };

        //holds category
        string[] category = new string[] { "Comedy", "Drama", "Action", "Sci-fi", "Horror", "Thriller", "Family", "New Release" };
        //holds comedy movies
        string[] comedyMovies = new string[] { "The Dilemma", "No Strings Attached", "Cedar Rapids", "Just Go With it" };
        //holds dramaMovies
        string[] dramaMovies = new string[] { "Company Men", "The Way Back", "Waiting for Forever" };
        string[] actionMovies = new string[] { "The Green Hornet", "Death Race 2", "The Mechanic", "Sanctum", "The Other Woman", "The Eagle" };
        string[] scifiMovies = new string[] { "Season of the Witch", "I am Number Four" };
        string[] horrorMovies = new string[] { "The Rite" };
        string[] thrillerMovies = new string[] { "The Roommate" };
        string[] familyMovies = new string[] { "Gnomeo and Juliet" };
        string[] newReleaseMovies = new string[] { "Footloose", "Real Steel" };

        public SelectionForm()
        {
            //to be added splashscreen
            Thread thread = new Thread(new ThreadStart(SplashScreen));
            thread.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            thread.Abort();
        }

        public void SplashScreen()
        {
            Application.Run(new splashScreen());
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleTextBox.Text = string.Empty;

            foreach (string value in MovieListBox.SelectedItems)
            {
                TitleTextBox.Text = value.ToString();
                if (value == "The Dilemma")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.thedilemma);
                }
                if (value == "No Strings Attached")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.nostringsattached);
                }
                if (value == "Cedar Rapids")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.cedarrapids);
                }
                if (value == "Just Go With it")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.justgowithit);
                }
                if (value == "Company Men")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.companymen);
                }
                if (value == "The Way Back")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.thewayback);
                }
                if (value == "Waiting for Forever")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.waitingforever);
                }
                if (value == "The Green Hornet")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.thegreenhornet);
                }
                if (value == "Death Race 2")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.deathrace2);
                }
                if (value == "The Mechanic")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.themechanic);
                }
                if (value == "Sanctum")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.sanctum);
                }
                if (value == "The Other Woman")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.theotherwoman);
                }
                if (value == "The Eagle")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.theeagle);
                }
                if (value == "Season of the Witch")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.seasonofthewitch);
                }
                if (value == "I am Number Four")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.iamnumberfour);
                }
                if (value == "The Rite")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.therite);
                }
                if (value == "The Roommate")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.theroommate);
                }
                if (value == "Gnomeo and Juliet")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.gnomeoandjuliet);
                }
                if (value == "Footloose")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.footloose);
                }
                if (value == "Real Steel")
                {
                    selectionPictureBox.Image = new Bitmap(Properties.Resources.realsteel);
                }

            }
        }



        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryIndexInteger = categoryListbox.SelectedIndex;


            if (categoryIndexInteger == 0)
            {
                MovieListBox.Items.Clear();
                MovieListBox.Items.AddRange(comedyMovies);
                CategoryTextBox.Text = category[0];
                CostTextBox.Text = downloadCost[0].ToString();
            }
            if (categoryIndexInteger == 1)
            {
                MovieListBox.Items.Clear();
                MovieListBox.Items.AddRange(dramaMovies);
                CategoryTextBox.Text = category[1];
                CostTextBox.Text = downloadCost[0].ToString();
            }
            if (categoryIndexInteger == 2)
            {
                MovieListBox.Items.Clear();
                MovieListBox.Items.AddRange(actionMovies);
                CategoryTextBox.Text = category[2];
                CostTextBox.Text = downloadCost[0].ToString();
            }
            if (categoryIndexInteger == 3)
            {
                MovieListBox.Items.Clear();
                MovieListBox.Items.AddRange(scifiMovies);
                CategoryTextBox.Text = category[3];
                CostTextBox.Text = downloadCost[0].ToString();
            }
            if (categoryIndexInteger == 4)
            {
                MovieListBox.Items.Clear();
                MovieListBox.Items.AddRange(horrorMovies);
                CategoryTextBox.Text = category[4];
                CostTextBox.Text = downloadCost[0].ToString();
            }
            if (categoryIndexInteger == 5)
            {
                MovieListBox.Items.Clear();
                MovieListBox.Items.AddRange(thrillerMovies);
                CategoryTextBox.Text = category[5];
                CostTextBox.Text = downloadCost[0].ToString();
            }
            if (categoryIndexInteger == 6)
            {
                MovieListBox.Items.Clear();
                MovieListBox.Items.AddRange(familyMovies);
                CategoryTextBox.Text = category[6];
                CostTextBox.Text = downloadCost[0].ToString();
            }
            if (categoryIndexInteger == 7)
            {
                MovieListBox.Items.Clear();
                MovieListBox.Items.AddRange(newReleaseMovies);
                CategoryTextBox.Text = category[7];
                CostTextBox.Text = downloadCost[7].ToString();
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {

            this.Hide();

            OrderForm newOrderFormA = new OrderForm(selectionPictureBox.Image);
            newOrderFormA.titleVar = TitleTextBox.Text;
            newOrderFormA.categoryVar = CategoryTextBox.Text;
            newOrderFormA.costVar = CostTextBox.Text;

            newOrderFormA.ShowDialog();

        }
    }
}


