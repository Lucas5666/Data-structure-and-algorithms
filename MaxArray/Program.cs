namespace MaxArray;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //每一天的股票价格 计算从什么时候买入 什么时候卖出 最划算
        int[] priceArray = {100,113,110,85,105,102,86,63,81,101,94,106,101,79,94,90,97};
        //每一天的波动价格 从第一天开始算起
        int[] priceFluctuationArray = new int[priceArray.Length - 1];
        for(int i = 1;i < priceArray.Length; i++)
        {
            priceFluctuationArray[i - 1] = priceArray[i] - priceArray[i - 1];
        }
        foreach(var item in priceFluctuationArray)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("******************");
        //Console.ReadKey();
        int totalMax = 0;
        int startIndex = 0;
        int endIndex = 0;
        for (int i = 0;i < priceFluctuationArray.Length; i++)
        {
            for(int j = 0;j < priceFluctuationArray.Length; j++)
            {
                for(int k = i; k <= j; k++)
                {
                    int total = 0;
                    total += priceFluctuationArray[k];
                    Console.WriteLine(total);
                    if(total > totalMax)
                    {
                        totalMax = total;
                        startIndex = i;
                        endIndex = j;
                    }
                }
            }
        }
        Console.WriteLine(totalMax);
        Console.WriteLine(startIndex);
        Console.WriteLine(endIndex);
        Console.ReadKey();
    }
}

