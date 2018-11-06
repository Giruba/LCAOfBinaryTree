using System;
using System.Collections.Generic;
using System.Text;

namespace LowestCommonAncestorInBinaryTree
{
    static class TreeUtility
    {
        public static void LowestCommonAncestor(BinaryTree binaryTree, int node1Value, int node2Value) {
            
            Result result = GetLowestCommonAncestor(binaryTree.GetRoot(), node1Value, node2Value);
            try
            {
                if (result != null && result.treeNode != null) {
                    if (result.presenceOfNode1 && result.presenceOfNode2)
                    {
                        Console.WriteLine("The LCA of (" + node1Value + "," + node2Value + ") " +
                            "is" + result.treeNode.GetData());
                    }
                    else {
                        if (isPresent(result.treeNode, node1Value) || isPresent(result.treeNode, node2Value))
                        {
                            Console.WriteLine("The LCA of (" + node1Value + "," + node2Value + ") " +
                            "is" + result.treeNode.GetData());

                        }
                        else {
                            if (isPresent(result.treeNode, node1Value))
                            {
                                Console.WriteLine("The value " + node2Value + "is NOT PRESENT in the tree!");
                            }
                            else {
                                Console.WriteLine("The value " + node1Value + "is NOT PRESENT in the tree!");
                            }
                        }
                    }
                }
            } catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
        }

        private static Result GetLowestCommonAncestor(BinaryTreeNode treeNode, int value1, int value2) {

            if (treeNode == null) return new Result();

            Result result = new Result();

            if (treeNode.GetData() == value1) {
                result.presenceOfNode1 = true;
                result.treeNode = treeNode;
                return result;
            }

            if (treeNode.GetData() == value2)
            {
                result.presenceOfNode2 = true;
                result.treeNode = treeNode;
                return result;
            }

            Result leftResult = GetLowestCommonAncestor(treeNode.GetLeft(), value1, value2);
            Result rightResult = GetLowestCommonAncestor(treeNode.GetRight(), value1, value2);

            if (leftResult.treeNode != null && rightResult.treeNode != null) {
                result.presenceOfNode2 = true;
                result.presenceOfNode1 = true;
                result.treeNode = treeNode;
                return result;
            }


            if (leftResult.treeNode != null)
            {
                result.presenceOfNode1 = true;
                result.treeNode = leftResult.treeNode;
                return result;
            }

            result.presenceOfNode2 = true;
            result.treeNode = rightResult.treeNode;
            return result;
        }

        public static bool isPresent(BinaryTreeNode binaryTreeNode, int value) {
            if (binaryTreeNode == null) return false;

            if (binaryTreeNode.GetData() == value || isPresent(binaryTreeNode.GetLeft(), value)
                || isPresent(binaryTreeNode.GetRight(), value)) {
                return true;
            }

            return false;
        }
    }
}
