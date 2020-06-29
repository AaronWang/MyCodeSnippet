/*
 * @lc app=leetcode id=1030 lang=csharp
 *
 * [1030] Matrix Cells in Distance Order
 */
using System.Collections.Generic;

namespace AllCellsDistOrder
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
            // AllCellsDistOrder(2, 3, 1, 1);
            // AllCellsDistOrder(3, 3, 0, 2);
            // [[0,2],[0,1],[1,2],[0,0],[1,1],[2,2],[1,0],[2,1],[2,0]]
        // }
        public class Node
        {
            public int r;
            public int c;
            public Node(int r, int c)
            {
                this.r = r;
                this.c = c;
            }
        }
        public void process(int r, int c, Queue<Node> queue, bool[][] matrix, int[][] ans, int ansIndex)
        {
            queue.Enqueue(new Node(r, c));
            matrix[r][c] = true;
            ans[ansIndex] = new int[] { r, c };
        }
        public int[][] AllCellsDistOrder(int R, int C, int r0, int c0)
        {
            bool[][] matrix = new bool[R][];
            int[][] ans = new int[R * C][];
            Queue<Node> queue = new Queue<Node>();

            for (int i = 0; i < R; i++)
            {
                matrix[i] = new bool[C];
                for (int j = 0; j < C; j++)
                    matrix[i][j] = false;
            }
            //initialize
            queue.Enqueue(new Node(r0, c0));
            ans[0] = new int[] { r0, c0 };
            matrix[r0][c0] = true;
            int ansIndex = 1;

            Node tmp;
            while (queue.Count > 0)
            {
                tmp = queue.Dequeue();
                //left side
                if (tmp.c - 1 >= 0 && matrix[tmp.r][tmp.c - 1] == false)
                {
                    process(tmp.r, tmp.c - 1, queue, matrix, ans, ansIndex++);
                }
                //up side
                if (tmp.r - 1 >= 0 && matrix[tmp.r - 1][tmp.c] == false)
                {
                    process(tmp.r - 1, tmp.c, queue, matrix, ans, ansIndex++);
                }
                // right side
                if (tmp.c + 1 < C && matrix[tmp.r][tmp.c + 1] == false)
                {
                    process(tmp.r, tmp.c + 1, queue, matrix, ans, ansIndex++);
                }
                //down side
                if (tmp.r + 1 < R && matrix[tmp.r + 1][tmp.c] == false)
                {
                    process(tmp.r + 1, tmp.c, queue, matrix, ans, ansIndex++);
                }
                //not working, 前面点加入 2的距离，后面点还有1的 距离没有加入。
                // //left up
                // if (tmp.r - 1 >= 0 && tmp.c - 1 >= 0 && matrix[tmp.r - 1][tmp.c - 1] == false)
                // {
                //     process(tmp.r - 1, tmp.c - 1, queue, matrix, ans, ansIndex++);
                // }
                // //right up
                // if (tmp.r - 1 >= 0 && tmp.c + 1 < C && matrix[tmp.r - 1][tmp.c + 1] == false)
                // {
                //     process(tmp.r - 1, tmp.c + 1, queue, matrix, ans, ansIndex++);
                // }
                // //left  down
                // if (tmp.r + 1 < R && tmp.c - 1 >= 0 && matrix[tmp.r + 1][tmp.c - 1] == false)
                // {
                //     process(tmp.r + 1, tmp.c - 1, queue, matrix, ans, ansIndex++);
                // }
                // //right down
                // if (tmp.r + 1 < R && tmp.c + 1 < C && matrix[tmp.r + 1][tmp.c + 1] == false)
                // {
                //     process(tmp.r + 1, tmp.c + 1, queue, matrix, ans, ansIndex++);
                // }
            }
            return ans;
        }
    }
    // @lc code=end

}