using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<int> one = new Node<int>(1);
            Node<int> two = new Node<int>(2);
            Node<int> three = new Node<int>(3);

            Console.WriteLine(one.ToString());
            one = DeleteLast(one);
            Console.WriteLine(one.ToString());

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


        public static Node<T> AddLast<T>(Node<T> node, T value)
        {
            if (node == null)
            {
                Node<T> noa = new Node<T>(value);
                return noa;

            }

            else
            {
                while (node.GetNext() != null)
                {
                    node = node.GetNext();
                }
                node.SetNext(new Node<T>(value));

                return node;
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

        public static Node<T> DeleteLast<T>(Node<T> node)
        {
            if (node == null)
            {
                Console.WriteLine("list is empty");
                return null;
            }
            else if (node.GetNext() == null)
            {
                return null;
            }
            else
            {

                while (node.GetNext().GetNext() != null)
                {
                    node = node.GetNext();
                }

                node.SetNext(null);
                return node;
            }
        }


    }


}


