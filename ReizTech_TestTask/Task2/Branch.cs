using System;
namespace ReizTech_TestTask
{
    public class Branch
    {
      public IList<Branch> Branches { get;  private set; }
      public string Name { get; private set; }

        public Branch(String name)
        {
            Name = name;
            Branches = new List<Branch>();
        }

        public Branch AddBranch(Branch branch)
        {
            Branches.Add(branch);
            return branch;

        }

        public List<Branch> FindDepth()
        {
            if (Branches == null)
                return null;
            List<Branch> path = new List<Branch>();
            foreach (Branch branch in Branches)
            {
                List<Branch> temp = branch.FindDepth();
                     if (temp.Count > path.Count)
                    path = temp;
            }
            
            path.Insert(0, this);
            return path;
        }

       
    }
}

