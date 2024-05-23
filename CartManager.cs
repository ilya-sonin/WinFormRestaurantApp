public static class CartManager
{
    private static List<Dish> selectedDishes = new List<Dish>();

    public static void AddDishToCart(Dish dish)
    {
        selectedDishes.Add(dish);
    }

    public static void RemoveDishFromCart(Dish dish)
    {
        selectedDishes.Remove(dish);
    }

    public static void ClearCart()
    {
        selectedDishes.Clear();
    }

    public static List<Dish> GetSelectedDishes()
    {
        return new List<Dish>(selectedDishes);
    }
}