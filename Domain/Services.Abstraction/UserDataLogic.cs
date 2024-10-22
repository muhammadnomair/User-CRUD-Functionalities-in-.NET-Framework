using System;
using System.Windows.Forms;
using UserCRUD.Domain.Models;
using System.Collections.Generic;
using UserCRUD.Domain.RepositoryInterfaces;

namespace UserCRUD.Domain.Services.Abstraction
{
    public class UserDataLogic:IUsersDataInterface
    {
        public bool ReadUserData(string user)
        {
            var isDataExists = true;
            try
            {
                UserDataService userDetail = new UserDataService();
                isDataExists = userDetail.ReadUserData(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred :\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isDataExists;
        }
        public string ReadRoleIdByRoleName(string roleName)
        {
            string roleId = "";
            try
            {
                UserDataService userDetail = new UserDataService();
                roleId = userDetail.ReadRoleIdByRoleName(roleName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred :\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return roleId;
        }
        public bool ReadAllUserDataByUserName(string userName)
        {
            var isUserExists = true;
            try
            {
                UserDataService userDetail = new UserDataService();
                isUserExists = userDetail.ReadAllUserDataByUserName(userName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred :\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isUserExists;
        }
        public bool InsertUserData(string loginName, string password, string firstName, string lastName, string email, string phone, string status, string roleId, string saltKey)
        {
            var isDataInserted = true;
            try
            {
                UserDataService userDetail = new UserDataService();
                isDataInserted = userDetail.InsertUserData(loginName, password, firstName, lastName, email, phone, status, roleId, saltKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred :\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isDataInserted;
        }
        public string ReadUserRoleByUserName(string userName)
        {
            var roleName = "";
            try
            {
                UserDataService userDetail = new UserDataService();
                roleName = userDetail.ReadUserRoleByUserName(userName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred :\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return roleName;
        }
        public bool DeleteUser(string userName)
        {
            var isUserDeleted = true;
            try
            {
                UserDataService userDetail = new UserDataService();
                isUserDeleted = userDetail.DeleteUser(userName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred :\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isUserDeleted;
        }
        public List<UserDetails> ReadAllUserData(int page, int pageSize)
        {
            List<UserDetails> data = new List<UserDetails>();
            try
            {
                UserDataService userDetail = new UserDataService();
                data = userDetail.ReadAllUserData(page, pageSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred :\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data;
        }
        public List<UserRoles> ReadUsersRole()
        {
            List<UserRoles> roles = new List<UserRoles>();
            try
            {
                UserDataService userDetail = new UserDataService();
                roles = userDetail.ReadUsersRole();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred :\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return roles;
        }
        public bool UpdateUserData(string loginName, string firstName, string lastName, string email, string phone, string status, string roleId)
        {
            var isUserUpdated = true;
            try
            {
                UserDataService userDetail = new UserDataService();
                isUserUpdated = userDetail.UpdateUserData(loginName, firstName, lastName, email, phone, status, roleId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred :\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isUserUpdated;
        }
        public int ReadUserDataCount()
        {
            int count = 0;
            try
            {
                UserDataService userDetail = new UserDataService();
                count = userDetail.ReadUserDataCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred :\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return count;
        }
    }
}
