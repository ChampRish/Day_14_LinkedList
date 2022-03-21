using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Day14
{
    public class Program
    {
        static void Main(string[] args)
        {
            Linkedlist1 linkedlist = new Linkedlist1();

            linkedlist.Add(56);
            linkedlist.Add(30);
            linkedlist.Add(70);
            linkedlist.Display();
            Console.ReadLine();
        }
    }
}
