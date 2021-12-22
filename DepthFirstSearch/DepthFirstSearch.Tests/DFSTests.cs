using NUnit.Framework;
using System.Collections.Generic;

namespace DepthFirstSearch.Tests
{
    public class DFSTests
    {
        [Test]
        public void Test_Search()
        {
            // arrange
            var root = new Node(0);
            var one = new Node(1);
            var two = new Node(2);
            var three = new Node(3);
            var four = new Node(4);
            var five = new Node(5);

            root.Children.Add(one);
            root.Children.Add(four);
            root.Children.Add(five);

            one.Children.Add(four);
            one.Children.Add(three);

            three.Children.Add(four);
            three.Children.Add(two);

            two.Children.Add(one);
            // act
            var actual = new DFS().Search(root, new List<int>());

            // assert
            var expected = new List<int> { 0, 1, 4, 3, 2, 5 };
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}