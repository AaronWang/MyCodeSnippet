using System;
using System.Collections.Generic;
using System.Linq;

namespace PermutationCombination
{
    public class Algorithm
    {
        // 排列公式 n个数中，取m个数的排列数， n!/(n-m)!
        // 组合公式 n个数中，取m个数的组合数， n!/(m!(n-m)!)
        // n!   n的阶乘

        //Permutation, with repitition
        public static IEnumerable<IEnumerable<T>> GetPermutationWithRepitition<T>(IEnumerable<T> list, int length)
        {
            if (length < 1) return new List<List<T>>();
            if (length == 1) return list.Select(t => new T[] { t });
            return GetPermutationWithRepitition(list, length - 1)
                .SelectMany(t => list,
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }
        //input:  1,2,3,4   length 2
        //output: 11,12,13,14,21,22,23,24,31,32,33,34,41,42,43,44 组合

        //Permutation, without repitition
        public static IEnumerable<IEnumerable<T>> GetPermutation<T>(IEnumerable<T> list, int length)
        {
            if (length < 1) return new List<List<T>>();
            if (length == 1) return list.Select(t => new T[] { t });
            return GetPermutation(list, length - 1)
                .SelectMany(t => list.Where(o => !t.Contains(o)),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }
        //input:  1,2,3,4 length 2
        //output: 11,12,13,14,21,22,23,24,31,32,33,34,41,42,43,44 组合
        //combination include itself
        public static IEnumerable<IEnumerable<T>> GetKCombinationWithRepitition<T>(IEnumerable<T> list, int length) where T : IComparable
        {
            if (length < 1) return new List<List<T>>();
            if (length == 1) return list.Select(t => new T[] { t });
            return GetKCombinationWithRepitition(list, length - 1)
                .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) >= 0),
                (t1, t2) => t1.Concat(new T[] { t2 }));
        }
        //input :1,2,3,4   length 2;
        //output:11,12,13,14,22,23,24,33,34,44

        // K-Combination doesnot include itself
        public static IEnumerable<IEnumerable<T>> GetKCombination<T>(IEnumerable<T> list, int length) where T : IComparable
        {
            if (length < 1) return new List<List<T>>();
            if (length == 1) return list.Select(t => new T[] { t });
            return GetKCombination(list, length - 1)
                .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) > 0),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }
        //input 1,2,3,4    length 2
        //output: {1,2} {1,3} {1,4} {2,3} {2,4} {3,4}
    }
}