using System.Collections;
using System.Text;

class CSstudy
{

    public void Mtext()
    {
        MyCustomer mc = new MyCustomer();
        mc.Name = "Kim";
        mc.Age = 20;
        //mc.SetAge(-23);
        
        Console.WriteLine(mc.GetcustomerData());
        Console.WriteLine(mc.CalAge(30));
    }
    // 구조체 정의
    public struct MyPoint
    {
        public int X;
        public int Y;
        public MyPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y);
        }
    }


    public void StructTest()
    {
        var pt = new CSstudy.MyPoint(10, 12);
        var pt2 = new CSstudy.MyPoint();
        Console.WriteLine(pt.ToString());
        Console.WriteLine(pt2.ToString());
    }
    public void ExceptionSample()
    {
        int[] intArr = new int[3];
        try
        {
            intArr[123] = 0;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"AE....");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"ior 오류 발생");
        }
        finally
        {
            Console.WriteLine("에러 없음");
        }
    }

    string GetName() { return ""; }
    static public int GetId() { return 0; }
    public static int GetId2(){ return 0; }

     [Flags]
    enum Border
    {
        None = 0,
        Top = 1,
        Right = 2,
        Bottom = 4,
        Left = 8
    }

    enum City
    {
        Seoul,
        Daejun,
        Busan = 5,
        Jeju = 10
    }
    public enum GameState { Ready, Run }
    public enum Category
    {
        Cake,
        IceCream,
        Bread
    }
    public void EnumSample()
    {
        Category category;
        category = Category.Bread;

        City myCity = City.Seoul;

        int cityValue = (int)myCity;
        // if (myCity == City.Seoul)
        // {
        //     Console.WriteLine("hihi");
        // }

        // OR 연산자로 다중 플래그 할당
        Border b = Border.Top | Border.Bottom;
        
        // & 연산자로 플래그 체크 
        if  ((b & Border.Top) != 0)
        {
            // hasFlag()이용 플래그 체크
            if (b.HasFlag(Border.Bottom))
            {
                // "Top, Bottom" 출력
                Console.WriteLine(b.ToString());
            }
        }
    }
    public void SbSample()
    {
        var sb = new StringBuilder();
        for (int i = 1; i <= 26; i++)
        {
            sb.Append(i.ToString());
            sb.Append(System.Environment.NewLine);
        }
        string s = sb.ToString();

        Console.WriteLine(s);

        sb.Clear();

        sb.Append((char)'A' + 3);
        Console.WriteLine(sb.ToString());
    }
    public void ASCIISample()
    {
        string s = "C# studies";

        for (int i = 0; i < s.Length; i++)
        {
            //Console.WriteLine($"{i} : {s[i]}");
        }

        string str = "Hello";
        char[] charArray = str.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            //Console.WriteLine($"{i}: {charArray[i]}");
        }

        char[] charArray2 = { 'A', 'B', 'C', 'D' };
        string s2 = new string(charArray2);
        //Console.WriteLine(s2);

        //문자연산
        char c1 = 'A';
        char c2 = (char)(c1 + 3);
        Console.WriteLine(c2);

    }
    public void StringSample()
    {
        string s1 = "C#";
        string s2 = "Programming";

        int len = s2.Length - 3;
        string s3 = s2.Substring(3, len);
        Console.WriteLine(s3);
    }
    public void Arraysample()
    {
        // 1차 배열
        string[] players = new string[10];
        string[] Regions = { "서울", "경기", "부산" };

        // 2차 배열 선언 및 초기화
        string[,] Depts = { { "김과장", "경리부" }, { "이과장", "총무부" } };


        // 3차 배열 선언
        string[,,] Cubes;

        int[,] aa = new int[3, 3];
        int[][] A = new int[3][];

        A[0] = new int[2];
        A[1] = new int[3] { 1, 2, 3 };
        A[2] = new int[4] { 1, 2, 3, 4 };
        A[0][0] = 1;
        A[0][1] = 2;
        aa[0, 0] = 1;
        aa[0, 1] = 2;

        int sum = 0;
        int[] scores = { 80, 78, 60, 90, 100 };
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }
        Console.WriteLine($"sum = {sum}");


    }

    public void SortedDicSample()
    {
        var tmap = new SortedDictionary<int, string>();
        tmap.Add(1001, "Tom");
        tmap.Add(1003, "John");
        tmap.Add(1010, "Irina");
        tmap.Add(1005, "Lee");
        string name1010 = tmap[1010];

        //Iterator 사용
        foreach (KeyValuePair<int, string> kv in tmap)
        {
            Console.WriteLine("{0} : {1}", kv.Key, kv.Value);
        }

        foreach (var item in tmap)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
    public void hashTableSample()
    {
        Hashtable ht = new Hashtable();
        ht.Add("irina", "Irina SP");
        ht.Add("tom", "TomCr");

        if (ht.Contains("tom"))
        {
            Console.WriteLine(ht["tom"]);
        }

        // Dictionary<int, string> emp = new Dictionary<int, string>();
        var emp = new Dictionary<int, string>();    //  <<간편하게 var를 써서 짧게사용가능
        emp.Add(1001, "jane");
        emp.Add(1002, "Tom");
        emp.Add(1003, "cindy");

        if (emp.ContainsKey(1002) == false) // 1002번이 추가가 안되면 처리
        {
            emp.Add(1002, "Kim");
        }

        string name = emp[1002];
        Console.WriteLine(name);

    }
    public void StackQueue()
    {
        //Stack<float> s = new Stack<float>();
        var s = new Stack<float>();
        s.Push(10.5f);
        s.Push(3.54f);
        s.Push(4.22f);

        float pp = s.Peek();
        Console.WriteLine($"pp: {pp}");

        float pp3 = s.Pop();
        Console.WriteLine($"pp3: {pp3}");


        Queue<int> q = new Queue<int>();
        q.Enqueue(120);
        q.Enqueue(130);
        q.Enqueue(150);

        int next = q.Peek();
        Console.WriteLine("next = " + next);



    }

    public void LinkedListSample()
    {
        //LickedList<string> list = new LickedList<string>();
        var list = new LinkedList<string>();

        list.AddLast("Apple");
        list.AddLast("Banana");

        var node = list.Find("Banana");
        var newNode = new LinkedListNode<string>("Grape");

        list.AddAfter(node, newNode);
        list.AddAfter(node, "Kiwi");

        list.ToList<string>().ForEach(p => Console.WriteLine(p));

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

    }


    public void ListSample()
    {
        // List<int> myList = new List<int>();
        var myList = new List<int>();
        myList.Add(90);
        myList.Add(88);
        myList.Add(75);
        int val = myList[1];

        var chrList = new List<char>();
        chrList.Add('b');

        var boolList = new List<bool>();
        boolList.Add(false);

        var iarray = new int[100];
        iarray[2] = 10;
        myList.Add(10);
        Console.WriteLine(iarray.Length);
        Console.WriteLine(myList.Count);
    }
    public void ArrayListSample()
    {
        // ArrayList mtList = new ArrayList();
        var myList = new ArrayList();
        myList.Add(90);
        myList.Add(88);
        myList.Add(75);
        int val = (int)myList[1];
        Console.WriteLine(val);
        Console.WriteLine(myList[0]);

    
    }
    

    public void AraayExample()
    {
        int sum = 0;
        int[] nums = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        nums[0] = 1;
        nums[1] = 2;

        nums[9] = 0;

        // nums[19] = 9;  이건 아노딤

        Random rand = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next() % 100;
        }

        for (int i = 0; i < nums.Length; i++)
        {

            if (i == 9)
            {
                Console.WriteLine($"{nums[i]} ");
            }
            else
            {
                Console.Write($"{nums[i]} + ");
            }
            sum += nums[i];
        }

        Console.WriteLine($"= {sum}");
    }


    public void DataType()
    {
        /*bool b = true;

        short sh = -32768;
        int i = 2147483647;
        long l = 1234L;
        float f = 123.45f;
        double d1 = 1223.45;
        double d2 = 1223.45D;
        decimal d = 123.45M;

        char c = 'A';
        string s = "Hello";
        string s2 = null;
        //int ii = null;

        //Console.WriteLine(f);
        i = (int)f;

        //Console.WriteLine(i);
        //DateTime dt = new DateTime(2025,07,09,11,02);
        */
    }
}