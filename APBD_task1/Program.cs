public class Program
{
    public static void Main(string[] args)
    {
        List<int> nums = new List<int>() {67, 5, 10, 15};
        double average = FindAverage(nums);
        Console.WriteLine($"The average for an array is {average:F2}");
        Console.WriteLine("S32793 Filatov Danylo");
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
    public static int FindMax(List<int> list)
    {
        int max = int.MinValue;
        foreach (int i in list)
        {
            max = Math.Max(max, i);
        }
        return max;
    }
    public static int getFirstElement(List<int> list)
    {
        if (list.Count == 0)
            return int.MinValue;
        return list[0];
    }
    public static double getAverageBetweenFirstAndLast(List<int> list)
    {
        if (list.Count < 2) return 0;
        return (list[0] + list[list.Count - 1]) / 2;
    }
    public static string DummyMethod()
    {
        return "dummy string in main";
    }
}