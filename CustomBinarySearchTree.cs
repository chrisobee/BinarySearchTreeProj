using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class CustomBinarySearchTree
    {
        //Member Variables
        public Node root = null;
        //Constructor
        public CustomBinarySearchTree()
        {

        }

        public CustomBinarySearchTree(int data)
        {
            root = new Node(data);
        }

        //Member Methods
        public void Add(int data)
        {
            Node current;
            if (root == null)
            {
                root = new Node(data);
            }
            current = root;

            while (true)
            {
                if (data >= current.data)
                {
                    if(current.rightNode != null)
                    {
                        current = current.rightNode;
                    }
                    else
                    {
                        current.rightNode = new Node(data);
                        break;
                    }
                }
                else if (data < current.data)
                {
                    if (current.leftNode != null)
                    {
                        current = current.leftNode;
                    }
                    else
                    {
                        current.leftNode = new Node(data);
                        break;
                    }
                }
            }
        }

        public bool Search(int data)
        {
            Node current;
            if(root == null)
            {
                return false;
            }
            current = root;
            while (true)
            {
                if(data == current.data)
                {
                    return true;
                }
                if (data >= current.data)
                {
                    if (current.rightNode != null)
                    {
                        current = current.rightNode;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (data < current.data)
                {
                    if (current.leftNode != null)
                    {
                        current = current.leftNode;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
