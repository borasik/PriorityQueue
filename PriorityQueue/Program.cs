using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    public class Program
    {
        public static IList<int> List = new List<int>(); 
        public static void Main(string[] args)
        {
           
            while (true)
            {
                Console.WriteLine("Please Enter Number [0 - Exit, 1 to print min]");
                var num = int.Parse(Console.ReadLine());

                if (num == 0) break;

                if (num == 1) PrintMin(List);

                List.Add(num);
                Heap.Heapfy(List);
            }

            Console.Read();
        }

        private static void PrintMin(IList<int> list)
        {
            Console.WriteLine("Min is: " + list[0]);
        }
    }

    public class Heap
    {
        public static void Heapfy(IList<int> list)
        { 
            if (list.Count < 1) return;
            var leafsIndex = (list.Count - 2) / 2;
            for(int i = leafsIndex; i >= 0; i--)
            {
                var leftChild = i * 2+1;
                var rightChild = i * 2 + 2;

                if (leftChild > list.Count - 1) continue;
                if (list[i] > list[leftChild])
                {
                    var temp = list[i];
                    list[i] = list[leftChild];
                    list[leftChild] = temp;
                }

                if (rightChild > list.Count - 1) continue;
                if (list[i] > list[rightChild])
                {
                    var temp = list[i];
                    list[i] = list[rightChild];
                    list[rightChild] = temp;
                }
            }
        }
    }
}
