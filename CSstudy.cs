using System.Collections;

class CSstudy
{

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