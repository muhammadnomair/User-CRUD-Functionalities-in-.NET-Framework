using UserCRUD.Domain.Models;
using System.Collections.Generic;

namespace UserCRUD.Domain.RepositoryInterfaces
{
    public interface IUsersDataInterface
    {
        /// <summary>
        /// Read User Details
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        bool ReadUserData(string user);

        /// <summary>
        /// Read All User Data From User Table By User Name
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        bool ReadAllUserDataByUserName(string userName);

        /// <summary>
        /// Read Role Id By Role Name
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        string ReadRoleIdByRoleName(string roleName);

        /// <summary>
        /// Insert User Data Into User Table
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="password"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="address"></param>
        /// <param name="status"></param>
        /// <param name="roleId"></param>
        /// <returns></returns>
        bool InsertUserData(string loginName, string password, string firstName, string lastName, string email, string phone, string status, string roleId, string saltKey);

        /// <summary>
        /// Read User Role By User Name
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        string ReadUserRoleByUserName(string userName);

        /// <summary>
        /// Delete User From User Table
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        bool DeleteUser(string userName);

        /// <summary>
        /// Read All User Data From User Table
        /// </summary>
        /// <returns></returns>
        List<UserDetails> ReadAllUserData(int page, int pageSize);

        /// <summary>
        /// Read Data from User Role Table
        /// </summary>
        /// <returns></returns>
        List<UserRoles> ReadUsersRole();

        /// <summary>
        /// Read User Data Count
        /// </summary>
        /// <returns></returns>
        int ReadUserDataCount();

        /// <summary>
        /// Update User Data In User Table
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="password"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="address"></param>
        /// <param name="status"></param>
        /// <param name="roleId"></param>
        /// <returns></returns>
        bool UpdateUserData(string loginName, string firstName, string lastName, string email, string address, string status, string roleId);
    }
}
