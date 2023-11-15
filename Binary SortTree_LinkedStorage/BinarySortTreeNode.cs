using System;
namespace Binary_SortTree_LinkedStorage
{
	public class BSNode
	{
        public BSNode Leftchild { get; set; }
        public BSNode Rightchild { get; set; } 
        public BSNode Parent { get; set; } 
        public int Data { get;  set; }
        public BSNode()
        {
            

        }
        public BSNode(int item)
        {
            this.Data = item;
        }
    }
}

