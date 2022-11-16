// See https://aka.ms/new-console-template for more information

using TemaCS;

var u = new User("Vlad", "aisa1bvoib", "vlad@gmail.com");
var u1 = new User("Ale", "aio521b", "ale@gmail.com");
var u2 = new User("Fern", "aio5sf1sa21b", "fern@gmail.com");
User[] userArray = new User[3];
userArray[0] = new User("Stef", "gjs18s", "stef@gmail.com");
userArray[1] = new User("Adel", "gsa1kkl1", "adel@gmail.com");
userArray[2] = new User("Mir1unik", "v1euig1qoi1y1", "mirunik@yahoo.com");

Application wa = new WebApplication("WebApp", userArray, 10);
Console.WriteLine(wa.ToString());
wa.AddUser(u); // add method
wa.AddUser(u1);
wa.AddUser(u1);
Console.WriteLine(wa.GetNumberOfUsers());
wa.RemoveUser(u); //remove method testing
Console.WriteLine(wa.GetNumberOfUsers());
((WebApplication)wa).HttpRequest(u2);
((WebApplication)wa).HttpRequest(u);
((WebApplication)wa).HttpRequest(u1);


Application ma = new MobileApplication("MobileApp", userArray, 100);
((MobileApplication)ma).RateApp(); // rate mobile app 5 times and print the average
((MobileApplication)ma).RateApp();
((MobileApplication)ma).RateApp();
((MobileApplication)ma).RateApp();
Console.WriteLine(((MobileApplication)ma).RateApp());

Console.WriteLine(((WebApplication)wa).GetNumberOfUsers());


// 5.
Console.Write("Admin name: ");
string n = Console.ReadLine();
if (!string.IsNullOrEmpty(n)) // checks if n is empty and if it refers to nothing (is null)
{
    User[] list = new User[0];
    Application ma1 = new MobileApplication("CandyCrush", list , 100);
    
    Admin adm1 = new Admin(n);
    adm1.AddApplication(wa);
    adm1.AddApplication(ma);
    adm1.AddApplication(ma1);
    adm1.AddUser(u, adm1.GetApplications()[0]);
    adm1.AddUser(u1, adm1.GetApplications()[1]);
    adm1.AddUser(u2, adm1.GetApplications()[1]);
    adm1.RemoveUser(u, adm1.GetApplications()[0]);
    Console.WriteLine($"{adm1.GetApplications()[0].GetName()} has {adm1.GetApplications()[0].GetNumberOfUsers()} users");
    Console.WriteLine($"{adm1.GetApplications()[1].GetName()} has {adm1.GetApplications()[1].GetNumberOfUsers()} users");
    Console.WriteLine($"{adm1.GetApplications()[2].GetName()} has {adm1.GetApplications()[2].GetNumberOfUsers()} users");
}
else
{
    Console.WriteLine("Error - admin has no name :'(");
}





