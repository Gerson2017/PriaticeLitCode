
using System;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;

    }

    public static void ReverseTest()
    {
        ListNode node = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
        ListNode resvernode = new Solution().ReverseList(node);
        Console.WriteLine(resvernode.val);
        while (resvernode.next != null)
        {
            Console.WriteLine(resvernode.next.val);
            resvernode = resvernode.next;
        }
    }
}


public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null)
        {
            return null;
        }
        ListNode pre = null;
        ListNode cur = head;
        ListNode next = null;
        while (cur.next != null)
        {
            next = cur.next;
            if (pre != null)
                cur.next = pre;
            else
                cur.next = null;
            pre = cur;
            if (next.next == null)
            {
                next.next = cur;
                cur = next;
                return cur;
            }
            cur = next;
        }
        return cur;
    }
}