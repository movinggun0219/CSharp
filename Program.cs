internal class Program
{
    /// <summary>
    /// Main 함수 
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        //Console.WriteLine($"{sol.Solution07102(2)}");


        CSstudy cSstudy = new CSstudy();
        //cSstudy.DataType();

        Solution sl = new Solution();
        //Console.WriteLine($"{sol.Solution07092(3, 2)}");

        //cSstudy.AraayExample();

        //cSstudy.ListSample();

        //Console.WriteLine($"{sol.Solution07112(4)}");
        MakeLotto();
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
            int index = rand.Next(0,ballList.Count) ;
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