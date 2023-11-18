namespace 钢条切割问题_递归实现;
class Program
{
    static void Main(string[] args)
    {
        //int n = 5;//我们要切割的钢条长度
        //int[] p = { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };//索引代表钢条长度，值代表相应长度的价格
        //Console.WriteLine(UpToDown(0,p));
        //Console.WriteLine(UpToDown(1, p));
        //Console.WriteLine(UpToDown(2, p));
        //Console.WriteLine(UpToDown(3, p));
        //Console.WriteLine(UpToDown(4, p));
        //Console.WriteLine(UpToDown(5, p));
        //Console.WriteLine(UpToDown(6, p));
        //Console.WriteLine(UpToDown(7, p));
        //Console.WriteLine(UpToDown(8, p));

        ////UpToDownWithMemo
        //int[] p = { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };//索引代表钢条长度，值代表相应长度的价格
        //int[] result = new int[11];
        //Console.WriteLine(UpToDownWithMemo(0, p,result));
        //Console.WriteLine(UpToDownWithMemo(1, p, result));
        //Console.WriteLine(UpToDownWithMemo(2, p, result));
        //Console.WriteLine(UpToDownWithMemo(3, p, result));
        //Console.WriteLine(UpToDownWithMemo(4, p, result));
        //Console.WriteLine(UpToDownWithMemo(5, p, result));
        //Console.WriteLine(UpToDownWithMemo(6, p, result));
        //Console.WriteLine(UpToDownWithMemo(7, p, result));
        //Console.WriteLine(UpToDownWithMemo(8, p, result));
        //Console.WriteLine(UpToDownWithMemo(9, p, result));
        //Console.WriteLine(UpToDownWithMemo(10, p, result));

        //UpToDownWithMemo
        int[] p = { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };//索引代表钢条长度，值代表相应长度的价格
        int[] result = new int[11];
        Console.WriteLine(BottomToUp(0, p, result));
        Console.WriteLine(BottomToUp(1, p, result));
        Console.WriteLine(BottomToUp(2, p, result));
        Console.WriteLine(BottomToUp(3, p, result));
        Console.WriteLine(BottomToUp(4, p, result));
        Console.WriteLine(BottomToUp(5, p, result));
        Console.WriteLine(BottomToUp(6, p, result));
        Console.WriteLine(BottomToUp(7, p, result));
        Console.WriteLine(BottomToUp(8, p, result));
        Console.WriteLine(BottomToUp(9, p, result));
        Console.WriteLine(BottomToUp(10, p, result));



        Console.ReadKey();


    }

    public static int UpToDown(int n, int[] p)//求长度为n的最大收益
    {
        if (n == 0) return 0;
        int tempMaxPrice = 0;
        for (int i = 1; i < n + 1; i++)
        {
            int maxPrice = p[i] + UpToDown(n - i, p);
            if (maxPrice > tempMaxPrice)
                tempMaxPrice = maxPrice;
        }
        return tempMaxPrice;
    }

    public static int UpToDownWithMemo(int n, int[] p, int[] result) //求长度为n的最大收益
    {
        if (result[n] != 0) return result[n];
        if (n == 0) return 0;
        int tempMaxPrice = 0;
        for (int i = 1; i < n + 1; i++)
        {
            int maxPrice = p[i] + UpToDownWithMemo(n - i, p,result);
            if (maxPrice > tempMaxPrice)
                tempMaxPrice = maxPrice;
        }
        result[n] = tempMaxPrice;

        return tempMaxPrice;
    }

    public static int BottomToUp(int n,int[] p, int[] result)
    {
        
        for (int i = 1; i < n +1; i++)
        {
            int tempMaxPrice = -1;
            for (int j = 1; j <= i; j++)
            {
                int maxPrice = p[j] + result[i - j];
                if (maxPrice > tempMaxPrice)
                    tempMaxPrice = maxPrice;
            }
            result[i] = tempMaxPrice;
        }
        return result[n];

    }
}

