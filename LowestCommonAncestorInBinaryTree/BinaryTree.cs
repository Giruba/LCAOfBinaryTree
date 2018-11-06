using System;
using System.Collections.Generic;
using System.Text;

namespace LowestCommonAncestorInBinaryTree
{
    class BinaryTree
    {
        BinaryTreeNode rootNode;

        public BinaryTree() { }
        public void SetRoot(BinaryTreeNode binaryTreeNode) {
            rootNode = binaryTreeNode;
        }

        public BinaryTreeNode GetRoot() {
            return rootNode;
        }

        public void Insert(int data) {
            rootNode = InsertUtil(rootNode, data);
        }

        private BinaryTreeNode InsertUtil(BinaryTreeNode binaryTreeNode, int data) {
            if (binaryTreeNode == null) {
                binaryTreeNode = new BinaryTreeNode(data);
                return binaryTreeNode;
            }

            if (binaryTreeNode.GetData() < data)
            {
                binaryTreeNode.SetRight(InsertUtil(binaryTreeNode.GetRight(), data));
            }
            else {
                binaryTreeNode.SetLeft(InsertUtil(binaryTreeNode.GetLeft(), data));
            }

            return binaryTreeNode;
        }
    }
}
