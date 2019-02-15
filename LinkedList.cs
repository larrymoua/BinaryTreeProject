using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject
{
    class LinkedList
    {
        public Node Root;
        public void Add(int data)
        {
            Node node;
            Node temp = new Node(data);

            if (Root == null)
            {
                Root = temp;

            }
            node = Root;
            while(node.Right != null)
            {
               node = node.Right;         
            }
            while (node.Left != null)
            {
               node = node.Left;
            }
            if (temp.data > node.data && node.Right == null)
            {
               node.Right = temp;                   
            }
            else if (temp.data < node.data && node.Left == null)
            {
               node.Left = temp;                  
            }
            
        }

    }
}

