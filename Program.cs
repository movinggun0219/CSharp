internal class Program
{
    private static void Main(string[] args)
    {
        // Solution0704(3 ,2);
        Console.WriteLine($"{Solution0704(3 ,2)}");
        Console.WriteLine($"{Solution0704(10, 5)}");
    }
    public static int Solution0704(int num1, int num2)
    {
        int answer = 0;
        answer = num1 % num2;
                
        return answer;
    }
}