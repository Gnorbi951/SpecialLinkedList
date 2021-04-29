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
