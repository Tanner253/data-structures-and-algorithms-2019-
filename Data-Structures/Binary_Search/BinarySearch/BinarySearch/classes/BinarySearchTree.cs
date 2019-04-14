using System;
using System.Collections.Generic;
using System.Text;
using BinarySearch.classes;
namespace BinarySearch.classes
{
    class BinarySearchTree : BinaryTree
    {
        public Node root;
        /// <summary>
        /// ctor
        /// </summary>
        public BinarySearchTree()
        {
            root = null;
        }
        /// <summary>
        /// check if a value is contained in tree
        /// </summary>
        /// <param name="value">alue checking for</param>
        /// <param name="root">tree</param>
        /// <returns></returns>
        public bool Contains(int value, Node root)
        {
            
            List<int> list = RecursiveBinarySearchPre(root);
            foreach (var val in list)
            {
                if(val == value)
                {
                    return true;
                }
            }
            return false;

        }
        /// <summary>
        /// Insert a node into a binary search tree in Log n 
        /// </summary>
        /// <param name="node">tree </param>
        /// <param name="insertValue">value node</param>
        /// <returns></returns>
        public Node Insert(Node root, int insertValue)
        {
                Node node1 = new Node(insertValue);
            if (root == null)
            {
                return node1;
            }

            if(insertValue < node1.Value){
                node1.LChild = Insert(root.LChild, insertValue);
            }
            else if(insertValue > node1.Value)
            {
                node1.RChild = Insert(node1.RChild, insertValue);
            }
            return node1;
            

            
        }
    }
}
