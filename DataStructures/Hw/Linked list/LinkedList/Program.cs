using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<int> node1 = new Node<int>(10);
            Node<int> node2 = new Node<int>(20);
            Node<int> node3 = new Node<int>(30);

            node1.SetNext(node2);
            node2.SetNext(node3);

            AddSecondLast(node1, 22);

            Console.WriteLine(node1.ToString());


        }

        public static int GetSum(Node<int> a)
        {
            int sum = 0;

            while (a != null)
            {
                sum += a.GetValue();
                a = a.GetNext();
            }

            return sum;
        }

        public static int GetMax(Node<int> a)
        {
            int highest = 0;

            while (a != null)
            {
                if (a.GetValue() > highest)
                {
                    highest = a.GetValue();
                }

                a = a.GetNext();
            }
            return highest;
        }

        public static void Adder(Node<int> node, int add)
        {
            while (node != null)
            {
                node.SetValue(node.GetValue() + add);
                node = node.GetNext();
            }
        }

        public static int NumberOfNodes<T>(Node<T> node)
        {
            int count = 0;
            while (node != null)
            {
                count++;
                node = node.GetNext();
            }
            return count;
        }


        public static void AddLast<T>(Node<T> node, T value)
        {
            if (node == null)
            {
                node.SetValue(value);
            }

            else
            {
                while (node.GetNext() != null)
                {
                    node = node.GetNext();
                }
                node.SetNext(new Node<T>(value));
            }
        }

        public static void AddSecondLast<T>(Node<T> node, T value)
        {
            while (node.GetNext().GetNext() != null)
            {
                node = node.GetNext();
            }

            Node<T> na = node.GetNext();
            node.SetNext(new Node<T>(value));
            node = node.GetNext();
            node.SetNext(na);

            
        }
    }


}


