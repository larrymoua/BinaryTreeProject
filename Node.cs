using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject
{
    class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }

        public int data;
        public Node Link;
        public Node(int data)
        {
            this.data = data;
        }

    }
}
