namespace TemaCS;

public class Admin
{
    private string name;
    private Application[] list = new Application[100];
    private int index = 0;

    public Admin(string name)
    {
        this.name = name;
    }

    public bool AddApplication(Application a)
    {
        if (index == 100)
        {
            return false;
        }

        list[index] = a;
        index++;
        return true;
    }

    public Application[] GetApplications()
    {
        return list;
    }
    public void AddUser(User user, Application app)
    {
        if (app.AddUser(user) == false)
        {
            Console.WriteLine("Error - user could not be added");
        }
        Console.WriteLine("User {0} added in {1}", user, app.GetName());
    }

    public void RemoveUser(User user, Application app)
    {
        if (app.RemoveUser(user) == false)
        {
            Console.WriteLine("Error - user could not be removed");
        }
        Console.WriteLine("User {0} removed from {1}", user, app.GetName());
    }
}