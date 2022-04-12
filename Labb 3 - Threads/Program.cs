using Labb_3___Threads.Models;

Car volvo = new Car("Volvo", "V90", 1957);
Car porsche = new Car("Porsche", "Cayenne", 1895);

Thread volvoThread = new Thread(() => Car.StartRace(volvo));
Thread porscheThread = new Thread(() => Car.StartRace(porsche));
Thread bgThread = new Thread(() => Background.CollectInfo(volvo, porsche));
bgThread.IsBackground = true;

Console.WriteLine("WELCOME TO THE RACE\n");

Car.GetInfo(volvo);
Car.GetInfo(porsche);

Console.WriteLine("To start the race, press Enter");
Console.ReadKey();

Console.WriteLine("\nThe race as started!");
Console.WriteLine("\nPress any key to get info on the cars");

volvoThread.Start();
porscheThread.Start();
bgThread.Start();

volvoThread.Join();
porscheThread.Join();
Thread.Sleep(1000);
foreach (Car item in Car.CarList)
{
    if (item == Car.CarList[0])
    {
        Console.WriteLine("Wow! {0} came in at first place! Amazing!", item.Make);
    }
    else
    {
        Console.WriteLine("Good job! {0} came in at second place!", item.Make);
    }
}
