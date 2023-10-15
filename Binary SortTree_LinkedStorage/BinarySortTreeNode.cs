using System;
namespace Binary_SortTree_LinkedStorage
{
	public class BinarySortTreeNode
	{
		public BinarySortTreeNode leftchild { get; set; }
        public BinarySortTreeNode rightchild { get; set; }
        public BinarySortTreeNode parent { get; set; }
        public int data { get; private set; }
        public BinarySortTreeNode()
        {

        }
        public BinarySortTreeNode(int item)
        {
            this.data = item;
        }
    }
}

