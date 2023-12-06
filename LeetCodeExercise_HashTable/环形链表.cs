using System;
namespace LeetCodeExercise_HashTable
{
     public class ListNode
     {
      public int val;
      public ListNode next;
      public ListNode(int x)
      {
            val = x;
            next = null;
      }
     }
    public class 环形链表
	{
        //给你一个链表的头节点 head ，判断链表中是否有环。
        //如果链表中有某个节点，可以通过连续跟踪 next 指针再次到达，则链表中存在环。 为了表示给定链表中的环，评测系统内部使用整数 pos 来表示链表尾连接到链表中的位置（索引从 0 开始）。注意：pos 不作为参数进行传递 。仅仅是为了标识链表的实际情况。
        //如果链表中存在环 ，则返回 true 。 否则，返回 false 。
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return false;
            HashSet<ListNode> rec = new HashSet<ListNode>();

            while (head.next != null)
            {
                if (!rec.Contains(head.next))
                    rec.Add(head.next);
                else
                    return true;
                head = head.next;
            }

            return false;
        }
    }
}

