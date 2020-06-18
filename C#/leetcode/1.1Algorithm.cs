using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    class Test
    {
        public void MainTest()
        {
            int[] source = new int[10];
            int[] destination = new int[10];
            Array.Copy(source, destination, 10);
            Array.Copy(source, 0, destination, 0, 10);

            Array.Fill(new int[10], 1);

            int num = 100;
            long root = num;
            while (root * root > num)
            {
                root = (root + num / root) / 2;
            }
            Console.WriteLine();
        }
    }
}