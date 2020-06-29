/*
 * @lc app=leetcode id=705 lang=csharp
 *
 * [705] Design HashSet
 */
namespace MyHashSet
{
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     MyHashSet hs = new MyHashSet();
        //     hs.Add(1);
        //     hs.Add(2);
        //     hs.Contains(3);
        //     hs.Contains(1);
        //     hs.Add(3);
        //     hs.Remove(3);
        //     hs.Contains(3);
        // }
    }
    // @lc code=start
    public class MyHashSet
    {
        public class HashNode
        {
            public int value;
            public HashNode next;
            public HashNode(int value)
            {
                this.value = value;
                next = null;
            }
        }

        HashNode[] hs = new HashNode[1000];
        /** Initialize your data structure here. */
        public MyHashSet()
        {

        }

        public void Add(int key)
        {
            HashNode hn = FindHashNodePrevious(key);
            if (hs[FindId(key)] == null)
                hs[FindId(key)] = new HashNode(key);
            else
            {
                if (hn != null && hn.next == null)
                    hn.next = new HashNode(key);
            }
        }

        public void Remove(int key)
        {
            HashNode hn = FindHashNodePrevious(key);
            if (hs[FindId(key)] != null)
            {
                if (hn == null)
                    hs[FindId(key)] = hs[FindId(key)].next;
                else
                    if (hn.next != null)
                    hn.next = hn.next.next;
            }
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            HashNode hn = FindHashNodePrevious(key);
            if (hs[FindId(key)] != null)
            {
                if (hn == null || hn.next != null)
                    return true;
            }
            return false;
        }
        public HashNode FindHashNodePrevious(int key)
        {
            HashNode previous = null;
            HashNode current = hs[FindId(key)];
            if (current == null) return null;
            while (current != null)
            {
                if (current.value == key)
                    return previous;
                previous = current;
                current = current.next;
            }
            return previous;
        }
        int FindId(int key)
        {
            return key.GetHashCode() % 1000;
        }
    }

    /**
     * Your MyHashSet object will be instantiated and called as such:
     * MyHashSet obj = new MyHashSet();
     * obj.Add(key);
     * obj.Remove(key);
     * bool param_3 = obj.Contains(key);
     */
    // @lc code=end

}