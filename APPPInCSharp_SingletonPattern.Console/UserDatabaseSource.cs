using System;

namespace APPPInCSharp_SingletonPattern.Console
{
    public class UserDatabaseSource : UserDatabase
    {
        private static UserDatabaseSource theInstance = new UserDatabaseSource();

        private UserDatabaseSource()
        {
        }

        public UserDatabaseSource Instance => theInstance;

        public User ReadUser(string username)
        {
            throw new NotImplementedException();
        }

        public void WriteUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}