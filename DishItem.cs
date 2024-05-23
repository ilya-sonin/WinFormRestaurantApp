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
    public partial class DishItem : UserControl
    {
        private Dish _dish;

        public DishItem(Dish dish)
        {
            InitializeComponent();
            _dish = dish;
            UpdateUI();
        }

        private void UpdateUI()
        {
            dishNameLabel.Text = _dish.Name;
            dishDescriptionLabel.Text = _dish.Description;
            dishPriceLabel.Text = _dish.Price.ToString("C");
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            OnDishAddedToCart(_dish);
        }

        public event EventHandler<Dish> DishAddedToCart;

        protected virtual void OnDishAddedToCart(Dish dish)
        {
            DishAddedToCart?.Invoke(this, dish);
        }
    }
}
