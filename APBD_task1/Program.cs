public class Program
{
    public static void Main(string[] args)
    {
        List<int> nums = new List<int>() {1, 2, 3, 4, 5, 10, 15};
        double average = FindAverage(nums);
        Console.WriteLine($"The average for an array is {average:F2}");
    }
    public static double FindAverage(List<int> list)
    {
        double sum = 0;
        foreach (int i in list)
        {
            sum += i;
        }
        return sum / list.Count;
    }
}