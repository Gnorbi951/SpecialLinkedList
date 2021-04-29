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

            lancoltLista.Append(1);
            lancoltLista.Append(2);
            lancoltLista.Append(3);
            lancoltLista.Append("any type of object");
            lancoltLista.Append(5);
            lancoltLista.PrintList();
        }
    }
}
