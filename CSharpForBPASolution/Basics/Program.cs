internal class program {
    static void Main(string[] args) {
        int[] test = {1,2,3,4,5};
        for (int i = 0; i<test.Length; i++) {
            Console.WriteLine(Convert.ToString(i) + " " + test[i]);
        }
    }
}