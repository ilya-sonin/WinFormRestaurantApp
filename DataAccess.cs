using Microsoft.Data.Sqlite;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

public class DataAccess
{
    private readonly string _databasePath;

    public DataAccess(string databasePath)
    {
        _databasePath = databasePath;
        EnsureDatabaseFileExists();
    }

    private void EnsureDatabaseFileExists()
    {
        if (!File.Exists(_databasePath))
        {
            // Создаем директорию, если она не существует
            var directoryPath = Path.GetDirectoryName(_databasePath);
            if (!string.IsNullOrEmpty(directoryPath) && !Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Создаем файл базы данных
            using (var connection = new SqliteConnection($"Data Source={_databasePath}"))
            {
                connection.Open();
            }

            Console.WriteLine($"Файл базы данных создан: {_databasePath}");
        }
    }

    public void InitializeDatabase()
    {
        using (var connection = new SqliteConnection($"Data Source={_databasePath}"))
        {
            connection.Open();

            // Проверяем, существует ли таблица "Users"
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='Users'";
                var tableExists = (long)command.ExecuteScalar() > 0;

                if (!tableExists)
                {
                    // Создаем таблицу "Users"
                    command.CommandText = @"
                        CREATE TABLE Users (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            PhoneNumber TEXT NOT NULL UNIQUE,
                            Password TEXT NOT NULL
                        )";
                    command.ExecuteNonQuery();
                    Console.WriteLine("Таблица Users создана.");
                }
                else
                {
                    Console.WriteLine("Таблица Users уже существует.");
                }
            }
        }
    }

    public bool RegisterUser(string phoneNumber, string password)
    {
        if (GetUserByPhoneNumber(phoneNumber) != null)
            return false;

        var user = new User
        {
            PhoneNumber = phoneNumber,
            Password = password
        };
        user.HashPassword();

        using (var connection = new SqliteConnection($"Data Source={_databasePath}"))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Users (PhoneNumber, Password) VALUES (@PhoneNumber, @Password)";
                command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                command.Parameters.AddWithValue("@Password", user.Password);
                var rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
    }

    public User GetUserByPhoneNumber(string phoneNumber)
    {
        using (var connection = new SqliteConnection($"Data Source={_databasePath}"))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Users WHERE PhoneNumber = @PhoneNumber";
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            Id = reader.GetInt32(0),
                            PhoneNumber = reader.GetString(1),
                            Password = reader.GetString(2)
                        };
                    }
                }
            }
        }

        return null;
    }

    public bool AuthenticateUser(string phoneNumber, string password)
    {
        var user = GetUserByPhoneNumber(phoneNumber);
        if (user == null)
            return false;

        using (var sha256 = SHA256.Create())
        {
            var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            var hashedPassword = Convert.ToBase64String(hashedBytes);

            return hashedPassword == user.Password;
        }
    }
}