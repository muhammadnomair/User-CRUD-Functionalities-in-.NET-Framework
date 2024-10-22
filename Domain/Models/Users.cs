using System;

namespace UserCRUD.Domain.Models
{
    public static class Users
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Email { get; set; }
        public static int RoleId { get; set; }
        public static string Phone { get; set; }
        public static string Status { get; set; }
        public static string RoleName { get; set; }
        public static string SaltKey { get; set; }
        public static DateTime DateCreated { get; set; }
    }
}
