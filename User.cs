using System.Security.Cryptography;
using System.Text;

public class User
{
    public int Id { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }

    public void HashPassword()
    {
        using (var sha256 = SHA256.Create())
        {
            var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Password));
            Password = Convert.ToBase64String(hashedBytes);
        }
    }
}