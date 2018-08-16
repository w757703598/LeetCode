using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteNode
{
    //请编写一个函数，使其可以删除某个链表中给定的（非末尾）节点，你将只被给定要求被删除的节点。
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ListNode(4);
            head.next = new ListNode(5);
            head.next.next = new ListNode(1);
            head.next.next.next = new ListNode(9);
            DeleteNode(head);
            Print(head);
            Console.ReadKey();

        }
        public static void Print(ListNode node)
        {
            
            Console.WriteLine(node.val);
            if (node.next != null)
            {
                Print(node.next);
            }
        }
        public static void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }

    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

}
