using System;
using System.Reflection;

namespace BinaryTree_SequentialStorage
{
	//如果节点为空 数据设置为-1
	public class BinaryTree<T>
	{
		private T[] data;
		private int count = 0;

        //capacity二叉树的容量 count表示保存的数据量
        public BinaryTree(int capacity)
		{
			data = new T[capacity];
		}

		public bool Add(T item)
		{
			if (count >= data.Length)
				return false;
			data[count] = item;
			count++;
			return true;
        }

		public void FirstTraversal()
		{
			FirstTraversal(0);
        }

        private void FirstTraversal(int index)
		{
			if (index >= count)
				return;
            //得到要遍历的编号
            int number = index + 1;
			if (data[index].Equals(-1))
				return;
			Console.WriteLine(data[index]);
			//得到左边的子节点的编号
			int left = number * 2;
			int right = number * 2 + 1;
			FirstTraversal(left - 1);
			FirstTraversal(right - 1);


        }
		public void MiddleTraversal()
		{
			MiddleTraversal(0);

        }
        private void MiddleTraversal(int index)
		{
            if (index >= count)
                return;
            //得到要遍历的编号
            int number = index + 1;
            if (data[index].Equals(-1))
                return;
            //得到左边的子节点的编号
            int left = number * 2;
            int right = number * 2 + 1;
            MiddleTraversal(left - 1);
            Console.WriteLine(data[index]);
            MiddleTraversal(right - 1);
        }
        public void LastTraversal()
        {
            LastTraversal(0);

        }
        private void LastTraversal(int index)
        {
            if (index >= count)
                return;
            //得到要遍历的编号
            int number = index + 1;
            if (data[index].Equals(-1))
                return;
            //得到左边的子节点的编号
            int left = number * 2;
            int right = number * 2 + 1;
            LastTraversal(left - 1);
            LastTraversal(right - 1);
            Console.WriteLine(data[index]);
        }
        public void LayerTraversal()
        {
            for(int i = 0;i < count; i++)
            {
                if (data[i].Equals(-1))
                {
                    continue;
                }

                Console.WriteLine(data[i]);
            }
        }
    }
}

