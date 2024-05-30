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
    public partial class Checkout : Form
    {
        private readonly List<Dish> _selectedDishes;

        public Checkout(List<Dish> selectedDishes)
        {
            InitializeComponent();
            _selectedDishes = selectedDishes;
            UpdateTotalPrice(selectedDishes);
        }

        private void checkBoxSamovivoz_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSamovivoz.Checked)
            {
                textBoxAdress.Text = "";
                textBoxTableNumber.Text = "";
            }
        }

        private void UpdateTotalPrice(List<Dish> dishes)
        {
            var totalPrice = dishes.Sum(d => d.Price);
            totalPriceLabel.Text = $"Итого: {totalPrice:C}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_selectedDishes.Count > 0) 
            { 
                MessageBox.Show("Заказ успешно оформлен!");
            }
        }
    }
}
