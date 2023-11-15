using System;
using System.Xml.Linq;

namespace Binary_SortTree_LinkedStorage
{
	public class BSTree
	{
        BSNode root = null;

		//添加数据
		public void Add(int item)
		{
			BSNode newNode = new BSNode(item);
			if (root == null)
			{
                root = newNode;
            }
            else
			{
				BSNode temp = root;
				while (true)
				{
                    if (item >= temp.Data)
                    {
                        if (temp.Rightchild == null)
                        {
                            temp.Rightchild = newNode;
                            newNode.Parent = temp;
                            break;
                        }
                        else
                        {
                            temp = temp.Rightchild;
                        }
                    }
                    else
                    {
                        if (temp.Leftchild == null)
                        {
                            temp.Leftchild = newNode;
                            newNode.Parent = temp;
                            break;
                        }
                        else
                        {
                            temp = temp.Leftchild;

                        }
                    }
                }
				
			}


		}

        public void MidTraversal()
        {
            MidTraversal(root);
        }
        private void MidTraversal(BSNode node)
        {
            if (node == null) return;
            MidTraversal(node.Leftchild);
            Console.Write(node.Data + " ");
            MidTraversal(node.Rightchild);
        }

        public bool Find(int item)
        {
            //return Find(item,root);

            BSNode temp = root;
            while (true)
            {
                if (temp == null) return false;
                if (item == temp.Data) return true;
                if(item > temp.Data)
                {
                    temp = temp.Rightchild;
                }
                if (item < temp.Data)
                {
                    temp = temp.Leftchild;
                }
            }
        }
        private bool Find(int item,BSNode node)
        {
            if (node == null) return false;
            if(node.Data == item)
            {
                return true;
            }
            else
            {
                //if(Find(item, node.Leftchild))
                //{
                //    return true;
                //}
                //if(Find(item, node.Rightchild))
                //{
                //    return true;
                //}

                if(item > node.Data)
                {
                    return Find(item, node.Rightchild);
                }
                else
                {
                    return Find(item, node.Leftchild);
                }

            }
            //return false;
        }

        public bool Delete(int item)
        {
            BSNode temp = root;
            while (true)
            {
                if (temp == null) return false;
                if (item == temp.Data)
                {
                    Delete(temp);
                    return true;
                }
                if (item > temp.Data)
                {
                    temp = temp.Rightchild;
                }
                if (item < temp.Data)
                {
                    temp = temp.Leftchild;
                }
            }

        }
        public void Delete(BSNode node)
        {
            if(node.Leftchild == null && node.Rightchild == null)
            {
                if (node.Parent == null)
                    root = null;
                else if (node.Parent.Data > node.Data)
                    node.Parent.Leftchild = null;
                else if (node.Parent.Data < node.Data)
                    node.Parent.Rightchild = null;
                return;
            }
            if (node.Leftchild == null && node.Rightchild != null)
            {
                node.Data = node.Rightchild.Data;
                node.Rightchild = null;
                return;
            }
            if (node.Leftchild != null && node.Rightchild == null)
            {
                node.Data = node.Leftchild.Data;
                node.Leftchild = null;
                return;
            }

            BSNode temp = node.Rightchild;
            while (true)
            {
                if (temp.Leftchild != null)
                    temp = temp.Leftchild;
                else
                    break;
            }
            node.Data = temp.Data;
            Delete(temp);

        }
    }
}

