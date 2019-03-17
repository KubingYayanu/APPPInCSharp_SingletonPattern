namespace APPPInCSharp_SingletonPattern.Console
{
    public interface UserDatabase
    {
        User ReadUser(string username);

        void WriteUser(User user);
    }
}