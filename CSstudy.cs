using System.Collections;

class CSstudy
{
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