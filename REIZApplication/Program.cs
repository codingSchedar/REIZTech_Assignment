using System;
using System.Collections.Generic;

namespace REIZApplication
{
    /// first we create a class for the Branch and make it store a list of the nodes under a branch
    class Branch
    {
        public List<Branch> branches = new List<Branch>();
    }
    internal class Program
    {

        /// we then create a function that will recurse and check for every node we have in our tree
        /// 
        static int GetDepth(Branch branch)
        {
            ///if have nothing on our list, then we only have the parent node, which is 1
            if(branch.branches.Count == 0)
                return 1;
            else
            {
                /// else we calculate the maximum depth of our tree
                int maxDepth = 0;

                /// we will check every branch under the root parent
                foreach(Branch child in branch.branches)
                {
                    /// we will use the same function to check for the children of the child of the root we are checking
                    int childDepth = GetDepth(child);
                    maxDepth = Math.Max(maxDepth, childDepth);
                }

                /// then we return the depth of the tree, we add 1 because we are cannot disrecard the root node
                return 1 + maxDepth;
            }
        }
        static void Main(string[] args)
        {
            /// we will then test this code
            /// 
            ///first we intialize the root 
            ///
            Branch root = new Branch();

            ///then its child
            ///

            Branch branch1 = new Branch();
            Branch branch2 = new Branch();
            Branch branch3 = new Branch();
            Branch branch4 = new Branch();
            Branch branch5 = new Branch();
            Branch branch6 = new Branch();
            Branch branch7 = new Branch();
            Branch branch8 = new Branch();
            Branch branch9 = new Branch();
            Branch branch10 = new Branch();


            /// then we will add their relationships
            /// 

            root.branches.Add(branch1);
            root.branches.Add(branch2);

            branch1.branches.Add(branch3);

            branch2.branches.Add(branch4);
            branch2.branches.Add(branch5);

            branch4.branches.Add(branch6);
            branch4.branches.Add(branch7);


            branch5.branches.Add(branch8);
            branch5.branches.Add(branch9);
            
            branch6.branches.Add(branch10);

            /// we will then get the depth of the root, we should get 5
            Console.WriteLine(GetDepth(root));

        }
    }
}
