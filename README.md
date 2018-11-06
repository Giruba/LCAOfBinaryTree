#Author : Giruba Beulah SE

# LCAOfBinaryTree
C# program to find the LCA of binary tree

Algorithm:

Recursive Function
-------------------
1. Initialize two variables (boolean) for indicating presence of two values supplied.
2. If any of the values is  equal to the root's value, set the appropriate presence variable true and return root
3. If none of the values match with root's value, recur for the left and right subtrees
4. If both left and right return with values, then one value lies in left subtree and the other lies in right subtree
    Therefore, retun root
5. If only one of the two is non-null, return the non-null node with the presence value



Now, 
1. If both the values are present and node is returned, print the node's value
2. If only one non-null value is returned, check whether the other value is infact present in the tree.
   If the other value is present, return the non-null's node as the root



