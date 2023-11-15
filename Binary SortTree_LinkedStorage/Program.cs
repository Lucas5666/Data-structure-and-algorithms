namespace Binary_SortTree_LinkedStorage;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        BSTree tree = new BSTree();
        int[] date = { 62, 58, 88, 47, 73, 99, 35, 51, 93, 37 };
        foreach (int item in date)
        {
            tree.Add(item);
        }
        tree.MidTraversal();
        Console.WriteLine(tree.Find(73));
        Console.WriteLine(tree.Find(9));

        tree.Delete(35);
        tree.MidTraversal();

        tree.Delete(62);
        tree.MidTraversal();

        Console.ReadKey();
    }
}

