using Ohoh;
internal class Program
{


    /// <summary>
    /// Main 함수 
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        var intArray = new int[] { 4, 11 };
        var strs = new string[] { "a","b","c" };
        var strs2 = new string[] { "com", "b", "d", "p", "c" };

        Solution sol = new Solution();

        Console.WriteLine(sol.solution07302(144));
        //PrintIntarray(sol.solution07282(strs));

        CSstudy study = new CSstudy();
        //study.SbSample();

        //Util.PrintIntarray(sol.solution07282(strs));

    }


    static IEnumerable<int> GetNumber()
    {
        yield return 10;
        yield return 20;
        yield return 30;

    }

    /// <summary>
    /// 정수 배열의 합을 구하기
    /// </summary>
    /// <param name="scoresArray"></param>
    /// <returns></returns>
    public static int CalculateSum(int[] scoresArray)
    {
        int sum = 0;
        for (int i = 0; i < scoresArray.Length; i++)
        {
            sum += scoresArray[i];
        }

        return sum;
    }

    /// <summary>
    /// 정수 배열 나오게하기
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
                Console.Write(", ");
            }
        }
        Console.Write("]");
    }

    /// <summary>
    /// 
    /// </summary>
    public static void MakeLotto()
    {
        const int TOTAL_BALLS = 45; // 전체 공 개수 const = 상수 
        const int PICK_BALLS = 6;   // 뽑는 공 수

        List<int> ballList = new List<int>();
        List<int> LottoList = new List<int>();

        Random rand = new Random();


        for (int i = 1; i <= TOTAL_BALLS; i++)
        {
            ballList.Add(i);
        }

        Console.WriteLine($"{ballList.Count}");

        for (int i = 0; i < PICK_BALLS; i++)
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