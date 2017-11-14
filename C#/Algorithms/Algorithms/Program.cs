using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Algorithms
    {
        class LinkedList {
            private int Key;
            private LinkedList next;
            public LinkedList(int key) {
                this.Key = key;
                this.next = null;
            }

            public void insert(int key) {
                LinkedList tempPointer = this;
                while (tempPointer.next != null) {
                    tempPointer = tempPointer.next;
                }
                tempPointer.next = new LinkedList(key);
            }
        }
        public int Kadane(int[] arr) {
            int currMax = 0;
            int overallMax = 0;

            for (int i = 0; i < arr.Length; i++) {
                currMax += arr[i];
                currMax = Math.Max(currMax, 0);
                overallMax = Math.Max(overallMax, currMax);
            }

            return overallMax;
        }

        public int longestIncreasingSub(int[] arr) {
            HashSet<int> s = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++) {

            }

        }

        static void Main(string[] args)
        {
            Algorithms k = new Algorithms();
            int[] randArr = new int[] { 1,-2,-3, 4,-1, 2, -11, -5, 4};
            Console.WriteLine("largest sequence is: {0}", k.Kadane(randArr));
            Console.ReadLine();
        }
    }
}
