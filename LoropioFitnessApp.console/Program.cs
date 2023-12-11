       Console.WriteLine("Activity Tracker Application");
        Console.WriteLine();

        Console.Write("Enter activity name: ");
        string activityName = Console.ReadLine();

        Console.Write("Enter distance covered (in meters): ");
        double distanceInMeters;
        while (!double.TryParse(Console.ReadLine(), out distanceInMeters) || distanceInMeters < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative number.");
        }

        Console.Write("Enter time taken (in hours): ");
        double timeTakenInHours;
        while (!double.TryParse(Console.ReadLine(), out timeTakenInHours) || timeTakenInHours < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative number.");
        }

        Console.Write("Enter date of the activity (YYYY-MM-DD): ");
        DateTime dateOfActivity;
        while (!DateTime.TryParse(Console.ReadLine(), out dateOfActivity))
        {
            Console.WriteLine("Invalid date format. Please enter the date in YYYY-MM-DD format.");
        }

        double averageSpeed = CalculateAverageSpeed(distanceInMeters, timeTakenInHours);

        Console.WriteLine("\nActivity Details");
        Console.WriteLine($"Activity Name: {activityName}");
        Console.WriteLine($"Distance Covered: {distanceInMeters} meters");
        Console.WriteLine($"Time Taken: {timeTakenInHours} hours");
        Console.WriteLine($"Date of Activity: {dateOfActivity.ToString("yyyy-MM-dd")}");
        Console.WriteLine($"Average Speed: {averageSpeed} meters per hour");
    

    static double CalculateAverageSpeed(double distance, double time)
    {
        return time != 0 ? distance / time : 0;
    }

