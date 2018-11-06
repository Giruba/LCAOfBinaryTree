using System;

namespace LowestCommonAncestorInBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lowest Common Ancestor in a Binary Tree!");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Enter the number of elements to form the tree");
            try
            {
                int noElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by space");
                String elemenst = Console.ReadLine();
                String[] elements = elemenst.Split(' ');
                BinaryTree binaryTree = new BinaryTree();

                for (int i = 0; i < noElements; i++) {
                    binaryTree.Insert(int.Parse(elements[i]));
                }

                Console.WriteLine("Enter the value1 and value2 whose Lowest common ancestor has to be found");
                String bothVals = Console.ReadLine();
                String[] twoValuesSeparated = bothVals.Split(' ');
                
                TreeUtility.LowestCommonAncestor(binaryTree, int.Parse(twoValuesSeparated[0]),
                    int.Parse(twoValuesSeparated[1]));
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }
    }
}
