public class ParameterDemo
{
    // Method 1: Increase using ref
    public void Increase(ref int number)
    {
        number += 10;
    }

    // Method 2: GetFullName using out
    public void GetFullName(out string fullname)
    {
        fullname = "David Rai";   // assign your full name here
    }

    // Method 3: SumAll using params
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach(int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}