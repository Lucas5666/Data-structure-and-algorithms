namespace MaxArray;
class Program
{
    public struct SubArray
    {
        public int startIndex;
        public int endIndex;
        public int total;
    }

    static void Main(string[] args)
    {
        //每一天的股票价格 计算从什么时候买入 什么时候卖出 最划算
        int[] priceArray = {100,113,110,85,105,102,86,63,81,101,94,106,101,79,94,90,97};
        MaxArray1(priceArray);
        //波动数组
        int[] priceFluctuationArray = new int[priceArray.Length - 1];
        for (int i = 1; i < priceArray.Length; i++)
        {
            priceFluctuationArray[i - 1] = priceArray[i] - priceArray[i - 1];
        }
        SubArray subArray = GetMaxSubArray2(0, priceFluctuationArray.Length - 1, priceFluctuationArray);
        Console.WriteLine(subArray.total);
        Console.WriteLine($"{subArray.total},{subArray.startIndex},{subArray.endIndex}");
        Console.WriteLine($"在第{subArray.startIndex - 1}天买入，在{subArray.endIndex + 1} 天卖出");
        Console.ReadKey();
    }
    //暴力求解 列举所有的数组
    public static void MaxArray1(int[] priceArray)
    {
        int[] priceFluctuationArray = new int[priceArray.Length - 1];

        for (int i = 1; i < priceArray.Length; i++)
        {
            priceFluctuationArray[i - 1] = priceArray[i] - priceArray[i - 1];
        }
        foreach (var item in priceFluctuationArray)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("******************");
        //Console.ReadKey();
        int totalMax = 0;
        int startIndex = 0;
        int endIndex = 0;
        for (int i = 0; i < priceFluctuationArray.Length; i++)
        {
            for (int j = 0; j < priceFluctuationArray.Length; j++)
            {
                int total = 0;
                for (int k = i; k <= j; k++)
                {

                    total += priceFluctuationArray[k];
                    Console.WriteLine(total);
                    if (total > totalMax)
                    {
                        totalMax = total;
                        startIndex = i;
                        endIndex = j;
                    }
                }
            }
        }
        Console.WriteLine("******************");
        Console.WriteLine(totalMax);
        Console.WriteLine(startIndex);
        Console.WriteLine(endIndex);
        Console.WriteLine($"买入的时间是第{startIndex - 1}天,卖出的时间是第{endIndex + 1}天");
        Console.ReadKey();
    }
    //分治算法
    public static SubArray GetMaxSubArray2(int low, int high, int[] array)
    {
        if(low == high)
        {
            SubArray subArray;
            subArray.startIndex = low;
            subArray.endIndex = high;
            subArray.total = array[low];
            return subArray;
        }
        int mid = (low + high) / 2;
        SubArray subArray1 = GetMaxSubArray2(low, mid, array);
        SubArray subArray2 = GetMaxSubArray2(mid + 1, high, array);
        int total = array[mid];
        int totalTemp= 0;
        int startIndex = mid;
        //从low和mid中找到最大子数组
        for(int i = mid;i >= low; i--)
        {
            totalTemp += array[i];
            if(totalTemp > total)
            {
                total = totalTemp;
                startIndex = i;
            }
        }
        int total2 = array[mid + 1];
        int totalTemp2 = 0;
        int endIndex = mid + 1;
        for (int j = mid + 1; j <= high; j++)
        {
            totalTemp2 += array[j];
            if (totalTemp2 > total2)
            {
                total2 = totalTemp2;
                endIndex = j;
            }
        }
        SubArray subArray3;
        subArray3.startIndex = startIndex;
        subArray3.endIndex = endIndex;
        subArray3.total = total + total2;

        if(subArray1.total >= subArray2.total && subArray1.total >= subArray3.total)
        {
            return subArray1;
        }
        else if(subArray2.total >= subArray1.total && subArray2.total >= subArray3.total)
        {
            return subArray2;
        }
        else
        {
            return subArray3;
        }
    }

}

