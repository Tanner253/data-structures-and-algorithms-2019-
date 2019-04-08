using System;
using Xunit;
using BinarySearch.classes;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
       [Fact]
        public void Preorder()
        {

            Node node1 = new Node(5);
            BinaryTree tree = new BinaryTree(node1);
            List<int> list = new List<int>();

            node1.LChild = new Node(10);
            node1.RChild = new Node(15);

            node1.LChild.LChild = new Node(20);
            node1.LChild.RChild = new Node(25);

            node1.RChild.RChild = new Node(30);
            node1.RChild.LChild = new Node(35);

            list.Add(node1.Value); //5
            list.Add(node1.LChild.Value); //10
            list.Add(node1.RChild.Value); //15
            list.Add(node1.LChild.LChild.Value); //20
            list.Add(node1.LChild.RChild.Value); //25
            list.Add(node1.RChild.RChild.Value); //30
            list.Add(node1.RChild.LChild.Value); //35
            
            

            Assert.Equal(list[0], node1.Value);

        }
        [Fact]
        public void CanInstantiateEmptyTree()
        {
           
            BinaryTree tree = new BinaryTree();

            Assert.Null(tree.Root);
        }
        [Fact]
        public void CanInstantiateTreeWithNode()
        {
            Node node = new Node(5);
            BinaryTree tree = new BinaryTree(node);

            Assert.NotNull(tree.Root);
        }
        [Fact]
        public void CanInstantiateTreeWithLNodeandRNode()
        {
            Node node = new Node(5);
            BinaryTree tree = new BinaryTree(node);
            node.LChild = new Node(10);
            node.RChild = new Node(15);

            Assert.Equal(10, node.LChild.Value);
        }
        [Fact]
        public void InOrder()
        {

            Node node1 = new Node(5);
            BinaryTree tree = new BinaryTree(node1);
            List<int> list = new List<int>();

            node1.LChild = new Node(10);
            node1.RChild = new Node(15);

            list.Add(node1.Value); //5
            list.Add(node1.LChild.Value); //10
            list.Add(node1.RChild.Value); //15
            var output = tree.RecursiveBinarySearchInOrder(node1);
            



            Assert.Equal(5, output[1]);

        }
        [Fact]
        public void PostOrder()
        {

            Node node1 = new Node(5);
            BinaryTree tree = new BinaryTree(node1);
            List<int> list = new List<int>();

            node1.LChild = new Node(10);
            node1.RChild = new Node(15);

            list.Add(node1.Value); //5
            list.Add(node1.LChild.Value); //10
            list.Add(node1.RChild.Value); //15
            var output = tree.RecursiveBinarySearchPostOrder(node1);




            Assert.Equal(5, output[2]);

        }
    }
}

