using System;
using System.Collections.Generic;
using System.Text;

namespace SpecLinkedList
{
    class Application
    {
        public void Run()
        {
            Console.WriteLine("Starting application....");
            LancoltLista lancoltLista = new LancoltLista();

            lancoltLista.Append("a");
            lancoltLista.Append("b");
            lancoltLista.Append("c");
            lancoltLista.Append("d");
            lancoltLista.Append("e");
            lancoltLista.DeleteNodeByIndex(8);
            Console.WriteLine(lancoltLista.getElementByIndex(3));
            lancoltLista.PrintList();
        }
    }
}
