/*
 * @lc app=leetcode id=690 lang=csharp
 *
 * [690] Employee Importance
 */
using System.Collections.Generic;
using System.Linq;

namespace GetImportance
{
    // Definition for Employee.
    class Employee
    {
        public int id;
        public int importance;
        public IList<int> subordinates;
    }
    // @lc code=start

    class Solution
    {
        public int GetImportance(IList<Employee> employees, int id)
        {
            int countValue = 0;
            List<int> listId = new List<int>();
            listId.Add(id);
            int nextId = 0;
            while (listId.Count != 0)
            {
                nextId = listId.First();
                listId.Remove(nextId);
                foreach (var item in employees)
                {
                    if (item.id == nextId)
                    {
                        countValue += item.importance;
                        employees.Remove(item);
                        listId.AddRange(item.subordinates);
                        break;
                    }
                }
            }
            return countValue;
        }
    }
    // @lc code=end

}