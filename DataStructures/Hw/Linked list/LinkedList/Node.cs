using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node<T>
    {
        T value; Node<T> next;

        public Node(T value)
        {
            SetValue(value);
            SetLink(null);
        }
        public Node(T value, Node<T> next)
        {
            SetValue(value);
            SetLink(next);
        }

        public Node<T> GetNext()
        {
            return next;
        }

        public void SetValue(T value)
        {
            this.value = value;
        }

        public T GetValue()
        {
            return value;
        }

        public void SetLink(Node<T> next)
        {
            this.next = next;
        }

        public bool HasNext()
        {
            if (GetNext() == null) return false;
            return true;
        }
        public void SetNext(Node<T> next)
        {
            this.next = next;
        }

        public override string ToString()
        {
            string s = $"{GetValue()}";
            Node<T> current = GetNext();
            while (current != null)
            {
                s += $" - {current.GetValue()}";
                current = current.GetNext();
            }
            return s;
        }


    }
}
