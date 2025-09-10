//#define Test_ENV
//#define PROD_ENV
using System.Collections;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Text;
using Ohoh;
using MyExtension; //Extension 불러오기
//Forms를 사용하려면 csproj 파일에  <itemgroup> 추가 필요
using System.Windows.Forms;
using System.Text.RegularExpressions;

class CSstudy
{
    public string Name
    {
        get
        {
            return Name;
        }
        set
        {
            Name = value;
        }        
    }
    class Person
    {
        public string Name { get; set; } = "(NO Name)";
        public string Nickname { get; }
        public int Age { get; }
        public bool Enabled { get; } = true;
        public int Level { get; }
        public Person()
        {
            this.Level = 1;
        }
    }
    public void AutoProperty()
    {
        Person p = new Person();
        Console.WriteLine(p.Name);
        Console.WriteLine(p.Nickname);
        Console.WriteLine(p.Age);
       // p.Age = 10;
      
    }

    

    /// <summary>
    /// Regex에 대해
    /// </summary>
    public void RegexSample()
    {
        // Ex1. 첫 매치 문자열 출력
        string str = "서울시 강남구 역삼동 강남아파트";
        Regex regex = new Regex("강남");
        //Match m = regex.Match(str);
        MatchCollection mc = regex.Matches(str);

        // if (m.Success)
        // {
        //     Console.WriteLine($"{m.Index}:{m.Value}");
        // }

        // while (m.Success)
        // {
        //     Console.WriteLine($"{m.Index}:{m.Value}");
        //     m = m.NextMatch();
        // }

        foreach (Match m in mc)
        {
            Console.WriteLine($"{m.Index}:{m.Value}");
        }

        string name = "김공돌";
        regex = new Regex(@"^[가-힣]{3}");
        if (regex.IsMatch(name))
        {
            Console.WriteLine("Match");
        }
        else
        {
            Console.WriteLine("MissMatch");
        }
    }

    /// <summary>
    /// Partial 사용
    /// </summary>
    public void PartialTest()
    {
        class1 c1 = new class1();
        c1.Get();
        c1.Put();
        c1.Run();

        Struct1 s1 = new Struct1(123, "KIM");
        Console.WriteLine($"{s1.ID}, {s1.Name}");
    }
    /// <summary>
    /// Extension 불러오기
    /// </summary>
    public void ExtensionTest()
    {
        string s = "This is a Test";
        string s2 = s.ToChangeCase();
        bool found = s.Found('z');
        Console.WriteLine($"{s2} , found: {found}");
    }
    public void AnoTypeTest()
    {
        var v = new[] {
            new{Name = "Lee", Age = 33, Phone = "01-111-1111"},
            new{Name = "Kime", Age = 25, Phone = "02-222-2222"},
            new{Name = "Park", Age = 37, Phone = "02-333-3333" }
        };
        var list = v.Where(p => p.Age >= 30)
            .Select(p => new { p.Name, p.Age });

        foreach (var item in list)
        {
            Debug.WriteLine($"{item.Name} {item.Age}");
        }
    }

    class MyArea : Form
    {
        public MyArea()  // using System.Windows.Forms; 필요
        {
            //this.MouseClick += delegate { MyAreaClicked(); };
            MouseClick += (s, e) => MyAreaClicked();
        }

        public delegate void ClickDelegate(object sender);
        
        //event 필드 
        public event ClickDelegate MyClick;

        void MyAreaClicked()
        {
            if (MyClick != null)
            {
                MyClick(this);
            }
        }
    }

    MyArea area;

    public void TestMyArea()
    {
        area = new MyArea();
        
        area.MyClick += Area_Click;
        area.MyClick += AfterClick;
        area.MyClick -= Area_Click;

        // event 일때 사용 불가
        //area.MyClick(null);
        //area.MyClick = Area_Click;

        area.Click += (s, a) => MessageBox.Show("OK");

        area.ShowDialog();
    }
    void Area_Click(object sender)
    {
        area.Text += " MyArea 클릭! ";
    }
    void AfterClick(object sender)
    {
        area.Text += " Afterclick 클릭!";
    }


    public void CompareRun()
    {
        int[] a = { 5, 53, 3, 7, 1 };

        // 올림차순으로 정렬 
        Util.CompareDelegate compDele = Util.AscendingCompare;
        Util.Sort(a, compDele);

        // 내림차순으로 정렬 

        compDele = Util.DescendingCompater;
        Util.Sort(a, compDele);
    }


    // 1. delegate 선언
    delegate void RunDelegate(int i);
    void RunThis(int val)
    {
        Console.WriteLine($"{val}");
    }

    void RunThat(int value)
    {
        Console.WriteLine($"0x{value:X}");
    }
    public void DelePerform()
    {
        // 2. delegate 인스턴스 생성
        //RunDelegate run = new RunDelegate(RunThis);
        RunDelegate run = RunThis;
        // 3. delegate 실행
        run(1024);
        run = new RunDelegate(RunThat);
        run = RunThat;
        run(1024);
    }

    // delegate 정의
    delegate int MyDelegate(string s);
    public void DeleTest()
    {
        // delegate 객체 생성
        MyDelegate m = new MyDelegate(stringToInt);
        // delegate 객체를 메서드로 전달
        DeleRun(m);
    }

    // delegate 대상이 되는 메서드
    int stringToInt(string s)
    {
        return int.Parse(s);
    }

    void DeleRun(MyDelegate m)
    {
        int i = m("123"); // m.invoke("123");
        Console.WriteLine(i);
    }
    class MyStack<T>
    {
        T[] _elements;
        int pos = 0;
        public int Pos
        {
            get { return pos; }
        }
        public MyStack()
        {
            _elements = new T[100];
        }
        public void Push(T element)
        {
            _elements[++pos] = element;
        }
        public T Pop()
        {
            return _elements[pos--];
        }
    }
    public void GenericSample()
    {
        MyStack<int> numberStack = new MyStack<int>();
        //MyStack<string> nameStack = new MyStack<string>();
        var nameStack = new MyStack<string>();
        numberStack.Push(14);
        numberStack.Push(20);
        numberStack.Push(5);
        Console.WriteLine($"pop: {numberStack.Pop()}, pos: {numberStack.Pos}");
        nameStack.Push("thrusday");
        Console.WriteLine(nameStack.Pop());
    }
    public void ClassSample()
    {

        Console.WriteLine("class Test");
        Animal anione = new Animal();
        anione.Name = "cat";
        anione.Age = 5;
        anione.SetGold(1000);
        Console.WriteLine($"Gold: {anione.GetGold()}");
        Dog mydog = new Dog();
        mydog.Name = "puppy";
        mydog.Age = 8;
        mydog.SetWeight(60);
        mydog.HowOld();
        mydog.SetGold(2000);
        Console.WriteLine($"Gold: {mydog.GetGold()}");
        Bird mybird = new Bird();
        mybird.Name = "seossi";
        mybird.Fly();

        // 이건 안됨
        //PureBase pb = new PureBase();

        /*
        DerivedA da = new DerivedA();
        Console.WriteLine(da.GetFirst());
        Console.WriteLine(da.GetNext());
        Console.WriteLine(da.GetEnd());
        */
    }
    public class MyClass
    {
        private const int MAX = 10;
        private string name;

        private int[] data = new int[MAX];

        // indexer
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= MAX)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return data[index];
                }

            }
            set
            {
                if (!(index < 0 || index >= MAX))
                {
                    // 정수배열에 값 저장
                    data[index] = value;
                }
            }
        }

        public void SetData(int index, int value)
        {
            if (index > 0 && index < MAX)
            {
                data[index] = value;
            }
        }
        public int GetData(int index)
        {
            if (index >= 0 && index < MAX)
            {
                return data[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        int id = 0;
        public string Name { get; set; }
        public void Run(int id) { }
        protected void Excute() { }

    }


    #region public methods
    public void Run() { }

    public void Create() { }
    #endregion Public  vethods

    public void PreProTest()
    {
        bool verbose = false;
#if (TEST_ENV)
        Console.WriteLine("Now test env.");
        verbose = true;
#elif(PROD_ENV)
        Console.WriteLine("Now prod env.");
#else
        Console.WriteLine("???");
#endif
        if (verbose)
        {
            Console.WriteLine("Verbose...");
        }
    }


    class MyLesson
    {
        public event EventHandler Run;

        public void RunEvent()
        {
            if (Run != null)
            {
                Run(this, EventArgs.Empty);
            }
        }

    }

    public void EventTest()
    {
        MyLesson lesson = new MyLesson();

        lesson.Run += new EventHandler(Lesson1);
        lesson.Run += new EventHandler(Lesson2);

        lesson.RunEvent();
        lesson.Run -= new EventHandler(Lesson2);
        lesson.RunEvent();
    }
    public void Lesson2(object sender, EventArgs e)
    {
        Console.WriteLine("두번째 레슨");
    }
    public void Lesson1(object sender, EventArgs e)
    {
        Console.WriteLine("첫번째 레슨");
    }

    public void StringTest()
    {
        string s21 = "string ";
        Console.WriteLine(s21.IndexOf('r'));
    }
    public void StandardNumericFormatString()
    {
        Console.WriteLine("C Example {0:C}", 123456f);
        Console.WriteLine("D6 sample {0 : D6}", -1234);
        Console.WriteLine("{0:E2}", -1052.0329112756f);
        Console.WriteLine("{0:F4}", -1234.56f);
        Console.WriteLine("{0:N3}", -1234.56f);
        Console.WriteLine("{0:P1}", -0.39678f);
        Console.WriteLine("{0:X4} {1:4}", 255, -1);
    }

    public void ParamSample()
    {
        //ref.초기화가 필요하다

        Method1(10, 20, "Park");
        int x = 1;
        double y = 1.0;
        double ret = GetData(ref x, ref y);

        //ret = Calc(100, 20, "-");
        //ret = Calc(b: 4, a: 3, calcType: "*");

        Console.WriteLine($"x={x}, y = {y}, ret = {ret}");
        Console.WriteLine("x = {0}, y = {1:0.0}, ret={2:0.0}", x, y, ret);


        int c, d;
        bool bret = GetData(10000, 2000, out c, out d);
        Console.WriteLine($"c={c:#,#}: d = {d:#,#}: bret = {bret}");
        Console.WriteLine("c = {0: #,#}: d= {1:#,#}:bret = {2}", c, d, bret);
    }
    public int Calc2(params int[] values)
    {
        return 0;
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

    public void Method3(int age = 10, int score = 0, bool live = true)
    {

    }
    public void Method2(int age, int score = 100, int city = 11)
    {

    }

    public void Method1(int age, int score, string name = "Name")
    {

    }

    public double GetData(ref int a, ref double b)
    {
        return ++a * ++b;
    }

    public bool GetData(int a, int b, out int c, out int d)
    {
        c = a + b;
        d = a - b;
        return true;
    }



    void NullableTest()
    {
        int? a = null;
        int? b = 0;
        int result = Nullable.Compare<int>(a, b);
        Console.WriteLine(result); //결과 -1

        double? c = 0.01;
        double? d = 0.0100;
        bool result2 = Nullable.Equals<double>(c, d);
        Console.WriteLine(result2); //결과 true
    }



    double _Sum = 0;
    DateTime _Time;
    bool? _Selected;

    public void CheckInput(int? i, double? d, DateTime? time, bool? selected)
    {
        if (i.HasValue && d.HasValue)
            this._Sum = (double)i.Value + (double)d.Value;

        // time값이 있는 체크.
        if (!time.HasValue)
            throw new ArgumentException();
        else
            this._Time = time.Value;

        // 만약 selected가 NULL이면 false를 할당
        this._Selected = selected ?? false;
    }

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
    public static int GetId2() { return 0; }

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
        if ((b & Border.Top) != 0)
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