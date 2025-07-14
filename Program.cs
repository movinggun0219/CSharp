internal class Program
{
    /// <summary>
    /// Main 함수 
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {

        var intArray = new int[] { 1, 2, 3, 4, 5 };
        Solution sol = new Solution();

        PrintIntarray(sol.Solution07142(intArray));

        CSstudy cSstudy = new CSstudy();
        // cSstudy.StackQueue();

        sol.Solution07142(intArray);
    }

    
    /// <summary>
    /// 정수 배열 뒤집기
    /// </summary>
    /// <param name="answerArray"></param>
    public static void PrintIntarray(int[] answerArray)
    {

        Console.Write("[");
        for (int i = 0; i < answerArray.Length; i++)
        {
            Console.Write($"{answerArray[i]}");
            if (i != answerArray.Length - 1)
            {
                Console.Write(",");
            }
        }
        Console.Write("]");
    }

    /// <summary>
    /// 
    /// </summary>
    public static void MakeLotto()
    {
        List<int> ballList = new List<int>();
        List<int> LottoList = new List<int>();

        Random rand = new Random();


        for (int i = 1; i <= 45; i++)
        {
            ballList.Add(i);
        }

        Console.WriteLine($"{ballList.Count}");

        for (int i = 0; i < 6; i++)
        {
            int index = rand.Next(0, ballList.Count);
            LottoList.Add(ballList[index]);
            //Console.Write($" [{index}] ");
            //Console.WriteLine($"{ballList[index]}");
            ballList.RemoveAt(index);
        }


        foreach (int num in LottoList)
        {
            Console.Write($"{num} ");
        }

    }
}