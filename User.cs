namespace TemaCS;

public class User
{
    private string username;
    private string password;
    private string email;

    public User(string username, string password, string email)
    {
        this.username = username;
        this.password = password;
        this.email = email;
    }

    public string GetMail()
    {
        return email;
    }

    public void ChangePassword(string newPassword)
    {
        password = newPassword;
    }

    public override string ToString()
    {
        return username + " " + email;
    }

    public override bool Equals(object? obj)
    {
        if (obj != null)
        {
            if (obj.GetType() == typeof(User))
            {
                if (((User)obj).username == this.username && ((User)obj).password == this.password && ((User)obj).email == this.email)
                {
                    return true;
                }
            }
        }
        
        return false;
    }
}

