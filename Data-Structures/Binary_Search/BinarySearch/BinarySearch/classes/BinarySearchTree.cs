using System;
using System.Collections.Generic;
using System.Text;
using BinarySearch.classes;
namespace BinarySearch.classes
{
    class BinarySearchTree : BinaryTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
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
        
        public Node Insert(Node node, int insertValue)
        {
                Node node1 = new Node(insertValue);
            if (node == null)
            {
                return node1;
            }

            if(insertValue < node1.Value){
                node1.LChild = Insert(node.LChild, insertValue);
            }
            else if(insertValue > node1.Value)
            {
                node1.RChild = Insert(node1.RChild, insertValue);
            }
            return node1;
            

            
        }
    }
}
