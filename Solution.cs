
using System.Text;
using System.Collections.Generic;
using System.Formats.Asn1;
class Solution
{
    public int solution07222(int[] sides)
    {
        int answer = 0;
        var list = new List<int> (sides);
        list.Sort();

        //Array.Sort(sides);
        //answer = (sides[2] < sides[0] + sides[1]) ? 1 : 2;

        answer = (list[2] < list[0] + list[1]) ? 1 : 2;


        return answer;
    }
    public int solution0722(int[] array, int height)
    {
        int answer = 0;
        // for (int i = 0; i < array.Length; i++)
        // {
        //     if (array[i] > height)
        //     {
        //         answer++;
        //     }
        // }

        foreach (var item in array)
        {
            answer += (item > height) ? 1 : 0;
        }

        return answer;
    }
    public int solution07212(int n)
    {
        int answer = 0;
        string str = n.ToString();

        foreach (var item in str)
        {
            answer += (item - '0');
        }

        return answer;
    }
    public string solution0721(string my_string)
    {
        return my_string.Replace("a", "")
            .Replace("e", "")
            .Replace("i", "")
            .Replace("o", "")
            .Replace("u", "");
        /*
        string answer = string.Empty;
        
        //for, if 를 사용한 방법 
        for (int i = 0; i < my_string.Length; i++)
        {
            if ((my_string[i] != 'a') &&
                (my_string[i] != 'e') &&
                (my_string[i] != 'i') &&
                (my_string[i] != 'o') &&
                (my_string[i] != 'u'))
            {
                // string연산이니까, stringBuilder 를 나중에 쓰자 ★
                answer += my_string[i];
            }
        }
        return answer;
        */
    }

    public int soulution0718(int[] numbers)
    {
        int answer = 0;


        // for (int i = 0; i < numbers.Length-1; i++)
        // {
        //     for (int j = i+1; j < numbers.Length; j++)
        //     {

        //         answer = Math.Max(answer, numbers[i] * numbers[j]);
        //     }
        // }

        //정렬을 이용한 방법
        // Array.Sort(numbers);
        // answer = numbers[numbers.Length-1] * numbers[numbers.Length - 2];


        var list = new List<int>(numbers);
        list.Sort();
        list.Reverse();
        //answer = list[list.Count-1] * list[list.Count -2];

        answer = list[0] * list[1];
        return answer;
    }
    public int Solution07172(int n, int t)
    {
        return n << t;

        // for (int i = 0; i < t; i++)
        // {
        //     n *= 2;
        // }
        // answer = n;

        //answer = (int)(n * Math.Pow(2, t));
        // 시간당 2배만큼 증가

        //return answer;
    }
    public int Solution0717(int n)
    {
        int answer = 0;
        // 온전한 피자 한판으로 먹을 수 있는 사람 수

        int pizza = n / 7;
        // 나머지 피자 조각 먹은 사람 수

        int res = ((n % 7) == 0) ? 0 : 1;

        answer = pizza + res;


        return answer;
    }

    public string Solution07162(string my_string)
    {
        var list = new List<char>(my_string);
        list.Reverse();
        string answer = new string(list.ToArray());


        /*
        var list = new List<char>(my_string);
        list.Reverse();
        string answer = ;
        */

        /*
        var sb = new StringBuilder();
        foreach (var item in my_string)
        {
            sb.Insert(0,item);
        }

        string answer = sb.ToString();
        s*/
        /*
            int len = my_string.Length;
            //string answer = string.Empty;
            char[] answerArray = new char[len];

             for (int i = 0; i < len; i++)
            {
                answerArray[len-1 -i] = my_string[i];
            }

            string answer = new string(answerArray);
            */



        return answer;
    }

    /// <summary>
    /// 편지
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public int Solution0716(string message)
    {
        int answer = 0;

        answer = message.Length * 2;

        return answer;
    }
    public string Solution07152(string my_string, string letter)
    {
        string answer = string.Empty; // ""; 
        answer = my_string.Replace(letter, string.Empty); //rebplace 성질을 이용하여 letter자리에 대신 쓰기


        // stringBuilder
        //StringBuilder sb = new StringBuilder();
        /*
        var sb = new StringBuilder();

        foreach (var item in my_string)
        {
            if (item.ToString().CompareTo(letter) != 0)  //compaterto로 스트링으로 변환된 값을 연산해준다.
            {
                sb.Append(item); // 값 더하기
            }
        }

        answer = sb.ToString();
        */

        // for, foreach
        /*
        for (int i = 0; i < my_string.Length; i++)
        {
            if (my_string[i].ToString() != letter)
            {
                answer += my_string[i];
            }
        }

        foreach (var item in my_string)
        {
            if (item != letter[0])
            {
                answer += item;
            }
        }
        */

        return answer;
    }
    /// <summary>
    /// 짝수 홀수 개수
    /// </summary>
    /// <param name="num_list"></param>
    /// <returns></returns>
    public int[] Solution0715(int[] num_list)
    {
        // int[] answer = new int[2]; // 홀수 짝수 표시
        var answer = new int[2] { 0, 0 }; // 짧게 표시

        for (int i = 0; i < num_list.Length; i++) // 1안
        {
            if (num_list[i] % 2 == 0)
            {
                answer[0]++;
            }
            else
            {
                answer[1]++;
            }
        }

        foreach (var item in num_list)  // 2안
        {
            answer[item % 2]++;

            // if (item % 2 == 0)
            // {
            //     answer[0]++;
            // }
            // else
            // {
            //     answer[1]++;
            // }
        }

        return answer;
    }

    public int[] Solution07142(int[] num_list)
    {
        int len = num_list.Length;
        int[] answer = new int[len];


        for (int i = len - 1; i >= 0; i--)
        {
            answer[i] = num_list[i];
            //Console.WriteLine($"[{answer[i]}]");
        }

        return answer;
    }
    public double Solution0714(int[] numbers)
    {

        double answer = 0;

        /*
        for (int i = 0; i < numbers.Length; i++)
        {
            answer += numbers[i];
        }
        */

        foreach (var item in numbers)
        {
            answer += item;
        }


        answer /= numbers.Length;

        return answer;
    }
    public int Solution07112(int n)
    {
        int answer = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                answer += i;
            }
        }
        return answer;
    }

    /// <summary>
    /// 몇인분
    /// </summary>
    /// <param name="n">양꼬치 개수</param>
    /// <param name="k">음료수 개수</param>
    /// <returns></returns>
    public int Solution0711(int n, int k)
    {
        // 양꼬치 10인분 먹으면 음료수 하나 서비스
        int answer = 0;

        int did = 12000; // 양꼬치
        int water = 2000; // 음료수
        int service = n / 10; // 서비스개수 

        answer = (did * n) + (water * k) - (service * water);

        return answer;
    }
    public int Solution07102(int angle)
    {

        // 1 = 예각
        // 2 = 직각
        // 3 = 둔각 
        // 4 = 평각
        int result = 0;
        string str = "";

        Console.Write($"{angle} 도는 ");

        if (0 < angle && angle < 90)
        {
            result = 1;
            str = "예";
        }
        else if (angle == 90)
        {
            result = 2;
            str = "직";
        }
        else if (angle > 90 && angle < 180)
        {
            result = 3;
            str = "둔";
        }
        else if (angle == 180)
        {
            result = 4;
            str = "평";
        }
        Console.WriteLine($"{str}각입니다.");

        return result;
    }

    public int Solution0710(int num1, int num2)
    {
        int result = num1 + num2;

        return result;
    }


    /// <summary>
    /// 두수의 나눗셈
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>

    public int Solution07092(int num1, int num2)
    {
        float answer = 0f;
        answer = (float)num1 / (float)num2 * 1000;
        return (int)answer;
    }

    /// <summary>
    /// 나이출력
    /// </summary>
    /// <param name="args"></param>
    public int Solution0709(int num1)
    {
        int answer = 2022;
        answer = answer - num1 + 1;

        return answer;
    }

    /// <summary>
    /// 비교문
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0708(int num1, int num2)
    {
        int answer = 0;

        if (num1 == num2)
        {
            answer = 1;
        }
        else
        {
            answer = -1;
        }
        return answer;
    }

    /// <summary>
    ///  두 수의 곱하기 연산
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution07072(int num1, int num2)
    {
        int answer = 0;
        answer = num1 * num2;
        return answer;
    }

    /// <summary>
    /// 빼기 연산
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0707(int num1, int num2)
    {
        int answer = 0;
        answer = num1 - num2;
        return answer;
    }

    /// <summary>
    ///  나머지 구하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0704(int num1, int num2)
    {
        int answer = 0;
        answer = num1 % num2;
        return answer;
    }


}