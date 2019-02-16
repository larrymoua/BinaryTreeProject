using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList linked = new LinkedList();
            linked.Add(20);
            linked.Add(19);
            linked.Add(22);
            linked.Add(15);
            linked.Add(11);
            linked.Add(12);
            linked.Search(15);
            linked.Search(19);
            linked.Search(10);


        }
    }
}
