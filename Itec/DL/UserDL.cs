using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itec.DB;
using Itec.Encryption;
using Itec.BL;
namespace Itec.DL
{
    public static class UserDL
    {
        //Check if a user exists
        public static User Login(string username, string password)
        {
            string query = $"SELECT * FROM users WHERE username = '{username}' AND role_id IS NOT NULL";
            DataTable dt = DatabaseHelper.GetData(query);

            if (dt.Rows.Count > 0)
            {
                string storedHash = dt.Rows[0]["password_hash"].ToString();
                if (PasswordHelper.VerifyPassword(password, storedHash))
                {
                    return new User
                    {
                        UserId = Convert.ToInt32(dt.Rows[0]["user_id"]),
                        Username = dt.Rows[0]["username"].ToString(),
                        Email = dt.Rows[0]["email"].ToString(),                                                                 
                        PasswordHash = storedHash,
                        RoleId = dt.Rows[0]["role_id"] == DBNull.Value ? null : (int?)Convert.ToInt32(dt.Rows[0]["role_id"])
                    };
                }
            }
            return null; 
        }

        //Register user
        public static void Signup(User user)
        {
            string query = $@"INSERT INTO users 
                         (username, email, password_hash, role_id) 
                         VALUES ('{user.Username}', '{user.Email}', 
                                 '{user.PasswordHash}', NULL)"; //ROle ID NULL for new users
            DatabaseHelper.ExecuteQuery(query);
        }

        //Check if a username/email already exists
        public static bool UserExists(string username, string email)
        {
            string query = $"SELECT * FROM users WHERE username = '{username}' OR email = '{email}'";
            DataTable dt = DatabaseHelper.GetData(query);
            return dt.Rows.Count > 0;
        }

        //Assign role to user
        public static void AssignRole(int userId, int roleId)
        {
            string query = $"UPDATE users SET role_id = {roleId} WHERE user_id = {userId}";
            DatabaseHelper.ExecuteQuery(query);
        }

        //Get non approved users
        public static List<User> GetPendingUsers()
        {
            List<User> users = new List<User>();
            string query = "SELECT * FROM users WHERE role_id IS NULL";
            DataTable dt = DatabaseHelper.GetData(query);

            foreach (DataRow row in dt.Rows)
            {
                users.Add(new User
                {
                    UserId = Convert.ToInt32(row["user_id"]),
                    Username = row["username"].ToString(),
                    Email = row["email"].ToString(),
                    PasswordHash = row["password_hash"].ToString(),
                    RoleId = null
                });
            }
            return users;
        }
    }
}
