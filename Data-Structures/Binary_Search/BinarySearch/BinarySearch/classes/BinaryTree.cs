using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch.classes
{
    
    public class BinaryTree
    {
        public Node Root { get; set; }
        List<int> list = new List<int>();

        public BinaryTree(Node node)
        {
            Root = node;
        }
        public BinaryTree()
        {

        }
        /// <summary>
        /// searches a tree in pre order
        /// </summary>
        /// <param name="Root">tree</param>
        /// <returns>node values in list</returns>
        public List<int> RecursiveBinarySearchPre(Node Root)
        {
            if (Root != null)
            {
                list.Add(Root.Value);
                if (Root.LChild != null)
                {
                    RecursiveBinarySearchPre(Root.LChild);
                }
                if (Root.RChild != null)
                {
                    RecursiveBinarySearchPre(Root.RChild);
                }
            }
            return list;

        }

        /// <summary>
        /// searches a tree in order
        /// </summary>
        /// <param name="Root">tree</param>
        /// <returns>node values in list</returns>
        public List<int> RecursiveBinarySearchInOrder(Node Root)
        {
            if (Root != null)
            {
                if (Root.LChild != null)
                {
                    RecursiveBinarySearchInOrder(Root.LChild);
                }
                list.Add(Root.Value);
                if (Root.RChild != null)
                {
                    RecursiveBinarySearchInOrder(Root.RChild);
                }
            }
            return list;

        }

        /// <summary>
        /// traverses a tree in post order
        /// </summary>
        /// <param name="Root">tree</param>
        /// <returns>node values in list</returns>
        public List<int> RecursiveBinarySearchPostOrder(Node Root)
        {
            if (Root != null)
            {
                if (Root.LChild != null)
                {
                    RecursiveBinarySearchPostOrder(Root.LChild);
                }
                if (Root.RChild != null)
                {
                    RecursiveBinarySearchPostOrder(Root.RChild);
                }
                list.Add(Root.Value);
            }
            return list;

        }
    }
}
