class Program
{
    static void Main(string[] args)
    {
        LinkedList<string> myList = new LinkedList<string>();

        myList.AddLast("Geeks");
        myList.AddLast("for");
        myList.AddLast("Data Structures");
        myList.AddLast("Noida");

        if (myList.Count > 0)
            Console.WriteLine("LinkedList is not Empty");
        else
            Console.WriteLine("LinkedList is Empty");
    }
}