namespace LeetCodeExercise;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine(ClimbStairsProblem.ClimbStairs(1));
        //Console.WriteLine(ClimbStairsProblem.ClimbStairs(2));
        //Console.WriteLine(ClimbStairsProblem.ClimbStairs(3));
        //Console.WriteLine(ClimbStairsProblem.ClimbStairs(6));

        //Console.WriteLine(杨辉三角_1.Generate(5));
        //var a = 杨辉三角_1.Generate(5);
        //foreach (var item in a)
        //{
        //    foreach (var b in item)
        //    {
        //        Console.WriteLine(b);
        //    }
        //}

        var c = 杨辉三角_2.GetRow(3);
        foreach (var item in c)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();

    }
}

