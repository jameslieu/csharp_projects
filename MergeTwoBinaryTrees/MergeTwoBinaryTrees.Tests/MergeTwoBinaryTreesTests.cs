using System.Collections.Generic;
using Xunit;

namespace MergeTwoBinaryTrees.Tests
{
    public class MergeTwoBinaryTreesTests
    {
       /* 
        *    Tree 1     Tree 2      Result        
        *       1         2           3
        *      / \       / \         / \
        *     3   2     1   3       4   5
        *    /           \   \     / \   \
        *   5             4   7   5   4   7
        */             
        [Fact]
        public void Test_MergeTrees()
        {
            // arrange
            var t1Root = new TreeNode(1);
            var t1Node2 = new TreeNode(3);
            var t1Node3 = new TreeNode(5);
            var t1Node4 = new TreeNode(2);

            t1Root.Left = t1Node2;
            t1Node2.Left = t1Node3;
            t1Root.Right = t1Node4;

            var t2Root = new TreeNode(2);
            var t2Node2 = new TreeNode(1);
            var t2Node3 = new TreeNode(4);
            var t2Node4 = new TreeNode(3);
            var t2Node5 = new TreeNode(7);

            t2Root.Left = t2Node2;
            t2Node2.Right = t2Node3;
            t2Root.Right = t2Node4;
            t2Node4.Right = t2Node5;

            // act
            var mergedTree = MergeTwoBinaryTrees.MergeTrees(t1Root, t2Root);

            // assert
            var expected = new List<int?> { 3, 4, 5, 4, 5, 7 };
            var actual = MergeTwoBinaryTrees.ConvertToList(mergedTree, new List<int?>());
            Assert.Equal(expected, actual);
        }
    }
}