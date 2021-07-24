using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_11__homework
{
    class User
    {
        private string userName;
        private string password;
        private bool isLogin;
        enum premission
        {
            User,
            Admin,
            Super_Admin

        }
        static User[] user = new User[5];


        public void Login(string username, string password)
        {
            for (int i = 0; i < user.Length; i++)
            {
                if (user[i].userName == username && user[i].password == password)
                {
                    
                }
            }
        }
    }

}
