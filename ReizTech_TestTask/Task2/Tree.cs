using System;
using System.Xml.Linq;

namespace ReizTech_TestTask
{
    public class Node
    {
        private int _data;
        private Node? _left;
        private Node? _right;

        public Node()
        {

        }

        public Node(int inputDataNode)
        {
            Data = inputDataNode;
        }

        public int Data { get => _data; set => _data = value; }
        public Node Left { get => _left; set => _left = value; }
        public Node Right { get => _right; set => _right = value; }
    }

    public class Tree
    {
        private Node? _root;
        public Node Root { get => _root; set => _root = value; }

        public Node AddNode(int inputDataNode, Node? root)
        {
            if (root == null)
            {
                root = new Node(inputDataNode);
            }
            else
            {
                if (inputDataNode < root.Data)
                {
                    root.Left = AddNode(inputDataNode, root.Left);
                }
                else
                {
                    root.Right = AddNode(inputDataNode, root.Right);
                }
            }
            return root;
        }

        public void PrintTree(int x, int y, Node? root, int delta = 0)
        {
            if (root != null)
            {
                if (delta == 0)
                    delta = x / 2;
                Console.SetCursorPosition(x, y);
                Console.Write(root.Data);
                PrintTree(x - delta, y + 3, root.Left, delta / 2);
                PrintTree(x + delta, y + 3, root.Right, delta / 2);
            }
        }

        public int CountElements(Node? root)
        {
            if (root == null)
                return 0;
            return 1 + CountElements(root.Left) + CountElements(root.Right);
        }

        public int SumDepthOfAllChildren(Node? node, int depth)
        {
            if (node == null)
                return 0;
            return depth + SumDepthOfAllChildren(node.Left, depth + 1) +
                           SumDepthOfAllChildren(node.Right, depth + 1);
        }

        public int FindDepth(Node? node)
        {
            if (node == null)
            {
                return (-1);
            }
            else
            {
                int leftDepth = FindDepth(node.Left);
                int rightDepth = FindDepth(node.Right);

                if (leftDepth > rightDepth)
                    return (leftDepth + 1);
                else
                    return (rightDepth + 1);
            }
        }
    }
}


