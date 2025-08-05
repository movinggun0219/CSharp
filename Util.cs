namespace Ohoh
{
    class Util
    {
        
        
        /// <summary>
        /// 사칙연산 계산기
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="calcType"></param>
        /// <returns></returns>
        /// <exception cref="ArithmeticException"></exception>
        public static int Calc(int a, int b, string calcType = "+")
        {
            switch (calcType)
            {
                case "+": return a + b;
                case "-": return a - b;
                case "*": return a * b;
                case "/": return a / b;
                default:
                    throw new ArithmeticException();
            }
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


