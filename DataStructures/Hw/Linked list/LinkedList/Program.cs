using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


            Console.WriteLine(node1.ToString());

            Adder(node1, 5);

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


    }
}

