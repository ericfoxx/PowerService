using PowerService.Services;

var powerService = new PowerServiceWorker();

Console.WriteLine("Welcome to the Power example consumer!");
powerService.TestUsage();


