using System;
using System.Collections.Generic;

namespace PriaticeLitCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListNode.ReverseTest();

            //Console.WriteLine(  Pow.PowNum(2, -11));

            Console.WriteLine(Majority.GetMajorityNum(new List<int>() { 1,2,13,2,3,1,1,3,2,2,4,5,66,3,7,2,1}));
        }
    }
}


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */


