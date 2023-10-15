namespace BinaryTree_SequentialStorage;
class Program
{
    static void Main(string[] args)
    {
        char[] data = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        BinaryTree<char> tree= new BinaryTree<char>(10);
        for(int i = 0;i < data.Length; i++)
        {
            tree.Add(data[i]);
        }
        tree.FirstTraversal();
        Console.WriteLine("***************");
        tree.MiddleTraversal();
        Console.WriteLine("***************");
        tree.LastTraversal();
        Console.WriteLine("***************");
        tree.LayerTraversal();
        Console.ReadKey();
    }
}
