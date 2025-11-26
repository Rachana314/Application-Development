
class Program
{
    static void Main(string[] args)
    {
        //Task 1
        // Create bank account object
        BankAccount BankAccount = new BankAccount("JBDOJEW8210", 5000);

        Console.WriteLine($"Account Number: {BankAccount.AccountNumber}");
        Console.WriteLine($"Initial Balance: {BankAccount.Balance}");

        // Deposit money
        BankAccount.Deposit(300);
        Console.WriteLine($"Balance after deposit: {BankAccount.Balance}");

        // Withdraw money
        BankAccount.Withdraw(200);
        Console.WriteLine($"Balance after withdrawal: {BankAccount.Balance}");

        //Task 2
        
        // Creating Car object
        Car  car = new Car()
        {
            Brand = "BMW",
            Speed = 480,
            Seats = 2
        };

        // Creating Motorcycle object
        Motorcycle motorbike = new Motorcycle()
        {
            Brand = "Mercedes",
            Speed = 550,
            Type = "Sports"
        };

        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        motorbike.Start();
        motorbike.DisplayInfo();
        motorbike.Stop();

        //Task 3
        Printer printer = new Printer();

        printer.Print("Hello Friend");     
        printer.Print(123);                
        printer.Print("Repeat Me", 3); 

        //Task 3

        NepaliTeacher nepaliTeacher = new NepaliTeacher();
        nepaliTeacher.Name = "Mr. Nitin";
        Console.WriteLine(nepaliTeacher.Name);
        nepaliTeacher.Teaching();
        nepaliTeacher.SalaryInfo();

        Console.WriteLine();

        EnglishTeacher englishTeacher = new EnglishTeacher();
        englishTeacher.Name = "Ms. Rachana";
        Console.WriteLine(englishTeacher.Name);
        englishTeacher.Teaching();
        englishTeacher.SalaryInfo();


        Carr carr = new Carr();
        Bikee bike = new Bikee();

        Console.WriteLine("Car:");
        carr.Display();
        carr.StartEngine();
        carr.StopEngine();

        Console.WriteLine();

        Console.WriteLine("Bike:");
        bike.Display();
        bike.StartEngine();
        bike.StopEngine();

        // Task 5 OOP Derived Classes

        Laptop laptops = new Laptop("MacBook", 400000);
        Smartphone phone = new Smartphone("I phone", 12500);

        Console.WriteLine("Laptop:");
        laptops.ShowInfo();
        laptops.TurnOnBattery();

        Console.WriteLine();

        Console.WriteLine("Smartphone:");
        phone.ShowInfo();
        phone.EnableCamera();

        //Task 5 OOP
        ElectronicsStore storeList = new ElectronicsStore();

        Laptop laptop = new Laptop("MacBook", 400000);
        Smartphone phones = new Smartphone("I phone", 12500);

        // Add devices
        storeList.AddDevice(laptop);
        storeList.AddDevice(phones);

        Console.WriteLine();

        // Display all devices
        storeList.ShowAllDeviceDetails();

        // Remove a device
        storeList.RemoveDevice(laptops);

        Console.WriteLine();
        storeList.ShowAllDeviceDetails();

    
        // 2. Create Laptop and Smartphone objects
        Laptop laptopp = new Laptop("MacBook", 400000);
        Smartphone phoned = new Smartphone("I phone", 12500);

        // 3. Add devices to the storeList
        storeList.AddDevice(laptopp);
        storeList.AddDevice(phoned);

        Console.WriteLine();

        // 4. Display all device details including child-specific behavior
        storeList.ShowAllDeviceDetails();
    }
}

