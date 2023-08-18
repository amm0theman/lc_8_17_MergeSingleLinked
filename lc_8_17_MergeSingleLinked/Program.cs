public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null)
        {
            return null;
        }

        bool endreachedboth = false;

        ListNode finalList = new ListNode();
        ListNode finalListHolder = finalList;

        while (endreachedboth == false)
        {
            //if the value in list 1 is smaller save it
            //otherwise save the value in list 2
            if (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    finalList.val = list1.val;
                    list1 = list1.next;
                }
                else
                {
                    finalList.val = list2.val;
                    list2 = list2.next;
                }
            }

            else if (list1 != null && list2 == null)
            {
                finalList.val = list1.val;
                list1 = list1.next;
            }

            else if (list2 != null && list1 == null)
            {
                finalList.val = list2.val;
                list2 = list2.next;
            }

            if (list1 != null || list2 != null)
            {
                finalList.next = new ListNode();
                finalList = finalList.next;
            }

            if (list1 == null && list2 == null)
            {
                endreachedboth = true;
            }
        }

        return finalListHolder;
    }
}