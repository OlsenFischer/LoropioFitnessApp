 // See https://aka.ms/new-console-template for more informationConsole.WriteLine("Activity Tracker Application");
        Console.WriteLine();

        Console.Write("Enter activity name: ");
        string activityName = Console.ReadLine();

        Console.Write("Enter distance covered (in kilometers): ");
        double distanceInKilometers;
        while (!double.TryParse(Console.ReadLine(), out distanceInKilometers) || distanceInKilometers < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative number.");
        }

        Console.Write("Enter time taken (in minutes): ");
        double timeTakenInMinutes;
        while (!double.TryParse(Console.ReadLine(), out timeTakenInMinutes) || timeTakenInMinutes < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative number.");
        }

        Console.Write("Enter date of the activity (YYYY-MM-DD): ");
        DateTime dateOfActivity;
        while (!DateTime.TryParse(Console.ReadLine(), out dateOfActivity))
        {
            Console.WriteLine("Invalid date format. Please enter the date in YYYY-MM-DD format.");
        }

        double averageSpeed = CalculateAverageSpeed(distanceInKilometers * 1000, timeTakenInMinutes * 60);

        Console.Write("How did you feel after the activity? (1: Bad, 2: OK, 3: Good, 4: Very Good, 5: Strong): ");
        int feeling = GetFeeling();

        Console.WriteLine("\nActivity Details");
        Console.WriteLine($"Activity Name: {activityName}");
        Console.WriteLine($"Distance Covered: {distanceInKilometers} kilometers");
        Console.WriteLine($"Time Taken: {timeTakenInMinutes} minutes");
        Console.WriteLine($"Date of Activity: {dateOfActivity.ToString("yyyy-MM-dd")}");
        Console.WriteLine($"How You Felt After the Activity: {GetFeelingText(feeling)}");
        Console.WriteLine($"Average Speed: {averageSpeed} kilometers per minute");
    

    static double CalculateAverageSpeed(double distance, double time)
    {
        return time != 0 ? distance / time : 0;
    }

    static int GetFeeling()
    {
        int feeling;
        while (!int.TryParse(Console.ReadLine(), out feeling) || feeling < 1 || feeling > 5)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
            Console.Write("How did you feel after the activity? (1: Bad, 2: OK, 3: Good, 4: Very Good, 5: Strong): ");
        }
        return feeling;
    }

    static string GetFeelingText(int feeling)
    {
        switch (feeling)
        {
            case 1:
                return "Bad";
            case 2:
                return "OK";
            case 3:
                return "Good";
            case 4:
                return "Very Good";
            case 5:
                return "Strong";
            default:
                return "Unknown Feeling";
        }
    }

