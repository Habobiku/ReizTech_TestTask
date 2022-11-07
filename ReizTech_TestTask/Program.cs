using System;
using System.Reflection;
namespace ReizTech_TestTask
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Task1.Start();

            //Console.ReadKey();
            //Console.Clear();
            ////////////////
            //Task2.Start();
            //Console.ReadKey();
            Branch root = new Branch("Root");
            Branch branch1 = root.AddBranch(new Branch("Branch1"));
            Branch branch2 = root.AddBranch(new Branch("Branch2"));
            Branch branch11 = branch1.AddBranch(new Branch("Branch11"));
       
            //root.Branches.Add(new Branch("Branch1"));
            //root.Branches.Add(new Branch("Branch2"));

            //Branch1.Branches.Add(new Branch("Branch11"));
            //Branch1.Branches.Add(new Branch("Branch12"));
            //Branch11.Branches.Add(new Branch("Branch111"));
            //Branch111.Branches.Add(new Branch("Branch1111"));
            //Branch2.Branches.Add(new Branch("Branch21"));   
            //Branch21.Branches.Add(new Branch("Branch211"));

            List<Branch> path = root.FindDepth();
            foreach (Branch n in path)
                Console.Write(String.Format("{0} - ", n.Name));
            Console.WriteLine("");
            Console.WriteLine(root.FindBranch("Branch").Name);
        }
    }
}

