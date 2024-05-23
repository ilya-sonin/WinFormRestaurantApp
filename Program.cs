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

            ApplicationConfiguration.Initialize();
            Application.Run(new Registration());
        }
    }
}