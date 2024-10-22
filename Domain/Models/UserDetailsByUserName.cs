namespace UserCRUD.Domain.Models
{
    public static class UserDetailsByUserName
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string Email { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Status { get; set; }
        public static string Role { get; set; }
        public static string Phone { get; set; }
        public static string SaltKey { get; set; }

    }
}
