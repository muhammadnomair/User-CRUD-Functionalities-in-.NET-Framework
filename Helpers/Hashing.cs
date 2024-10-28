using System;
using System.Text;
using System.Security.Cryptography;

namespace UserCRUD.Helpers
{
    public class Hashing
    {
        // Generating hashed password based on given password and salt key
        public static string GenerateHashPassword(string password, string hashedSaltKey)
        {
            string hashedPassword = password + hashedSaltKey;
            using (var hash = SHA512.Create())
            {
                byte[] hashBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(hashedPassword));
                return Convert.ToBase64String(hashBytes);
            }
        }// End of the funciton: GenerateHashPassword

        // Generate hashed salt key of tghe random number for security purpose
        public static string GenerateHashedSaltKey()
        {
            Random random = new Random();
            int randomNumber = random.Next();
            string saltKey = Convert.ToString(randomNumber);
            using (var hash = SHA512.Create())
            {
                byte[] hashBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(saltKey));
                return Convert.ToBase64String(hashBytes);
            }
        }// End of the function: GenerateHashedSaltKey
    }
}
