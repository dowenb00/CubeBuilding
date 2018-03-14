using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Your task is to construct a building which will be a pile of n cubes. The cube at the bottom will have a volume of n^3, 
 * the cube above will have volume of (n-1)^3 and so on until the top which will have a volume of 1^3.

You are given the total volume m of the building. Being given m can you find the number n of cubes you will have to build?

The parameter of the function findNb (find_nb, find-nb, findNb) will be an integer m and you have to return the integer n 
such as n^3 + (n-1)^3 + ... + 1^3 = m if such a n exists or -1 if there is no such n.
 */ 

namespace CubeBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            int cube = -9;

            long i = findNb(cube);

            Console.WriteLine(i);

        }
        public static long findNb(long m)
        {
            long sum = 0;
            long i = 1;

            while (sum <= m)
            {
                sum += i * i * i;

                if (sum == m)
                {
                    return i;
                }

                i++;
            }
            return -1;
        }
    }
}
