namespace TemaCS;

public abstract class Application
{
    protected string Name;
    protected User[] Users = new User[100];
    protected int maxNr = 100;
    protected int index = 0;

    public Application(string Name, User[] Users, int maxNr)
    {
        this.Name = Name;
        for (int i = 0; i < Users.Length; i++)
        {
            this.Users[i] = Users[i];
        }
        this.maxNr = maxNr;
        index = Users.Length;
    }

    public bool AddUser(User u)
    {
        if (index == maxNr)
        {
            return false;
        }
        else
        {
            Users[index] = u;
            index++;
            return true;
        }
    }

    public bool RemoveUser(User u)
    {
        if (index == 0)
        {
            return false;
        }
        for (int i = 0; i < index; i++)
            {
                if (Users[i].Equals(u))
                {
                    for (int j = i; j < index-1; j++)
                    {
                        Users[j] = Users[j + 1];
                    }
                    index--;
                    return true;
                }
                
            }
        return false;
    }
    
    public string GetName()
    {
        return Name;
    }
    
    public int GetNumberOfUsers()
    {
        return index;
    }

    public override string ToString()
    {
        return Name + " " + maxNr;
    }
}