public class LoginForm
{
    public bool Login(string username, string password)
    {
        return username == "admin" && password == "password"; 
    }
}