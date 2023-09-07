using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatAsService.API;

namespace CatAsService.View
{
    public partial class frmFavorites : Form
    {
        CatApiGet catAPI = new CatApiGet();
        CatApiDelete catAPIDel = new CatApiDelete();
        public frmFavorites()
        {
            InitializeComponent();

            var catList = catAPI.GetCatList();
            var favoriteList = catAPI.GetCatFavoriteList();
            if (favoriteList != null)
            {
                foreach (Favorite favCat in favoriteList)
                {
                    if (favCat.image_id != null)
                    {
                        foreach (Cat cat in catList)
                        {
                            if (favCat.image_id == cat.id)
                            {
                                lboxFavorites.Items.Add(cat.name);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Can't connect to favorites database", "Connection Error");
            }
            checkListBlockButton();
        }

        private void btnRemoveFavorite_Click(object sender, EventArgs e)
        {
            if (lboxFavorites.SelectedIndex >= 0)
            {
                var favoriteList = catAPI.GetCatFavoriteList();
                var selectedIndex = lboxFavorites.SelectedIndex!;
                var selectedFavorite = favoriteList![selectedIndex];
                var favouriteID = selectedFavorite.id;

                catAPIDel.DeleteFavCat(favouriteID);
                favoriteList.RemoveAt(selectedIndex);
                lboxFavorites.Items.RemoveAt(selectedIndex);
                MessageBox.Show("Favorite Removed.", "Success");
            }
            else
            {
                MessageBox.Show("Select the favorite to be removed.", "Error");
            }

            checkListBlockButton();
        }
        private void checkListBlockButton()
        {
            if (lboxFavorites.Items.Count == 0)
            {
                btnRemoveFavorite.Enabled = false;
            }
            else
            {
                btnRemoveFavorite.Enabled = true;
            }
        }
    }
}
