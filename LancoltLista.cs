using System;
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

        internal void InsertAfter(Node prev_node, object new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            Node new_node = new Node();
            new_node.data = new_data;
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }



        public void Delete(Node node)
        {
            if (root == node)
            {
                root = node.next;
                node.next = null;
            }
            else
            {
                Node current = root;
                while (current.next != null)
                {
                    if (current.next == node)
                    {
                        current.next = node.next;
                        node.next = null;
                        break;
                    }
                    current = current.next;
                }
            }
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
