using System.Collections.Generic;

internal class program {
    static void Main(string[] args) {
        List<string> test = new List<string>();
        test.Add("1");
        test.Add("2");
        test.Add("3");
        test.Add("4");
        for (int i=0; i<test.Count; i++) {
            Console.WriteLine(test[i]);
        }
    }
}