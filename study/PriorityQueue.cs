using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace study
{
    class Heap
    {
        public void Heapify(ArrayList iArray, int i)
        {
            int size = iArray.Count;
            int max = i;

            int lNode = 2 * i + 1;
            int rNode = 2 * i + 2;
            // Find max
            if (lNode < size && Convert.ToInt32(iArray[lNode]) > Convert.ToInt32(iArray[max]))
            {
                max = lNode;
            }
            if (rNode < size && Convert.ToInt32(iArray[rNode]) > Convert.ToInt32(iArray[max]))
            {
                max = rNode;
            }

            // Swap value 
            if (max != i)
            {
                int teamp = Convert.ToInt32(iArray[i]);
                iArray[i] = iArray[max];
                iArray[max] = teamp;

                Heapify(iArray, max);
            }
        }

        public void Sort(ArrayList iArray)
        {
            int size = iArray.Count;
            for (int i = size / 2 - 1; i >= 0; i--)
            {
                Heapify(iArray, i);
            }
        }
        public void Insert(ArrayList iArray, int value)
        {
            int size = iArray.Count;
            iArray.Add(value);
            
            for (int i = size / 2 - 1; i >= 0; i--)
            {
               Heapify(iArray, i);
            }
            
            

        }
        public void Pop(ArrayList iArray, int num)
        {
            int i;
            int size = iArray.Count;
            for (i = 0; i < size; i++)
            {
                if (num == Convert.ToInt32(iArray[i]))
                {
                    break;
                }
            }

            int teamp = Convert.ToInt32(iArray[i]);
            iArray[i] = iArray[size - 1];
            iArray[size - 1] = teamp;
            iArray.RemoveAt(size - 1);

            for (int z = size / 2 - 1; z >= 0; z--)
            {
                Heapify(iArray, z);
            }
        }
    }
}
