using static DataAccess;

namespace CursovaySonin2024
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var databasePath = "./database.db";
            var dataAccess = new DataAccess(databasePath);
            dataAccess.InitializeDatabase();

            AddDishesForSeafoodRestaurant(dataAccess);

            ApplicationConfiguration.Initialize();
            Application.Run(new Registration());
        }

        private static void AddDishesForSeafoodRestaurant(DataAccess dataAccess)
        {
            dataAccess.AddDish("Жареные креветки", 2912.99m, "Хрустящие жареные креветки, обжаренные в чесночном масле");
            dataAccess.AddDish("Устрицы на гриле", 3499.99m, "Свежие устрицы, приготовленные на гриле с лимоном и зеленью");
            dataAccess.AddDish("Лосось с соусом терияки", 2799.99m, "Филе лосося, приготовленное на гриле, с соусом терияки и рисом");
            dataAccess.AddDish("Морской коктейль", 3999.99m, "Ассорти из морепродуктов: креветки, мидии, кальмары, подаются с соусом");
            dataAccess.AddDish("Карпаччо из тунца", 2299.99m, "Тонко нарезанные ломтики свежего тунца, заправленные оливковым маслом и лимонным соком");
            dataAccess.AddDish("Мидии в белом вине", 1999.99m, "Мидии, приготовленные в белом вине с чесноком и зеленью");
            dataAccess.AddDish("Рыбное ассорти гриль", 4499.99m, "Ассорти из рыбы и морепродуктов, приготовленных на гриле: лосось, тунец, креветки, кальмары");
            dataAccess.AddDish("Сашими из лосося", 2699.99m, "Тонко нарезанные ломтики свежего лосося, подаются с соевым соусом и васаби");
            dataAccess.AddDish("Суп из морских гребешков", 1799.99m, "Ароматный суп с нежными морскими гребешками и овощами");
            dataAccess.AddDish("Цезарь с креветками", 2199.99m, "Классический салат Цезарь с обжаренными креветками");
            dataAccess.AddDish("Филе трески с овощами", 2399.99m, "Филе трески, запеченное с овощами и лимонным соусом");
            dataAccess.AddDish("Тартар из тунца", 2499.99m, "Свежий тунец, нарезанный тартаром, с авокадо и соусом из маринованного лука");
            dataAccess.AddDish("Морской микс фритюр", 2999.99m, "Ассорти из обжаренных в панировке морепродуктов: креветки, кальмары, рыба");
            dataAccess.AddDish("Лобстер с маслом и чесноком", 6999.99m, "Целый лобстер, приготовленный на гриле с чесночным маслом");
        }
    }
}