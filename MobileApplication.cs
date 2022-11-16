namespace TemaCS;

public class MobileApplication : Application
{
    private double rating = 0;
    private int i = 0;
    public MobileApplication(string name, User[] users, int maxNr) : base(name, users, maxNr) {}

    public double RateApp()
    {
        Console.Write("Add rating: ");
        double nota = Convert.ToDouble(Console.ReadLine());
        i = i + 1;
        rating = ((i-1) * rating + nota) / i;
        return rating;
    }
}