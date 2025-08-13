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