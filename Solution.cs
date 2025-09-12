using System.Text;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Text.RegularExpressions;
using System.Diagnostics;

class Solution
{
    public int solution0912(string num_str)
    {
        int answer = 0;

        foreach (var item in num_str)
        {
            answer += item - '0';
        }
            
        return answer;
    }
    public int solution09102(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] != arr[j, i])
                {
                    return 0;
                }
            }
        }
        return 1;
    }
    public int[,] solution0910(int n)
    {
        int[,] answer = new int[n, n];

        // for (int i = 0; i < n; i++)
        // {
        //     for (int j = 0; j < n; j++)
        //     {
        //         if (i == j)
        //         {
        //             answer[i, j] = 1;
        //         }
        //     }
        // }

        for (int i = 0; i < n; i++)
        {
            answer[i, i] = 1;
        }
        return answer;
    }   
     public int solution0904(double flo)
    {
        int answer = (int)flo;

        string str = flo.ToString();
        string[] strArr = str.Split(".");
        answer = Convert.ToInt32(strArr[0]);
        return answer;
    }
    public int[] solution09032(int[] arr, int k)
    {
        var answer = new List<int>();
        foreach (var item in arr)
        {
            answer.Add(k % 2 == 0 ? item + k : item * k);            
        }        
        return answer.ToArray();
    }
    public string solution0903(string myString)
    {
        return Regex.Replace(myString, "[a-k]", "l");
    }
    public int solution09022(int[] num_list)
    {
        int answer = 0;
        string a = "";
        string b = "";
        foreach (var item in num_list)
        {
            if (item % 2 == 0) // 짝수
            {
                a += item.ToString();
            }
            else
            {               
                b += item.ToString();
            }
        }
        
        answer = Int32.Parse(a) + Convert.ToInt32(b);

        return answer;
    }

    public string solution0902(string my_string, string alp)
    {
        //return my_string.Replace(alp, alp.ToUpper());
        var sb = new StringBuilder();
        foreach (var item in my_string)
        {
            if (item.ToString().Equals(alp))
            {
                //answer += alp.ToUpper();
                sb.Append((char)(item - 'a' + 'A'));
            }
            else
            {
                sb.Append(item);
            }
        }

        return sb.ToString();
    }

    public void soulution09012()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);


        Console.WriteLine($"{a} + {b} = {a + b}");
    }
    public void solution0901()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        foreach (var item in s)
        {
            Console.WriteLine($"{item}");
        }
    }
    public int[] solution0829(int[] num_list)
    {
        var list = new List<int>(num_list);

        int len = list.Count - 1;

        if (list[len] < list[len - 1])
        {
            list.Add(list[len] * 2);
        }
        else if (list[len] > list[len - 1])
        {
            list.Add(list[len] - list[len - 1]);
        }

        return list.ToArray();
    }

    public string solution08282(int[] numLog)
    {
        var sb = new StringBuilder();

        for (int i = 0; i < numLog.Length - 1; i++)
        {
            int a = numLog[i + 1] - numLog[i];

            if (a == 1) sb.Append('w');

            else if (a == -1) sb.Append('s');

            else if (a == 10) sb.Append('d');

            else if (a == -10) sb.Append('a');

        }

        return sb.ToString();
    }

    public int solution0828(int n, string control)
    {


        foreach (var item in control)
        {
            switch (item)
            {
                case 'w': n++; break;
                case 's': n--; break;
                case 'd': n += 10; break;
                case 'a': n -= 10; break;
                default:
                    Console.WriteLine("Error!!");
                    break;
            }
        }


        return n;
    }

    public int[] solution08272(int n)
    {
        var list = new List<int>();
        while (n != 1)
        {
            list.Add(n);
            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n = 3 * n + 1;
            }

        }
        list.Add(1);
        return list.ToArray();
    }


    public string solution08262(string[] my_strings, int[,] parts)
    {
        string answer = "";
        int cnt = parts.GetLength(0);


        for (int i = 0; i < cnt; i++)
        {
            int len = parts[i, 1] - parts[i, 0] + 1;
            answer += my_strings[i].Substring(parts[i, 0], len);
        }

        return answer;
    }
    public int solution08252(string my_string, string is_prefix)
    {
        int answer = 1;

        if (is_prefix.Length > my_string.Length)
        {
            return 0;
        }

        for (int i = 0; i < is_prefix.Length; i++)
        {
            if (my_string[i] != is_prefix[i])
            {
                return 0;
            }
        }

        return my_string.IndexOf(is_prefix) == 0 ? 1 : 0;
        return answer;
    }
    /// <summary>
    /// 더 크게 합치기
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int solution0825(int a, int b)
    {
        string ab = $"{a}{b}";
        string ba = $"{b}{a}";
        int iab = int.Parse(ab);
        int iba = Convert.ToInt32(ba);
        int answer = Math.Max(iab, iba);

        return answer;
    }
    public int[] solution08222(int n, int k)
    {
        var list = new List<int>();
        
        for (int i = 1,j = i*k ; j <= n; i++,j =i*k)
        {
            list.Add(j);
        }

        return list.ToArray();


    }

    public int[] solution0822(int start_num, int end_num)
    {

        int len = start_num - end_num + 1;
        int[] answer = new int[len];

        for (int i = 0; i < len; i++)
        {
            answer[i] = start_num - i;
        }

        return answer;


        /*
        var list = new List<int>();
        
        for (int i = start_num; i >= end_num; i--)
        {
            list.Add(i);
        }

        return list.ToArray();
        */
    }

        public int[] solution08212(int[] num_list, int n)
    {
        int len = num_list.Length;
        int[] answer = new int[len];

        for (int i = 0; i < len; i++)
        {
            answer[i] = num_list[(i + n) % len];
        }

        return answer;
    }

    public int solution0821(int[] num_list)
    {
        for (int i = 0; i < num_list.Length; i++)
        {
            if (num_list[i] < 0)
            {
                return i;
            }
        }
        return -1;
    }

    public int solution08202(int[] numbers, int n)
    {
        int answer = 0;

        foreach (var item in numbers)
        {
            answer += item;
            if (answer >= n)
            {
                break;
            }
        }

        if (answer < n)
        {
            answer = -1;
        }

        return answer;
    }
    public string solution0820(string my_string, int n)
    {
        string answer = "";
        //string answer = my_string.Substring(my_string.Length-n,n);
        //return my_string.Remove(0, my_string.Length - n);

        for (int i = my_string.Length - n; i < my_string.Length; i++)
        {
            answer += my_string[i];
        }

        // for (int i = 0; i < my_string.Length; i++)
        // {
        //     if (i<my_string.Length - n)
        //     {
        //         continue;
        //     }
        //     else
        //     {
        //         answer += my_string[i];
        //     }
        // }

        return answer;
    }

    public string solution08192(string my_string)
    {
        /*
        string answer = "";

        var list = new List<string>();
        foreach (var item in my_string)
        {
            list.Add(item.ToString().ToLower());
        }
        list.Sort();

        foreach (var item in list)
        {
            answer += item;
        }
        return answer;
        */

        char[] chrarr = my_string.ToLower().ToCharArray();
        Array.Sort(chrarr);
        return new string(chrarr);

    }

    public int[] solution0819(int[] array)
    {

        int[] answer = new int[2];

        /*
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > answer[0])
            {
                answer[0] = array[i];
                answer[1] = i;
            }
        }
        */
        var dic = new Dictionary<int, int>(); // 
        var list = new List<int>(array);


        for (int i = 0; i < array.Length; i++)
        {
            dic.Add(array[i], i);
        }
        list.Sort();
        answer[0] = list[list.Count - 1];
        answer[1] = dic[answer[0]];

        return answer;
    }
    public int[] solution08182(int n)
    {
        var list = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                list.Add(i);
            }
        }
        return list.ToArray();
    }

    /// <summary>
    /// 인덱스바꾸기
    /// </summary>
    /// <param name="my_string"></param>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public string solution0818(string my_string, int num1, int num2)
    {
        /*
        string answer = "";
        char chr1 = my_string[num1];
        char chr2 = my_string[num2];


        for (int i = 0; i < my_string.Length; i++)
        {
            if (i == num1)
            {
                answer += chr2;
            }
            else if (i == num2)
            {
                answer += chr1;
            }
            else
            {
                answer += my_string[i];
            }
        }
        
        return answer;
        */

        var sb = new StringBuilder(my_string);
        sb[num1] = my_string[num2];
        sb[num2] = my_string[num1];

        return sb.ToString();

    }
    public string solution08142(string my_string)
    {
        var sb = new StringBuilder();

        foreach (var item in my_string)
        {
            if (item >= 'a' && item <= 'z')
            {
                sb.Append(item.ToString().ToUpper());
            }

            else
            {
                sb.Append(item.ToString().ToLower());
            }
        }

        foreach (var item in my_string)
        {
            // 소문자면 대문자로
            if (char.IsLower(item))
            {
                sb.Append(char.ToUpper(item));
            }
            // 그 외 (대문자 등)는 소문자로
            else
            {
                sb.Append(char.ToLower(item));
            }
        }

        return sb.ToString();
    }
    public int solution0814(int a, int b, bool flag)
    {
        int answer = 0;

        // if (flag)
        // {
        //     answer = a + b;
        // }
        // else
        // {
        //     answer = a - b;
        // }
        // return answer;

        answer = flag ? a + b : a - b;

        return answer;
    }

    public string solution08132(string cipher, int code)
    {

        var sb = new StringBuilder();



        for (int i = code - 1; i < cipher.Length; i += code)
        {
            sb.Append(cipher[i]);
        }

        return sb.ToString();

        /*
        string answer = "";
        int index = 0;
        foreach (var item in cipher)
        {
            if (index % code == code - 1)
            {
                answer += item.ToString();
            }
            index++;
        }

        return answer;
        */
    }
    public int[] solution0813(int[] num_list, int n)
    {
        int len = num_list.Length - (n - 1);
        int[] answer = new int[len];

        // for (int i = 0; i < len; i++)
        // {
        //     answer[i] = num_list[n-1];
        //     n++;
        // }

        for (int i = n - 1, j = 0; i < num_list.Length; i++, j++)
        {
            answer[j] = num_list[i];
        }


        return answer;
    }

    /// <summary>
    /// 홀짝구분하기
    /// </summary>
    public void solution08122()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);

        const string str = "{0} is {1}";
        const string strEven = "even";
        const string strOdd = "odd";
        string strVal = (a % 2 == 0) ? strEven : strOdd;
        Console.WriteLine(str, a, strVal);

        // if (a % 2 == 0)
        // {
        //     Console.WriteLine($"{a} is even");
        // }

        // else
        // {
        //     Console.WriteLine($"{a} is odd");
        // }

    }
    public string solution0812(string my_string, int k)
    {
        //string answer = "";
        var sb = new StringBuilder();


        for (int i = 0; i < k; i++)
        {
            //answer += my_string;
            sb.Append(my_string);
        }

        return sb.ToString();
    }
    public int solution08112(int[] numbers)
    {
        //int answer = 0;

        // for (int i = 0; i < numbers.Length - 1; i++)
        // {
        //     for (int j = i + 1; j < numbers.Length; j++)
        //     {
        //         int max = numbers[i] * numbers[j];
        //         if (answer < max)
        //         {
        //             answer = max;
        //         }
        //     }
        // }

        Array.Sort(numbers); // 오름차순 정렬

        int maxProduct = numbers[numbers.Length - 1] * numbers[numbers.Length - 2]; // 가장 큰 두 수
        int minProduct = numbers[0] * numbers[1]; // 가장 작은 두 수 (음수일 수 있음)

        return Math.Max(maxProduct, minProduct); // 둘 중 더 큰 값 반환
    }
    public int solution0811(string my_string)
    {
        int answer = 0;

        foreach (var item in my_string)
        {
            // if (item >= '1' && item <= '9')
            // {
            //     answer += (item - '0');
            // }
            if (int.TryParse(item.ToString(),out var value))
            {
                answer += value;
            }
        }
        return answer;
    }

    public int[] solution08082(string my_string)
    {

        var list = new List<int>();

        foreach (var item in my_string)
        {
            // if ((item >= '0') && (item <= '9'))
            // {
            //     list.Add(item - '0');
            // }

            if (int.TryParse(item.ToString(), out var value))
            {
                list.Add(value);
            }
        }

        list.Sort();

        return list.ToArray();
    }
    public int solution0808(int[] box, int n)
    {
        int answer = 0;

        answer = (box[0] / n) * (box[1] / n); //* (box[2] / n);


        return answer;
    }
    public string Solution08072(string rsp)
    {
        // for (int i = 0; i < rsp.Length; i++)
        // {
        //     if (rsp[i] == '0')
        //     {
        //         answer += "5";
        //     }
        //     else if (rsp[i] == '2')
        //     {
        //         answer += "0";
        //     }
        //     else if (rsp[i] == '5')
        //     {
        //         answer += "2";
        //     }
        // }

        const char rsp_rock = '0';
        const char rsp_scissors = '2';
        const char rsp_paper = '5';



        var sb = new StringBuilder();

        foreach (var item in rsp)
        {
            if (string.Equals(item, rsp_rock))
            {
                sb.Append(rsp_paper);
            }
            else if (item == rsp_scissors)
            {
                sb.Append(rsp_rock);
            }
            else if (item == rsp_paper)
            {
                sb.Append(rsp_scissors);
            }
            else
            {
                Console.WriteLine("잘못입력됨");
            }
        }



        return sb.ToString();
    }
    /// <summary>
    /// 공배수
    /// </summary>
    /// <param name="number"></param>
    /// <param name="n"></param>
    /// <param name="m"></param>
    /// <returns></returns>
    public int Solution0807(int number, int n, int m)
    {
        int answer = 0;

        // if (number % n == 0 && number % m == 0)
        // {
        //     answer = 1;
        // }
        // else
        // {
        //     answer = 0;
        // }

        answer = ((number % n == 0) && (number % m == 0)) ? 1 : 0;

        return answer;
    }
    public int Solution08062(int hp)
    {
        int answer = 0;
        int a = 5; //장군개미 공격력
        int b = 3; //병정개미 공격력
        //int c = 1; //일개미 공격력

        int aCount = hp / a;
        hp = hp % a;

        int bCount = hp / b;
        hp = hp % b;

        //int cCount = hp / c;

        answer = aCount + bCount + hp;
        Console.WriteLine($"장군개미: {aCount}마리, 병정개미: {bCount}마리, 일개미: {hp}마리");

        return answer;
    }

    public void Solution0806()
    {
        string[] s;
        Console.Clear();
        s = Console.ReadLine().Split(' ');
        int n = Int32.Parse(s[0]);
        int n2 = Convert.ToInt32(s[0]);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
        }

    }
    public string Solution0802(string my_string, int n)
    {
        /*
        var list = new List<char>();
        
        for (int i = 0; i < n; i++)
        {
            list.Add(my_string[i]);
        }

        string answer = new string (list.ToArray());

        return answer;
        */

        /*
        string answer = "";
        var sb = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            //answer += my_string[i];
            sb.Append(my_string[i]);
        }
        //return answer;
        return sb.ToString();
        */

        return my_string.Substring(0, n);
    }
    public int Solution0805(int num, int n)
    {
        /*
        if (num % n == 0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
        */

        int answer = (num % n == 0) ? 1 : 0;

        return answer;
    }
    public int soulution08042(int price)
    {

        if (price >= 500000)
        {
            price *= (int)(price * 0.8);
        }
        else if (price >= 300000)
        {
            price *= (int)(price * 0.9);
        }
        else if (price >= 100000)
        {
            price *= (int)(price * 0.95);
        }

        return price;
    }
    public int[] soulution0804(int n)
    {

        var list = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 1)
            {
                list.Add(i);
            }
        }


        int[] answer = list.ToArray();


        return answer;
    }
    public int solution08012(int[] array)
    {
        var list = new List<int>(array);

        list.Sort();

        int index = list.Count / 2;
        //int index = array.Length / 2;

        return list[index];
    }
    /// <summary>
    /// 배열 두배 만들기
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public int[] solution0801(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            //numbers[i] = numbers[i] * 2;
            numbers[i] *= 2;

            //numbers[i] <<= 1;
        }

        return numbers;
    }
    public int solution07312(int[] array, int n)
    {
        int answer = 0;

        foreach (var item in array)
        {
            if (item == n)
            {
                answer++;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == n)
            {
                answer++;
            }
        }



        return answer;
    }

    /// <summary>
    /// 문자열 붙여서 출력하기
    /// </summary>
    public void Soulution0731()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' '); //split - 분리 

        // String s1 = input[0];
        // String s2 = input[1];
        // string sum = s1 + s2;
        // sum = sum.Trim();

        //Console.WriteLine($"{sum}");
        

        for (int i = 0; i < input.Length; i++)
        {
            Console.Write($"{input[i]}");
        }

    }
    public int solution07302(int n)
    {
        /*
        int answer = 0, min = 1, max = 1000;
        
        for (int i = min; i <= max; i++)
        {
            if (i * i == n)
            {
                answer = 1;
                break;
            }
            answer = 2;
            
        }
        
        return answer;
        */
        double answer = Math.Sqrt(n);
        if (answer % 1 == 0)
        {
            return 1;
        }
        else
            return 2;


    }
    public string solution0730(string[] arr)
    {
        string answer = "";

        // foreach (var item in arr)
        // {
        //     answer += item;
        // }


        var sb = new StringBuilder();

        foreach (var item in arr)
        {
            sb.Append(item);
        }

        answer = sb.ToString();

        return answer;
    }

    public string solution07292(string my_string, int n)
    {
        string answer = string.Empty;

        foreach (var item in my_string)
        {
            for (int i = 0; i < n; i++)
            {
                answer += item;
            }
        }
        return answer;
    }

    public int solution0729(string str1, string str2)
    {
        int answer = 0;
        if (str1.Contains(str2))
        {
            answer = 1;
        }
        else
        {
            answer = 2;
        }

        int answer2 = (str1.Contains(str2) ? 1 : 2);

        return answer2;
    }
    public int[] solution07282(string[] strlist)
    {
        int len = strlist.Length;
        int[] answer = new int[len];

        for (int i = 0; i < len; i++)
        {
            answer[i] = strlist[i].Length;
        }

        return answer;

        /*
        var answer = new List<int>();

        foreach (var item in strlist)
        {
            answer.Add(item.Length);
        }

        return answer.ToArray();
        */
    }

    public int[] solution0728(int money)
    {
        /*
        int[] answer = new int[2] ;
        answer[0] = money / 5500;

        answer[1] = money % 5500;

        return answer;
        */

        return new int[] { money / 5500, money % 5500 };
    }
    public int[] solution07252(int n, int[] numlist)
    {
        var answer = new List<int>();

        for (int i = 0; i < numlist.Length; i++)
        {
            if (numlist[i] % n == 0)
            {
                answer.Add(numlist[i]);
            }
        }
        int[] myArray = answer.ToArray();


        return myArray;
    }
    public int solution0725(int n)
    {
        int answer = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                answer++;
            }
        }

        return answer;
    }
    public int solution07242(string[] s1, string[] s2)
    {
        int answer = 0;

        foreach (var item in s1)
        {
            foreach (var item2 in s2)
            {
                if (item.Equals(item2))
                {
                    answer++;
                }
                /*if (item == item2)
                {
                    answer++;
                }
                */
            }
        }

        return answer;
    }
    public int solution0724(int[] dot)
    {

        int answer = 0;

        if (dot[0] > 0)
        {
            if (dot[1] > 0)
            {
                return 1;
            }
            else if (dot[1] < 0)
            {
                return 4;
            }
        }

        else if (dot[0] < 0)
        {
            if (dot[1] > 0)
            {
                return 2;
            }
            else if (dot[1] < 0)
            {
                return 3;
            }
        }


        // int answer = (dot[0] > 0) ? (dot[1] > 0) ? 1 :4 :(dot[1]>0 )? 2:3;


        return answer;
    }
    public int solution0723(int slice, int n)
    {
        //int answer = 0;

        int answer = (n % slice > 0) ? n / slice + 1 : n / slice;
        // answer = n / slice;

        // if (n % slice != 0)
        // {
        //     answer++;
        // }

        /*
        for (int i = 1; i <= n; i += slice)
        {
            answer++;
        }
        */
        return answer;
    }
    public int[] solution0723(int[] numbers, int num1, int num2)
    {
        // 리턴할 배열의 크기를 먼저 구한다
        int len = num2 - num1 + 1;
        // 구한 크기만큼 배열을 선언
        int[] answer = new int[len];

        for (int i = 0; i < len; i++)
        {
            answer[i] = numbers[num1 + i];
        }

        return answer;
    }
    public int solution07222(int[] sides)
    {

        int answer = 0;
        var list = new List<int>(sides);
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