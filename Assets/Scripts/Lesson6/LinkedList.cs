using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson6
{
    public class LinkedList<T>
    {
        private LinkedListNode<T> _headNode;

        public LinkedList()
        {
            _headNode = new LinkedListNode<T>();
            _headNode.Val =default;
            _headNode.Next = null;
            _headNode.Previous = null;
        }

        public void AddFirst(T item)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>();
            newNode.Val = item;
            newNode.Previous = null;
            newNode.Next = _headNode;
            _headNode = newNode;
        }

        public void AddLast(T item)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>();
            newNode.Val = item;
            newNode.Next = null;
            LinkedListNode<T> current = _headNode;
            if ((_headNode = null) != null)
            {
                _headNode = newNode;
                return;
            }

            while (current.Next != null)
            {
                current = current.Next;
            }

            newNode.Previous = current;
            current.Next = newNode;
            
        }

        public void RemoveFirst()
        {
            
        }

        public void RemoveLast()
        {
            
        }

        public void Clear()
        {
            _headNode = null;
        }

        public void PrintList()
        {
            
        }
    }
}
