using System;
using System.Collections.Generic;
namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            bool returnedNumber;
            CustomBinarySearchTree tree = new CustomBinarySearchTree();
            tree.Add(30);
            tree.Add(20);
            tree.Add(40);
            tree.Add(25);
            tree.Add(35);

            returnedNumber = tree.Search(40);
            returnedNumber = tree.Search(15);
        }
    }
}
