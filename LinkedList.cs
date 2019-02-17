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
            if(temp.data > Root.data)
            {
                while (node.Right != null)
                {
                    node = node.Right;
                }
            }
            else if(temp.data < Root.data)
            {
                while (node.Left != null)
                {
                    node = node.Left;
                }
            }
            if (temp.data > node.data)
            {
               node.Right = temp;                   
            }
            else if (temp.data < node.data)
            {
               node.Left = temp;                  
            }          
        }
        public void Search(int data)
        {
            Node node;
            Node temp = new Node(data);
            node = Root;

            while (node != null)
            {
                if ((temp.data == node.data) || (temp.data == node.Left.data) || (temp.data == node.Left.data))
                {
                    Console.WriteLine($"We Found {data}!");
                    Console.ReadKey();
                    break;
                }
                else if (temp.data < node.data)
                {
                    node = node.Left;
                    if (temp.data > node.data)
                    {
                        if (node.Right == null)
                        {
                            Console.WriteLine($"{data} does not exist in this tree!");
                            Console.ReadKey();
                            break;
                        }
                    }
                    else if (temp.data < node.data)
                    {
                        if (node.Left == null)
                        {
                            Console.WriteLine($"{data} does not exist in this tree!");
                            Console.ReadKey();
                            break;
                        }
                    }
                }
                else if (temp.data > node.data)
                {
                    node = node.Right;
                    if (temp.data > node.data)
                    {
                        if (node.Right == null)
                        {
                            Console.WriteLine($"{data} does not exist in this tree!");
                            Console.ReadKey();
                            break;
                        }
                    }
                    else if (temp.data < node.data)
                    {
                        if (node.Left == null)
                        {
                            Console.WriteLine($"{data} does not exist in this tree!");
                            Console.ReadKey();
                            break;
                        }
                    }
                }
            }   
        }
    }
}

