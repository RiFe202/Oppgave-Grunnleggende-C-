using System.Reflection.Metadata.Ecma335;

namespace C__oppgave_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int x = 1;
        string hello = "HelloWorld";
        double z = 2.1;
        char h = 'H';
        int[] list = [10, 20, 30];
        for (int i = 0; i < list.Length; i++) {
            Console.WriteLine(list[i]);
        }
        string[] lists = ["hei", "hallo", "halloen"];
        for (int i = 0; i < lists.Length; i++) {
            Console.WriteLine(lists[i]);
        }
        var actuallist = new List<string>();
        actuallist.Add("last");
        actuallist.Add("last2");
        actuallist.Add("last3");
        foreach (var el in actuallist) {
            Console.WriteLine(el);
        }
        var myDictionary = new Dictionary<int, string>();
        myDictionary.Add(1, "lost");
        myDictionary.Add(200, "lost1");
        myDictionary.Add(1000, "lost2");
        var a = myDictionary[1];
        foreach (var el in myDictionary) {
            Console.WriteLine("key:" + el.Key + " value:" + el.Value);
        }
        
        Console.WriteLine("add:" + Add(4,5,60));

        VssCode("Eric");
    }
    public static int Add(int a, int b, int c) {
        return a + b + c;
    }
    public static void VssCode(string name) {
        Console.WriteLine("hello " + name + ", from VssCode");
    }
}
