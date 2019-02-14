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
            if(Root == null)
            {
                Root = temp;
                node = Root;
            }        
            else if (Root.Right == null && temp.data > Root.data)
            {
                    Root.Right = temp;
            }
            else if (Root.Left == null && temp.data < Root.data)
            {
                  Root.Left = temp;       
            }

            else if(temp.data > Root.data && Root.Left != null && Root.Right != null)
            {
                Root = Root.Right;
                Add(temp.data);
            }

            else if (temp.data < Root.data && Root.Left != null && Root.Right != null)
            {
                Root = Root.Left;
                Add(temp.data);
            }

        }

    }
}
