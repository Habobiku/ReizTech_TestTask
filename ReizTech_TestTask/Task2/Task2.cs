using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ReizTech_TestTask
{
   public static class Task2
    {
        private static Branch CreateBranch()
        {
            Branch root = new Branch("Root");
            Branch branch1 = root.AddBranch(new Branch("Branch1"));
            Branch branch2 = root.AddBranch(new Branch("Branch2"));
            Branch branch11 = branch1.AddBranch(new Branch("Branch11"));
            Branch branch111 = branch11.AddBranch(new Branch("Branch111"));
            Branch branch1111 = branch111.AddBranch(new Branch("Branch1111"));
            Branch branch21 = branch2.AddBranch(new Branch("Branch21"));
            Branch branch211 = branch21.AddBranch(new Branch("Branch211"));
            Branch branch11111 = branch1111.AddBranch(new Branch("Branch11111"));



            return root;



        }

        public static void Start()
        {
            Branch root = CreateBranch();
            List<Branch> path = root.FindDepth();
            foreach (Branch branch in path)
                Console.Write(String.Format("{0} - ", branch.Name));
            Console.WriteLine("Depth of structer is " +path.Count());
        }
    }
}







