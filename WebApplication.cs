namespace TemaCS;

public class WebApplication: Application
{
    public  WebApplication(string name, User[] users, int maxNr) : base(name, users, maxNr){}

    public void HttpRequest(User user)
    {
        bool ok = false;
        for (int i = 0; i < index; i++)
        {
            if (Users[i].Equals(user))
            {
                ok = true;
            }
        }

        if (ok == true)
        {
            Console.WriteLine("Ok Request");
        }
        else
        {
            Console.WriteLine("Bad Request");
        }
    }
}