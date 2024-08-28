using System;
namespace LeetCodeTasks
{
	public class LinkedListCycle
	{
		public ListNode HasCycle(ListNode head)
		{
            ListNode slow = head;
            ListNode fast = head;
            bool isCycle = false;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    isCycle = true;
                    break;
                }
            }
            if (isCycle == false)
            {
                return null;
            }

            slow = head;
            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }
            return slow;
        }
	}
}

