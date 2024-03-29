﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpecLinkedList
{
    class LancoltLista
    {
        public class Node
        {
            // link to next Node in list
            public Node next = null;
            // value of this Node
            public object data;
        }
        private Node root = null;

        // Get the first element of the list
        public Node First { get { return root; } }

        //Get the last element of the list
        public Node Last
        {
            get
            {
                Node currentNode = root;
                if (currentNode == null)
                    return null;
                while (currentNode.next != null)
                    currentNode = currentNode.next;
                return currentNode;
            }
        }
        public void Append(object value)
        {
            Node n = new Node { data = value };
            if (root == null)
                root = n;
            else
                Last.next = n;
        }

        public void DeleteElementByIndex(int index)
        {
            if (index == 0)
            {
                root = root.next;
            }
            try
            {
                Node previousNode = null;
                Node currentNode = root;
                for (int i=0; i<index; i++)
                {
                    previousNode = currentNode;
                    currentNode = currentNode.next;
                }
                previousNode.next = currentNode.next;
            }
            catch(NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void DeleteElementByValue(object value)
        {
            Node temp = root;
            Node prev = null;
            if (temp != null && temp.data == value)
            {
                root = temp.next;
                return;
            }
            while (temp != null && temp.data != value)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }

        public object getElementByIndex(int index)
        {
            if (index == 0)
            {
                return root.data;
            }
            Node currentNode = root;
            try
            {
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.next;
                }
            } catch (NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
            return currentNode.data;
        }


        public void PrintList()
        {
            List<String> listData = new List<String>();
            Node currentNode = root;
            if (currentNode == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            while (currentNode.next != null)
            {
                listData.Add(currentNode.data.ToString());
                currentNode = currentNode.next;
            }
            listData.Add(currentNode.data.ToString());
            Console.WriteLine("Linked list data:");
            Console.WriteLine($"\t {String.Join(",", listData)}");

        }
    }
}
