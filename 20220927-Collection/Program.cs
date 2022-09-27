class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>();

        for (int j = 5; j < 10; j++) { 
            myList.Add(j * 3);
        }

        foreach (int items in myList)
        {
            Console.WriteLine(items);
        }
    }
}