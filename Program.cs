internal class Program
{
    /// <summary>
    /// Main 함수 
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {

        var intArray = new int[] { 1,3,5,7 };
        Solution sol = new Solution();
  
        //PrintIntarray(sol.Solution0715(intArray));
        Console.WriteLine(sol.Solution07152("abcdef","f"));


        CSstudy cSstudy = new CSstudy();
        // cSstudy.StackQueue();

        

        //cSstudy.hashTableSample();
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