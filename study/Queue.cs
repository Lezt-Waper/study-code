using System;
using System.Collections.Generic;
using System.Text;

namespace study
{
    class Queue
    {
        public int[] str;
        public int rear = -1;
        public int front = -1;
        public int max;

        public Queue(int size)
        {
            str = new int[size];
            max = size;
        }

        // check full
        public bool Full()
        {
            if (front == 0 && rear == max + 1)
            {
                return true;
            }
            else if (rear +1 == front)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // check emty
        public bool Emty()
        {
            return front == - 1;
        }
        // push value at rear
        public void PushAtRear(int value)
        {
            if (Full())
            {
                Console.WriteLine("Storage is full");
            }
            else
            {
                if (front == -1)
                {
                    front = 0;
                }
                rear = (rear + 1)% max;
                str[rear] = value;
                Console.WriteLine("Added "+ value+ " to the storage");
            }
        }

        // push value at rear
        public void PushAtFront(int value)
        {
            if (Full())
            {
                Console.WriteLine("Storage is full");
            }
            else
            {
                if (front < 1)
                {
                    front = max -1;
                }
                else
                {
                    front--;
                }
                
                str[front] = value;
                Console.WriteLine("Added " + value + " to the storage");
            }
        }

        //pop value at front
        public int PopAtFront()
        {
            if (Emty())
            {
                Console.WriteLine("Storage is emty");
                return 0;
            }
            else
            {
                int get = str[front];
                if (front == rear)
                {
                    front = rear = -1;
                }
                else
                {
                    front = (front + 1)% max;
                }
                return get;
            }
        }

        // Pop value at rear
        public int PopAtRear()
        {
            if (Emty())
            {
                Console.WriteLine("Storage is emty");
                return 0;
            }
            else
            {
                int get = str[rear];
                if (front == rear)
                {
                    front = rear = -1;
                }
                else
                {
                    if (rear < 1)
                    {
                        rear = max - 1;
                    }
                    else
                    {
                        rear--;
                    }
                }
                return get;
            }
        }

        //print
        public void Print()
        {
            char space = '\t';
            if (Emty())
            {
                Console.WriteLine("Storage is emty");
            }
            else
            {
                if (rear > front)
                {
                    for (int i = front; i <= rear; i++)
                    {
                        Console.Write("{0}{1}",str[i],space);
                    }
                }
                else if (rear < front)
                {
                    for (int i = front; i < max; i++)
                    {
                        Console.Write("{0}{1}", str[i], space);
                    }

                    for (int i = 0; i <= rear; i++)
                    {
                        Console.Write("{0}{1}", str[i], space);
                    }
                }
            }
        }
    }
}
