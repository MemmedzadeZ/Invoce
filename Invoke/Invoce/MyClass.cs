namespace Invoce;

#nullable disable 


delegate void Func(string param);

class MyClass
{

    public string CinString;


    public MyClass(string str)
    {
        CinString = str;
    }


    public void Space(string str)
    {
        Console.WriteLine(string.Join("_", str));
    }

    public void Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(new string(charArray));
    }


    public void invoPerOperation(Func func)
    {
        func(CinString);
    }
}
