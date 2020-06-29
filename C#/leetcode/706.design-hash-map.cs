using System.Transactions;
/*
 * @lc app=leetcode id=706 lang=csharp
 *
 * [706] Design HashMap
 */

namespace MyHashMap
{
    // @lc code=start
    public class MyHashMap
    {
        public class ListNode
        {
            public int key, value;
            public ListNode next;
            public ListNode(int key, int value)
            {
                this.key = key;
                this.value = value;
                next = null;
            }

        }
        ListNode[] list = new ListNode[10000];
        int GetId(int key) { return key.GetHashCode() % 10000; }
        /** Initialize your data structure here. */
        public MyHashMap()
        {
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            if (list[GetId(key)] == null) list[GetId(key)] = new ListNode(key, value);
            else
            {
                ListNode tmp = Find(list[GetId(key)], key);
                if (tmp == null)
                {
                    var newNode = new ListNode(key, value);
                    newNode.next = list[GetId(key)];
                    list[GetId(key)] = newNode;
                }
                else
                {
                    tmp.value = value;
                }
            }
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            if (list[GetId(key)] == null) return -1;
            else
            {
                ListNode tmp = Find(list[GetId(key)], key);
                if (tmp == null) return -1;
                else
                {
                    return tmp.value;
                }
            }
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            if (list[GetId(key)] == null) return;
            else
            {
                ListNode tmp = Find(list[GetId(key)], key);
                if (tmp == null) return;
                else
                {
                    var tt = FindPrevious(list[GetId(key)], key);
                    if (tt == null) list[GetId(key)] = tmp.next;
                    else
                        tt.next = tt.next.next;
                }
            }
        }
        ListNode Find(ListNode firstNode, int key)
        {
            ListNode tmp = firstNode;
            while (tmp != null)
            {
                if (tmp.key == key)
                    return tmp;
                else
                    tmp = tmp.next;
            }
            return null;
        }
        ListNode FindPrevious(ListNode firstNode, int key)
        {
            ListNode previous = null;
            ListNode tmp = firstNode;
            while (tmp != null)
            {
                if (tmp.key == key)
                    return previous;
                else
                {
                    previous = tmp;
                    tmp = tmp.next;
                }
            }
            return null;
        }
    }

    /**
     * Your MyHashMap object will be instantiated and called as such:
     * MyHashMap obj = new MyHashMap();
     * obj.Put(key,value);
     * int param_2 = obj.Get(key);
     * obj.Remove(key);
     */
    // @lc code=end
}