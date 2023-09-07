using CatAsService.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatAsService.View
{
    public partial class frmFindBreed : Form
    {

        List<Cat> catList = new CatApiGet().GetCatList();

        public frmFindBreed()
        {
            InitializeComponent();

            foreach (var cat in catList)
            {
                comboBreed.Items.Add(cat.name.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (comboBreed.SelectedIndex >= 0)
            {
                lblOrigin.Text = catList[comboBreed.SelectedIndex].origin;
                lblTemperament.Text = catList[comboBreed.SelectedIndex].temperament;
                lblDescription.Text = catList[comboBreed.SelectedIndex].description;
            }
            else
            {
                MessageBox.Show("Invalid Cat Breed", "Invalid Option");
            }
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if (comboBreed.SelectedIndex >= 0)
            {
                if (lblDescription.Text != "" && lblOrigin.Text != "" && lblTemperament.Text != "")
                {
                    var postFavouriteCat = new CatApiPost();

                    postFavouriteCat.Favourite(catList[comboBreed.SelectedIndex].id);

                    if (postFavouriteCat.Success())
                    {
                        MessageBox.Show("Favorite successfully saved!", "Favorite Saved");
                    }
                    else
                    {
                        switch (postFavouriteCat?.Response?.StatusCode)
                        {
                            case 0:
                                MessageBox.Show($"Unable to save as favorite.\nError Code: No Internet Connection", "Error");
                                break;
                            default:
                                MessageBox.Show($"Unable to save as favorite.\nError Code: {postFavouriteCat?.Response?.StatusCode}", "Error");
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You must click \"Search\" first in order to favorite", "Search a Cat Breed first");
                }
            }
            else
            {
                MessageBox.Show("You must choose a cat breed to save as favorite", "Select a Cat Breed");
            }
        }
        private void comboRaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblOrigin.Text = "";
            lblTemperament.Text = "";
            lblDescription.Text = "";
        }
    }
}
