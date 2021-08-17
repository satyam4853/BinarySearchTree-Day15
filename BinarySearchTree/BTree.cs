using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BTree<T> LeftTree { get; set; }
        public BTree<T> RightTree { get; set; }
        public BTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        /// <summary>
        /// Insert the value in Binary Tree
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BTree<T>(item);
                else
                    this.LeftTree.Insert(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BTree<T>(item);
                else
                    this.RightTree.Insert(item);
            }
        }
        /// <summary>
        /// Display the elements of Binary Tree
        /// </summary>
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();

            }
        }
        /// <summary>
        /// Get the size of the Binary Tree
        /// </summary>
        public void GetSize() => Console.WriteLine("Size" + " " + (1 + leftCount + rightCount));
        /// <summary>
        /// Check if the element exists in the Binary Tree
        /// </summary>
        /// <param name="element"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool IfExists(T element, BTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.NodeData);
                return true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST", node.NodeData);
            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                IfExists(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExists(element, node.RightTree);
            }
            return result;
        }
    }

}
