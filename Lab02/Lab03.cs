public class TemperatureTracker
{
    private int[] temperature_week = new int[7];
    public static int x = 1;

    public TemperatureTracker(int[] temp_week)
    {
        this.temperature_week = temp_week;
    }
    
    public static void record_temp(int[] tempweek)
    {
        Console.WriteLine("Enter the temperature of day " + x + ": ");
        tempweek[x-1] = int.Parse(Console.ReadLine());
        x = x + 1;
        if (x > 7)
        {
            display(tempweek);
            Environment.Exit(0);
        }
        else
        {
            record_temp(tempweek);
        }

    }

    public static void display(int[] tempweek)
    {
        for (int x = 0; x<7; x++)
        {
            Console.WriteLine("Temperature of day " +(x+1)+ " : " + tempweek[x]);
        }
    }
}

class program
{
    static void Main(string[] args)
    {
        int[] temp_week = new int[7];
        TemperatureTracker.record_temp(temp_week);
        TemperatureTracker weektemp = new TemperatureTracker(temp_week);
    }
}