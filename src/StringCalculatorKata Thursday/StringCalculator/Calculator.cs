
using NSubstitute.Core;

public class Calculator
{
    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }
        else
        {
            string[] nums = numbers.Split(new[] { ',', '\n' });
            int sum = 0;
            foreach(var num in nums)
            {
                sum += int.Parse(num);
            }
            return sum;
        }
        /*
        else if (numbers.Contains(","))
        {
            string[] nums = numbers.Split(',');
            int sum = 0;
            foreach (var num in nums)
            {
                sum += int.Parse(num);
            }
            return sum;
        }
        else if (int.TryParse(numbers, out int result))
        {
            return result;
        }
            return -42;
        */
    }
}
