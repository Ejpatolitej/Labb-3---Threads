using Labb_3___Threads.Models;

Car volvo = new Car("Volvo", "V90", 1957);
Car koenigsegg = new Car("Koenigsegg", "Agera", 2021);
Car porsche = new Car("Porsche", "Cayenne", 1895);

Thread volvoThread = new Thread(() => Car.StartRace(volvo));
Thread koenigseggThread = new Thread(() => Car.StartRace(koenigsegg));
Thread porscheThread = new Thread(() => Car.StartRace(porsche));
Thread bgThread = new Thread(() => Background.CollectInfo(volvo, koenigsegg, porsche));
bgThread.IsBackground = true;

Console.WriteLine("WELCOME TO THE RACE\n");

Car.GetInfo(volvo);
Car.GetInfo(koenigsegg);
Car.GetInfo(porsche);

Console.WriteLine("To start the race, press Enter");
Console.ReadKey();

Console.WriteLine("\nThe race has started!");
Console.WriteLine("\nPress any key to get info on the cars");

bgThread.Start();
volvoThread.Start();
koenigseggThread.Start();
porscheThread.Start();
