namespace HeapSort;
class Program
{
    static void Main(string[] args)
    {
        int[] data = { 50, 10, 90, 30, 70, 40, 80, 60, 20 };
        HeapSort(data);
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }

    public static void HeapSort(int[]date)
    {
        for(int i = date.Length/2; i>= 1; i--)//遍历所以的非叶节点，把子树变成大顶堆
        {
            HeapAdjust(i, date, date.Length);

        }
        //把i和第一个最大的数交换 i-- 在重新排列成为大顶堆 再次交换 。。。 完成排序
        for (int i = date.Length; i > 1; i--)
        {
            int temp2 = date[0];
            date[0] = date[i - 1];
            date[i - 1] = temp2;

            HeapAdjust(1, date, i - 1);
        }
    }

    public static void HeapAdjust(int numberAdjust, int[] date,int maxNumber)
    {
        int maxNodeNumber = numberAdjust;//最大节点编号
        int tempI = numberAdjust;
        while (true)
        {
            //把i节点变成大顶堆
            int leftChildNumber = tempI * 2;
            int rightChildNumber = tempI * 2 + 1;
            if (leftChildNumber <= maxNumber && date[leftChildNumber - 1] > date[maxNodeNumber - 1])
            {
                maxNodeNumber = leftChildNumber;
            }
            if (rightChildNumber <= maxNumber && date[rightChildNumber - 1] > date[maxNodeNumber - 1])
            {
                maxNodeNumber = rightChildNumber;
            }
            if (maxNodeNumber != tempI)
            {
                int temp = date[tempI - 1];
                date[tempI - 1] = date[maxNodeNumber - 1];
                date[maxNodeNumber - 1] = temp;
                tempI = maxNodeNumber;
            }
            else
            {
                break;
            }
        }
    }
}

