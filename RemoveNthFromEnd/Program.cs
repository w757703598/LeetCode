using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNthFromEnd
{
    //给定一个链表，删除链表的倒数第 n 个节点，并且返回链表的头结点。
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(4);
            //head.next.next.next.next = new ListNode(5);
            var temp=RemoveNthFromEnd(head,2);
            Print(temp);
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
        public static int GetLength(ListNode node)
        {
            if (node.next != null)
            {
                return GetLength(node.next)+1;
            }
            else
            {
                return 1;
            }
        }
        public static ListNode RemoveNthFromEnd(ListNode head,int n)
        {
            ListNode  temp = head;
           var num = GetLength(head) - n-1;
            if (num < 0)
            {
                return head.next;
            }
            if (num == 0)
            {
                head.next = head.next.next;
                return head;
            }
            while (num != 0)
            {
                head = head.next;
                num--;
            }
            head.next = head.next.next;
            
            return temp;
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
