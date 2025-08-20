namespace Ohoh
{
    class Util
    {
        // 델리게이트 CompareDelegate 선언
        public delegate int CompareDelegate(int i1, int i2);
        // Util에 있는 compareDelegate와 동일한 prototype
        public static int AscendingCompare(int i1, int i2)
        {
            if (i1 == i2)
            {
                return 0;
            }

            return (i2 - i1) > 0 ? 1 : -1;
        }

        // Util에 있는 compareDelegate와 동일한 prototype
        public static int DescendingCompater(int i1, int i2)
        {
            if (i1 == i2)
            {
                return 0;
            }
            return (i1 - i2) > 0 ? 1 : -1;
        }

        /// <summary>
        /// 오름차순, 내림차순 정렬
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="comp"></param>
        public static void Sort(int[] arr, CompareDelegate comp)
        {
            if (arr.Length < 2) return;
            //Console.WriteLine($"함수 prototype: {comp.Method}");

            int ret;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    ret = comp(arr[i], arr[j]);
                    if (ret == -1)
                    {
                        int tmp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tmp;
                    }
                }
            }
            //PrintArray(arr);
        }

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
        /// 배열을 출력시키는 함수
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="answerArray"></param>
        public static void PrintArray<T>(T[] answerArray)
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


