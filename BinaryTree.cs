using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject
{
    class BinaryTree : IEnumerable
    {
        public Node root;
        public Node Left { get; set; }
        public Node Right { get; set; }
        public BinaryTree()
        {
    
        }
        public void AddNodeToTree(int data)
        {
       

            Node temp = new Node(data);
            if (root == null)
            {
                root = temp;
            }
            else if (data > root.data)
            {
               Left = temp;
            }
           else if (data < root.data)
           {
                Right = temp;
           }
            
                return;
       
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 5; i++)
            {
                yield return"";
            }
            yield return "No more data";
        }
    }
}
