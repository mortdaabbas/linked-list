using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    internal class Program
    {
        class linkedlistnode
        {
            public int data;
            public linkedlistnode next;
            public linkedlistnode(int x) 
            {
                data = x;
                next = null;
            }
        }

        class linkedlist
        {
           static int count;

          private linkedlistnode head;
            public linkedlist()
            {
                head = null;
                count = 0;
            }
            public void AddNodetofront(int data)
            {
                linkedlistnode node = new linkedlistnode(data);
                node.next = head;
                head = node;
                count++;
            }
            public void printlist()
            {
                linkedlistnode runner = head;
                while (runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }
            }
            public int Find(int x) 
            {
                linkedlistnode f = head;
                while (f != null)
                {
                    if (f.data == x)
                        return 1;
                    f = f.next;
                }
                return -1;
            }
           
        }

        static void Main(string[] args)
        {
      
            linkedlist linkedlist = new linkedlist();
            for (int i = 0; i < 5; i++)
            {
                linkedlist.AddNodetofront(i);
            }
            linkedlist.printlist();
            
           int f= linkedlist.Find(0);
            if (f != -1)
                Console.WriteLine("found");
            else
                Console.WriteLine("not found");
        }
    }
}
