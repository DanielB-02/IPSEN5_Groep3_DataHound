namespace ipsen5_data_hound.Services;

public class LoginService
{
    public string username { get; set; }
    public string password { get; set; }

    public bool testName()
    {
        if (username == "admin")
        {
            return true;
        }
        else return false;
    }
    
    public bool testPass()
    {
        if (password == "admin")
        {
            return true;
        }
        else return false;
    }
    
}