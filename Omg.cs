namespace Ohoh
{
    class Util
    {
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
    }
}


