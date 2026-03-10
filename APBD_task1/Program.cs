public class Program
{
    public static void Main(string[] args)
    {
        List<int> nums = new List<int>() {67, 5, 10, 15};
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
    public static int FindMin(List<int> list)
    {
        int min = int.MaxValue;
        foreach (int i in list)
        {
            min = Math.Min(min, i);
        }
        return min;
    }
}