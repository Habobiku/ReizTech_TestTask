using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ReizTech_TestTask
{
   public static class Task2
    {
        private static Tree CreateTree(int[] elements)
        {
            Tree tree = new Tree();
            foreach (int element in elements)
                tree.Root = tree.AddNode(element, tree.Root);
            return tree;
        }

        public static void Start()
        {
            int[] elements = { 0, 9, 44, 45, 6, 10, -7, -12 };
            Tree tree = CreateTree(elements);
            tree.PrintTree(Console.WindowWidth / 2, 0, tree.Root);
            Console.WriteLine();


            Console.WriteLine("Sum of depth of all node is " + tree.SumDepthOfAllChildren(tree.Root, 0));
            Console.WriteLine("Depth of tree is " + tree.FindDepth(tree.Root));
        }
    }
}







