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
    public partial class CartDialog : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private readonly RestuarantMenu _restuarantMenu;
        private List<Dish> _selectedDishes;

        public CartDialog(List<Dish> selectedDishes, RestuarantMenu restuarantMenu)
        {
            InitializeComponent();
            _restuarantMenu = restuarantMenu;
            _selectedDishes = selectedDishes;
            UpdateCartView(selectedDishes);
        }

        private void UpdateCartView(List<Dish> dishes)
        {
            bindingSource.DataSource = dishes;
            _selectedDishes = dishes;
            cartDataGridView.DataSource = bindingSource;

            if (cartDataGridView.Columns.Count > 0)
            {
                cartDataGridView.Columns["Name"].HeaderText = "Название блюда";
                cartDataGridView.Columns["Description"].HeaderText = "Описание";
                cartDataGridView.Columns["Price"].HeaderText = "Цена";
                cartDataGridView.Columns["Id"].Visible = false;

                if (cartDataGridView.Columns["RemovesButtons"] == null)
                {
                    var deleteColumn = new DataGridViewButtonColumn
                    {
                        HeaderText = "Кнопки действий",
                        Text = "Удалить",
                        UseColumnTextForButtonValue = true,
                        Name = "RemovesButtons"
                    };
                    cartDataGridView.Columns.Add(deleteColumn);
                }
            }

            UpdateTotalPrice(dishes);
        }

        private void UpdateTotalPrice(List<Dish> dishes)
        {
            var totalPrice = dishes.Sum(d => d.Price);
            totalPriceLabel.Text = $"Итого: {totalPrice:C}";
        }

        private void cartDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cartDataGridView.Columns["RemovesButtons"].Index && e.RowIndex >= 0)
            {
                var dish = (Dish)cartDataGridView.Rows[e.RowIndex].DataBoundItem;
                CartManager.RemoveDishFromCart(dish);
                UpdateCartView(CartManager.GetSelectedDishes());
                _restuarantMenu.UpdateCartCountLabel();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CartManager.ClearCart();
            UpdateCartView(CartManager.GetSelectedDishes());
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public void UpdateCartView()
        {
            UpdateCartView(CartManager.GetSelectedDishes());
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            var checkout = new Checkout(_selectedDishes);
            checkout.ShowDialog();
        }
    }
}
