using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursovaySonin2024
{
    public partial class RestuarantMenu : Form
    {
        private CartDialog cartDialog;

        public RestuarantMenu()
        {
            InitializeComponent();
            LoadMenu();
        }

        private void LoadMenu()
        {
            flowLayoutPanelRestuarantMenu.Controls.Clear();

            var dataAccessDb = new DataAccess("./database.db");
            var dishes = dataAccessDb.GetAllDishes();
            foreach (var dish in dishes)
            {
                var dishItem = new DishItem(dish);
                dishItem.DishAddedToCart += DishItem_DishAddedToCart;
                flowLayoutPanelRestuarantMenu.Controls.Add(dishItem);
            }
        }

        private void DishItem_DishAddedToCart(object sender, Dish dish)
        {
            CartManager.AddDishToCart(dish);
            UpdateCartCountLabel();

            if (cartDialog != null)
            {
                cartDialog.UpdateCartView();
            }
        }

        public void UpdateCartCountLabel()
        {
            cartCountLabel.Text = CartManager.GetSelectedDishes().Count.ToString();
        }

        private void ShowCartDialog()
        {
            if (cartDialog == null || cartDialog.IsDisposed)
            {
                cartDialog = new CartDialog(CartManager.GetSelectedDishes(), this);
                cartDialog.Show();
            }
            else
            {
                cartDialog.Activate();
            }
        }

        private void cartOpen_Click(object sender, EventArgs e)
        {
            ShowCartDialog();
        }
    }
}
