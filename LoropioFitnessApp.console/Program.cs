using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Activity Details:");

        Console.Write("Activity Name: ");
        string activityName = Console.ReadLine();

        Console.Write("Distance Covered (in meters): ");
        double distanceInMeters = double.Parse(Console.ReadLine());

        Console.Write("Time Taken (in minutes): ");
        double timeInMinutes = double.Parse(Console.ReadLine());

        Console.Write("Date of Activity (YYYY-MM-DD): ");
        string dateOfActivity = Console.ReadLine();

        double distanceInKilometers = ConvertMetersToKilometers(distanceInMeters);

        double averageSpeedInKilometersPerMinute = CalculateAverageSpeedInKilometersPerMinute(distanceInKilometers, timeInMinutes);

        Console.WriteLine("\nActivity Details");
        Console.WriteLine($"Activity Name: {activityName}");
        Console.WriteLine($"Distance Covered: {distanceInKilometers} kilometers");
        Console.WriteLine($"Time Taken: {timeInMinutes} minutes");
        Console.WriteLine($"Date of Activity: {dateOfActivity}");
        Console.WriteLine($"Average Speed: {averageSpeed} kilometers per minute");
    }

    static double ConvertMetersToKilometers(double meters)
    {
        return meters / 1000.0;
    }

    static double CalculateAverageSpeedInKilometersPerMinute(double distanceInKilometers, double timeInMinutes)
    {
        return distanceInKilometers / timeInMinutes;
    }
}
