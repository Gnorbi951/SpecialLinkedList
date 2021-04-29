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
                Node curr = root;
                if (curr == null)
                    return null;
                while (curr.next != null)
                    curr = curr.next;
                return curr;
            }
        }
    }
}
