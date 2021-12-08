using NUnit.Framework;
using System.Collections.Generic;

namespace BreadthFirstSearch.Tests
{
    public class BFSTests
    {
        //         40
        //        /  \
        //       /    \
        //     20      30
        //    /  \    /  \
        //   60  80  10  100
        [Test]
        public void Test_BFS()
        {
            // arrange
            var root = new Node<int>(40);
            var a = new Node<int>(20);
            var b = new Node<int>(60);
            var c = new Node<int>(80);
            var d = new Node<int>(30);
            var e = new Node<int>(10);
            var f = new Node<int>(100);

            root.Left = a;
            a.Left = b;
            a.Right = c;

            root.Right = d;
            d.Left = e;
            d.Right = f;
                     
            // act                    
            var actual = BFS.PrintNodesToList(root);

            // assert
            var expected = new List<int> { 40, 20, 30, 60, 80, 10, 100 };
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
