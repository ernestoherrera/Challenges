using BalanceTreeCheck.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceTreeCheck.BinaryTree
{

    //                1
    //            /      \
    //           2        3
    //          / \     /    \
    //         4   5   6      7
    //          \     / \    /  \
    //           8   9   10  11  12
    //              /
    //             13
    //
    public class BinaryTreeUtils
    {
        public bool IsBinaryTreeBalanced<T>(BinaryTreeNode<T> root)
        {
            var treeHeight = GetBinaryTreeHeight(root);

            return treeHeight >= 0;
        }

        private int GetBinaryTreeHeight<T>(BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return 0;
            }

            var hl = GetBinaryTreeHeight(node.Left);
            var hr = GetBinaryTreeHeight(node.Right);

            if (hl == -1 || hr == -1)
            {
                return -1;
            }

            if (Math.Abs(hl - hr) > 1)
            {
                return -1;
            }

            if (hl > hr) return hl + 1;
            else return hr + 1;
        }
    }
}
