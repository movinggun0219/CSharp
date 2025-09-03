partial class class1
{
    public void Run() {}
}
partial class class1
{
    public void Get(){}
}
partial class class1
{
    public void Put(){}
}

partial struct Struct1
{
    public int ID;
}
partial struct Struct1
{
    public string Name;
    public Struct1(int id, string name)
    {
        this.ID = id;
        this.Name = name;
    }
}

partial interface IDoable
{
    string Name{get; set;}
}
partial interface IDoable
{
    void Do();
}

public class DoClass : IDoable
{
    public string Name {get; set;}
    public void Do()
    {
        
    }
}
class ClimateMonitor
{
    ILogger logger;
    public ClimateMonitor(ILogger inlogger)
    {
        logger = inlogger;
    }

    public void Start()
    {
        while (true)
        {
            Console.Write("온도를 입력해주세요 : ");
            string tem = Console.ReadLine();
            if (tem == "")
                break;

            logger.WriteLog($"현재 온도 : {tem}");
        }
    }
}

interface ILogger       // C#에서는 인터페이스명 첫 글자에 'I'를 붙이는 것이 암묵적인 룰이다.
{
    void WriteLog(string message);
}
public class FileLogger : ILogger
{
    StreamWriter writer;
    public FileLogger(string path)
    {
        writer = File.CreateText(path);
        writer.AutoFlush = true;
    }
    public void WriteLog(string message)
    {
        writer.WriteLine($"{DateTime.Now.ToShortTimeString}{message}");
    }
}
class ConsoleLogger : ILogger
{
    public void WriteLog(string message)
    {
        Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
    }
}
public interface Icomparable
{
    // 멤버 앞에 접근 제한자 사용안함 (인터페이스 멤버는 자동으로 public이기 때문)
    int CompareTo(object obj);

    void Open();
    void Close();
}

public class MyClass2 : Icomparable
{
    public int CompareTo(object obj)
    {
        return 0;
    }

    public void Open()
    {

    }

    public void Close()
    {

    }
}



public class InterfaceSample
{
    public void sample()
    {
        //Icomparable ic = new Icomparable();  // 이건 에러
        Icomparable ic = new MyClass2();
        ic.Open();
        ic.Close();

        MyClass2 mc2 = new MyClass2();
        mc2.Open();
        mc2.Close();
    }
}



// static 클래스 정의
public static class MyUtility
{
    private static int ver;

    // static 생성자
    static MyUtility()
    {
        ver = 1;
    }

    public static string Convert(int i)
    {
        return i.ToString();
    }

    public static int ConvertBack(string s)
    {
        return int.Parse(s);
    }
}


// static 클래스 사용
public class MyClass
{
    private int val = 1;

    // 인스턴스 메서드
    public int InstRun()
    {
        int k = MyClass.Run();
        return val;
    }

    // 정적(Static) 메서드
    public static int Run()
    {
        return 1;
    }
}
       
public class Client
{
    public void Test()
    {
        // 인스턴스 메서드 호출
        MyClass myClass = new MyClass();
        int i = myClass.InstRun();
        Console.WriteLine($"i : {i}");
        // 정적 메서드 호출
        int j = MyClass.Run();
        Console.WriteLine($"j : {j}");
   }
}




// base class

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    protected int Weight{ get; set; }
    private int Gold;
    public void SetGold(int value)
    {
        Gold = value;
    }
    public int GetGold()
    {
        return Gold;
    }
}

public class Dog : Animal
{
    public void SetWeight(int value)
    {
        Weight = value;
    }
    public void HowOld()
    {
        Console.WriteLine($"나이: {this.Age},Weight: {this.Weight}");
    }
}

public class Bird : Animal
{
    public void Fly()
    {
        Console.WriteLine($"{this.Name} is flying");
    }
}

public abstract class PureBase
{
    // abstact 
    public abstract int GetFirst();
    public abstract int GetNext();

    public int GetEnd()
    {
        return 100;
    }
}

public class DerivedA : PureBase
{
    private int no = 1;

    public override int GetFirst()
    {
        return no;
    }
    public override int GetNext()
    {
        return ++no;
    }
}