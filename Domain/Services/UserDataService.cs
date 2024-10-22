using System;
using System.Data;
using System.Linq;
using System.Data.SQLite;
using System.Windows.Forms;
using UserCRUD.Domain.Models;
using UserCRUD.Domain.DataBase;
using System.Collections.Generic;
using UserCRUD.Domain.RepositoryInterfaces;

namespace UserCRUD.Domain.Services
{
    public class UserDataService : ConnectionToSql, IUsersDataInterface
    {
        public bool ReadUserData(string userName)
        {
            var isUserExists = true;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var sqlCommand = new SQLiteCommand())
                    {
                        sqlCommand.Connection = connection;
                        sqlCommand.CommandText = "SELECT * FROM Users JOIN Roles ON Users.RoleId=Roles.RoleNumber WHERE Users.UserName=@user AND Users.Status=@userStatus";
                        sqlCommand.Parameters.AddWithValue("@user", userName);
                        sqlCommand.Parameters.AddWithValue("@userStatus", "Active");
                        sqlCommand.CommandType = CommandType.Text;

                        using (SQLiteDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                Users.UserId = Convert.ToInt32(reader["Id"]);
                                Users.UserName = reader["UserName"].ToString();
                                Users.Password = reader["Password"].ToString();
                                Users.FirstName = reader["FirstName"].ToString();
                                Users.LastName = reader["LastName"].ToString();
                                Users.RoleId = Convert.ToInt32(reader["RoleId"]);
                                Users.Phone = reader["ContactNumber"].ToString();
                                Users.SaltKey = reader["Salt"].ToString();
                                Users.Email = reader["Email"].ToString();
                                Users.Status = reader["Status"].ToString();
                                Users.RoleName = reader["RoleName"].ToString();
                            }
                            else
                            {
                                isUserExists = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isUserExists;
        }
        public bool ReadAllUserDataByUserName(string userName)
        {
            var isUserDataExists = true;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var sqlCommand = new SQLiteCommand())
                    {
                        sqlCommand.Connection = connection;
                        sqlCommand.CommandText = "SELECT * FROM Users JOIN Roles ON Users.RoleId=Roles.RoleNumber WHERE UserName=@userName";
                        sqlCommand.Parameters.AddWithValue("@userName", userName);
                        sqlCommand.CommandType = CommandType.Text;
                        using (SQLiteDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                UserDetailsByUserName.UserId = Convert.ToInt32(reader["Id"]);
                                UserDetailsByUserName.UserName = reader["UserName"].ToString();
                                UserDetailsByUserName.Password = reader["Password"].ToString();
                                UserDetailsByUserName.FirstName = reader["FirstName"].ToString();
                                UserDetailsByUserName.LastName = reader["LastName"].ToString();
                                UserDetailsByUserName.Role = reader["RoleName"].ToString();
                                UserDetailsByUserName.Phone = reader["ContactNumber"].ToString();
                                UserDetailsByUserName.Email = reader["Email"].ToString();
                                UserDetailsByUserName.Status = reader["Status"].ToString();
                                UserDetailsByUserName.SaltKey = reader["Salt"].ToString();
                            }
                            else
                            {
                                isUserDataExists = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isUserDataExists;
        }
        public string ReadRoleIdByRoleName(string roleName)
        {
            string roleId = "";
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var sqlCommand = new SQLiteCommand())
                    {
                        sqlCommand.Connection = connection;
                        sqlCommand.CommandText = "select * from Roles where RoleName=@roleName";
                        sqlCommand.Parameters.AddWithValue("@roleName", roleName);
                        sqlCommand.CommandType = CommandType.Text;

                        using (var reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                roleId = reader["RoleNumber"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return roleId;
        }
        public bool InsertUserData(string loginName, string password, string firstName, string lastName, string email, string phone, string status, string roleId, string saltKey)
        {
            var isUserRowEffected = false;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var sqlCommand = new SQLiteCommand())
                    {
                        sqlCommand.Connection = connection;
                        sqlCommand.CommandText = "INSERT INTO Users (UserName,Password,FirstName,LastName,RoleId,Email,ContactNumber,Status,Salt,DateCreated,CreatedBy) VALUES (@userName,@password,@firstName,@lastName,@roleId,@email,@phone,@status,@salt,@dateCreated,@createdBy)";
                        sqlCommand.Parameters.AddWithValue("@userName", loginName);
                        sqlCommand.Parameters.AddWithValue("@password", password);
                        sqlCommand.Parameters.AddWithValue("@firstName", firstName);
                        sqlCommand.Parameters.AddWithValue("@lastName", lastName);
                        sqlCommand.Parameters.AddWithValue("@email", email);
                        sqlCommand.Parameters.AddWithValue("@phone", phone);
                        sqlCommand.Parameters.AddWithValue("@salt", saltKey);
                        sqlCommand.Parameters.AddWithValue("@status", status);
                        sqlCommand.Parameters.AddWithValue("@dateCreated", DateTime.Now);
                        sqlCommand.Parameters.AddWithValue("@createdBy", "Admin");
                        sqlCommand.Parameters.AddWithValue("@roleId", roleId);
                        sqlCommand.CommandType = CommandType.Text;
                        int rowEffected = sqlCommand.ExecuteNonQuery();
                        if (rowEffected > 0)
                        {
                            isUserRowEffected = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isUserRowEffected;
        }
        public string ReadUserRoleByUserName(string userName)
        {
            var userRole = "";
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var sqlCommand = new SQLiteCommand())
                    {
                        sqlCommand.Connection = connection;
                        sqlCommand.CommandText = "SELECT Roles.RoleName FROM Users,Roles WHERE Users.RoleId=Roles.RoleNumber AND UserName=@userName";
                        sqlCommand.Parameters.AddWithValue("@userName", userName);
                        sqlCommand.CommandType = CommandType.Text;
                        using (SQLiteDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                userRole = reader["RoleName"].ToString();
                            }
                            else
                            {
                                userRole = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return userRole;
        }
        public bool DeleteUser(string userName)
        {
            var isUserDeleted = false;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var sqlCommand = new SQLiteCommand())
                    {
                        sqlCommand.Connection = connection;
                        sqlCommand.CommandText = "DELETE FROM Users WHERE UserName=@userName ";
                        sqlCommand.Parameters.AddWithValue("@userName", userName);
                        sqlCommand.CommandType = CommandType.Text;
                        int rowEffected = sqlCommand.ExecuteNonQuery();
                        if (rowEffected > 0)
                        {
                            isUserDeleted = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isUserDeleted;
        }
        public List<UserDetails> ReadAllUserData(int pageNumber, int pageSize)
        {
            List<UserDetails> userDetails = new List<UserDetails>();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var sqlCommand = new SQLiteCommand())
                    {
                        sqlCommand.Connection = connection;
                        sqlCommand.CommandText = "SELECT * FROM Users JOIN Roles ON Users.RoleId=Roles.RoleNumber";
                        sqlCommand.CommandType = CommandType.Text;

                        using (var reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    UserDetails userRole = new UserDetails
                                    {
                                        UserName = reader["UserName"].ToString(),
                                        Password = reader["Password"].ToString(),
                                        FirstName = reader["FirstName"].ToString(),
                                        LastName = reader["LastName"].ToString(),
                                        Role = reader["RoleName"].ToString(),
                                        Email = reader["Email"].ToString(),
                                        Status = reader["Status"].ToString()
                                    };
                                    userDetails.Add(userRole);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return userDetails.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }
        public List<UserRoles> ReadUsersRole()
        {
            List<UserRoles> userRoleList = new List<UserRoles>();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var sqlCommand = new SQLiteCommand())
                    {
                        sqlCommand.Connection = connection;
                        sqlCommand.CommandText = "select * from Roles where Status=@roleStatus";
                        sqlCommand.Parameters.AddWithValue("@roleStatus", "Active");
                        sqlCommand.CommandType = CommandType.Text;

                        using (var reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    UserRoles userRole = new UserRoles
                                    {
                                        RoleId = Convert.ToInt32(reader["Id"]),
                                        RoleName = Convert.ToString(reader["RoleName"])
                                    };
                                    userRoleList.Add(userRole);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return userRoleList;
        }
        public bool UpdateUserData(string loginName, string firstName, string lastName, string email, string phone, string status, string roleId)
        {
            var isUserRowEffected = false;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var sqlCommand = new SQLiteCommand())
                    {
                        sqlCommand.Connection = connection;
                        sqlCommand.CommandText = "UPDATE Users SET UserName=@userName,FirstName=@firstName,LastName=@lastName,RoleId=@roleId,Email=@email,ContactNumber=@phone,Status=@status,DateModified=@dateModified,ModifiedBy=@modifiedBy WHERE Id=@userID";
                        sqlCommand.Parameters.AddWithValue("@userName", loginName);
                        sqlCommand.Parameters.AddWithValue("@firstName", firstName);
                        sqlCommand.Parameters.AddWithValue("@lastName", lastName);
                        sqlCommand.Parameters.AddWithValue("@email", email);
                        sqlCommand.Parameters.AddWithValue("@phone", phone);
                        sqlCommand.Parameters.AddWithValue("@status", status);
                        sqlCommand.Parameters.AddWithValue("@dateModified", DateTime.Now);
                        sqlCommand.Parameters.AddWithValue("@modifiedBy", "Admin");
                        sqlCommand.Parameters.AddWithValue("@roleId", roleId);
                        sqlCommand.Parameters.AddWithValue("@userID", UserDetailsByUserName.UserId);
                        sqlCommand.CommandType = CommandType.Text;
                        int rowEffected = sqlCommand.ExecuteNonQuery();
                        if (rowEffected > 0)
                        {
                            isUserRowEffected = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isUserRowEffected;
        }
        public int ReadUserDataCount()
        {
            int userCount = 0;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var sqlCommand = new SQLiteCommand())
                    {
                        sqlCommand.Connection = connection;
                        sqlCommand.CommandText = "SELECT Count(*) AS NoOfRows FROM Users";
                        sqlCommand.CommandType = CommandType.Text;

                        using (SQLiteDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                userCount = Convert.ToInt32(reader["NoOfRows"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return userCount;
        }
    }
}
